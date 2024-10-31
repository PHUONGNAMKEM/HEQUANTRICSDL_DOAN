namespace DEAN_SQL
{
    partial class KhachHangView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnrank = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.grpnhapthongtin = new System.Windows.Forms.GroupBox();
            this.txtsodt = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txttenkh = new System.Windows.Forms.TextBox();
            this.txtmakh = new System.Windows.Forms.TextBox();
            this.lblsodt = new System.Windows.Forms.Label();
            this.lbldiachi = new System.Windows.Forms.Label();
            this.lbltenkh = new System.Windows.Forms.Label();
            this.lblmakh = new System.Windows.Forms.Label();
            this.grpthongtinkhach = new System.Windows.Forms.GroupBox();
            this.lst_khachhang = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnclear = new System.Windows.Forms.Button();
            this.grpnhapthongtin.SuspendLayout();
            this.grpthongtinkhach.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnrank
            // 
            this.btnrank.Location = new System.Drawing.Point(566, 281);
            this.btnrank.Name = "btnrank";
            this.btnrank.Size = new System.Drawing.Size(120, 46);
            this.btnrank.TabIndex = 14;
            this.btnrank.Text = "Hạng";
            this.btnrank.UseVisualStyleBackColor = true;
            this.btnrank.Click += new System.EventHandler(this.btnrank_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(407, 281);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(120, 46);
            this.btnsua.TabIndex = 13;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(248, 281);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(120, 46);
            this.btnxoa.TabIndex = 12;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(89, 281);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(120, 46);
            this.btnthem.TabIndex = 11;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(436, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "APP";
            // 
            // grpnhapthongtin
            // 
            this.grpnhapthongtin.Controls.Add(this.txtsodt);
            this.grpnhapthongtin.Controls.Add(this.txtdiachi);
            this.grpnhapthongtin.Controls.Add(this.txttenkh);
            this.grpnhapthongtin.Controls.Add(this.txtmakh);
            this.grpnhapthongtin.Controls.Add(this.lblsodt);
            this.grpnhapthongtin.Controls.Add(this.lbldiachi);
            this.grpnhapthongtin.Controls.Add(this.lbltenkh);
            this.grpnhapthongtin.Controls.Add(this.lblmakh);
            this.grpnhapthongtin.Location = new System.Drawing.Point(89, 66);
            this.grpnhapthongtin.Name = "grpnhapthongtin";
            this.grpnhapthongtin.Size = new System.Drawing.Size(756, 201);
            this.grpnhapthongtin.TabIndex = 9;
            this.grpnhapthongtin.TabStop = false;
            this.grpnhapthongtin.Text = "Nhập thông tin khách hàng";
            // 
            // txtsodt
            // 
            this.txtsodt.Location = new System.Drawing.Point(459, 121);
            this.txtsodt.Name = "txtsodt";
            this.txtsodt.Size = new System.Drawing.Size(238, 22);
            this.txtsodt.TabIndex = 7;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(459, 43);
            this.txtdiachi.Multiline = true;
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(238, 22);
            this.txtdiachi.TabIndex = 6;
            // 
            // txttenkh
            // 
            this.txttenkh.Location = new System.Drawing.Point(110, 127);
            this.txttenkh.Name = "txttenkh";
            this.txttenkh.Size = new System.Drawing.Size(238, 22);
            this.txttenkh.TabIndex = 5;
            // 
            // txtmakh
            // 
            this.txtmakh.Location = new System.Drawing.Point(110, 43);
            this.txtmakh.Name = "txtmakh";
            this.txtmakh.Size = new System.Drawing.Size(238, 22);
            this.txtmakh.TabIndex = 4;
            // 
            // lblsodt
            // 
            this.lblsodt.AutoSize = true;
            this.lblsodt.Location = new System.Drawing.Point(397, 126);
            this.lblsodt.Name = "lblsodt";
            this.lblsodt.Size = new System.Drawing.Size(37, 16);
            this.lblsodt.TabIndex = 3;
            this.lblsodt.Text = "SĐT:";
            // 
            // lbldiachi
            // 
            this.lbldiachi.AutoSize = true;
            this.lbldiachi.Location = new System.Drawing.Point(397, 46);
            this.lbldiachi.Name = "lbldiachi";
            this.lbldiachi.Size = new System.Drawing.Size(50, 16);
            this.lbldiachi.TabIndex = 2;
            this.lbldiachi.Text = "Địa chỉ:";
            // 
            // lbltenkh
            // 
            this.lbltenkh.AutoSize = true;
            this.lbltenkh.Location = new System.Drawing.Point(58, 130);
            this.lbltenkh.Name = "lbltenkh";
            this.lbltenkh.Size = new System.Drawing.Size(52, 16);
            this.lbltenkh.TabIndex = 1;
            this.lbltenkh.Text = "TenKH:";
            // 
            // lblmakh
            // 
            this.lblmakh.AutoSize = true;
            this.lblmakh.Location = new System.Drawing.Point(58, 46);
            this.lblmakh.Name = "lblmakh";
            this.lblmakh.Size = new System.Drawing.Size(47, 16);
            this.lblmakh.TabIndex = 0;
            this.lblmakh.Text = "MaKH:";
            // 
            // grpthongtinkhach
            // 
            this.grpthongtinkhach.Controls.Add(this.lst_khachhang);
            this.grpthongtinkhach.Location = new System.Drawing.Point(89, 353);
            this.grpthongtinkhach.Name = "grpthongtinkhach";
            this.grpthongtinkhach.Size = new System.Drawing.Size(756, 212);
            this.grpthongtinkhach.TabIndex = 8;
            this.grpthongtinkhach.TabStop = false;
            this.grpthongtinkhach.Text = "Thông tin khách hàng";
            // 
            // lst_khachhang
            // 
            this.lst_khachhang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lst_khachhang.FullRowSelect = true;
            this.lst_khachhang.GridLines = true;
            this.lst_khachhang.HideSelection = false;
            this.lst_khachhang.Location = new System.Drawing.Point(61, 39);
            this.lst_khachhang.Name = "lst_khachhang";
            this.lst_khachhang.Size = new System.Drawing.Size(636, 148);
            this.lst_khachhang.TabIndex = 0;
            this.lst_khachhang.UseCompatibleStateImageBehavior = false;
            this.lst_khachhang.View = System.Windows.Forms.View.Details;
            this.lst_khachhang.Click += new System.EventHandler(this.lst_khachhang_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "MAKH";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "TENKH";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "DIACHI";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "SODT";
            this.columnHeader4.Width = 90;
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(725, 281);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(120, 46);
            this.btnclear.TabIndex = 15;
            this.btnclear.Text = "Mới";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // KhachHangView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 586);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnrank);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grpnhapthongtin);
            this.Controls.Add(this.grpthongtinkhach);
            this.Name = "KhachHangView";
            this.Text = "KhachHangView";
            this.Load += new System.EventHandler(this.KhachHangView_Load);
            this.grpnhapthongtin.ResumeLayout(false);
            this.grpnhapthongtin.PerformLayout();
            this.grpthongtinkhach.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnrank;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grpnhapthongtin;
        private System.Windows.Forms.TextBox txtsodt;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txttenkh;
        private System.Windows.Forms.TextBox txtmakh;
        private System.Windows.Forms.Label lblsodt;
        private System.Windows.Forms.Label lbldiachi;
        private System.Windows.Forms.Label lbltenkh;
        private System.Windows.Forms.Label lblmakh;
        private System.Windows.Forms.GroupBox grpthongtinkhach;
        private System.Windows.Forms.ListView lst_khachhang;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnclear;
    }
}