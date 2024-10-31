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
    public partial class CHITIETHOADON : Form
    {
        ChiTietHoaDon_BLL BLL = new ChiTietHoaDon_BLL();

        public string user, pass, server, data, connectionString;
        public CHITIETHOADON(string username, string password, string servername, string database)
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
            cbomahg.DataSource = BLL.getall_mahang();
            cbomahg.DisplayMember = "TenHang_P";
            cbomahg.ValueMember = "MaHang_P";
        }
        public void load_mahoadon()
        {
            cbomahd.DataSource = BLL.getall_mahoadon();
            cbomahd.DisplayMember = "MAHD_P";
            cbomahd.ValueMember = "MAHD_P";
        }
        private void CHITIETHOADON_Load(object sender, EventArgs e)
        {
            load_mahang();
            load_mahoadon();
            display();
        }
        public void display()
        {
            foreach (ChiTietHoaDon_DTO hd in BLL.display())
            {
                ListViewItem item = new ListViewItem(hd.MaHD_P);
                item.SubItems.Add(hd.MaHG_P);
                item.SubItems.Add(hd.SoLuong_P.ToString());
                item.SubItems.Add(hd.GiaBan_P.ToString());
                lst_dl.Items.Add(item);
            }
        }

        private void lst_dl_Click(object sender, EventArgs e)
        {
            cbomahd.Text = lst_dl.SelectedItems[0].SubItems[0].Text;
            cbomahg.SelectedValue = lst_dl.SelectedItems[0].SubItems[1].Text;
            txtsoluong.Text = lst_dl.SelectedItems[0].SubItems[2].Text;
            txtgiaban.Text = lst_dl.SelectedItems[0].SubItems[3].Text;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (cbomahd.Text !="")
            {
                try
                {
                    ChiTietHoaDon_DTO hd = new ChiTietHoaDon_DTO(cbomahd.Text, cbomahg.SelectedValue.ToString(), txtsoluong.Text, txtgiaban.Text);
                    string kq = BLL.them(hd);
                    if (kq == "true")
                    {
                        lst_dl.Items.Clear();
                        display();
                    }
                    else
                    {
                        MessageBox.Show("Lổi-->"+kq+"", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Mã hóa đơn không được đễ trống", "Thông báo");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                ChiTietHoaDon_DTO hd = new ChiTietHoaDon_DTO(cbomahd.Text, cbomahg.SelectedValue.ToString(), txtsoluong.Text, txtgiaban.Text);
                bool kq = BLL.xoa(hd);
                if (kq == true)
                {
                    lst_dl.Items.Clear();
                    BLL.xoa(hd);
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
            try
            {
                ChiTietHoaDon_DTO hd = new ChiTietHoaDon_DTO(cbomahd.Text, cbomahg.SelectedValue.ToString(), txtsoluong.Text, txtgiaban.Text, item.SubItems[0].Text.Trim(), item.SubItems[1].Text.Trim());
                string kq = BLL.sua(hd);
                if (kq == "true")
                {
                    lst_dl.Items.Clear();
                    display();
                }
                else
                {
                    MessageBox.Show("Lổi-->"+kq+"", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtgiaban.Clear();
            txtsoluong.Clear();
        }

    }
}
