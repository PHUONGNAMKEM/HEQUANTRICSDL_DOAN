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

namespace DEAN_SQL
{
    public partial class NhanVienView : Form
    {
        public string user, pass, server, data, connectionString;
        public NhanVienView(string username, string password, string servername, string database)
        {
            InitializeComponent();
            user = username;
            pass = password;
            server = servername;
            data = database;
            connectionString = "Server=" + server + ";Database=" + data + ";User Id=" + user + ";Password=" + pass + ";";
        }
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader read;
        int i = 0;
        string sql;
        private void NhanVienView_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connectionString);
            display();
        }
        public void display()
        {
            i = 0;
            lst_dl.Items.Clear();
            conn.Open();
            //sql = @"SELECT * FROM NHANVIEN_COPY";
            sql = @"EXEC DISPLAY_NHANVIEN_VIEW";
            cmd = new SqlCommand(sql, conn);
            read = cmd.ExecuteReader();
            while (read.Read())
            {
                lst_dl.Items.Add(read[0].ToString());
                lst_dl.Items[i].SubItems.Add(read[1].ToString());
                lst_dl.Items[i].SubItems.Add(read[2].ToString());
                lst_dl.Items[i].SubItems.Add(read[3].ToString());
                i++;
            }
            conn.Close();
        }

        private void lst_dl_Click(object sender, EventArgs e)
        {
            txtmanv.Text = lst_dl.SelectedItems[0].SubItems[0].Text;
            txttennv.Text = lst_dl.SelectedItems[0].SubItems[1].Text;
            txtchucvu.Text = lst_dl.SelectedItems[0].SubItems[2].Text;
            txtnguoiql.Text = lst_dl.SelectedItems[0].SubItems[3].Text;
        }

        private void btntuoi_Click(object sender, EventArgs e)
        {
            if (txtmanv.TextLength != 0)
            {
                try
                {
                    int tuoi = 0;
                    conn.Open();
                    sql = @"SELECT dbo.F_TinhTuoiNhanVien('"+txtmanv.Text+"')";
                    cmd = new SqlCommand(sql, conn);
                    tuoi=(int)cmd.ExecuteScalar();
                    conn.Close();
                    MessageBox.Show("Nhân viên "+txttennv.Text+" "+tuoi.ToString()+" tuổi");
                    display();
                }
                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show("Lỗi " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Mã nhân viên không được đễ trống", "Thông báo");
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txtmanv.TextLength != 0)
            {
                try
                {
                    conn.Open();
                    //sql = @"INSERT INTO NHANVIEN_COPY(MANV, TENNV, CHUCVU, MANV_QUANLY) VALUES('" + txtmanv.Text.Trim() + "',N'" + txttennv.Text.Trim() + "',N'" + txtchucvu.Text.Trim() + "','" + txtnguoiql.Text.Trim() + "')";
                    sql = @"EXEC INSERT_NHANVIEN_VIEW '" + txtmanv.Text.Trim() + "',N'" + txttennv.Text.Trim() + "',N'" + txtchucvu.Text.Trim() + "','" + txtnguoiql.Text.Trim() + "'";
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    display();
                }
                catch (Exception ex)
                {
                    conn.Close();
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
                conn.Open();
                //sql = @"DELETE FROM NHANVIEN_COPY WHERE MANV = '" + txtmanv.Text.Trim() + "'";
                sql = @"EXEC DELETE_NHANVIEN_VIEW '" + txtmanv.Text.Trim() + "'";
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                display();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Lỗi " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            ListViewItem item = lst_dl.FocusedItem;
            try
            {
                conn.Open();
                //string sql = @"UPDATE NHANVIEN_COPY SET MANV = @MANV, TENNV = @TENNV, CHUCVU = @CHUCVU, MANV_QUANLY = @MANV_QUANLY WHERE MANV = '" + item.SubItems[0].Text + "'";
                string sql = @"EXEC UPDATE_NHANVIEN_VIEW '" + item.SubItems[0].Text.Trim() + "', '" + txtmanv.Text.Trim() + "', N'" + txttennv.Text.Trim() + "', N'" + txtchucvu.Text.Trim() + "', '" + txtnguoiql.Text.Trim() + "'";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MANV", txtmanv.Text.Trim());
                    cmd.Parameters.AddWithValue("@TENNV", txttennv.Text.Trim());
                    cmd.Parameters.AddWithValue("@CHUCVU", txtchucvu.Text.Trim());
                    cmd.Parameters.AddWithValue("@MANV_QUANLY", txtnguoiql.Text.Trim());
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
                display();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Lỗi " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
