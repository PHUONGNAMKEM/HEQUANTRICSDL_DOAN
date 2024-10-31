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
using System.Security.RightsManagement;
using DTO;
using BLL;

namespace DEAN_SQL
{
    public partial class App : Form
    {
        private Timer timer_logout;
        string user, pass, server, data;
        Logout_DTO logout;
        public App(string phanQuyen, string name, string password, string servername, string database)
        {
            InitializeComponent();
            lblPhanQuyen.Text = phanQuyen;
            
            timer_logout = new Timer();
            timer_logout.Interval = 500; // Kiểm tra mỗi phút
            timer_logout.Tick += timer_logout_Tick;
            timer_logout.Start();
            user = name;
            pass = password;
            server = servername;
            data = database;
            logout=new Logout_DTO(name, password, servername, database);

        }
        private void btnlogout_Click(object sender, EventArgs e)
        {

            //DatabaseConnection.InitializeConnection(connString);
            try
            {
                // Đăng xuất và đóng tất cả các form khác
                timer_logout.Stop();
                // Xóa phiên đăng nhập
                Logout_BLL BLL = new Logout_BLL();
                BLL.Xoa_phiendangnhap(logout);



                // Hiển thị form đăng nhập và đóng form hiện tại
                Form1 login = new Form1();
                login.Location = this.Location; // Đặt form login ở vị trí của form hiện tại
                login.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error-------> " + ex.Message);
            }
        }

        private void timer_logout_Tick(object sender, EventArgs e)
        {
            try
            {
                Logout_BLL BLL = new Logout_BLL();
                bool kq = BLL.timer_logout_Tick(logout);
                if (kq == true)
                {
                    timer_logout.Stop();
                    // Hiển thị form đăng nhập và đóng form chính
                    Form1 login = new Form1();
                    login.Location = this.Location; // Đặt form login ở vị trí của form hiện tại
                    login.Show();
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error-------> " + ex.Message);
            }
        }

    
        private void btnnew_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }

        private void App_Load(object sender, EventArgs e)
        {

        }

        //private void btnKhachHang_Click(object sender, EventArgs e)
        //{
        //    KhachHang kh = new KhachHang();
        //    kh.Show();
        //}

        //private void btnhoadon_Click(object sender, EventArgs e)
        //{
        //    HoaDon hd = new HoaDon();
        //    hd.Show();
        //}

        //private void btnchitiethoadon_Click(object sender, EventArgs e)
        //{
        //    CHITIETHOADON ct = new CHITIETHOADON();
        //    ct.Show();
        //}

        //private void btnhanghoa_Click(object sender, EventArgs e)
        //{
        //    HangHoa hh = new HangHoa(user, pass, server, data);
        //    hh.Show();
        //}

        //private void btnloaihang_Click(object sender, EventArgs e)
        //{
        //    LoaiHang lh = new LoaiHang();
        //    lh.Show();
        //}

        //private void btnchitietpn_Click(object sender, EventArgs e)
        //{
        //    CHITIETPN ctpn = new CHITIETPN();
        //    ctpn.Show();
        //}

        //private void btnphieunhap_Click(object sender, EventArgs e)
        //{
        //    PHIEUNHAP pn = new PHIEUNHAP();
        //    pn.Show();
        //}

        //private void btnnhacc_Click(object sender, EventArgs e)
        //{
        //    NHACC ncc = new NHACC();
        //    ncc.Show();
        //}

        //private void btnnhanvien_Click(object sender, EventArgs e)
        //{
        //    NhanVien nv = new NhanVien();
        //    nv.Show();
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    ThongTinNhanVien ttnv = new ThongTinNhanVien();
        //    ttnv.Show();
        //}

        private void btnview_Click(object sender, EventArgs e)
        {
            NhanVienView nv = new NhanVienView(user, pass, server, data);
            nv.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KhachHangView kh = new KhachHangView(user, pass, server, data);
            kh.Show();
        }

        private void btnhoadonview_Click(object sender, EventArgs e)
        {
            HoaDonView hd = new HoaDonView(user, pass, server, data);
            hd.Show();
        }
    }   
}
