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
    public partial class PHIEUNHAP : Form
    {
        public string user, pass, server, data, connectionString;
        public PHIEUNHAP(string username, string password, string servername, string database)
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
        private void PHIEUNHAP_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connectionString);
            display();
        }
        public void display()
        {
            i = 0;
            lst_dl.Items.Clear();
            conn.Open();
            //sql = @"SELECT * FROM PHIEUNHAP";
            sql = @"select * from dbo.F_HIENTHI_PHIEUNHAP()";
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

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txtmapn.TextLength != 0)
            {
                try
                {
                    conn.Open();
                    //sql = @"INSERT INTO PHIEUNHAP(MAPN, NGAYNHAP, MANCC, MANV) VALUES('" + txtmapn.Text.Trim() + "',N'" + txtngaynhap.Text.Trim() + "',N'" + txtmancc.Text.Trim() + "','" + txtmanv.Text.Trim() + "')";
                    sql = @"EXEC THEM_PHIEUNHAP '" + txtmapn.Text.Trim() + "', '" + txtngaynhap.Text.Trim() + "', '" + txtmancc.Text.Trim() + "', '" + txtmanv.Text.Trim() + "'";
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
                //sql = @"DELETE FROM PHIEUNHAP WHERE MAPN = '" + txtmapn.Text.Trim() + "'";
                sql = @"EXEC XOA_PHIEUNHAP '" + txtmapn.Text.Trim() + "'";
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
                string sql = @"UPDATE PHIEUNHAP SET MAPN = @MAPN, NGAYNHAP = @NGAYNHAP, MANCC = @MANCC, MANV = @MANV WHERE MAPN = '" + item.SubItems[0].Text+ "'";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MAPN", txtmapn.Text.Trim());
                    cmd.Parameters.AddWithValue("@NGAYNHAP", txtngaynhap.Text.Trim());
                    cmd.Parameters.AddWithValue("@MANCC", txtmancc.Text.Trim());
                    cmd.Parameters.AddWithValue("@MANV", txtmanv.Text.Trim());
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

        private void lst_dl_Click(object sender, EventArgs e)
        {
            txtmapn.Text = lst_dl.SelectedItems[0].SubItems[0].Text;
            txtngaynhap.Text = lst_dl.SelectedItems[0].SubItems[1].Text;
            txtmancc.Text = lst_dl.SelectedItems[0].SubItems[2].Text;
            txtmanv.Text = lst_dl.SelectedItems[0].SubItems[3].Text;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtmancc.Clear();
            txtmanv.Clear();
            txtmapn.Clear();
            txtngaynhap.Clear();
        }

    }
}
