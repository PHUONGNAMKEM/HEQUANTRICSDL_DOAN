namespace DEAN_SQL
{
    partial class NHACC
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
            this.txtsodt = new System.Windows.Forms.TextBox();
            this.txttenncc = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txtmancc = new System.Windows.Forms.TextBox();
            this.lblsodt = new System.Windows.Forms.Label();
            this.lbltenncc = new System.Windows.Forms.Label();
            this.lbldiachi = new System.Windows.Forms.Label();
            this.lblmncc = new System.Windows.Forms.Label();
            this.grpthongtinnhacc = new System.Windows.Forms.GroupBox();
            this.lst_dl = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpnhapthongtin.SuspendLayout();
            this.grpthongtinnhacc.SuspendLayout();
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
            this.grpnhapthongtin.Controls.Add(this.txtsodt);
            this.grpnhapthongtin.Controls.Add(this.txttenncc);
            this.grpnhapthongtin.Controls.Add(this.txtdiachi);
            this.grpnhapthongtin.Controls.Add(this.txtmancc);
            this.grpnhapthongtin.Controls.Add(this.lblsodt);
            this.grpnhapthongtin.Controls.Add(this.lbltenncc);
            this.grpnhapthongtin.Controls.Add(this.lbldiachi);
            this.grpnhapthongtin.Controls.Add(this.lblmncc);
            this.grpnhapthongtin.Location = new System.Drawing.Point(89, 66);
            this.grpnhapthongtin.Name = "grpnhapthongtin";
            this.grpnhapthongtin.Size = new System.Drawing.Size(756, 201);
            this.grpnhapthongtin.TabIndex = 30;
            this.grpnhapthongtin.TabStop = false;
            this.grpnhapthongtin.Text = "Nhập thông tin nhà cung cấp";
            // 
            // txtsodt
            // 
            this.txtsodt.Location = new System.Drawing.Point(478, 130);
            this.txtsodt.Name = "txtsodt";
            this.txtsodt.Size = new System.Drawing.Size(230, 22);
            this.txtsodt.TabIndex = 7;
            // 
            // txttenncc
            // 
            this.txttenncc.Location = new System.Drawing.Point(478, 48);
            this.txttenncc.Multiline = true;
            this.txttenncc.Name = "txttenncc";
            this.txttenncc.Size = new System.Drawing.Size(230, 22);
            this.txttenncc.TabIndex = 6;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(129, 130);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(215, 22);
            this.txtdiachi.TabIndex = 5;
            // 
            // txtmancc
            // 
            this.txtmancc.Location = new System.Drawing.Point(129, 48);
            this.txtmancc.Name = "txtmancc";
            this.txtmancc.Size = new System.Drawing.Size(215, 22);
            this.txtmancc.TabIndex = 4;
            // 
            // lblsodt
            // 
            this.lblsodt.AutoSize = true;
            this.lblsodt.Location = new System.Drawing.Point(393, 133);
            this.lblsodt.Name = "lblsodt";
            this.lblsodt.Size = new System.Drawing.Size(48, 17);
            this.lblsodt.TabIndex = 3;
            this.lblsodt.Text = "SoĐT:";
            // 
            // lbltenncc
            // 
            this.lbltenncc.AutoSize = true;
            this.lbltenncc.Location = new System.Drawing.Point(393, 51);
            this.lbltenncc.Name = "lbltenncc";
            this.lbltenncc.Size = new System.Drawing.Size(65, 17);
            this.lbltenncc.TabIndex = 2;
            this.lbltenncc.Text = "TenNCC:";
            this.lbltenncc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbldiachi
            // 
            this.lbldiachi.AutoSize = true;
            this.lbldiachi.Location = new System.Drawing.Point(54, 133);
            this.lbldiachi.Name = "lbldiachi";
            this.lbldiachi.Size = new System.Drawing.Size(55, 17);
            this.lbldiachi.TabIndex = 1;
            this.lbldiachi.Text = "Địa chỉ:";
            // 
            // lblmncc
            // 
            this.lblmncc.AutoSize = true;
            this.lblmncc.Location = new System.Drawing.Point(54, 51);
            this.lblmncc.Name = "lblmncc";
            this.lblmncc.Size = new System.Drawing.Size(59, 17);
            this.lblmncc.TabIndex = 0;
            this.lblmncc.Text = "MaNCC:";
            // 
            // grpthongtinnhacc
            // 
            this.grpthongtinnhacc.Controls.Add(this.lst_dl);
            this.grpthongtinnhacc.Location = new System.Drawing.Point(89, 333);
            this.grpthongtinnhacc.Name = "grpthongtinnhacc";
            this.grpthongtinnhacc.Size = new System.Drawing.Size(756, 212);
            this.grpthongtinnhacc.TabIndex = 29;
            this.grpthongtinnhacc.TabStop = false;
            this.grpthongtinnhacc.Text = "Thông tin nhà cung cấp";
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
            this.columnHeader1.Text = "MANCC";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "TENNCC";
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
            // NHACC
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
            this.Name = "NHACC";
            this.Text = "NHACC";
            this.Load += new System.EventHandler(this.NHACC_Load);
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
        private System.Windows.Forms.TextBox txtsodt;
        private System.Windows.Forms.TextBox txttenncc;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txtmancc;
        private System.Windows.Forms.Label lblsodt;
        private System.Windows.Forms.Label lbltenncc;
        private System.Windows.Forms.Label lbldiachi;
        private System.Windows.Forms.Label lblmncc;
        private System.Windows.Forms.GroupBox grpthongtinnhacc;
        private System.Windows.Forms.ListView lst_dl;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}