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
using BLL;

namespace DEAN_SQL
{
    public partial class NhanVien : Form
    {
        NhanVien_BLL BLL = new NhanVien_BLL();

        public string user, pass, server, data, connectionString;
        public NhanVien(string username, string password, string servername, string database)
        {
            InitializeComponent();
            user = username;
            pass = password;
            server = servername;
            data = database;
            Login_DTO login = new Login_DTO(username, password, servername, database);
            BLL.login(login);
        }
        private void NhanVien_Load(object sender, EventArgs e)
        {
            display();
        }
        public void display()
        {
            foreach (NhanVien_DTO nv in BLL.display())
            {
                ListViewItem item = new ListViewItem(nv.MaNV_P);
                item.SubItems.Add(nv.TenNV_P);
                item.SubItems.Add(nv.ChucVu_P);
                item.SubItems.Add(nv.MaQL_P);
                lst_dl.Items.Add(item);
            }
        }

        private void lst_dl_Click(object sender, EventArgs e)
        {
            txtmanv.Text = lst_dl.SelectedItems[0].SubItems[0].Text;
            txttennv.Text = lst_dl.SelectedItems[0].SubItems[1].Text;
            txtchucvu.Text = lst_dl.SelectedItems[0].SubItems[2].Text;
            txtnguoiql.Text = lst_dl.SelectedItems[0].SubItems[3].Text;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txtmanv.TextLength != 0)
            {
                try
                {
                    
                    NhanVien_DTO nv = new NhanVien_DTO(txtmanv.Text, txttennv.Text, txtchucvu.Text, txtmanv.Text);
                    bool kq = BLL.them(nv);
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
                MessageBox.Show("Mã nhân viên không được đễ trống", "Thông báo");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                NhanVien_DTO nv = new NhanVien_DTO(txtmanv.Text, txttennv.Text, txtchucvu.Text, txtmanv.Text);
                bool kq = BLL.xoa(nv);
                if (kq == true)
                {
                    lst_dl.Items.Clear();
                    BLL.xoa(nv);
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
            if(item!=null)
            {
                try
                {
                    NhanVien_DTO nv = new NhanVien_DTO(txtmanv.Text, txttennv.Text, txtchucvu.Text, txtmanv.Text, item.SubItems[0].Text);
                    bool kq = BLL.sua(nv);
                    if (kq == true)
                    {
                        lst_dl.Items.Clear();
                        BLL.sua(nv);
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

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtchucvu.Clear();
            txtmanv.Clear();
            txtnguoiql.Clear();
            txttennv.Clear();
            display();
        }


    }
}
