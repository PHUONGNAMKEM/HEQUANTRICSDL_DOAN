namespace DEAN_SQL
{
    partial class HoaDonView
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
            this.btnclear = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.grpnhapthongtin = new System.Windows.Forms.GroupBox();
            this.cbotrangthai = new System.Windows.Forms.ComboBox();
            this.lbltrangthai = new System.Windows.Forms.Label();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.txtmakh = new System.Windows.Forms.TextBox();
            this.txtngaylap = new System.Windows.Forms.TextBox();
            this.txtmahd = new System.Windows.Forms.TextBox();
            this.lblmanv = new System.Windows.Forms.Label();
            this.lblmakh = new System.Windows.Forms.Label();
            this.lblngaylap = new System.Windows.Forms.Label();
            this.lblmahd = new System.Windows.Forms.Label();
            this.grpthongtinhoadon = new System.Windows.Forms.GroupBox();
            this.lst_dl = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpnhapthongtin.SuspendLayout();
            this.grpthongtinhoadon.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(699, 281);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(146, 46);
            this.btnclear.TabIndex = 21;
            this.btnclear.Text = "Mới";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(493, 281);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(146, 46);
            this.btnsua.TabIndex = 20;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(291, 281);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(146, 46);
            this.btnxoa.TabIndex = 19;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(89, 281);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(146, 46);
            this.btnthem.TabIndex = 18;
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
            this.label5.TabIndex = 17;
            this.label5.Text = "APP";
            // 
            // grpnhapthongtin
            // 
            this.grpnhapthongtin.Controls.Add(this.cbotrangthai);
            this.grpnhapthongtin.Controls.Add(this.lbltrangthai);
            this.grpnhapthongtin.Controls.Add(this.txtmanv);
            this.grpnhapthongtin.Controls.Add(this.txtmakh);
            this.grpnhapthongtin.Controls.Add(this.txtngaylap);
            this.grpnhapthongtin.Controls.Add(this.txtmahd);
            this.grpnhapthongtin.Controls.Add(this.lblmanv);
            this.grpnhapthongtin.Controls.Add(this.lblmakh);
            this.grpnhapthongtin.Controls.Add(this.lblngaylap);
            this.grpnhapthongtin.Controls.Add(this.lblmahd);
            this.grpnhapthongtin.Location = new System.Drawing.Point(89, 66);
            this.grpnhapthongtin.Name = "grpnhapthongtin";
            this.grpnhapthongtin.Size = new System.Drawing.Size(756, 201);
            this.grpnhapthongtin.TabIndex = 16;
            this.grpnhapthongtin.TabStop = false;
            this.grpnhapthongtin.Text = "Nhập thông tin hóa đơn";
            // 
            // cbotrangthai
            // 
            this.cbotrangthai.FormattingEnabled = true;
            this.cbotrangthai.Location = new System.Drawing.Point(133, 150);
            this.cbotrangthai.Name = "cbotrangthai";
            this.cbotrangthai.Size = new System.Drawing.Size(215, 24);
            this.cbotrangthai.TabIndex = 9;
            // 
            // lbltrangthai
            // 
            this.lbltrangthai.AutoSize = true;
            this.lbltrangthai.Location = new System.Drawing.Point(58, 157);
            this.lbltrangthai.Name = "lbltrangthai";
            this.lbltrangthai.Size = new System.Drawing.Size(78, 17);
            this.lbltrangthai.TabIndex = 8;
            this.lbltrangthai.Text = "TrangThai:";
            // 
            // txtmanv
            // 
            this.txtmanv.Location = new System.Drawing.Point(467, 93);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(230, 22);
            this.txtmanv.TabIndex = 7;
            // 
            // txtmakh
            // 
            this.txtmakh.Location = new System.Drawing.Point(467, 43);
            this.txtmakh.Multiline = true;
            this.txtmakh.Name = "txtmakh";
            this.txtmakh.Size = new System.Drawing.Size(230, 22);
            this.txtmakh.TabIndex = 6;
            // 
            // txtngaylap
            // 
            this.txtngaylap.Location = new System.Drawing.Point(133, 99);
            this.txtngaylap.Name = "txtngaylap";
            this.txtngaylap.Size = new System.Drawing.Size(215, 22);
            this.txtngaylap.TabIndex = 5;
            // 
            // txtmahd
            // 
            this.txtmahd.Location = new System.Drawing.Point(133, 43);
            this.txtmahd.Name = "txtmahd";
            this.txtmahd.Size = new System.Drawing.Size(215, 22);
            this.txtmahd.TabIndex = 4;
            // 
            // lblmanv
            // 
            this.lblmanv.AutoSize = true;
            this.lblmanv.Location = new System.Drawing.Point(397, 98);
            this.lblmanv.Name = "lblmanv";
            this.lblmanv.Size = new System.Drawing.Size(50, 17);
            this.lblmanv.TabIndex = 3;
            this.lblmanv.Text = "MaNV:";
            // 
            // lblmakh
            // 
            this.lblmakh.AutoSize = true;
            this.lblmakh.Location = new System.Drawing.Point(397, 46);
            this.lblmakh.Name = "lblmakh";
            this.lblmakh.Size = new System.Drawing.Size(50, 17);
            this.lblmakh.TabIndex = 2;
            this.lblmakh.Text = "MaKH:";
            this.lblmakh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblngaylap
            // 
            this.lblngaylap.AutoSize = true;
            this.lblngaylap.Location = new System.Drawing.Point(58, 102);
            this.lblngaylap.Name = "lblngaylap";
            this.lblngaylap.Size = new System.Drawing.Size(69, 17);
            this.lblngaylap.TabIndex = 1;
            this.lblngaylap.Text = "NgayLap:";
            // 
            // lblmahd
            // 
            this.lblmahd.AutoSize = true;
            this.lblmahd.Location = new System.Drawing.Point(58, 46);
            this.lblmahd.Name = "lblmahd";
            this.lblmahd.Size = new System.Drawing.Size(51, 17);
            this.lblmahd.TabIndex = 0;
            this.lblmahd.Text = "MaHD:";
            // 
            // grpthongtinhoadon
            // 
            this.grpthongtinhoadon.Controls.Add(this.lst_dl);
            this.grpthongtinhoadon.Location = new System.Drawing.Point(89, 333);
            this.grpthongtinhoadon.Name = "grpthongtinhoadon";
            this.grpthongtinhoadon.Size = new System.Drawing.Size(756, 212);
            this.grpthongtinhoadon.TabIndex = 15;
            this.grpthongtinhoadon.TabStop = false;
            this.grpthongtinhoadon.Text = "Thông tin hóa đơn";
            // 
            // lst_dl
            // 
            this.lst_dl.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lst_dl.FullRowSelect = true;
            this.lst_dl.GridLines = true;
            this.lst_dl.HideSelection = false;
            this.lst_dl.Location = new System.Drawing.Point(61, 39);
            this.lst_dl.Name = "lst_dl";
            this.lst_dl.Size = new System.Drawing.Size(636, 148);
            this.lst_dl.TabIndex = 0;
            this.lst_dl.UseCompatibleStateImageBehavior = false;
            this.lst_dl.View = System.Windows.Forms.View.Details;
            this.lst_dl.Click += new System.EventHandler(this.lst_dl_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "MAHD";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "NGAYLAP";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "TRANGTHAI";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "MAKH";
            this.columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "MANV";
            this.columnHeader5.Width = 90;
            // 
            // HoaDonView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 562);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grpnhapthongtin);
            this.Controls.Add(this.grpthongtinhoadon);
            this.Name = "HoaDonView";
            this.Text = "HoaDonView";
            this.Load += new System.EventHandler(this.HoaDonView_Load);
            this.grpnhapthongtin.ResumeLayout(false);
            this.grpnhapthongtin.PerformLayout();
            this.grpthongtinhoadon.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grpnhapthongtin;
        private System.Windows.Forms.ComboBox cbotrangthai;
        private System.Windows.Forms.Label lbltrangthai;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.TextBox txtmakh;
        private System.Windows.Forms.TextBox txtngaylap;
        private System.Windows.Forms.TextBox txtmahd;
        private System.Windows.Forms.Label lblmanv;
        private System.Windows.Forms.Label lblmakh;
        private System.Windows.Forms.Label lblngaylap;
        private System.Windows.Forms.Label lblmahd;
        private System.Windows.Forms.GroupBox grpthongtinhoadon;
        private System.Windows.Forms.ListView lst_dl;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}