namespace DEAN_SQL
{
    partial class NhanVienView
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
            this.txtnguoiql = new System.Windows.Forms.TextBox();
            this.txttennv = new System.Windows.Forms.TextBox();
            this.txtchucvu = new System.Windows.Forms.TextBox();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.lblnguoiql = new System.Windows.Forms.Label();
            this.lbltennv = new System.Windows.Forms.Label();
            this.lblchucvu = new System.Windows.Forms.Label();
            this.lblmanv = new System.Windows.Forms.Label();
            this.grpthongtinnhacc = new System.Windows.Forms.GroupBox();
            this.lst_dl = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btntuoi = new System.Windows.Forms.Button();
            this.grpnhapthongtin.SuspendLayout();
            this.grpthongtinnhacc.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(721, 281);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(121, 46);
            this.btnclear.TabIndex = 49;
            this.btnclear.Text = "Mới";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(405, 281);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(121, 46);
            this.btnsua.TabIndex = 48;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(247, 281);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(121, 46);
            this.btnxoa.TabIndex = 47;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(89, 281);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(121, 46);
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
            this.grpnhapthongtin.Controls.Add(this.txtnguoiql);
            this.grpnhapthongtin.Controls.Add(this.txttennv);
            this.grpnhapthongtin.Controls.Add(this.txtchucvu);
            this.grpnhapthongtin.Controls.Add(this.txtmanv);
            this.grpnhapthongtin.Controls.Add(this.lblnguoiql);
            this.grpnhapthongtin.Controls.Add(this.lbltennv);
            this.grpnhapthongtin.Controls.Add(this.lblchucvu);
            this.grpnhapthongtin.Controls.Add(this.lblmanv);
            this.grpnhapthongtin.Location = new System.Drawing.Point(89, 66);
            this.grpnhapthongtin.Name = "grpnhapthongtin";
            this.grpnhapthongtin.Size = new System.Drawing.Size(756, 201);
            this.grpnhapthongtin.TabIndex = 44;
            this.grpnhapthongtin.TabStop = false;
            this.grpnhapthongtin.Text = "Nhập thông tin nhân viên";
            // 
            // txtnguoiql
            // 
            this.txtnguoiql.Location = new System.Drawing.Point(478, 130);
            this.txtnguoiql.Name = "txtnguoiql";
            this.txtnguoiql.Size = new System.Drawing.Size(230, 22);
            this.txtnguoiql.TabIndex = 7;
            // 
            // txttennv
            // 
            this.txttennv.Location = new System.Drawing.Point(478, 48);
            this.txttennv.Multiline = true;
            this.txttennv.Name = "txttennv";
            this.txttennv.Size = new System.Drawing.Size(230, 22);
            this.txttennv.TabIndex = 6;
            // 
            // txtchucvu
            // 
            this.txtchucvu.Location = new System.Drawing.Point(129, 130);
            this.txtchucvu.Name = "txtchucvu";
            this.txtchucvu.Size = new System.Drawing.Size(215, 22);
            this.txtchucvu.TabIndex = 5;
            // 
            // txtmanv
            // 
            this.txtmanv.Location = new System.Drawing.Point(129, 48);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(215, 22);
            this.txtmanv.TabIndex = 4;
            // 
            // lblnguoiql
            // 
            this.lblnguoiql.AutoSize = true;
            this.lblnguoiql.Location = new System.Drawing.Point(393, 133);
            this.lblnguoiql.Name = "lblnguoiql";
            this.lblnguoiql.Size = new System.Drawing.Size(63, 16);
            this.lblnguoiql.TabIndex = 3;
            this.lblnguoiql.Text = "Người QL";
            // 
            // lbltennv
            // 
            this.lbltennv.AutoSize = true;
            this.lbltennv.Location = new System.Drawing.Point(393, 51);
            this.lbltennv.Name = "lbltennv";
            this.lbltennv.Size = new System.Drawing.Size(53, 16);
            this.lbltennv.TabIndex = 2;
            this.lbltennv.Text = "TenNV:";
            this.lbltennv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblchucvu
            // 
            this.lblchucvu.AutoSize = true;
            this.lblchucvu.Location = new System.Drawing.Point(54, 133);
            this.lblchucvu.Name = "lblchucvu";
            this.lblchucvu.Size = new System.Drawing.Size(57, 16);
            this.lblchucvu.TabIndex = 1;
            this.lblchucvu.Text = "Chức vụ:";
            // 
            // lblmanv
            // 
            this.lblmanv.AutoSize = true;
            this.lblmanv.Location = new System.Drawing.Point(54, 51);
            this.lblmanv.Name = "lblmanv";
            this.lblmanv.Size = new System.Drawing.Size(48, 16);
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
            this.columnHeader1.Text = "MANV";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "TENNV";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "CHUCVU";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "MAQL";
            this.columnHeader4.Width = 90;
            // 
            // btntuoi
            // 
            this.btntuoi.Location = new System.Drawing.Point(563, 281);
            this.btntuoi.Name = "btntuoi";
            this.btntuoi.Size = new System.Drawing.Size(121, 46);
            this.btntuoi.TabIndex = 50;
            this.btntuoi.Text = "Tuổi";
            this.btntuoi.UseVisualStyleBackColor = true;
            this.btntuoi.Click += new System.EventHandler(this.btntuoi_Click);
            // 
            // NhanVienView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 562);
            this.Controls.Add(this.btntuoi);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grpnhapthongtin);
            this.Controls.Add(this.grpthongtinnhacc);
            this.Name = "NhanVienView";
            this.Text = "NhanVienView";
            this.Load += new System.EventHandler(this.NhanVienView_Load);
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
        private System.Windows.Forms.TextBox txtnguoiql;
        private System.Windows.Forms.TextBox txttennv;
        private System.Windows.Forms.TextBox txtchucvu;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.Label lblnguoiql;
        private System.Windows.Forms.Label lbltennv;
        private System.Windows.Forms.Label lblchucvu;
        private System.Windows.Forms.Label lblmanv;
        private System.Windows.Forms.GroupBox grpthongtinnhacc;
        private System.Windows.Forms.ListView lst_dl;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btntuoi;
    }
}