namespace DEAN_SQL
{
    partial class CHITIETPN
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
            this.txtmahang = new System.Windows.Forms.TextBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.txtmapn = new System.Windows.Forms.TextBox();
            this.lblgiaban = new System.Windows.Forms.Label();
            this.lblmahang = new System.Windows.Forms.Label();
            this.lblsoluong = new System.Windows.Forms.Label();
            this.lblmahg = new System.Windows.Forms.Label();
            this.grpthongtinhanghoa = new System.Windows.Forms.GroupBox();
            this.lst_dl = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpnhapthongtin.SuspendLayout();
            this.grpthongtinhanghoa.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(699, 281);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(146, 46);
            this.btnclear.TabIndex = 35;
            this.btnclear.Text = "Mới";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(493, 281);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(146, 46);
            this.btnsua.TabIndex = 34;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(291, 281);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(146, 46);
            this.btnxoa.TabIndex = 33;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(89, 281);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(146, 46);
            this.btnthem.TabIndex = 32;
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
            this.label5.TabIndex = 31;
            this.label5.Text = "APP";
            // 
            // grpnhapthongtin
            // 
            this.grpnhapthongtin.Controls.Add(this.txtgiaban);
            this.grpnhapthongtin.Controls.Add(this.txtmahang);
            this.grpnhapthongtin.Controls.Add(this.txtsoluong);
            this.grpnhapthongtin.Controls.Add(this.txtmapn);
            this.grpnhapthongtin.Controls.Add(this.lblgiaban);
            this.grpnhapthongtin.Controls.Add(this.lblmahang);
            this.grpnhapthongtin.Controls.Add(this.lblsoluong);
            this.grpnhapthongtin.Controls.Add(this.lblmahg);
            this.grpnhapthongtin.Location = new System.Drawing.Point(89, 66);
            this.grpnhapthongtin.Name = "grpnhapthongtin";
            this.grpnhapthongtin.Size = new System.Drawing.Size(756, 201);
            this.grpnhapthongtin.TabIndex = 30;
            this.grpnhapthongtin.TabStop = false;
            this.grpnhapthongtin.Text = "Nhập thông tin chi tiết phiếu nhập";
            // 
            // txtgiaban
            // 
            this.txtgiaban.Location = new System.Drawing.Point(467, 119);
            this.txtgiaban.Name = "txtgiaban";
            this.txtgiaban.Size = new System.Drawing.Size(230, 22);
            this.txtgiaban.TabIndex = 7;
            // 
            // txtmahang
            // 
            this.txtmahang.Location = new System.Drawing.Point(467, 43);
            this.txtmahang.Multiline = true;
            this.txtmahang.Name = "txtmahang";
            this.txtmahang.Size = new System.Drawing.Size(230, 22);
            this.txtmahang.TabIndex = 6;
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(133, 125);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(215, 22);
            this.txtsoluong.TabIndex = 5;
            // 
            // txtmapn
            // 
            this.txtmapn.Location = new System.Drawing.Point(133, 43);
            this.txtmapn.Name = "txtmapn";
            this.txtmapn.Size = new System.Drawing.Size(215, 22);
            this.txtmapn.TabIndex = 4;
            // 
            // lblgiaban
            // 
            this.lblgiaban.AutoSize = true;
            this.lblgiaban.Location = new System.Drawing.Point(397, 124);
            this.lblgiaban.Name = "lblgiaban";
            this.lblgiaban.Size = new System.Drawing.Size(59, 17);
            this.lblgiaban.TabIndex = 3;
            this.lblgiaban.Text = "GiaBan:";
            // 
            // lblmahang
            // 
            this.lblmahang.AutoSize = true;
            this.lblmahang.Location = new System.Drawing.Point(397, 46);
            this.lblmahang.Name = "lblmahang";
            this.lblmahang.Size = new System.Drawing.Size(65, 17);
            this.lblmahang.TabIndex = 2;
            this.lblmahang.Text = "MaHang:";
            this.lblmahang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblsoluong
            // 
            this.lblsoluong.AutoSize = true;
            this.lblsoluong.Location = new System.Drawing.Point(58, 128);
            this.lblsoluong.Name = "lblsoluong";
            this.lblsoluong.Size = new System.Drawing.Size(69, 17);
            this.lblsoluong.TabIndex = 1;
            this.lblsoluong.Text = "SoLuong:";
            this.lblsoluong.Click += new System.EventHandler(this.lblsoluong_Click);
            // 
            // lblmahg
            // 
            this.lblmahg.AutoSize = true;
            this.lblmahg.Location = new System.Drawing.Point(58, 46);
            this.lblmahg.Name = "lblmahg";
            this.lblmahg.Size = new System.Drawing.Size(50, 17);
            this.lblmahg.TabIndex = 0;
            this.lblmahg.Text = "MaPN:";
            // 
            // grpthongtinhanghoa
            // 
            this.grpthongtinhanghoa.Controls.Add(this.lst_dl);
            this.grpthongtinhanghoa.Location = new System.Drawing.Point(89, 333);
            this.grpthongtinhanghoa.Name = "grpthongtinhanghoa";
            this.grpthongtinhanghoa.Size = new System.Drawing.Size(756, 212);
            this.grpthongtinhanghoa.TabIndex = 29;
            this.grpthongtinhanghoa.TabStop = false;
            this.grpthongtinhanghoa.Text = "Thông tin chi tiết phiếu nhập";
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
            this.columnHeader1.Text = "MAPN";
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
            // CHITIETPN
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
            this.Controls.Add(this.grpthongtinhanghoa);
            this.Name = "CHITIETPN";
            this.Text = "CHITIETPN";
            this.Load += new System.EventHandler(this.CHITIETPN_Load);
            this.grpnhapthongtin.ResumeLayout(false);
            this.grpnhapthongtin.PerformLayout();
            this.grpthongtinhanghoa.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox txtmahang;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.TextBox txtmapn;
        private System.Windows.Forms.Label lblgiaban;
        private System.Windows.Forms.Label lblmahang;
        private System.Windows.Forms.Label lblsoluong;
        private System.Windows.Forms.Label lblmahg;
        private System.Windows.Forms.GroupBox grpthongtinhanghoa;
        private System.Windows.Forms.ListView lst_dl;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}