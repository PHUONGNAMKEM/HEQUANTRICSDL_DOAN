namespace DEAN_SQL
{
    partial class ThongTinNhanVien
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
            this.txtcmnd = new System.Windows.Forms.TextBox();
            this.txtngaysinh = new System.Windows.Forms.TextBox();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.lblcmnd = new System.Windows.Forms.Label();
            this.lblngaysinh = new System.Windows.Forms.Label();
            this.lblgioitinh = new System.Windows.Forms.Label();
            this.lblmanv = new System.Windows.Forms.Label();
            this.grpthongtinnhacc = new System.Windows.Forms.GroupBox();
            this.lst_dl = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbogioitinh = new System.Windows.Forms.ComboBox();
            this.grpnhapthongtin.SuspendLayout();
            this.grpthongtinnhacc.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(699, 281);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(146, 46);
            this.btnclear.TabIndex = 49;
            this.btnclear.Text = "Mới";
            this.btnclear.UseVisualStyleBackColor = true;
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(493, 281);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(146, 46);
            this.btnsua.TabIndex = 48;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(291, 281);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(146, 46);
            this.btnxoa.TabIndex = 47;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(89, 281);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(146, 46);
            this.btnthem.TabIndex = 46;
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
            this.label5.TabIndex = 45;
            this.label5.Text = "APP";
            // 
            // grpnhapthongtin
            // 
            this.grpnhapthongtin.Controls.Add(this.cbogioitinh);
            this.grpnhapthongtin.Controls.Add(this.txtemail);
            this.grpnhapthongtin.Controls.Add(this.lblemail);
            this.grpnhapthongtin.Controls.Add(this.txtcmnd);
            this.grpnhapthongtin.Controls.Add(this.txtngaysinh);
            this.grpnhapthongtin.Controls.Add(this.txtmanv);
            this.grpnhapthongtin.Controls.Add(this.lblcmnd);
            this.grpnhapthongtin.Controls.Add(this.lblngaysinh);
            this.grpnhapthongtin.Controls.Add(this.lblgioitinh);
            this.grpnhapthongtin.Controls.Add(this.lblmanv);
            this.grpnhapthongtin.Location = new System.Drawing.Point(89, 66);
            this.grpnhapthongtin.Name = "grpnhapthongtin";
            this.grpnhapthongtin.Size = new System.Drawing.Size(756, 201);
            this.grpnhapthongtin.TabIndex = 44;
            this.grpnhapthongtin.TabStop = false;
            this.grpnhapthongtin.Text = "Nhập thông tin nhân viên";
            // 
            // txtcmnd
            // 
            this.txtcmnd.Location = new System.Drawing.Point(478, 104);
            this.txtcmnd.Name = "txtcmnd";
            this.txtcmnd.Size = new System.Drawing.Size(230, 22);
            this.txtcmnd.TabIndex = 7;
            // 
            // txtngaysinh
            // 
            this.txtngaysinh.Location = new System.Drawing.Point(478, 48);
            this.txtngaysinh.Multiline = true;
            this.txtngaysinh.Name = "txtngaysinh";
            this.txtngaysinh.Size = new System.Drawing.Size(230, 22);
            this.txtngaysinh.TabIndex = 6;
            // 
            // txtmanv
            // 
            this.txtmanv.Location = new System.Drawing.Point(129, 48);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(230, 22);
            this.txtmanv.TabIndex = 4;
            // 
            // lblcmnd
            // 
            this.lblcmnd.AutoSize = true;
            this.lblcmnd.Location = new System.Drawing.Point(393, 107);
            this.lblcmnd.Name = "lblcmnd";
            this.lblcmnd.Size = new System.Drawing.Size(52, 17);
            this.lblcmnd.TabIndex = 3;
            this.lblcmnd.Text = "CMND:";
            // 
            // lblngaysinh
            // 
            this.lblngaysinh.AutoSize = true;
            this.lblngaysinh.Location = new System.Drawing.Point(393, 51);
            this.lblngaysinh.Name = "lblngaysinh";
            this.lblngaysinh.Size = new System.Drawing.Size(73, 17);
            this.lblngaysinh.TabIndex = 2;
            this.lblngaysinh.Text = "NgaySinh:";
            this.lblngaysinh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblgioitinh
            // 
            this.lblgioitinh.AutoSize = true;
            this.lblgioitinh.Location = new System.Drawing.Point(40, 107);
            this.lblgioitinh.Name = "lblgioitinh";
            this.lblgioitinh.Size = new System.Drawing.Size(64, 17);
            this.lblgioitinh.TabIndex = 1;
            this.lblgioitinh.Text = "Giới tính:";
            // 
            // lblmanv
            // 
            this.lblmanv.AutoSize = true;
            this.lblmanv.Location = new System.Drawing.Point(54, 51);
            this.lblmanv.Name = "lblmanv";
            this.lblmanv.Size = new System.Drawing.Size(50, 17);
            this.lblmanv.TabIndex = 0;
            this.lblmanv.Text = "MaNV:";
            // 
            // grpthongtinnhacc
            // 
            this.grpthongtinnhacc.Controls.Add(this.lst_dl);
            this.grpthongtinnhacc.Location = new System.Drawing.Point(89, 333);
            this.grpthongtinnhacc.Name = "grpthongtinnhacc";
            this.grpthongtinnhacc.Size = new System.Drawing.Size(756, 212);
            this.grpthongtinnhacc.TabIndex = 43;
            this.grpthongtinnhacc.TabStop = false;
            this.grpthongtinnhacc.Text = "Thông tin nhân viên";
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
            this.columnHeader1.Text = "MANV";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "NGAYSINH";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "GIOITINH";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "CMND";
            this.columnHeader4.Width = 90;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(129, 156);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(230, 22);
            this.txtemail.TabIndex = 9;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(58, 159);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(46, 17);
            this.lblemail.TabIndex = 8;
            this.lblemail.Text = "Email:";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "EMAIL";
            this.columnHeader5.Width = 90;
            // 
            // cbogioitinh
            // 
            this.cbogioitinh.FormattingEnabled = true;
            this.cbogioitinh.Location = new System.Drawing.Point(129, 104);
            this.cbogioitinh.Name = "cbogioitinh";
            this.cbogioitinh.Size = new System.Drawing.Size(230, 24);
            this.cbogioitinh.TabIndex = 10;
            // 
            // ThongTinNhanVien
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
            this.Controls.Add(this.grpthongtinnhacc);
            this.Name = "ThongTinNhanVien";
            this.Text = "ThongTinNhanVien";
            this.Load += new System.EventHandler(this.ThongTinNhanVien_Load);
            this.grpnhapthongtin.ResumeLayout(false);
            this.grpnhapthongtin.PerformLayout();
            this.grpthongtinnhacc.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox txtcmnd;
        private System.Windows.Forms.TextBox txtngaysinh;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.Label lblcmnd;
        private System.Windows.Forms.Label lblngaysinh;
        private System.Windows.Forms.Label lblgioitinh;
        private System.Windows.Forms.Label lblmanv;
        private System.Windows.Forms.GroupBox grpthongtinnhacc;
        private System.Windows.Forms.ListView lst_dl;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ComboBox cbogioitinh;
    }
}