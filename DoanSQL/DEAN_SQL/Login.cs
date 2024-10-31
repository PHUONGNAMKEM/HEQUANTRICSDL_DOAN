using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//Khai báo thử viện để sử dụng câu lệnh kết nối sql
using BLL;
using DAL;
using DTO;

namespace DEAN_SQL
{
    public partial class Form1 : Form
    {
        
        Login_BLL BLL = new Login_BLL();
        public Form1()
        {
            InitializeComponent();
        }
       
        private void btnlogin_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtusername.Text)||string.IsNullOrEmpty(txtpassword.Text))
            {
                MessageBox.Show("Tên người dùng và mật  không được để trống");
                return;
            }
            try
            {
                Login_DTO user = new Login_DTO(txtusername.Text, txtpassword.Text, txtservername.Text, txtdatabase.Text);
                bool kq = BLL.login(user);
                if(kq) 
                {
                    MessageBox.Show("Kết nối thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (txtusername.Text == "sa" && txtpassword.Text == "sa")
                    {
                        lblPhanQuyen.Text = "&Admin"; //Kiểm tra nếu là admin thì cấp quyền
                        this.Close();
                        AppForAdmin appForAdmin = new AppForAdmin(lblPhanQuyen.Text, user.UserName, user.Password, user.Servername, user.Database);
                        appForAdmin.Show();
                    }
                    else if(txtusername.Text == "Ad" && txtpassword.Text == "1")
                    {
                        lblPhanQuyen.Text = "&Admin"; //Kiểm tra nếu là admin thì cấp quyền
                        this.Close();
                        AppForAdmin appForAdmin = new AppForAdmin(lblPhanQuyen.Text, user.UserName, user.Password, user.Servername, user.Database);
                        appForAdmin.Show();
                    }    
                    else
                    {
                        lblPhanQuyen.Text = user.UserName; //không là admin thì gán bằng username
                        App app = new App(lblPhanQuyen.Text, user.UserName, user.Password, user.Servername, user.Database);
                        app.Show();
                        this.Close();
                    }
                }
                else 
                {
                    MessageBox.Show("Kết nối thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            catch (Exception ex)
            {
                // Log ngoại lệ hoặc xử lý phù hợp tại đây
                MessageBox.Show("Kết nối thất bại: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtusername.Clear();
            txtpassword.Clear();
            txtusername.Focus();
        }

        private void lblregister_Click(object sender, EventArgs e)
        {
            //khi lựa chọn chuyển sang sign up thì tạo form sign up mới rồi hiển thị nó cũng như sẽ ẩn đi form hiện tại là form login
            dangky dk = new dangky();
            dk.Show();
            this.Close();
        }

        private void chkpass_CheckedChanged(object sender, EventArgs e)
        {
            //Dùng để đổi mật khẩu thành các dấuu * và đổi ngược lại
            if(chkpass.Checked==true)
            {
                txtpassword.PasswordChar = '\0';
            }
            else
            {
                txtpassword.PasswordChar = '*';
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
        