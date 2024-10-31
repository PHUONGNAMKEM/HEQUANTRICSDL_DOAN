using BLL;
using DocumentFormat.OpenXml.Wordprocessing;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DEAN_SQL
{
    public partial class AppForAdmin : Form
    {
        Logout_BLL BLL = new Logout_BLL();
        HangHoa_BLL BLL_HH=new HangHoa_BLL();
        private Timer timer_logout;
        public string user, pass, sever, data;
        Logout_DTO logout;
        public AppForAdmin(string phanQuyen, string name, string password, string servername, string database)
        {
           
            InitializeComponent();
            lblPhanQuyen.Text = phanQuyen;
            
            timer_logout = new Timer();
            timer_logout.Interval = 2000; // Kiểm tra mỗi phút
            timer_logout.Tick += timer_logout_Tick;
            timer_logout.Start();
            user = name;
            pass = password;
            sever = servername;
            data = database;
            logout = new Logout_DTO(name, password, servername, database);
            Login_DTO login = new Login_DTO(name, password, servername, database);
            BLL_HH.login(login);

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }


        private void App_Load(object sender, EventArgs e)
        {
            btnWorkWithData.Visible = false;

            if (lblPhanQuyen.Text.Equals("&Admin"))
            {
                btnWorkWithData.Visible = true;
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void App_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    

        private void btnWorkWithData_Click(object sender, EventArgs e)
        {
            //WorkWithData workWithData = new WorkWithData(lblPhanQuyen.Text, user, pass, sever, data);
            //workWithData.Show();
            OpenChildForm(new WorkWithData(lblPhanQuyen.Text, user, pass, sever, data));
            //this.Close();
        }


        private void timer_logout_Tick(object sender, EventArgs e)
        {
            try
            {

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
        private void btnlogout_Click(object sender, EventArgs e)
        {


            //DatabaseConnection.InitializeConnection(connString);
            try
            {
                // Đăng xuất và đóng tất cả các form khác
                timer_logout.Stop();
                // Xóa phiên đăng nhập

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
        private void btnnew_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            //KhachHang kh = new KhachHang(user, pass, sever, data);
            //kh.Show();
            OpenChildForm(new KhachHangView(user, pass, sever, data));
        }

        private void btnhoadon_Click(object sender, EventArgs e)
        {
            panelcontainer.Controls.Clear();
            //HoaDon hd = new HoaDon(user, pass, sever, data);

            OpenChildForm(new HoaDon(user, pass, sever, data));

            //hd.TopLevel = false; // Đặt formCon là form con không có thanh tiêu đề riêng.
            //hd.FormBorderStyle = FormBorderStyle.None; // Bỏ viền của form con.
            //hd.Dock = DockStyle.Fill; // Form con sẽ chiếm toàn bộ khu vực chứa.
            //// Giả sử bạn có một Panel tên là panelContainer trong FormCha
            //hd.Parent = panelcontainer;
            //hd.Dock = DockStyle.Fill; // Tùy chọn: Hoặc điều chỉnh vị trí theo nhu cầu.

            //hd.Show();
        }

        private void btnchitiethoadon_Click(object sender, EventArgs e)
        {
            //CHITIETHOADON ct = new CHITIETHOADON(user, pass, sever, data);
            //ct.Show();
            OpenChildForm(new CHITIETHOADON(user, pass, sever, data));
        }

        private void btnhanghoa_Click(object sender, EventArgs e)
        {

            OpenChildForm(new HangHoa(user, pass, sever, data));
            //panelcontainer.Controls.Clear(); -- dòng này command lại
            //HangHoa hh = new HangHoa(user, pass, sever, data); -- dòng này command lại

            //hh.TopLevel = false; // Đặt formCon là form con không có thanh tiêu đề riêng.
            //hh.FormBorderStyle = FormBorderStyle.None; // Bỏ viền của form con.
            //hh.Dock = DockStyle.Fill; // Form con sẽ chiếm toàn bộ khu vực chứa.
            //// Giả sử bạn có một Panel tên là panelContainer trong FormCha
            //hh.Parent = panelcontainer;
            //hh.Dock = DockStyle.Fill; // Tùy chọn: Hoặc điều chỉnh vị trí theo nhu cầu.

            //hh.Show();  -- dòng này command lại
        }
        private void btnkhuyenmai_Click(object sender, EventArgs e)
        {
            //KhuyenMai km = new KhuyenMai(user, pass, sever, data);
            //km.Show();
            OpenChildForm(new KhuyenMai(user, pass, sever, data));

        }

        private void btnloaihang_Click(object sender, EventArgs e)
        {
            //LoaiHang lh = new LoaiHang(user, pass, sever, data);
            //lh.Show();
            OpenChildForm(new LoaiHang(user, pass, sever, data));
        }

        private void btnchitietpn_Click(object sender, EventArgs e)
        {
            //CHITIETPN ctpn = new CHITIETPN( user, pass, sever, data);
            //ctpn.Show();
            OpenChildForm(new CHITIETPN(user, pass, sever, data));
        }

        private void btnphieunhap_Click(object sender, EventArgs e)
        {
            //PHIEUNHAP pn = new PHIEUNHAP(user, pass, sever, data);
            //pn.Show();
            OpenChildForm(new PHIEUNHAP(user, pass, sever, data));
        }

        private void btnnhacc_Click(object sender, EventArgs e)
        {
            //NHACC ncc = new NHACC(user, pass, sever, data);
            //ncc.Show();
            OpenChildForm(new NHACC(user, pass, sever, data));
        }

        private void btnnhanvien_Click(object sender, EventArgs e)
        {
            //NhanVien nv = new NhanVien(user, pass, sever, data);
            //nv.Show();
            OpenChildForm(new NhanVienView(user, pass, sever, data));
        }


        private void btnbanhang_Click(object sender, EventArgs e)
        {
            //panelkhachhang.Visible = true;
            //panelboloc.Visible = true;
            //panelbanhang.Visible = true;
            //lstbanhang.Visible = true;
            //LoadProducts();

            panelButtonBanHang.BringToFront();
            panelkhachhang.Visible = true;
            panelboloc.Visible = true;
            panelbanhang.Visible = true;
            lstbanhang.Visible = true;
            flowLayoutPanelProducts.Visible = true;
            panelcontainer.Visible = true;

            panelMainDesktop.BringToFront();

            panelbanhang.BringToFront();
            lstbanhang.BringToFront();
            flowLayoutPanelProducts.BringToFront();
            panelcontainer.BringToFront();

            LoadProducts();
        }

        private void btnchitietkhuyenmai_Click(object sender, EventArgs e)
        {
            //ChiTietKhuyenMai ctkm = new ChiTietKhuyenMai(user, pass, sever, data);
            //ctkm.Show();
            OpenChildForm(new ChiTietKhuyenMai(user, pass, sever, data));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ThongTinNhanVien ttnv = new ThongTinNhanVien(user, pass, sever, data);
            //ttnv.Show();
            OpenChildForm(new ThongTinNhanVien(user, pass, sever, data));
        }

        private void txttienkhachtra_TextChanged(object sender, EventArgs e)
        {
            if (!txttienkhachtra.Text.All(char.IsDigit))
            {
                MessageBox.Show("Bạn chỉ có thể nhập số nguyên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txttienkhachtra.Text = new string(txttienkhachtra.Text.Where(char.IsDigit).ToArray());
                txttienkhachtra.SelectionStart = txttienkhachtra.TextLength;
            }
            else
            {
                if (txttienkhachtra.Text.Length == 0)
                {
                    txttienthua.Text = "";
                }
                else if (float.Parse(txttienkhachtra.Text) > total)
                {
                    txttienthua.Text = (float.Parse(txttienkhachtra.Text) - total).ToString();
                }
                else if (float.Parse(txttienkhachtra.Text) < total)
                {
                    txttienthua.Text = "Không đủ";
                }
                else txttienthua.Text = "0";
            }  
        
        }
        private void LoadProducts()
        {
            flowLayoutPanelProducts.Controls.Clear();
            // Giả sử có danh sách các sản phẩm
            List<HangHoa_DTO> products = BLL_HH.display(); // Phương thức lấy danh sách sản phẩm.

            // Thêm từng sản phẩm vào FlowLayoutPanel
            foreach (var product in products)
            {
                Panel panel = new Panel
                {
                    Size = new Size(150, 200), // Kích thước mỗi sản phẩm
                    BorderStyle = BorderStyle.FixedSingle
                };

                // Thêm ảnh sản phẩm
                string fileName = product.Hinh_P;
                //Lấy đường dẫn tới thư mục hiện tại của ứng dụng (thường là Debug hoặc Release khi chạy từ Visual Studio).
                string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
                //Lùi về một cấp để thoát khỏi thư mục Debug hoặc Release, lấy thư mục gốc của dự án.
                projectDirectory = System.IO.Directory.GetParent(projectDirectory).Parent.Parent.FullName;

                // Kết hợp đường dẫn với thư mục Images
                string imagePath = System.IO.Path.Combine(projectDirectory, "Images", fileName);
                if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
                {
                    pictureBox1.Image = Image.FromFile(imagePath);            
                }
                PictureBox pictureBox = new PictureBox
                {
                    Size = new Size(150, 150),
                    Image = Image.FromFile(imagePath), // Đường dẫn ảnh sản phẩm
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                pictureBox.Click += (sender, e) => AddToInvoice(product);
                panel.Controls.Add(pictureBox);

                // Thêm tên sản phẩm
                Label lblName = new Label
                {
                    Text = product.TenHang_P,
                    AutoSize = true,
                    Location = new Point(10, 160)
                };
                lblName.Click+= (sender, e) => AddToInvoice(product);
                panel.Controls.Add(lblName);

                // Thêm giá sản phẩm
                Label lblPrice = new Label
                {
                    Text = $"Giá: {product.DonGia_P:N0} đ",
                    AutoSize = true,
                    Location = new Point(10, 180)
                };
                lblPrice.Click+= (sender, e) => AddToInvoice(product);
                panel.Controls.Add(lblPrice);

                // Thêm sự kiện khi click vào panel
                panel.Click += (sender, e) => AddToInvoice(product);

                // Thêm panel vào FlowLayoutPanel
                flowLayoutPanelProducts.Controls.Add(panel);
            }
        }

     
        private void AddToInvoice(HangHoa_DTO product)
        {
            // Kiểm tra xem sản phẩm đã có trong hóa đơn chưa
            foreach (ListViewItem item in lstbanhang.Items)
            {
                if (item.SubItems[1].Text == product.TenHang_P)
                {
                    // Tăng số lượng sản phẩm nếu đã tồn tại trong hóa đơn
                    item.SubItems[4].Text = (int.Parse(item.SubItems[4].Text) + 1).ToString();
                    item.SubItems[5].Text = (int.Parse(item.SubItems[4].Text) * product.DonGia_P).ToString();
                    UpdateTotal();
                    return;
                }
            }

            // Nếu sản phẩm chưa có trong hóa đơn, thêm mới
            ListViewItem newItem = new ListViewItem(product.MaHang_P);  // Cột 0: Mã sản phẩm
            newItem.SubItems.Add(product.TenHang_P);         // Cột 1: Tên sản phẩm
            newItem.SubItems.Add(product.DonGia_P.ToString());         // Cột 2: Giá sản phẩm
            newItem.SubItems.Add("0");         // Cột 3: Khuyến mãi
            newItem.SubItems.Add("1");                              // Cột 4: Số lượng (Mặc định 1)
            newItem.SubItems.Add(product.DonGia_P.ToString());         // Cột 5: Thành tiền

            lstbanhang.Items.Add(newItem);
            UpdateTotal();  // Cập nhật tổng hóa đơn
        }
        // Tính tổng tiền hóa đơn
        float total;
        private void UpdateTotal()
        {
            total = 0;
            //foreach (DataGridViewRow row in dataGridViewInvoice.Rows)
            //{
            //    total += Convert.ToInt32(row.Cells["ThanhTien"].Value);
            //}
            foreach(ListViewItem item in lstbanhang.Items)
            {
                total += float.Parse(item.SubItems[5].Text);
            }    
            lbltongtien.Text = $"{total:N0} đ";
        }
        private void ThanhToanHoaDon()
        {
            if (txttienthua.Text == "Không đủ")
            {
                MessageBox.Show("Không đủ để thanh toán hóa đơn");
            }
            else
            {
                try
                {
                    // 1. Tạo mã hóa đơn mới
                    string maHoaDon = GenerateMaHoaDon();
                    string ngayLap = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                    // 2. Lưu thông tin hóa đơn vào cơ sở dữ liệu
                    using (SqlConnection conn = new SqlConnection("Data Source=LAPTOP-H6IDD6F8\\SQLEXPRESS;Initial Catalog=DEAN5;Integrated Security=True;Encrypt=False"))  // Thay "connectionString" bằng chuỗi kết nối của bạn
                    {
                        conn.Open();

                        // Lưu thông tin hóa đơn vào bảng HoaDon
                        SqlCommand cmd = new SqlCommand("EXEC P_LUU_HOADON_THANHTOAN @NgayLap, 1", conn);
                        //cmd.Parameters.AddWithValue("@MaHoaDon", maHoaDon);
                        cmd.Parameters.AddWithValue("@NgayLap", ngayLap);
                        cmd.ExecuteNonQuery();

                        //Lấy mã hóa đơn mới nhất
                        int mahd;
                        SqlCommand cmd1 = new SqlCommand("select top(1) MAHD from HOADON ORDER BY MAHD DESC", conn);
                        mahd = (int)cmd1.ExecuteScalar();

                        // Lưu chi tiết hóa đơn vào bảng ChiTietHoaDon
                        foreach (ListViewItem item in lstbanhang.Items)
                        {
                            string masp = item.SubItems[0].Text;
                            string donGia = item.SubItems[2].Text;
                            string soLuong = item.SubItems[4].Text;

                            SqlCommand cmdChiTiet = new SqlCommand("EXEC P_LUU_CHITIETHOADON_THANHTOAN @MaHoaDon, @MAHG, @SoLuong, @DonGia", conn);
                            cmdChiTiet.Parameters.AddWithValue("@MaHoaDon", mahd);
                            cmdChiTiet.Parameters.AddWithValue("@MAHG", masp);
                            cmdChiTiet.Parameters.AddWithValue("@DonGia", donGia);
                            cmdChiTiet.Parameters.AddWithValue("@SoLuong", soLuong);
                            cmdChiTiet.ExecuteNonQuery();
                        }
                    }

                    // 3. Thông báo thanh toán thành công
                    MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 4. Gọi chức năng in hóa đơn
                    InHoaDon(maHoaDon, ngayLap);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra khi thanh toán: " + ex.Message);
                }
            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            ThanhToanHoaDon();

        }
        

        private void button4_Click(object sender, EventArgs e)
        {
            total = 0;
            lstbanhang.Items.Clear();
            txttienkhachtra.Clear();
            txttienthua.Clear();
            lbltongtien.Text = "";
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            txttentimkiem.Clear();
            LoadProducts();
        }
        public void timkiemsp_theoten()
        {
            flowLayoutPanelProducts.Controls.Clear();
            // Giả sử có danh sách các sản phẩm
            List<HangHoa_DTO> products = BLL_HH.search(txttentimkiem.Text, cbogiadau.Text, cbogiacuoi.Text); // Phương thức lấy danh sách sản phẩm.

            // Thêm từng sản phẩm vào FlowLayoutPanel
            foreach (var product in products)
            {
                Panel panel = new Panel
                {
                    Size = new Size(150, 200), // Kích thước mỗi sản phẩm
                    BorderStyle = BorderStyle.FixedSingle
                };

                // Thêm ảnh sản phẩm
                string fileName = product.Hinh_P;
                //Lấy đường dẫn tới thư mục hiện tại của ứng dụng (thường là Debug hoặc Release khi chạy từ Visual Studio).
                string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
                //Lùi về một cấp để thoát khỏi thư mục Debug hoặc Release, lấy thư mục gốc của dự án.
                projectDirectory = System.IO.Directory.GetParent(projectDirectory).Parent.Parent.FullName;

                // Kết hợp đường dẫn với thư mục Images
                string imagePath = System.IO.Path.Combine(projectDirectory, "Images", fileName);
                if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
                {
                    pictureBox1.Image = Image.FromFile(imagePath);
                }
                PictureBox pictureBox = new PictureBox
                {
                    Size = new Size(150, 150),
                    Image = Image.FromFile(imagePath), // Đường dẫn ảnh sản phẩm
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                pictureBox.Click += (sender, e) => AddToInvoice(product);
                panel.Controls.Add(pictureBox);

                // Thêm tên sản phẩm
                Label lblName = new Label
                {
                    Text = product.TenHang_P,
                    AutoSize = true,
                    Location = new Point(10, 160)
                };
                lblName.Click += (sender, e) => AddToInvoice(product);
                panel.Controls.Add(lblName);

                // Thêm giá sản phẩm
                Label lblPrice = new Label
                {
                    Text = $"Giá: {product.DonGia_P:N0} đ",
                    AutoSize = true,
                    Location = new Point(10, 180)
                };
                lblPrice.Click += (sender, e) => AddToInvoice(product);
                panel.Controls.Add(lblPrice);

                // Thêm sự kiện khi click vào panel
                panel.Click += (sender, e) => AddToInvoice(product);

                // Thêm panel vào FlowLayoutPanel
                flowLayoutPanelProducts.Controls.Add(panel);
            }
        }
        private void btnapdung_Click(object sender, EventArgs e)
        {
            timkiemsp_theoten();

        }

        private void cbogiadau_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbogiacuoi.Text!="" && float.Parse(cbogiadau.Text)>float.Parse(cbogiacuoi.Text))
            {
                MessageBox.Show("Giá đầu không được lớn hơn giá cuối");
                cbogiadau.SelectedIndex = 0;
            }
        }

        private void cbogiacuoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbogiadau.Text != "" && float.Parse(cbogiadau.Text) > float.Parse(cbogiacuoi.Text))
            {
                MessageBox.Show("Giá cuối không được nhỏ hơn giá giá đầu");
                cbogiacuoi.SelectedIndex = 0;
            }
        }

        private void panelkhachhang_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int Msg, int wParam, int lParam);
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void InHoaDon(string maHoaDon, string ngayLap)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += (sender, e) => printDocument_PrintPage(sender, e, maHoaDon, ngayLap);

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        // Hàm để vẽ nội dung hóa đơn lên trang in
        private void printDocument_PrintPage(object sender, PrintPageEventArgs e, string maHoaDon, string ngayLap)
        {
            e.Graphics.DrawString("HÓA ĐƠN THANH TOÁN", new System.Drawing.Font("Arial", 18, FontStyle.Bold), Brushes.Black, new PointF(100, 50));
            e.Graphics.DrawString($"Mã hóa đơn: {maHoaDon}", new System.Drawing.Font("Arial", 12), Brushes.Black, new PointF(100, 100));
            e.Graphics.DrawString($"Ngày lập: {ngayLap}", new System.Drawing.Font("Arial", 12), Brushes.Black, new PointF(100, 130));
            e.Graphics.DrawString("Sản phẩm:", new System.Drawing.Font("Arial", 12), Brushes.Black, new PointF(100, 160));

            float yPos = 190;
            foreach (ListViewItem item in lstbanhang.Items)
            {
                string tenSanPham = item.SubItems[1].Text;
                string donGia = item.SubItems[2].Text;
                string soLuong = item.SubItems[4].Text;
                string thanhTien = item.SubItems[5].Text;

                e.Graphics.DrawString($"{tenSanPham} x{soLuong} - {thanhTien}đ", new System.Drawing.Font("Arial", 12), Brushes.Black, new PointF(100, yPos));
                yPos += 30;
            }

            e.Graphics.DrawString($"Tổng tiền: {total:N0}đ", new System.Drawing.Font("Arial", 12), Brushes.Black, new PointF(100, yPos));
            e.Graphics.DrawString($"Tiền khách trả: {txttienkhachtra.Text:N0}đ", new System.Drawing.Font("Arial", 12), Brushes.Black, new PointF(100, yPos+30));
            e.Graphics.DrawString($"Tiền thừa: {float.Parse(txttienkhachtra.Text) - total:N0}đ", new System.Drawing.Font("Arial", 12), Brushes.Black, new PointF(100, yPos+60));
        }

        private void AppForAdmin_Load(object sender, EventArgs e)
        {

        }

 
        private string GenerateMaHoaDon()
        {
            return "HD" + DateTime.Now.ToString("yyyyMMddHHmmss");
        }

        private Form currentChildForm;
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMainDesktop.Controls.Add(childForm);
            panelMainDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

    }
}
