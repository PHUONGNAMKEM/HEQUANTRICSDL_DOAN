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
    public partial class LoaiHang : Form
    {
        public string user, pass, server, data, connectionString;
        public LoaiHang(string username, string password, string servername, string database)
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
        private void LoaiHang_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connectionString);
            display();
        }
        public void display()
        {
            i = 0;
            lst_dl.Items.Clear();
            conn.Open();
            //sql = @"SELECT * FROM LOAIHANG";
            sql = @"select * from dbo.F_HIENTHI_LOAIHANG()";
            cmd = new SqlCommand(sql, conn);
            read = cmd.ExecuteReader();
            while (read.Read())
            {
                lst_dl.Items.Add(read[0].ToString());
                lst_dl.Items[i].SubItems.Add(read[1].ToString());
                i++;
            }
            conn.Close();
        }

        private void lst_dl_Click(object sender, EventArgs e)
        {
            txtmaloai.Text = lst_dl.SelectedItems[0].SubItems[0].Text;
            txttenloai.Text = lst_dl.SelectedItems[0].SubItems[1].Text;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txtmaloai.TextLength != 0)
            {
                try
                {
                    conn.Open();
                    //sql = @"INSERT INTO LOAIHANG(MALOAI, TENLOAI) VALUES('" + txtmaloai.Text.Trim() + "',N'" + txttenloai.Text.Trim()+ "')";
                    sql = @"EXEC THEM_LOAIHANG '" + txtmaloai.Text.Trim() + "', N'" + txttenloai.Text.Trim() + "'";
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
                MessageBox.Show("Mã loại không được đễ trống", "Thông báo");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                //sql = @"DELETE FROM LOAIHANG WHERE MALOAI = '" + txtmaloai.Text.Trim() + "'";
                sql = @"EXEC XOA_LOAIHANG '" + txtmaloai.Text.Trim() + "'";
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
                //string sql = @"UPDATE LOAIHANG SET MALOAI = @MALOAI, TENLOAI = @TENLOAI WHERE MALOAI = '" +item.SubItems[0].Text + "'";
                string sql = @"EXEC SUA_LOAIHANG '" + txtmaloai.Text.Trim() + "', N'" + txttenloai.Text.Trim() + "','" + item.SubItems[0].Text + "'";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MALOAI", txtmaloai.Text.Trim());
                    cmd.Parameters.AddWithValue("@TENLOAI", txttenloai.Text.Trim());
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
            txtmaloai.Clear();
            txttenloai.Clear();
        }


    }
}
