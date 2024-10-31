using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEAN_SQL
{
    public partial class KhuyenMai : Form
    {
        KhuyenMai_BLL BLL = new KhuyenMai_BLL();

        public string user, pass, server, data, connectionString;

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txtmakm.TextLength != 0)
            {
                try
                {

                    KhuyenMai_DTO km = new KhuyenMai_DTO(txtmakm.Text, txttenkm.Text, txtdieukien.Text, txtgiamgia.Text, txtmota.Text);
                    bool kq = BLL.them(km);
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

        private void btnsua_Click(object sender, EventArgs e)
        {
            ListViewItem item = lst_dl.FocusedItem;
            if (item != null)
            {
                try
                {
                    KhuyenMai_DTO km = new KhuyenMai_DTO(txtmakm.Text, txttenkm.Text, txtdieukien.Text, txtgiamgia.Text, txtmota.Text);
                    bool kq = BLL.sua(km);
                    if (kq == true)
                    {
                        lst_dl.Items.Clear();
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

        public KhuyenMai(string username, string password, string servername, string database)
        {
            InitializeComponent();
            user = username;
            pass = password;
            server = servername;
            data = database;
            Login_DTO login = new Login_DTO(username, password, servername, database);
            BLL.login(login);
        }

        private void lst_dl_Click(object sender, EventArgs e)
        {
            txtmakm.Text = lst_dl.SelectedItems[0].SubItems[0].Text;
            txttenkm.Text = lst_dl.SelectedItems[0].SubItems[1].Text;
            txtdieukien.Text = lst_dl.SelectedItems[0].SubItems[2].Text;
            txtgiamgia.Text = lst_dl.SelectedItems[0].SubItems[3].Text;
            txtmota.Text = lst_dl.SelectedItems[0].SubItems[4].Text;
        }

        private void KhuyenMai_Load(object sender, EventArgs e)
        {
            display();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                KhuyenMai_DTO km = new KhuyenMai_DTO(txtmakm.Text, txttenkm.Text, txtdieukien.Text, txtgiamgia.Text, txtmota.Text);
                bool kq = BLL.xoa(km);
                if (kq == true)
                {
                    lst_dl.Items.Clear();
                    BLL.xoa(km);
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
            txtmakm.Clear();
            txttenkm.Clear();
            txtdieukien.Clear();
            txtgiamgia.Clear();
            txtmota.Clear();
            display();
        }
        public void display()
        {
            foreach (KhuyenMai_DTO km in BLL.display())
            {
                ListViewItem item = new ListViewItem(km.MaKM_P);
                item.SubItems.Add(km.TenKM_P);
                item.SubItems.Add(km.DieuKien_P);
                item.SubItems.Add(km.GiamGia_P);
                item.SubItems.Add(km.MoTa_P);
                lst_dl.Items.Add(item);
            }
        }

    }
}

