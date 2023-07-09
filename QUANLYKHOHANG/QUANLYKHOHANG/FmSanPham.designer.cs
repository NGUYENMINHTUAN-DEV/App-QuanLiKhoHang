namespace QUANLYKHOHANG
{
    partial class FmSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmSanPham));
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DataSanPham = new System.Windows.Forms.DataGridView();
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
            this.ANH = new System.Windows.Forms.DataGridViewImageColumn();
            this.sANPHAMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnThem = new System.Windows.Forms.Button();
            this.txtPhanLoaiSP = new System.Windows.Forms.TextBox();
            this.txtMaSp = new System.Windows.Forms.TextBox();
            this.cmMaNCC = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTenSp = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtGiaSp = new System.Windows.Forms.TextBox();
            this.dateNSX = new System.Windows.Forms.DateTimePicker();
            this.dateHSD = new System.Windows.Forms.DateTimePicker();
            this.txtGhiChuSp = new System.Windows.Forms.TextBox();
            this.picXoa = new System.Windows.Forms.GroupBox();
            this.cmMaLSp = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmMaKho = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnAnh = new System.Windows.Forms.Button();
            this.btnInThongKe = new System.Windows.Forms.Button();
            this.btnXoaSp = new System.Windows.Forms.Button();
            this.btnSuaSP = new System.Windows.Forms.Button();
            this.btnThemSp = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.picXoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Aqua;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(381, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(765, 55);
            this.label12.TabIndex = 25;
            this.label12.Text = "Chào Mừng Bạn Đến Với Sản Phẩm";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DataSanPham);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 561);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1572, 292);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Sản Phẩm";
            // 
            // DataSanPham
            // 
            this.DataSanPham.AutoGenerateColumns = false;
            this.DataSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.ANH});
            this.DataSanPham.DataSource = this.sANPHAMBindingSource;
            this.DataSanPham.Location = new System.Drawing.Point(6, 28);
            this.DataSanPham.Name = "DataSanPham";
            this.DataSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataSanPham.Size = new System.Drawing.Size(1560, 258);
            this.DataSanPham.TabIndex = 0;
            this.DataSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataSanPham_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MA_SP";
            this.Column1.HeaderText = "Mã SP";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MA_NCC";
            this.Column2.HeaderText = "Mã NCC";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MAKHO";
            this.Column3.HeaderText = "Mã Kho";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TEN_SP";
            this.Column4.HeaderText = "Tên SP";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "NGAYSX";
            this.Column5.HeaderText = "Ngày Sản Xuất";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "HSD";
            this.Column6.HeaderText = "HSD";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "SOLUONG_SP";
            this.Column7.HeaderText = "Số Lượng";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "MALOAI";
            this.Column8.HeaderText = "Mã Loại SP";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "GIA";
            this.Column9.HeaderText = "Giá";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "GHICHU_SP";
            this.Column10.HeaderText = "Ghi Chú";
            this.Column10.Name = "Column10";
            // 
            // ANH
            // 
            this.ANH.DataPropertyName = "ANH";
            this.ANH.HeaderText = "Ảnh";
            this.ANH.Name = "ANH";
            // 
            // sANPHAMBindingSource
            // 
            this.sANPHAMBindingSource.DataMember = "SAN_PHAM";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(352, 362);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(103, 38);
            this.btnThem.TabIndex = 23;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // txtPhanLoaiSP
            // 
            this.txtPhanLoaiSP.Location = new System.Drawing.Point(832, 176);
            this.txtPhanLoaiSP.Name = "txtPhanLoaiSP";
            this.txtPhanLoaiSP.Size = new System.Drawing.Size(377, 20);
            this.txtPhanLoaiSP.TabIndex = 18;
            // 
            // txtMaSp
            // 
            this.txtMaSp.Location = new System.Drawing.Point(232, 55);
            this.txtMaSp.Name = "txtMaSp";
            this.txtMaSp.Size = new System.Drawing.Size(379, 32);
            this.txtMaSp.TabIndex = 1;
            // 
            // cmMaNCC
            // 
            this.cmMaNCC.FormattingEnabled = true;
            this.cmMaNCC.Location = new System.Drawing.Point(232, 115);
            this.cmMaNCC.Name = "cmMaNCC";
            this.cmMaNCC.Size = new System.Drawing.Size(379, 31);
            this.cmMaNCC.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã SP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã NCC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên SP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ngày Sản Xuất";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(677, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "HSD";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(677, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 23);
            this.label7.TabIndex = 9;
            this.label7.Text = "Số Lượng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(677, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 23);
            this.label8.TabIndex = 10;
            this.label8.Text = "Mã Loại SP";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(677, 249);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 23);
            this.label9.TabIndex = 11;
            this.label9.Text = "Giá";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(677, 307);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 23);
            this.label10.TabIndex = 12;
            this.label10.Text = "Ghi Chú";
            // 
            // txtTenSp
            // 
            this.txtTenSp.Location = new System.Drawing.Point(232, 253);
            this.txtTenSp.Name = "txtTenSp";
            this.txtTenSp.Size = new System.Drawing.Size(379, 32);
            this.txtTenSp.TabIndex = 14;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(825, 114);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(379, 32);
            this.txtSoLuong.TabIndex = 17;
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuongSP_KeyPress);
            // 
            // txtGiaSp
            // 
            this.txtGiaSp.Location = new System.Drawing.Point(825, 246);
            this.txtGiaSp.Name = "txtGiaSp";
            this.txtGiaSp.Size = new System.Drawing.Size(379, 32);
            this.txtGiaSp.TabIndex = 19;
            this.txtGiaSp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuongSP_KeyPress);
            // 
            // dateNSX
            // 
            this.dateNSX.CustomFormat = "dd/MM/yyyy";
            this.dateNSX.Location = new System.Drawing.Point(232, 309);
            this.dateNSX.Name = "dateNSX";
            this.dateNSX.Size = new System.Drawing.Size(379, 32);
            this.dateNSX.TabIndex = 24;
            // 
            // dateHSD
            // 
            this.dateHSD.CustomFormat = "dd/MM/yyyy";
            this.dateHSD.Location = new System.Drawing.Point(825, 57);
            this.dateHSD.Name = "dateHSD";
            this.dateHSD.Size = new System.Drawing.Size(379, 32);
            this.dateHSD.TabIndex = 29;
            // 
            // txtGhiChuSp
            // 
            this.txtGhiChuSp.Location = new System.Drawing.Point(825, 307);
            this.txtGhiChuSp.Name = "txtGhiChuSp";
            this.txtGhiChuSp.Size = new System.Drawing.Size(379, 32);
            this.txtGhiChuSp.TabIndex = 30;
            // 
            // picXoa
            // 
            this.picXoa.BackColor = System.Drawing.SystemColors.Control;
            this.picXoa.Controls.Add(this.btnAnh);
            this.picXoa.Controls.Add(this.btnInThongKe);
            this.picXoa.Controls.Add(this.btnXoaSp);
            this.picXoa.Controls.Add(this.btnSuaSP);
            this.picXoa.Controls.Add(this.btnThemSp);
            this.picXoa.Controls.Add(this.cmMaLSp);
            this.picXoa.Controls.Add(this.label4);
            this.picXoa.Controls.Add(this.cmMaKho);
            this.picXoa.Controls.Add(this.label16);
            this.picXoa.Controls.Add(this.label15);
            this.picXoa.Controls.Add(this.label14);
            this.picXoa.Controls.Add(this.label13);
            this.picXoa.Controls.Add(this.label11);
            this.picXoa.Controls.Add(this.pictureBox1);
            this.picXoa.Controls.Add(this.txtGhiChuSp);
            this.picXoa.Controls.Add(this.dateHSD);
            this.picXoa.Controls.Add(this.dateNSX);
            this.picXoa.Controls.Add(this.txtGiaSp);
            this.picXoa.Controls.Add(this.txtSoLuong);
            this.picXoa.Controls.Add(this.txtTenSp);
            this.picXoa.Controls.Add(this.label10);
            this.picXoa.Controls.Add(this.label9);
            this.picXoa.Controls.Add(this.label8);
            this.picXoa.Controls.Add(this.label7);
            this.picXoa.Controls.Add(this.label6);
            this.picXoa.Controls.Add(this.label5);
            this.picXoa.Controls.Add(this.label3);
            this.picXoa.Controls.Add(this.label2);
            this.picXoa.Controls.Add(this.label1);
            this.picXoa.Controls.Add(this.cmMaNCC);
            this.picXoa.Controls.Add(this.txtMaSp);
            this.picXoa.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.picXoa.Location = new System.Drawing.Point(12, 76);
            this.picXoa.Name = "picXoa";
            this.picXoa.Size = new System.Drawing.Size(1572, 479);
            this.picXoa.TabIndex = 29;
            this.picXoa.TabStop = false;
            this.picXoa.Text = "Thông Tin Sản Phẩm";
            // 
            // cmMaLSp
            // 
            this.cmMaLSp.FormattingEnabled = true;
            this.cmMaLSp.Location = new System.Drawing.Point(825, 177);
            this.cmMaLSp.Name = "cmMaLSp";
            this.cmMaLSp.Size = new System.Drawing.Size(379, 31);
            this.cmMaLSp.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 23);
            this.label4.TabIndex = 44;
            this.label4.Text = "Mã Kho";
            // 
            // cmMaKho
            // 
            this.cmMaKho.FormattingEnabled = true;
            this.cmMaKho.Location = new System.Drawing.Point(232, 183);
            this.cmMaKho.Name = "cmMaKho";
            this.cmMaKho.Size = new System.Drawing.Size(379, 31);
            this.cmMaKho.TabIndex = 43;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1067, 459);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 23);
            this.label16.TabIndex = 42;
            this.label16.Text = "Thống Kê";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1379, 454);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 23);
            this.label15.TabIndex = 40;
            this.label15.Text = "Thêm Ảnh";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(474, 459);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 23);
            this.label14.TabIndex = 39;
            this.label14.Text = "Sửa";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(776, 459);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 23);
            this.label13.TabIndex = 38;
            this.label13.Text = "Xóa";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(160, 456);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 23);
            this.label11.TabIndex = 37;
            this.label11.Text = "Thêm";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox1.Location = new System.Drawing.Point(1271, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(279, 318);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "ANH";
            this.dataGridViewImageColumn1.HeaderText = "ANH";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 69;
            // 
            // btnAnh
            // 
            this.btnAnh.Enabled = false;
            this.btnAnh.Image = ((System.Drawing.Image)(resources.GetObject("btnAnh.Image")));
            this.btnAnh.Location = new System.Drawing.Point(1378, 372);
            this.btnAnh.Name = "btnAnh";
            this.btnAnh.Size = new System.Drawing.Size(97, 84);
            this.btnAnh.TabIndex = 55;
            this.btnAnh.UseVisualStyleBackColor = true;
            this.btnAnh.Click += new System.EventHandler(this.btnTKn_Click);
            // 
            // btnInThongKe
            // 
            this.btnInThongKe.Enabled = false;
            this.btnInThongKe.Image = ((System.Drawing.Image)(resources.GetObject("btnInThongKe.Image")));
            this.btnInThongKe.Location = new System.Drawing.Point(1054, 384);
            this.btnInThongKe.Name = "btnInThongKe";
            this.btnInThongKe.Size = new System.Drawing.Size(105, 71);
            this.btnInThongKe.TabIndex = 54;
            this.btnInThongKe.UseVisualStyleBackColor = true;
            this.btnInThongKe.Click += new System.EventHandler(this.btnInThongKe_Click);
            // 
            // btnXoaSp
            // 
            this.btnXoaSp.Enabled = false;
            this.btnXoaSp.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaSp.Image")));
            this.btnXoaSp.Location = new System.Drawing.Point(751, 384);
            this.btnXoaSp.Name = "btnXoaSp";
            this.btnXoaSp.Size = new System.Drawing.Size(95, 78);
            this.btnXoaSp.TabIndex = 53;
            this.btnXoaSp.UseVisualStyleBackColor = true;
            this.btnXoaSp.Click += new System.EventHandler(this.btnXoaSp_Click);
            // 
            // btnSuaSP
            // 
            this.btnSuaSP.Enabled = false;
            this.btnSuaSP.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaSP.Image")));
            this.btnSuaSP.Location = new System.Drawing.Point(443, 385);
            this.btnSuaSP.Name = "btnSuaSP";
            this.btnSuaSP.Size = new System.Drawing.Size(103, 77);
            this.btnSuaSP.TabIndex = 52;
            this.btnSuaSP.UseVisualStyleBackColor = true;
            this.btnSuaSP.Click += new System.EventHandler(this.btnSuaSP_Click);
            // 
            // btnThemSp
            // 
            this.btnThemSp.Image = ((System.Drawing.Image)(resources.GetObject("btnThemSp.Image")));
            this.btnThemSp.Location = new System.Drawing.Point(146, 388);
            this.btnThemSp.Name = "btnThemSp";
            this.btnThemSp.Size = new System.Drawing.Size(103, 71);
            this.btnThemSp.TabIndex = 51;
            this.btnThemSp.UseVisualStyleBackColor = true;
            this.btnThemSp.Click += new System.EventHandler(this.btnThemSp_Click);
            // 
            // FmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1583, 852);
            this.Controls.Add(this.picXoa);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label12);
            this.Name = "FmSanPham";
            this.Text = "Sản Phẩm";
            this.Load += new System.EventHandler(this.FmSanPham_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.picXoa.ResumeLayout(false);
            this.picXoa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtPhanLoaiSP;
        private System.Windows.Forms.GroupBox picXoa;
        private System.Windows.Forms.TextBox txtGhiChuSp;
        private System.Windows.Forms.DateTimePicker dateHSD;
        private System.Windows.Forms.DateTimePicker dateNSX;
        private System.Windows.Forms.TextBox txtGiaSp;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtTenSp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmMaNCC;
        private System.Windows.Forms.TextBox txtMaSp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
 
        private System.Windows.Forms.BindingSource sANPHAMBindingSource;
        private System.Windows.Forms.DataGridViewImageColumn aNHDataGridViewImageColumn;
        private System.Windows.Forms.DataGridView DataSanPham;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmMaLSp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmMaKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn mASPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mANCCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dANHMUCSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYSXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hSDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOLUONGSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gHICHUSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pHANLOAISPDataGridViewTextBoxColumn;
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
        private System.Windows.Forms.DataGridViewImageColumn ANH;
        private System.Windows.Forms.Button btnAnh;
        private System.Windows.Forms.Button btnInThongKe;
        private System.Windows.Forms.Button btnXoaSp;
        private System.Windows.Forms.Button btnSuaSP;
        private System.Windows.Forms.Button btnThemSp;
    }
}