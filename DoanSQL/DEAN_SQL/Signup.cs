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
using DAL;
using BLL;
using DTO;
namespace DEAN_SQL
{
    public partial class dangky : Form
    {
        Signup_BLL BLL = new Signup_BLL();
        public dangky()
        {
            InitializeComponent();
        }
        private void btnsignup_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtpassword.Text))
            {
                MessageBox.Show("Tên người dùng và mật khẩu không được để trống.");
                return;
            }
            if (txtrePassword.Text.Equals(txtpassword.Text) == false)
            {
                MessageBox.Show("Mật khẩu của bạn nhập lại không chính xác.");
                txtrePassword.Clear();
                return;
            }
            try
            {
                Signup_DTO user = new Signup_DTO(txtUsername.Text, txtpassword.Text);
                bool kq = BLL.signup(user);
                if (kq == true)
                {
                    MessageBox.Show("Tạo người dùng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Form1 dangnhap = new Form1();
                    dangnhap.Show();
                }
                else
                {
                    MessageBox.Show("Tạo người dùng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtpassword.Clear();
            txtrePassword.Clear();
            txtUsername.Focus();
        }


        private void lbllogin_Click(object sender, EventArgs e)
        {
            //khi lựa chọn chuyển sang login thì tạo form login mới rồi hiển thị nó cũng như sẽ ẩn đi form hiện tại là form sign up
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void chkpass_CheckedChanged(object sender, EventArgs e)
        {
            //Dùng để đổi mật khẩu thành các dấuu * và đổi ngược lại
            if (chkpass.Checked == true)
            {
                txtpassword.PasswordChar = '\0';
                txtrePassword.PasswordChar = '\0';
            }
            else
            {
                txtpassword.PasswordChar = '*';
                txtrePassword.PasswordChar = '*';
            }
        }

        private void dangky_Load(object sender, EventArgs e)
        {

        }
    }
}
