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
    public partial class ChiTietKhuyenMai : Form
    {
        ChiTietKhuyenMai_BLL BLL = new ChiTietKhuyenMai_BLL();

        public string user, pass, server, data, connectionString;

 

       

        public ChiTietKhuyenMai(string username, string password, string servername, string database)
        {
            InitializeComponent();
            user = username;
            pass = password;
            server = servername;
            data = database;
            Login_DTO login = new Login_DTO(username, password, servername, database);
            BLL.login(login);
        }



        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                ChiTietKhuyenMai_DTO km = new ChiTietKhuyenMai_DTO(txtmahd.Text, txtmakm.Text, txtmahg.Text);
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
            txtmahd.Clear();
            txtmahg.Clear();
            display();
        }

        private void lst_dl_Click(object sender, EventArgs e)
        {

            txtmahd.Text = lst_dl.SelectedItems[0].SubItems[0].Text;
            txtmakm.Text = lst_dl.SelectedItems[0].SubItems[1].Text;
            txtmahg.Text = lst_dl.SelectedItems[0].SubItems[2].Text;
        }

        private void ChiTietKhuyenMai_Load(object sender, EventArgs e)
        {
            display();

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            ListViewItem item = lst_dl.FocusedItem;
            if (item != null)
            {
                try
                {
                    ChiTietKhuyenMai_DTO km = new ChiTietKhuyenMai_DTO(txtmahd.Text, txtmakm.Text, txtmahg.Text, item.SubItems[0].Text.Trim(), item.SubItems[1].Text.Trim());
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

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txtmakm.TextLength != 0)
            {
                try
                {

                    ChiTietKhuyenMai_DTO km = new ChiTietKhuyenMai_DTO(txtmahd.Text, txtmakm.Text, txtmahg.Text);
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

        

      

     
        public void display()
        {
            foreach (ChiTietKhuyenMai_DTO km in BLL.display())
            {
                ListViewItem item = new ListViewItem(km.MaHD_P);
                item.SubItems.Add(km.MaKM_P);
                item.SubItems.Add(km.MaHG_P);
                lst_dl.Items.Add(item);
            }
        }

    }


}
