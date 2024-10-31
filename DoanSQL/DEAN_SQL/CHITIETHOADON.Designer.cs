namespace DEAN_SQL
{
    partial class CHITIETHOADON
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
            this.txtgiaban = new System.Windows.Forms.TextBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.lblgiaban = new System.Windows.Forms.Label();
            this.lblmakh = new System.Windows.Forms.Label();
            this.lblsoluong = new System.Windows.Forms.Label();
            this.lblmahd = new System.Windows.Forms.Label();
            this.grpthongtinhchitiethd = new System.Windows.Forms.GroupBox();
            this.lst_dl = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbomahd = new System.Windows.Forms.ComboBox();
            this.cbomahg = new System.Windows.Forms.ComboBox();
            this.grpnhapthongtin.SuspendLayout();
            this.grpthongtinhchitiethd.SuspendLayout();
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
            this.grpnhapthongtin.Controls.Add(this.cbomahg);
            this.grpnhapthongtin.Controls.Add(this.cbomahd);
            this.grpnhapthongtin.Controls.Add(this.txtgiaban);
            this.grpnhapthongtin.Controls.Add(this.txtsoluong);
            this.grpnhapthongtin.Controls.Add(this.lblgiaban);
            this.grpnhapthongtin.Controls.Add(this.lblmakh);
            this.grpnhapthongtin.Controls.Add(this.lblsoluong);
            this.grpnhapthongtin.Controls.Add(this.lblmahd);
            this.grpnhapthongtin.Location = new System.Drawing.Point(89, 66);
            this.grpnhapthongtin.Name = "grpnhapthongtin";
            this.grpnhapthongtin.Size = new System.Drawing.Size(756, 201);
            this.grpnhapthongtin.TabIndex = 16;
            this.grpnhapthongtin.TabStop = false;
            this.grpnhapthongtin.Text = "Nhập thông tin chi tiết hóa đơn";
            // 
            // txtgiaban
            // 
            this.txtgiaban.Location = new System.Drawing.Point(467, 119);
            this.txtgiaban.Name = "txtgiaban";
            this.txtgiaban.Size = new System.Drawing.Size(230, 22);
            this.txtgiaban.TabIndex = 7;
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(133, 125);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(215, 22);
            this.txtsoluong.TabIndex = 5;
            // 
            // lblgiaban
            // 
            this.lblgiaban.AutoSize = true;
            this.lblgiaban.Location = new System.Drawing.Point(397, 124);
            this.lblgiaban.Name = "lblgiaban";
            this.lblgiaban.Size = new System.Drawing.Size(55, 16);
            this.lblgiaban.TabIndex = 3;
            this.lblgiaban.Text = "GiaBan:";
            // 
            // lblmakh
            // 
            this.lblmakh.AutoSize = true;
            this.lblmakh.Location = new System.Drawing.Point(397, 46);
            this.lblmakh.Name = "lblmakh";
            this.lblmakh.Size = new System.Drawing.Size(49, 16);
            this.lblmakh.TabIndex = 2;
            this.lblmakh.Text = "MaHG:";
            this.lblmakh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblsoluong
            // 
            this.lblsoluong.AutoSize = true;
            this.lblsoluong.Location = new System.Drawing.Point(58, 128);
            this.lblsoluong.Name = "lblsoluong";
            this.lblsoluong.Size = new System.Drawing.Size(64, 16);
            this.lblsoluong.TabIndex = 1;
            this.lblsoluong.Text = "SoLuong:";
            // 
            // lblmahd
            // 
            this.lblmahd.AutoSize = true;
            this.lblmahd.Location = new System.Drawing.Point(58, 46);
            this.lblmahd.Name = "lblmahd";
            this.lblmahd.Size = new System.Drawing.Size(49, 16);
            this.lblmahd.TabIndex = 0;
            this.lblmahd.Text = "MaHD:";
            // 
            // grpthongtinhchitiethd
            // 
            this.grpthongtinhchitiethd.Controls.Add(this.lst_dl);
            this.grpthongtinhchitiethd.Location = new System.Drawing.Point(89, 333);
            this.grpthongtinhchitiethd.Name = "grpthongtinhchitiethd";
            this.grpthongtinhchitiethd.Size = new System.Drawing.Size(756, 212);
            this.grpthongtinhchitiethd.TabIndex = 15;
            this.grpthongtinhchitiethd.TabStop = false;
            this.grpthongtinhchitiethd.Text = "Thông tin chi tiết hóa đơn";
            // 
            // lst_dl
            // 
            this.lst_dl.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
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
            this.columnHeader2.Text = "MAHG";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "SOLUONG";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "GIABAN";
            this.columnHeader4.Width = 90;
            // 
            // cbomahd
            // 
            this.cbomahd.FormattingEnabled = true;
            this.cbomahd.Location = new System.Drawing.Point(133, 43);
            this.cbomahd.Name = "cbomahd";
            this.cbomahd.Size = new System.Drawing.Size(215, 24);
            this.cbomahd.TabIndex = 8;
            // 
            // cbomahg
            // 
            this.cbomahg.FormattingEnabled = true;
            this.cbomahg.Location = new System.Drawing.Point(467, 43);
            this.cbomahg.Name = "cbomahg";
            this.cbomahg.Size = new System.Drawing.Size(230, 24);
            this.cbomahg.TabIndex = 9;
            // 
            // CHITIETHOADON
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
            this.Controls.Add(this.grpthongtinhchitiethd);
            this.Name = "CHITIETHOADON";
            this.Text = "CHITIETHOADON";
            this.Load += new System.EventHandler(this.CHITIETHOADON_Load);
            this.grpnhapthongtin.ResumeLayout(false);
            this.grpnhapthongtin.PerformLayout();
            this.grpthongtinhchitiethd.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox txtgiaban;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.Label lblgiaban;
        private System.Windows.Forms.Label lblmakh;
        private System.Windows.Forms.Label lblsoluong;
        private System.Windows.Forms.Label lblmahd;
        private System.Windows.Forms.GroupBox grpthongtinhchitiethd;
        private System.Windows.Forms.ListView lst_dl;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ComboBox cbomahg;
        private System.Windows.Forms.ComboBox cbomahd;
    }
}