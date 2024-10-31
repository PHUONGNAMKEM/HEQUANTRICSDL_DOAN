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
    public partial class NHACC : Form
    {
        public string user, pass, server, data, connectionString;
        public NHACC(string username, string password, string servername, string database)
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
        private void NHACC_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connectionString);
            display();
        }
        public void display()
        {
            i = 0;
            lst_dl.Items.Clear();
            conn.Open();
            //sql = @"SELECT * FROM NHACC";
            sql = @"select * from dbo.F_HIENTHI_NHACC()";
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
            txtmancc.Text = lst_dl.SelectedItems[0].SubItems[0].Text;
            txttenncc.Text = lst_dl.SelectedItems[0].SubItems[1].Text;
            txtdiachi.Text = lst_dl.SelectedItems[0].SubItems[2].Text;
            txtsodt.Text = lst_dl.SelectedItems[0].SubItems[3].Text;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txtmancc.TextLength != 0)
            {
                try
                {
                    conn.Open();
                    //sql = @"INSERT INTO NHACC(MANCC, TENNCC, DIACHI, SODT) VALUES('" + txtmancc.Text.Trim() + "',N'" + txttenncc.Text.Trim() + "',N'" + txtdiachi.Text.Trim() + "','" + txtsodt.Text.Trim() + "')";
                    sql = @"EXEC THEM_NHACC '" + txtmancc.Text.Trim() + "', N'" + txttenncc.Text.Trim() + "', N'" + txttenncc.Text.Trim() + "', '" + txtsodt.Text.Trim() + "'";
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
                MessageBox.Show("Mã nhà cung cấp không được đễ trống", "Thông báo");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                //sql = @"DELETE FROM NHACC WHERE MANCC = '" + txtmancc.Text.Trim() + "'";
                sql = @"EXEC XOA_NHACC '" + txtmancc.Text.Trim() + "'";
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
                //string sql = @"UPDATE NHACC SET MANCC = @MANCC, TENNCC = @TENNCC, DIACHI = @DIACHI, SODT = @SODT WHERE MANCC = '" + item.SubItems[0].Text + "'";
                string sql = @"EXEC SUA_NHACC '" + txtmancc.Text.Trim() + "', N'" + txttenncc.Text.Trim() + "', N'" + txtdiachi.Text.Trim() + "', '" + txtsodt.Text.Trim() + "','" + item.SubItems[0].Text + "'";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MANCC", txtmancc.Text.Trim());
                    cmd.Parameters.AddWithValue("@TENNCC", txttenncc.Text.Trim());
                    cmd.Parameters.AddWithValue("@DIACHI", txtdiachi.Text.Trim());
                    cmd.Parameters.AddWithValue("@SODT", txtsodt.Text.Trim());
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
            txtdiachi.Clear();
            txtmancc.Clear();
            txtsodt.Clear();
            txttenncc.Clear();
        }

    }
}
