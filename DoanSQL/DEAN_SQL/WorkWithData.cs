using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using ExcelDataReader;
using ClosedXML.Excel;
using System.Net.Mail;

namespace DEAN_SQL
{
    public partial class WorkWithData : Form
    {

        //public string connectionString = "Data Source=LAPTOP-7VLSR7BE\\SQLEXPRESS;Initial Catalog=DEAN4;User ID=sa";
        public SqlConnection con;
        public string user, pass, server, data, constr;
        public WorkWithData(string phanQuyen, string username, string password, string servername, string database)
        {
            InitializeComponent();
            user = username;
            pass = password;
            server = servername;
            data = database;
            lblPhanQuyen.Text = phanQuyen;
            constr = "Server=" + server + ";Database=" + data + ";User Id=" + user + ";Password=" + pass + ";";
            con = new SqlConnection(constr);
            
        }
         
        private void btnReturnAdminPage_Click(object sender, EventArgs e)
        {
            AppForAdmin returnApp = new AppForAdmin(lblPhanQuyen.Text,  user, pass, server, data);
            returnApp.Show();
            this.Close();
        }

        private void cboChooseSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[cboChooseSheet.SelectedItem.ToString()];
            dgvwShowData.DataSource = dt; //cập nhật datagridview dựa vào nguồn dữ liệu lấy từ biến dt ở trên
        }

