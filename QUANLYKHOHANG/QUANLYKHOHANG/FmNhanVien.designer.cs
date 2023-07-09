namespace QUANLYKHOHANG
{
    partial class FmNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmNhanVien));
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaNv = new System.Windows.Forms.TextBox();
            this.cmGtNv = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoaNV = new System.Windows.Forms.Button();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.cmBp = new System.Windows.Forms.ComboBox();
            this.dateNv = new System.Windows.Forms.DateTimePicker();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtLuongNv = new System.Windows.Forms.TextBox();
            this.txtDiaChiNv = new System.Windows.Forms.TextBox();
            this.txtCvNv = new System.Windows.Forms.TextBox();
            this.txtDtNv = new System.Windows.Forms.TextBox();
            this.txtMailNv = new System.Windows.Forms.TextBox();
            this.txtTenNv = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DataNhanVien = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã NV";
            // 
            // txtMaNv
            // 
            this.txtMaNv.Location = new System.Drawing.Point(160, 54);
            this.txtMaNv.Name = "txtMaNv";
            this.txtMaNv.Size = new System.Drawing.Size(379, 32);
            this.txtMaNv.TabIndex = 1;
            this.txtMaNv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaNv_KeyPress);
            // 
            // cmGtNv
            // 
            this.cmGtNv.FormattingEnabled = true;
            this.cmGtNv.Items.AddRange(new object[] {
            "NAM",
            "NỮ"});
            this.cmGtNv.Location = new System.Drawing.Point(160, 299);
            this.cmGtNv.Name = "cmGtNv";
            this.cmGtNv.Size = new System.Drawing.Size(379, 31);
            this.cmGtNv.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnXoaNV);
            this.groupBox1.Controls.Add(this.btnThemNV);
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.cmBp);
            this.groupBox1.Controls.Add(this.dateNv);
            this.groupBox1.Controls.Add(this.txtTimKiem);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtLuongNv);
            this.groupBox1.Controls.Add(this.txtDiaChiNv);
            this.groupBox1.Controls.Add(this.txtCvNv);
            this.groupBox1.Controls.Add(this.txtDtNv);
            this.groupBox1.Controls.Add(this.txtMailNv);
            this.groupBox1.Controls.Add(this.txtTenNv);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmGtNv);
            this.groupBox1.Controls.Add(this.txtMaNv);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1552, 421);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Nhân Viên";
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.Control;
            this.btnSua.Enabled = false;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(910, 344);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(103, 77);
            this.btnSua.TabIndex = 31;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoaNV
            // 
            this.btnXoaNV.BackColor = System.Drawing.SystemColors.Control;
            this.btnXoaNV.Enabled = false;
            this.btnXoaNV.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaNV.Image")));
            this.btnXoaNV.Location = new System.Drawing.Point(617, 340);
            this.btnXoaNV.Name = "btnXoaNV";
            this.btnXoaNV.Size = new System.Drawing.Size(103, 77);
            this.btnXoaNV.TabIndex = 30;
            this.btnXoaNV.UseVisualStyleBackColor = false;
            this.btnXoaNV.Click += new System.EventHandler(this.btnXoaNV_Click);
            // 
            // btnThemNV
            // 
            this.btnThemNV.BackColor = System.Drawing.SystemColors.Control;
            this.btnThemNV.Image = ((System.Drawing.Image)(resources.GetObject("btnThemNV.Image")));
            this.btnThemNV.Location = new System.Drawing.Point(343, 336);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(99, 85);
            this.btnThemNV.TabIndex = 29;
            this.btnThemNV.UseVisualStyleBackColor = false;
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Enabled = false;
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(1338, 155);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(115, 71);
            this.btnTimKiem.TabIndex = 28;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // cmBp
            // 
            this.cmBp.FormattingEnabled = true;
            this.cmBp.Items.AddRange(new object[] {
            "PHỤC VỤ",
            "NHẬP HÀNG",
            "XUẤT HÀNG"});
            this.cmBp.Location = new System.Drawing.Point(754, 299);
            this.cmBp.Name = "cmBp";
            this.cmBp.Size = new System.Drawing.Size(379, 31);
            this.cmBp.TabIndex = 25;
            // 
            // dateNv
            // 
            this.dateNv.Location = new System.Drawing.Point(160, 246);
            this.dateNv.Name = "dateNv";
            this.dateNv.Size = new System.Drawing.Size(379, 32);
            this.dateNv.TabIndex = 24;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(1208, 105);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(325, 32);
            this.txtTimKiem.TabIndex = 22;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1291, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(162, 23);
            this.label11.TabIndex = 21;
            this.label11.Text = "Tìm Kiếm Mã NV";
            // 
            // txtLuongNv
            // 
            this.txtLuongNv.Location = new System.Drawing.Point(754, 246);
            this.txtLuongNv.Name = "txtLuongNv";
            this.txtLuongNv.Size = new System.Drawing.Size(379, 32);
            this.txtLuongNv.TabIndex = 19;
            this.txtLuongNv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDtNv_KeyPress);
            // 
            // txtDiaChiNv
            // 
            this.txtDiaChiNv.Location = new System.Drawing.Point(754, 176);
            this.txtDiaChiNv.Name = "txtDiaChiNv";
            this.txtDiaChiNv.Size = new System.Drawing.Size(379, 32);
            this.txtDiaChiNv.TabIndex = 18;
            // 
            // txtCvNv
            // 
            this.txtCvNv.Location = new System.Drawing.Point(754, 114);
            this.txtCvNv.Name = "txtCvNv";
            this.txtCvNv.Size = new System.Drawing.Size(379, 32);
            this.txtCvNv.TabIndex = 17;
            // 
            // txtDtNv
            // 
            this.txtDtNv.Location = new System.Drawing.Point(754, 57);
            this.txtDtNv.Name = "txtDtNv";
            this.txtDtNv.Size = new System.Drawing.Size(379, 32);
            this.txtDtNv.TabIndex = 16;
            this.txtDtNv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDtNv_KeyPress);
            // 
            // txtMailNv
            // 
            this.txtMailNv.Location = new System.Drawing.Point(160, 182);
            this.txtMailNv.Name = "txtMailNv";
            this.txtMailNv.Size = new System.Drawing.Size(379, 32);
            this.txtMailNv.TabIndex = 14;
            this.txtMailNv.TextChanged += new System.EventHandler(this.txtMailNv_TextChanged);
            // 
            // txtTenNv
            // 
            this.txtTenNv.Location = new System.Drawing.Point(160, 114);
            this.txtTenNv.Name = "txtTenNv";
            this.txtTenNv.Size = new System.Drawing.Size(379, 32);
            this.txtTenNv.TabIndex = 13;
            this.txtTenNv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaNv_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(617, 307);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 23);
            this.label10.TabIndex = 12;
            this.label10.Text = "Bộ Phận";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(617, 249);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 23);
            this.label9.TabIndex = 11;
            this.label9.Text = "Lương";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(617, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 23);
            this.label8.TabIndex = 10;
            this.label8.Text = "Địa Chỉ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(617, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 23);
            this.label7.TabIndex = 9;
            this.label7.Text = "Chức Vụ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(617, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Điện Thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Giới Tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ngày Sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên NV";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Aqua;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(361, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(771, 55);
            this.label12.TabIndex = 23;
            this.label12.Text = "Chào Mừng Bạn Đến Với Nhân Viên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DataNhanVien);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 514);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1540, 266);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Nhân Viên";
            // 
            // DataNhanVien
            // 
            this.DataNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.DataNhanVien.Location = new System.Drawing.Point(0, 31);
            this.DataNhanVien.Name = "DataNhanVien";
            this.DataNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataNhanVien.Size = new System.Drawing.Size(1534, 235);
            this.DataNhanVien.TabIndex = 1;
            this.DataNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataNhanVien_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MANV";
            this.Column1.HeaderText = "Mã NV";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TEN_NV";
            this.Column2.HeaderText = "Tên NV";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "EMAIL_NV";
            this.Column3.HeaderText = "Email";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "NGSINH_NV";
            this.Column4.HeaderText = "Ngày Sinh";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "GIOITINH_NV";
            this.Column5.HeaderText = "Giới Tính";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "SDT_NV";
            this.Column6.HeaderText = "Điện Thoại";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "CHUCVU_NV";
            this.Column7.HeaderText = "Chức Vụ";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "DIACHI_NV";
            this.Column8.HeaderText = "Địa Chỉ";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "LUONG_NV";
            this.Column9.HeaderText = "Lương";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "BOPHAN_NV";
            this.Column10.HeaderText = "Bộ Phận";
            this.Column10.Name = "Column10";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1557, 784);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox1);
            this.Name = "FmNhanVien";
            this.Text = "Nhân Viên";
            this.Load += new System.EventHandler(this.FmNhanVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaNv;
        private System.Windows.Forms.ComboBox cmGtNv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMailNv;
        private System.Windows.Forms.TextBox txtTenNv;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtLuongNv;
        private System.Windows.Forms.TextBox txtDiaChiNv;
        private System.Windows.Forms.TextBox txtCvNv;
        private System.Windows.Forms.TextBox txtDtNv;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DataNhanVien;
        private System.Windows.Forms.DateTimePicker dateNv;
        private System.Windows.Forms.ComboBox cmBp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.Button btnXoaNV;
        private System.Windows.Forms.Button btnSua;
    }
}