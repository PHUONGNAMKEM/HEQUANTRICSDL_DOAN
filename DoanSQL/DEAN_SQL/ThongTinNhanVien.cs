using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DEAN_SQL
{
    public partial class ThongTinNhanVien : Form
    {
        //public ThongTinNhanVien()
        //{
        //    InitializeComponent();
        //}
        //string connectionString = "Server=" + "localhost" + "\\SQLEXPRESS02" + ";Database=" + "DEAN4" + ";User Id=" + DangNhap.name + ";Password=" + DangNhap.password + ";";
        public string user, pass, server, data, connectionString;
        public ThongTinNhanVien(string username, string password, string servername, string database)
        {
            InitializeComponent();
            user = username;
            pass = password;
            server = servername;
            data = database;
            connectionString = "Server=" + server + ";Database=" + data + ";User Id=" + user + ";Password=" + pass + ";";
        }
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader read;
        int i = 0;
        string sql;
        private void ThongTinNhanVien_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connectionString);
            display();
            string[] str = new string[] { "Nam", "Nữ", "khác" };
            foreach(string s in str)
            {
                cbogioitinh.Items.Add(s);
            }
        }
        public void display()
        {
            i = 0;
            lst_dl.Items.Clear();
            conn.Open();
            //sql = @"SELECT * FROM THONGTINNHANVIEN";
            sql = @"EXEC DISPLAY_THONGTINNHANVIEN";
            cmd = new SqlCommand(sql, conn);
            read = cmd.ExecuteReader();
            while (read.Read())
            {
                lst_dl.Items.Add(read[0].ToString());
                lst_dl.Items[i].SubItems.Add(read[1].ToString());
                lst_dl.Items[i].SubItems.Add(read[2].ToString());
                lst_dl.Items[i].SubItems.Add(read[3].ToString());
                lst_dl.Items[i].SubItems.Add(read[4].ToString());
                i++;
            }
            conn.Close();
        }

        private void lst_dl_Click(object sender, EventArgs e)
        {
            txtmanv.Text = lst_dl.SelectedItems[0].SubItems[0].Text;
            txtngaysinh.Text = lst_dl.SelectedItems[0].SubItems[1].Text;
            cbogioitinh.Text = lst_dl.SelectedItems[0].SubItems[2].Text;
            txtcmnd.Text = lst_dl.SelectedItems[0].SubItems[3].Text;
            txtemail.Text = lst_dl.SelectedItems[0].SubItems[4].Text;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {   
            if (txtmanv.TextLength != 0)
            {
                try
                {
                    conn.Open();
                    sql = @"EXEC INSERT_THONGTINNHANVIEN '"+txtmanv.Text+"', '"+txtngaysinh.Text+"', N'"+cbogioitinh.Text+"', '"+txtcmnd.Text+"', '"+txtemail.Text+"'";
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    display();
                }
                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show("Lỗi " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Mã nhân viên không được đễ trống", "Thông báo");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                //sql = @"DELETE FROM THONGTINNHANVIEN WHERE MANV = '" + txtmanv.Text.Trim() + "'";
                sql = @"EXEC DELETE_THONGTINNHANVIEN '"+txtmanv.Text+"'";
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                display();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Lỗi " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            ListViewItem item = lst_dl.FocusedItem;
            try
            {
                conn.Open();
                //string sql = @"UPDATE THONGTINNHANVIEN SET MANV = @MANV, NGAYSINH = @NGAYSINH, GIOITINH = @GIOITINH, CMND = @CMND, EMAIL = @EMAIL WHERE MANV = '" + item.SubItems[0].Text+ "'";
                string sql = @"EXEC UPDATE_THONGTINNHANVIEN '"+ item.SubItems[0].Text + "', '"+txtmanv.Text.Trim()+"', '"+txtngaysinh.Text+"', N'"+cbogioitinh.Text.Trim()+"', '"+txtcmnd.Text.Trim()+"', '"+txtemail.Text.Trim()+"'";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    //cmd.Parameters.AddWithValue("@MANV", txtmanv.Text.Trim());
                    //cmd.Parameters.AddWithValue("@NGAYSINH", txtngaysinh.Text.Trim());
                    //cmd.Parameters.AddWithValue("@GIOITINH", cbogioitinh.Text.Trim());
                    //cmd.Parameters.AddWithValue("@CMND", txtcmnd.Text.Trim());
                    //cmd.Parameters.AddWithValue("@EMAIL", txtemail.Text.Trim());
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
                display();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Lỗi " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