        DataTableCollection tableCollection;// chứa các sheet dữ liệu từ file excel đã đọc - mỗi sheet ở dạng datatable

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            //using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx|Excel 97-2003 Workbook|*.xls|CSV File|*.csv" })
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel 97-2003 Workbook|*.xls|Excel Workbook|*.xlsx" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtFilePath.Text = openFileDialog.FileName;
                    using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            //Đọc dữ liệu từ file excel lưu vào result (DataSet là một tập hợp các DataTable)
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                //Cấu hình cách đọc dữ liệu vào từng DataTabel trong DataSet
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                                //UseHeaderRow = true -> sử dụng dòng đầu tiên trong file excel làm tên cột cho các cột trong bảng sql
                            });
                            tableCollection = result.Tables;
                            cboChooseSheet.Items.Clear();
                            foreach (DataTable table in tableCollection)
                                cboChooseSheet.Items.Add(table.TableName); // thêm các sheet vô combobox 
                        }
                    }
                }
            }
        }

        //Đọc dữ liệu từ excel đưa vô một bảng có sẵn trong database 
        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem đã chọn sheet nào chưa
                if (cboChooseSheet.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn sheet cần import!");
                    return;
                }

                // Kiểm tra xem đã chọn bảng đích nào chưa
                if (cboDestinationTable.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn bảng đích để import!");
                    return;
                }

                // Lấy DataTable từ sheet đã chọn
                DataTable dt = tableCollection[cboChooseSheet.SelectedItem.ToString()];

                // Tạo câu lệnh SQL INSERT
                //string tableName = "KHACHHANG";  // Thay thế bằng tên bảng đích trong SQL Server
                string tableName = cboDestinationTable.SelectedItem.ToString();

                con.Open();

                // Mở kết nối đến SQL Server
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();

                    // Dùng SqlBulkCopy để nhập dữ liệu
                    // ĐÂY LÀ CÁCH DÙNG SQLBULKCOPY -> ƯU ĐIỂM LÀ NHANH HƠN CHO DỮ LIỆU LỚN, TỰ ĐỘNG TẠO INSERT KO CẦN THỦ CÔNG NHƯ STRINGBUILDER
                    using (SqlBulkCopy bulkCopy = new SqlBulkCopy(con))
                    {
                        bulkCopy.DestinationTableName = tableName;
                        bulkCopy.WriteToServer(dt);
                    }
                }

                MessageBox.Show("Import dữ liệu thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi import dữ liệu: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            ////Kiểm tra rỗng table cần export ra excel
            //if (cboChooseTableToExport.SelectedItem == null)
            //{
            //    MessageBox.Show("Please select a table to export.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //string selectedTable = cboChooseTableToExport.SelectedItem.ToString();

            ////using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx|CSV File|*.csv" })
            //using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            //{
            //    if (sfd.ShowDialog() == DialogResult.OK)
            //    {
            //        try
            //        {
            //            using (XLWorkbook workbook = new XLWorkbook())
            //            {
            //                using (SqlConnection connection = new SqlConnection( constr))
            //                {
            //                    connection.Open();

            //                    // Lấy dữ liệu từ bảng được chọn
            //                    //using (SqlDataAdapter adapter = new SqlDataAdapter($"SELECT * FROM {selectedTable}", connection))

            //                    // SỬ DỤNG THỦ TỤC Ở ĐÂY!!!
            //                    using (SqlDataAdapter adapter = new SqlDataAdapter("EXEC EXPORT_FROM_ANY_TABLE '"+selectedTable+"'", connection))
            //                    {
            //                        DataTable tableData = new DataTable();
            //                        adapter.Fill(tableData);

            //                        // Thêm dữ liệu vào workbook
            //                        workbook.Worksheets.Add(tableData, selectedTable);
            //                    }
            //                }

            //                workbook.SaveAs(sfd.FileName);
            //            }

            //            MessageBox.Show("Export successful", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        }
            //        catch (Exception ex)
            //        {
            //            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //    }
            //}

            // Kiểm tra nếu không có bảng được chọn để export
            if (cboChooseTableToExport.SelectedItem == null)
            {
                MessageBox.Show("Please select a table to export.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string selectedTable = cboChooseTableToExport.SelectedItem.ToString();


            // Lấy tên các cột từ cơ sở dữ liệu
            List<string> columnNames = new List<string>();
            // Để lấy ra tên các cột của một bảng nào đó
            // Gõ dòng này vào sql thì ví dụ BẢNG KHACHHANG nó sẽ cho ra các cột như MAKH, TENKH, DIACHI, SODT
            string getColumnNamesQuery = $"SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{selectedTable}'";

            // connect tới db
            using (SqlConnection connection = new SqlConnection(constr))
            {
                connection.Open();
                SqlCommand getColumnsCommand = new SqlCommand(getColumnNamesQuery, connection);
                SqlDataReader reader = getColumnsCommand.ExecuteReader();

                while (reader.Read())
                {
                    columnNames.Add(reader["COLUMN_NAME"].ToString());
                    // đọc bằng datareader lấy ra các cột để thêm vào list columnNames của mình
                }
                reader.Close();
            }

            // Tạo một file tạm để lưu dữ liệu tạm thời
            string tempFilePath = System.IO.Path.GetTempFileName();

            // Lệnh bcp để xuất dữ liệu từ bảng ra file tạm với định dạng CSV và 'đặc biệt' có mã hóa UTF-8
            string bcpCommand = $"bcp {selectedTable} out \"{tempFilePath}\" -c -t, -C 65001 -U sa -P sa -S LAPTOP-7VLSR7BE\\SQLEXPRESS02 -d DEAN5";


            // Sử dụng bcp ở đây -> bcp lệnh xuất dữ liệu từ sql server (bulk copy program) 
            // {selectedTable} là bảng cần export ra
            // out \"{tempFilePath}\" - đường dẫn của file tạm ở trên để xuất dl ra
            // -c là để XUẤT dữ liệu ở định dạng ký tự
            // -t, : là sử dụng dấu , để làm ký tự ngăn cách 
            // -C 65001: Sử dụng mã hóa UTF-8
            // -U sa -P sa -S LAPTOP-7VLSR7BE\\SQLEXPRESS02 -d DEAN5: servername và db tương ứng!


            // là một lớp trong c# để khởi chạy chương trình nào đó
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo.FileName = "cmd.exe"; // chỉ định ctrinh hoặc tệp tin nào sẽ được chạy
            process.StartInfo.Arguments = $"/C {bcpCommand}"; // bỏ câu lệnh bcp vào cmd để chạy (tham số)
                                                              // Cần phải thêm hai dòng này để redirect StandardError và StandardOutput
            process.StartInfo.RedirectStandardError = true; // nhận thông báo lỗi từ process
            process.StartInfo.RedirectStandardOutput = true; // kết quả của bcp (dòng lệnh trong cmd) khi chạy
                                                             // RedirectStandardError và RedirectStandardOutput: để ghi lại thông báo lỗi hoặc kết quả của lệnh bcp nếu cần
            process.StartInfo.UseShellExecute = false; // không sử dụng shell để khởi chạy
                                                       // nếu useshell ở đây (true) thì khi chạy process nó sẽ chạy cmd của window lên (không thể redirect để nhận tbao lỗi hay kết quả thực thi)
                                                       // mình đang muốn nó chạy ngầm thôi nên đặt là false (không mở shell - shell là cmd á)
            process.StartInfo.CreateNoWindow = true; // no window ko tạo ra cửa số mới - ko hiển thị cso nào hết khi chạy
            process.Start();
            process.WaitForExit(); // chờ chừng nào process hoàn thành thì ms chạy tiếp

            // Kiểm tra xem lệnh bcp có chạy thành công không (=0 là tcong và ko có lỗi)
            if (process.ExitCode == 0)
            {
                // Đọc nội dung file tạm với mã hóa 
                // để đọc tất cả các dòng từ file tạm được tạo ra bởi lệnh bcp và mã hóa UTF8
                string[] fileContent = System.IO.File.ReadAllLines(tempFilePath, System.Text.Encoding.UTF8);

                // Tạo header cho file (tiêu đề các cột) mỗi cột cách nhau bằng dấu ,
                string header = string.Join(",", columnNames);

                // Kết hợp header và nội dung file lại với nhau
                List<string> finalContent = new List<string> { header }; // lúc này chỉ chứa các header vừa tạo thôi
                finalContent.AddRange(fileContent); //thêm nội dung vừa đọc được ở fileContent vào đây

                // Chọn nơi lưu file CSV cuối cùng với mã hóa UTF-8
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "CSV File|*.csv" })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        string finalFilePath = sfd.FileName; // lấy đường dẫn của file mà ta mới chọn

                        // Ghi nội dung ra file CSV với mã hóa UTF-8 - lấy ndung của finalContent lưu vào filePath với UFT-8
                        System.IO.File.WriteAllLines(finalFilePath, finalContent, System.Text.Encoding.UTF8);

                        // Thông báo thành công
                        MessageBox.Show("Export successful", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                // Đọc lỗi từ StandardError nếu lệnh bcp gặp vấn đề
                string error = process.StandardError.ReadToEnd();
                MessageBox.Show($"Error: {error}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Xóa file tạm
            if (System.IO.File.Exists(tempFilePath))
            {
                System.IO.File.Delete(tempFilePath);
            }

        }

        private void WorkWithData_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(constr))
            {
                connection.Open();

                DataTable tables = connection.GetSchema("Tables"); //Lấy danh sách tất cả các bảng trong csdl (trả về một datatable)
                foreach (DataRow row in tables.Rows)
                {
                    string tableName = row["TABLE_NAME"].ToString();
                    cboChooseTableToExport.Items.Add(tableName);
                }
            }
            using (SqlConnection connection = new SqlConnection(constr))
            {
                connection.Open();

                DataTable tables = connection.GetSchema("Tables");
                cboDestinationTable.Items.Clear();
                foreach (DataRow row in tables.Rows)
                {
                    string tableName = row["TABLE_NAME"].ToString();
                    cboDestinationTable.Items.Add(tableName);
                }
            }
        }

        private void btnExportAll_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            // Kết nối tới cơ sở dữ liệu
                            using (SqlConnection connection = new SqlConnection(constr))
                            {
                                connection.Open();

                                // Lấy danh sách tất cả các bảng trong cơ sở dữ liệu
                                DataTable tables = connection.GetSchema("Tables");

                                foreach (DataRow row in tables.Rows)
                                {
                                    string tableName = row["TABLE_NAME"].ToString();

                                    // Lấy dữ liệu từ từng bảng
                                    //using (SqlDataAdapter adapter = new SqlDataAdapter($"SELECT * FROM {tableName}", connection))
                                    using (SqlDataAdapter adapter = new SqlDataAdapter("EXEC EXPORT_FROM_ANY_TABLE '" + tableName + "'", connection))
                                    {
                                        DataTable tableData = new DataTable();
                                        adapter.Fill(tableData);

                                        // Thêm dữ liệu vào workbook
                                        workbook.Worksheets.Add(tableData, tableName);
                                    }
                                }
                            }
                            workbook.SaveAs(sfd.FileName);
                        }
                        MessageBox.Show("Successfully", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnImportNewTable_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem đã chọn sheet nào chưa
                if (cboChooseSheet.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn sheet cần import!");
                    return;
                }

                // Kiểm tra nếu người dùng muốn tạo bảng mới
                string tableName;
                if (!string.IsNullOrWhiteSpace(txtNewTableName.Text))
                {
                    // Người dùng nhập tên bảng mới
                    tableName = txtNewTableName.Text;
                }
                else if (cboDestinationTable.SelectedIndex != -1)
                {
                    // Người dùng chọn bảng đã tồn tại từ combobox
                    tableName = cboDestinationTable.SelectedItem.ToString();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn bảng đích hoặc nhập tên bảng mới!");
                    return;
                }

                // Lấy DataTable từ sheet đã chọn
                DataTable dt = tableCollection[cboChooseSheet.SelectedItem.ToString()];

                using (SqlConnection connection = new SqlConnection(constr))
                {
                    con.Open();

                    // Kiểm tra nếu người dùng muốn tạo bảng mới
                    if (!string.IsNullOrWhiteSpace(txtNewTableName.Text))
                    {
                        // Tạo bảng mới trong SQL Server
                        //using (SqlCommand cmd = new SqlCommand($"IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = '{tableName}') BEGIN CREATE TABLE {tableName} (", con))
                        //{
                        //    foreach (DataColumn column in dt.Columns)
                        //    {
                        //        string sqlDataType = "NVARCHAR(MAX)"; // mặc định là NVARCHAR(MAX)
                        //        if (column.DataType == typeof(int))
                        //            sqlDataType = "INT";
                        //        else if (column.DataType == typeof(DateTime))
                        //            sqlDataType = "DATETIME";

                        //        cmd.CommandText += $"{column.ColumnName} {sqlDataType},";
                        //    }
                        //    cmd.CommandText = cmd.CommandText.TrimEnd(',') + "); END";
                        //    cmd.ExecuteNonQuery();
                        //}
                        using (SqlConnection con = new SqlConnection(constr))
                        {
                            con.Open();

                            // Tạo chuỗi chứa các cột và kiểu dữ liệu từ DataTable
                            string columnDefinitions = "";
                            foreach (DataColumn column in dt.Columns)
                            {
                                string sqlDataType = "NVARCHAR(MAX)"; // Mặc định là NVARCHAR(MAX)
                                if (column.DataType == typeof(int))
                                    sqlDataType = "INT";
                                else if (column.DataType == typeof(DateTime))
                                    sqlDataType = "DATETIME";

                                // Thêm tên cột và kiểu dữ liệu vào chuỗi
                                columnDefinitions += $"{column.ColumnName} {sqlDataType},";
                            }

                            // Bỏ dấu phẩy cuối cùng
                            columnDefinitions = columnDefinitions.TrimEnd(',');

                            // Sử dụng thủ tục để tạo bảng
                            using (SqlCommand cmd = new SqlCommand("IMPORT_NEW_TABLE_CHECK_EXIST", con))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;

                                // Thêm tham số tên bảng
                                cmd.Parameters.AddWithValue("@TABLE_NAME", tableName);

                                // Thêm tham số chứa định nghĩa cột
                                cmd.Parameters.AddWithValue("@COLUMNS_DEFINITION", columnDefinitions);

                                // Thực thi thủ tục
                                cmd.ExecuteNonQuery();
                            }
                        }

                    }

                    // Dùng SqlBulkCopy để nhập dữ liệu
                    using (SqlBulkCopy bulkCopy = new SqlBulkCopy(con))
                    {
                        bulkCopy.DestinationTableName = tableName;
                        bulkCopy.WriteToServer(dt);
                    }

                    MessageBox.Show("Import dữ liệu thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi import dữ liệu: " + ex.Message);
            }
        }
    }
}
