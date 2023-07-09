namespace QUANLYKHOHANG
{
    partial class FmKhachHang
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmKhachHang));
            this.dataKh = new System.Windows.Forms.GroupBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmGt = new System.Windows.Forms.ComboBox();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.txtMailKh = new System.Windows.Forms.TextBox();
            this.txtDTKh = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenKh = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaKh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DataKhachHang = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnXuat = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnSuaKh = new System.Windows.Forms.Button();
            this.btnXoaKh = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dataKh.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataKh
            // 
            this.dataKh.Controls.Add(this.txtTimKiem);
            this.dataKh.Controls.Add(this.label9);
            this.dataKh.Controls.Add(this.cmGt);
            this.dataKh.Controls.Add(this.txtFax);
            this.dataKh.Controls.Add(this.txtMailKh);
            this.dataKh.Controls.Add(this.txtDTKh);
            this.dataKh.Controls.Add(this.txtDiaChi);
            this.dataKh.Controls.Add(this.txtTenKh);
            this.dataKh.Controls.Add(this.label7);
            this.dataKh.Controls.Add(this.txtMaKh);
            this.dataKh.Controls.Add(this.label1);
            this.dataKh.Controls.Add(this.label6);
            this.dataKh.Controls.Add(this.label2);
            this.dataKh.Controls.Add(this.label3);
            this.dataKh.Controls.Add(this.label4);
            this.dataKh.Controls.Add(this.label5);
            this.dataKh.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataKh.Location = new System.Drawing.Point(17, 89);
            this.dataKh.Name = "dataKh";
            this.dataKh.Size = new System.Drawing.Size(461, 488);
            this.dataKh.TabIndex = 0;
            this.dataKh.TabStop = false;
            this.dataKh.Text = "Thông Tin Khách Hàng";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(181, 439);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(258, 36);
            this.txtTimKiem.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 452);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 23);
            this.label9.TabIndex = 14;
            this.label9.Text = "Tìm Kiếm Mã KH";
            // 
            // cmGt
            // 
            this.cmGt.FormattingEnabled = true;
            this.cmGt.Items.AddRange(new object[] {
            "NAM",
            "NỮ"});
            this.cmGt.Location = new System.Drawing.Point(181, 224);
            this.cmGt.Name = "cmGt";
            this.cmGt.Size = new System.Drawing.Size(258, 31);
            this.cmGt.TabIndex = 13;
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(181, 386);
            this.txtFax.Multiline = true;
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(258, 36);
            this.txtFax.TabIndex = 12;
            this.txtFax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDTKh_KeyPress);
            // 
            // txtMailKh
            // 
            this.txtMailKh.Location = new System.Drawing.Point(181, 331);
            this.txtMailKh.Multiline = true;
            this.txtMailKh.Name = "txtMailKh";
            this.txtMailKh.Size = new System.Drawing.Size(258, 36);
            this.txtMailKh.TabIndex = 11;
            this.txtMailKh.TextChanged += new System.EventHandler(this.txtMailKh_TextChanged);
            // 
            // txtDTKh
            // 
            this.txtDTKh.Location = new System.Drawing.Point(181, 270);
            this.txtDTKh.Multiline = true;
            this.txtDTKh.Name = "txtDTKh";
            this.txtDTKh.Size = new System.Drawing.Size(258, 36);
            this.txtDTKh.TabIndex = 10;
            this.txtDTKh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDTKh_KeyPress);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(181, 175);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(258, 36);
            this.txtDiaChi.TabIndex = 9;
            // 
            // txtTenKh
            // 
            this.txtTenKh.Location = new System.Drawing.Point(181, 108);
            this.txtTenKh.Multiline = true;
            this.txtTenKh.Name = "txtTenKh";
            this.txtTenKh.Size = new System.Drawing.Size(258, 36);
            this.txtTenKh.TabIndex = 8;
            this.txtTenKh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenKh_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 409);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 23);
            this.label7.TabIndex = 7;
            this.label7.Text = "Số Fax";
            // 
            // txtMaKh
            // 
            this.txtMaKh.Location = new System.Drawing.Point(181, 42);
            this.txtMaKh.Multiline = true;
            this.txtMaKh.Name = "txtMaKh";
            this.txtMaKh.Size = new System.Drawing.Size(258, 36);
            this.txtMaKh.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Khách Hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Khách Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số Điện Thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Giới Tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Địa Chỉ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DataKhachHang);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(503, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(980, 486);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Khách Hàng";
            // 
            // DataKhachHang
            // 
            this.DataKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.DataKhachHang.Location = new System.Drawing.Point(6, 40);
            this.DataKhachHang.Name = "DataKhachHang";
            this.DataKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataKhachHang.Size = new System.Drawing.Size(974, 446);
            this.DataKhachHang.TabIndex = 0;
            this.DataKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataKhachHang_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MAKH";
            this.Column1.HeaderText = "Mã Khách Hàng";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TEN_KH";
            this.Column2.HeaderText = "Tên Khách Hàng";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DIACHI_KH";
            this.Column3.HeaderText = "Địa Chỉ";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "GIOITINH_KH";
            this.Column4.HeaderText = "Giới Tính";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "SDT_KH";
            this.Column5.HeaderText = "Số Điện Thoại";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "EMAIL_KH";
            this.Column6.HeaderText = "Email";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "FAX";
            this.Column7.HeaderText = "Fax";
            this.Column7.Name = "Column7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Aqua;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(344, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(814, 55);
            this.label8.TabIndex = 2;
            this.label8.Text = "Chào Mừng Bạn Đến Với Khách Hàng";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnXuat
            // 
            this.btnXuat.Enabled = false;
            this.btnXuat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnXuat.Image = ((System.Drawing.Image)(resources.GetObject("btnXuat.Image")));
            this.btnXuat.Location = new System.Drawing.Point(1036, 586);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(102, 74);
            this.btnXuat.TabIndex = 51;
            this.btnXuat.UseVisualStyleBackColor = true;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Enabled = false;
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(1271, 586);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(106, 78);
            this.btnTimKiem.TabIndex = 50;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnSuaKh
            // 
            this.btnSuaKh.Enabled = false;
            this.btnSuaKh.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaKh.Image")));
            this.btnSuaKh.Location = new System.Drawing.Point(768, 583);
            this.btnSuaKh.Name = "btnSuaKh";
            this.btnSuaKh.Size = new System.Drawing.Size(103, 81);
            this.btnSuaKh.TabIndex = 49;
            this.btnSuaKh.UseVisualStyleBackColor = true;
            this.btnSuaKh.Click += new System.EventHandler(this.btnSuaKh_Click);
            // 
            // btnXoaKh
            // 
            this.btnXoaKh.Enabled = false;
            this.btnXoaKh.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaKh.Image")));
            this.btnXoaKh.Location = new System.Drawing.Point(463, 581);
            this.btnXoaKh.Name = "btnXoaKh";
            this.btnXoaKh.Size = new System.Drawing.Size(103, 80);
            this.btnXoaKh.TabIndex = 48;
            this.btnXoaKh.UseVisualStyleBackColor = true;
            this.btnXoaKh.Click += new System.EventHandler(this.btnXoaKh_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(122, 583);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(103, 77);
            this.btnThem.TabIndex = 47;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // FmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1485, 674);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnSuaKh);
            this.Controls.Add(this.btnXoaKh);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataKh);
            this.Name = "FmKhachHang";
            this.Text = "Khách Hàng";
            this.Load += new System.EventHandler(this.KhachHang_Load);
            this.dataKh.ResumeLayout(false);
            this.dataKh.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox dataKh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.TextBox txtMailKh;
        private System.Windows.Forms.TextBox txtDTKh;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenKh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaKh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DataKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmGt;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnSuaKh;
        private System.Windows.Forms.Button btnXoaKh;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label9;
    }
}