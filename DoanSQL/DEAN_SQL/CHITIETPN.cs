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
    public partial class CHITIETPN : Form
    {
        public string user, pass, server, data, connectionString;
        public CHITIETPN(string username, string password, string servername, string database)
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
        private void CHITIETPN_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connectionString);
            display();
        }
        public void display()
        {
            i = 0;
            lst_dl.Items.Clear();
            conn.Open();
            //sql = @"SELECT * FROM CHITIETPN";
            sql = @"select * from dbo.F_HIENTHI_CHITIETPN()";
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

        private void lblsoluong_Click(object sender, EventArgs e)
        {
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txtmapn.TextLength != 0)
            {
                try
                {
                    conn.Open();
                    //sql = @"INSERT INTO CHITIETPN(MAPN, MAHG, SOLUONG, GIABAN) VALUES('" + txtmapn.Text.Trim() + "',N'" + txtmahang.Text.Trim() + "',N'" + txtsoluong.Text.Trim() + "','" + txtgiaban.Text.Trim() + "')";
                    sql = @"EXEC THEM_CHITIETPN '" + txtmapn.Text.Trim() + "', '" + txtmahang.Text.Trim() + "', " + txtsoluong.Text.Trim() + ", " + txtgiaban.Text.Trim() + ")";
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
                MessageBox.Show("Mã phiếu nhập không được đễ trống", "Thông báo");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                //sql = @"DELETE FROM CHITIETPN WHERE MAPN = '" + txtmapn.Text.Trim() + "' AND MAHG = '"+txtmahang.Text.Trim()+"'";
                sql = @"EXEC XOA_CHITIETPN '" + txtmapn.Text.Trim() + "', '" + txtmahang.Text.Trim() + "'";
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
                //string sql = @"UPDATE CHITIETPN SET MAPN = @MAPN, MAHG = @MAHG, SOLUONG = @SOLUONG, GIABAN = @GIABAN WHERE MAPN = @MAPN AND MAHG = '" + item.SubItems[0].Text + "'";
                string sql = @"EXEC SUA_CHITIETPN @MAPN, @MAHG, @SOLUONG, @GIABAN,'" + item.SubItems[0].Text + "','" + item.SubItems[1].Text + "'";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MAPN", txtmapn.Text.Trim());
                    cmd.Parameters.AddWithValue("@MAHG", txtmahang.Text.Trim());
                    cmd.Parameters.AddWithValue("@SOLUONG", txtsoluong.Text.Trim());
                    cmd.Parameters.AddWithValue("@GIABAN", txtgiaban.Text.Trim());
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
            txtgiaban.Clear();
            txtmahang.Clear();
            txtmapn.Clear();
            txtsoluong.Clear();
        }

        private void lst_dl_Click(object sender, EventArgs e)
        {
            txtmapn.Text = lst_dl.SelectedItems[0].SubItems[0].Text;
            txtmahang.Text = lst_dl.SelectedItems[0].SubItems[1].Text;
            txtsoluong.Text = lst_dl.SelectedItems[0].SubItems[2].Text;
            txtgiaban.Text = lst_dl.SelectedItems[0].SubItems[3].Text;
        }


    }
}
