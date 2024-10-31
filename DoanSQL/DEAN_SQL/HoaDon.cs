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
using DocumentFormat.OpenXml.Office2010.Drawing;
using BLL;
using DTO;

namespace DEAN_SQL
{
    public partial class HoaDon : Form
    {
        HoaDon_BLL BLL = new HoaDon_BLL();
        public string user, pass, server, data, connectionString;
        public HoaDon(string username, string password, string servername, string database)
        {
            InitializeComponent();
            user = username;
            pass = password;
            server = servername;
            data = database;
            Login_DTO login = new Login_DTO(username, password, servername, database);
            BLL.login(login);
        }
        private void HoaDon_Load(object sender, EventArgs e)
        {
            load_manv();
            display();
            string[] str = new string[] { "Đang xử lý", "Đã giao", "Đã hủy" };
            foreach(string s in str)
            {
                cbotrangthai.Items.Add(s);
            }
        }
        public void load_manv()
        {
            cbomanv.DataSource = BLL.getall_manv();
            cbomanv.DisplayMember = "TenNV_P";
            cbomanv.ValueMember = "MaNV_P";
        }
        public void display()
        {
            foreach (HoaDon_DTO hd in BLL.display())
            {
                ListViewItem item = new ListViewItem(hd.MAHD_P);
                item.SubItems.Add(hd.NGAYLAP_P);
                item.SubItems.Add(hd.TRANGTHAI_P);
                item.SubItems.Add(hd.MAKH_P);
                item.SubItems.Add(hd.MANV_P);
                lst_dl.Items.Add(item);
            }
        }

        private void lst_dl_Click(object sender, EventArgs e)
        {
            txtmahd.Text = lst_dl.SelectedItems[0].SubItems[0].Text;
            txtngaylap.Text = lst_dl.SelectedItems[0].SubItems[1].Text;
            cbotrangthai.Text= lst_dl.SelectedItems[0].SubItems[2].Text;
            txtmakh.Text = lst_dl.SelectedItems[0].SubItems[3].Text;
            cbomanv.SelectedValue = lst_dl.SelectedItems[0].SubItems[4].Text;

        }

        private void lst_dl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txtmahd.TextLength != 0 )
            {
                try
                {
                    HoaDon_DTO hd = new HoaDon_DTO(txtmahd.Text, txtngaylap.Text, cbotrangthai.Text, txtmakh.Text, cbomanv.SelectedValue.ToString());
                    bool kq = BLL.them(hd);
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
                MessageBox.Show("Mã hóa đơn không được đễ trống", "Thông báo");
            }

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                HoaDon_DTO hd = new HoaDon_DTO(txtmahd.Text, txtngaylap.Text, cbotrangthai.Text, txtmakh.Text.ToString(), cbomanv.SelectedValue.ToString());
                bool kq = BLL.xoa(hd);
                if (kq == true)
                {
                    lst_dl.Items.Clear();
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
                    HoaDon_DTO hd = new HoaDon_DTO(txtmahd.Text, txtngaylap.Text, cbotrangthai.Text, txtmakh.Text, cbomanv.SelectedValue.ToString());
                    bool kq = BLL.sua(hd);
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
            else
            {
                MessageBox.Show("Bạn hãy chọn một đối tượng cần sửa");
            }    
          
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtmahd.Clear();
            txtngaylap.Clear();
            cbotrangthai.Text = "";
            lst_dl.Items.Clear();
            display();
        }

    }
}
