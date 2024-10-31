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
    public partial class KhachHangView : Form
    {
        KhachHangView_BLL BLL = new KhachHangView_BLL();
        public string user, pass, server, data;
        public KhachHangView(string username, string password, string servername, string database)
        {
            InitializeComponent();
            user = username;
            pass = password;
            server = servername;
            data = database;
            Login_DTO login = new Login_DTO(username, password, servername, database);
            BLL.login(login);
        }
        private void KhachHangView_Load(object sender, EventArgs e)
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

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtmakh.Clear();
            txttenkh.Clear();
            txtdiachi.Clear();
            txtsodt.Clear();
            lst_khachhang.Items.Clear();
            display();
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

        private void lst_khachhang_Click(object sender, EventArgs e)
        {
            txtmakh.Text = lst_khachhang.SelectedItems[0].SubItems[0].Text;
            txttenkh.Text = lst_khachhang.SelectedItems[0].SubItems[1].Text;
            txtdiachi.Text = lst_khachhang.SelectedItems[0].SubItems[2].Text;
            txtsodt.Text = lst_khachhang.SelectedItems[0].SubItems[3].Text;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            ListViewItem item = lst_khachhang.FocusedItem;
            if (item != null)
            {
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
            else MessageBox.Show("Bạn hãy chọn một đối tượng cần sửa");

        }

        private void btnrank_Click(object sender, EventArgs e)
        {
            KhachHang_DTO kh = new KhachHang_DTO(txtmakh.Text, txttenkh.Text, txtdiachi.Text, txtsodt.Text);
            // Hiển thị tổng số lượng hàng chưa bán ra màn hình hoặc gán vào nhãn (label)
            MessageBox.Show(BLL.rank(kh), "Thông báo");

        }

    }
}
