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
using DTO;
using DAL;
using BLL;

namespace DEAN_SQL
{
    public partial class KhachHang : Form
    {
        KhachHang_BLL BLL = new KhachHang_BLL();
        public string user, pass, server, data;
        public KhachHang(string username, string password, string servername, string database)
        {
            InitializeComponent();
            user = username;
            pass = password;
            server = servername;
            data = database;
            Login_DTO login = new Login_DTO(username, password, servername, database);
            BLL.login(login);
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            display();
        }
        public void display()
        {
            foreach (KhachHang_DTO kh in BLL.display())
            {
                ListViewItem item = new ListViewItem(kh.MaKH_P);
                item.SubItems.Add(kh.TenKH_P);
                item.SubItems.Add(kh.DiaChi_P);
                item.SubItems.Add(kh.SDT_P);
                lst_khachhang.Items.Add(item);
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txtmakh.TextLength != 0 && txttenkh.TextLength != 0)
            {
                try
                {
                    KhachHang_DTO kh = new KhachHang_DTO(txtmakh.Text, txttenkh.Text, txtdiachi.Text, txtsodt.Text);
                    bool kq = BLL.them(kh);
                    if (kq == true)
                    {
                        lst_khachhang.Items.Clear();
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
                MessageBox.Show("Tên khách và mã khách hàng không được đễ trống", "Thông báo");
            }



        }

        private void lst_khachhang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lst_khachhang_Click(object sender, EventArgs e)
        {
            txtmakh.Text = lst_khachhang.SelectedItems[0].SubItems[0].Text;
            txttenkh.Text = lst_khachhang.SelectedItems[0].SubItems[1].Text;
            txtdiachi.Text = lst_khachhang.SelectedItems[0].SubItems[2].Text;
            txtsodt.Text = lst_khachhang.SelectedItems[0].SubItems[3].Text;
        }

        private void txtmakh_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                KhachHang_DTO kh = new KhachHang_DTO(txtmakh.Text, txttenkh.Text, txtdiachi.Text, txtsodt.Text);
                bool kq = BLL.xoa(kh);
                if (kq == true)
                {
                    lst_khachhang.Items.Clear();
                    BLL.xoa(kh);
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

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtmakh.Clear();
            txttenkh.Clear();
            txtdiachi.Clear();
            txtsodt.Clear();
            lst_khachhang.Items.Clear();
            display();
        }
        private void btnsua_Click(object sender, EventArgs e)
        {
            ListViewItem item = lst_khachhang.FocusedItem;
            try
            {
                KhachHang_DTO kh = new KhachHang_DTO(item.SubItems[0].Text, txtmakh.Text, txttenkh.Text, txtdiachi.Text, txtsodt.Text);
                bool kq = BLL.sua(kh);
                if (kq == true)
                {
                    lst_khachhang.Items.Clear();
                    BLL.sua(kh);
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



    }
}
