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
using BLL;
using DTO;

namespace DEAN_SQL
{
    public partial class HangHoa : Form
    {
        HangHoa_BLL BLL = new HangHoa_BLL();
        public string user, pass, server, data;
        public HangHoa(string username, string password, string servername, string database)
        {
            InitializeComponent();
            user = username;
            pass = password;
            server = servername;
            data = database;
            Login_DTO login = new Login_DTO(username, password, servername, database);
            BLL.login(login);
        }
        public void load_mahang()
        {
            cbomaloai.DataSource = BLL.getall_mahang();
            cbomaloai.DisplayMember = "TenLoai_P";
            cbomaloai.ValueMember = "MaLoai_P";
        }
        private void HangHoa_Load(object sender, EventArgs e)
        {
            load_mahang();
            display();
        }
        public void display()
        {
            foreach (HangHoa_DTO hanghoa in BLL.display())
            {
                ListViewItem item = new ListViewItem(hanghoa.MaHang_P);
                item.SubItems.Add(hanghoa.TenHang_P);
                item.SubItems.Add(hanghoa.DVT_P);
                item.SubItems.Add(hanghoa.MaLoai_P);
                item.SubItems.Add(hanghoa.DonGia_P.ToString());
                item.SubItems.Add(hanghoa.Hinh_P);
                lst_dl.Items.Add(item);
            }
        }
        public void display_1()
        {
            foreach (HangHoa_DTO hanghoa in BLL.display_1())
            {
                ListViewItem item = new ListViewItem(hanghoa.MaHang_P);
                item.SubItems.Add(hanghoa.TenHang_P);
                item.SubItems.Add(hanghoa.DVT_P);
                item.SubItems.Add(hanghoa.MaLoai_P);
                item.SubItems.Add(hanghoa.DonGia_P.ToString());
                item.SubItems.Add(hanghoa.Hinh_P);
                item.SubItems.Add(hanghoa.DoanhThu_P.ToString());
                lst_dl.Items.Add(item);
            }
        }
        public void display_2()
        {
            foreach (HangHoa_DTO hanghoa in BLL.display_2())
            {
                ListViewItem item = new ListViewItem(hanghoa.MaHang_P);
                item.SubItems.Add(hanghoa.TenHang_P);
                item.SubItems.Add(hanghoa.DVT_P);
                item.SubItems.Add(hanghoa.MaLoai_P);
                item.SubItems.Add(hanghoa.DonGia_P.ToString());
                item.SubItems.Add(hanghoa.Hinh_P);
                item.SubItems.Add("");
                item.SubItems.Add(hanghoa.DoanhThu_P.ToString());
                lst_dl.Items.Add(item);
            }
        }


        private void lst_dl_Click(object sender, EventArgs e)
        {
            txtmahg.Text = lst_dl.SelectedItems[0].SubItems[0].Text;
            txttenhang.Text = lst_dl.SelectedItems[0].SubItems[1].Text;
            txtdvt.Text = lst_dl.SelectedItems[0].SubItems[2].Text;
            cbomaloai.SelectedValue = lst_dl.SelectedItems[0].SubItems[3].Text;
            txtdongia.Text= lst_dl.SelectedItems[0].SubItems[4].Text;
            txthinh.Text = lst_dl.SelectedItems[0].SubItems[5].Text;

            string fileName = lst_dl.SelectedItems[0].SubItems[5].Text;
            //Lấy đường dẫn tới thư mục hiện tại của ứng dụng (thường là Debug hoặc Release khi chạy từ Visual Studio).
            string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
            //Lùi về một cấp để thoát khỏi thư mục Debug hoặc Release, lấy thư mục gốc của dự án.
            projectDirectory = System.IO.Directory.GetParent(projectDirectory).Parent.Parent.FullName;

            // Kết hợp đường dẫn với thư mục Images
            string imagePath = System.IO.Path.Combine(projectDirectory, "Images", fileName);
            if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
            {
                pictureBox1.Image = Image.FromFile(imagePath);
                //txthinh.Text = imagePath; // Hiển thị đường dẫn hình ảnh trong TextBox
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txtmahg.TextLength != 0)
            {
                try
                {
                    HangHoa_DTO hang = new HangHoa_DTO(txtmahg.Text, txttenhang.Text, txtdvt.Text, cbomaloai.SelectedValue.ToString(), float.Parse(txtdongia.Text), txthinh.Text);
                    bool kq = BLL.them(hang);
                    if (kq == true)
                    {
                        lst_dl.Items.Clear();
                        display();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Mã hàng không được đễ trống", "Thông báo");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                HangHoa_DTO hang = new HangHoa_DTO(txtmahg.Text, txttenhang.Text, txtdvt.Text, cbomaloai.SelectedValue.ToString(), float.Parse(txtdongia.Text), txthinh.Text);
                bool kq = BLL.xoa(hang);
                if (kq == true)
                {
                    lst_dl.Items.Clear();
                    BLL.xoa(hang);
                    display();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            ListViewItem item = lst_dl.FocusedItem;
            if (item != null)
            {
                try
                {
                    HangHoa_DTO hang = new HangHoa_DTO(item.SubItems[0].Text, txtmahg.Text, txttenhang.Text, txtdvt.Text, cbomaloai.SelectedValue.ToString(), float.Parse(txtdongia.Text), txthinh.Text);
                    bool kq = BLL.sua(hang);
                    if (kq == true)
                    {
                        lst_dl.Items.Clear();
                        BLL.sua(hang);
                        display();
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Bạn hãy chọn một đối tưởng để sửa");

        }

        private void btnmo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog.Title = "Chọn hình ảnh";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string fileName = System.IO.Path.GetFileName(filePath);

                // Thư mục gốc của dự án (không phải Debug/Release)
                string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;

                // Lùi về một cấp thư mục để thoát khỏi Debug hoặc Release
                projectDirectory = System.IO.Directory.GetParent(projectDirectory).Parent.Parent.FullName;

                // Tạo đường dẫn tới thư mục Images
                string targetFolder = System.IO.Path.Combine(projectDirectory, "Images");

                // Kiểm tra và tạo thư mục nếu chưa tồn tại
                if (!System.IO.Directory.Exists(targetFolder))
                {
                    System.IO.Directory.CreateDirectory(targetFolder);
                }

                // Sao chép file vào thư mục Images
                string destPath = System.IO.Path.Combine(targetFolder, fileName);
                if (!System.IO.File.Exists(destPath))
                {
                    try
                    {
                        System.IO.File.Copy(filePath, destPath, true);
                        txthinh.Text = fileName; // Chỉ lưu tên file
                        pictureBox1.Image = Image.FromFile(destPath); // Hiển thị hình ảnh
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi sao chép file: " + ex.Message);
                    }
                }
                else
                {
                    txthinh.Text = fileName; // Chỉ lưu tên file
                    pictureBox1.Image = Image.FromFile(destPath); // Hiển thị hình ảnh
                }

            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtmahg.Clear();
            txttenhang.Clear();
            txtdvt.Clear();
            lst_dl.Items.Clear();
            display();
        }

        private void btnhangchuaban_Click(object sender, EventArgs e)
        {
            lst_dl.Items.Clear();
            display_1();
        }

        private void btnhangbanchaynhat_Click(object sender, EventArgs e)
        {

            lst_dl.Items.Clear();
            display_2();
        }
    }
}
