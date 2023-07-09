
namespace QUANLYKHOHANG
{
    partial class FmChiTietNH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmChiTietNH));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSuaPhieu = new System.Windows.Forms.Button();
            this.btnXoaPhieu = new System.Windows.Forms.Button();
            this.btnThemPhieu = new System.Windows.Forms.Button();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DataCTPN = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataKh = new System.Windows.Forms.GroupBox();
            this.btnInPN = new System.Windows.Forms.Button();
            this.cmMaSp = new System.Windows.Forms.ComboBox();
            this.cmMaPN = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataCTPN)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.dataKh.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnSuaPhieu
            // 
            this.btnSuaPhieu.Enabled = false;
            this.btnSuaPhieu.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaPhieu.Image")));
            this.btnSuaPhieu.Location = new System.Drawing.Point(746, 192);
            this.btnSuaPhieu.Name = "btnSuaPhieu";
            this.btnSuaPhieu.Size = new System.Drawing.Size(103, 77);
            this.btnSuaPhieu.TabIndex = 32;
            this.btnSuaPhieu.UseVisualStyleBackColor = true;
            this.btnSuaPhieu.Click += new System.EventHandler(this.btnSuaPhieu_Click);
            // 
            // btnXoaPhieu
            // 
            this.btnXoaPhieu.BackColor = System.Drawing.SystemColors.Control;
            this.btnXoaPhieu.Enabled = false;
            this.btnXoaPhieu.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaPhieu.Image")));
            this.btnXoaPhieu.Location = new System.Drawing.Point(454, 192);
            this.btnXoaPhieu.Name = "btnXoaPhieu";
            this.btnXoaPhieu.Size = new System.Drawing.Size(103, 77);
            this.btnXoaPhieu.TabIndex = 33;
            this.btnXoaPhieu.UseVisualStyleBackColor = false;
            this.btnXoaPhieu.Click += new System.EventHandler(this.btnXoaPhieu_Click);
            // 
            // btnThemPhieu
            // 
            this.btnThemPhieu.BackColor = System.Drawing.SystemColors.Control;
            this.btnThemPhieu.Image = ((System.Drawing.Image)(resources.GetObject("btnThemPhieu.Image")));
            this.btnThemPhieu.Location = new System.Drawing.Point(194, 184);
            this.btnThemPhieu.Name = "btnThemPhieu";
            this.btnThemPhieu.Size = new System.Drawing.Size(99, 85);
            this.btnThemPhieu.TabIndex = 32;
            this.btnThemPhieu.UseVisualStyleBackColor = false;
            this.btnThemPhieu.Click += new System.EventHandler(this.btnThemPhieu_Click);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(764, 77);
            this.txtSoLuong.Multiline = true;
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(295, 36);
            this.txtSoLuong.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(581, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số Lượng";
            // 
            // DataCTPN
            // 
            this.DataCTPN.AllowUserToAddRows = false;
            this.DataCTPN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataCTPN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataCTPN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.DataCTPN.Location = new System.Drawing.Point(6, 28);
            this.DataCTPN.Name = "DataCTPN";
            this.DataCTPN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataCTPN.Size = new System.Drawing.Size(1175, 256);
            this.DataCTPN.TabIndex = 0;
            this.DataCTPN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataCTPN_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MAPHIEU_NH";
            this.Column1.HeaderText = "Mã Phiếu Nhập";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MA_SP";
            this.Column2.HeaderText = "Mã Sản Phẩm";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SOLUONG";
            this.Column3.HeaderText = "Số Lượng";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "THANHTIEN";
            this.Column4.HeaderText = "Tổng Tiền";
            this.Column4.Name = "Column4";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DataCTPN);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 342);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1187, 284);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Phiếu Nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Sản Phẩm";
            // 
            // dataKh
            // 
            this.dataKh.Controls.Add(this.btnInPN);
            this.dataKh.Controls.Add(this.cmMaSp);
            this.dataKh.Controls.Add(this.cmMaPN);
            this.dataKh.Controls.Add(this.btnSuaPhieu);
            this.dataKh.Controls.Add(this.btnXoaPhieu);
            this.dataKh.Controls.Add(this.btnThemPhieu);
            this.dataKh.Controls.Add(this.txtSoLuong);
            this.dataKh.Controls.Add(this.label3);
            this.dataKh.Controls.Add(this.label2);
            this.dataKh.Controls.Add(this.label1);
            this.dataKh.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataKh.Location = new System.Drawing.Point(12, 67);
            this.dataKh.Name = "dataKh";
            this.dataKh.Size = new System.Drawing.Size(1173, 269);
            this.dataKh.TabIndex = 29;
            this.dataKh.TabStop = false;
            this.dataKh.Text = "Thông Tin Chi Tiết Phiếu Nhập";
            // 
            // btnInPN
            // 
            this.btnInPN.Enabled = false;
            this.btnInPN.Image = ((System.Drawing.Image)(resources.GetObject("btnInPN.Image")));
            this.btnInPN.Location = new System.Drawing.Point(992, 191);
            this.btnInPN.Name = "btnInPN";
            this.btnInPN.Size = new System.Drawing.Size(103, 71);
            this.btnInPN.TabIndex = 50;
            this.btnInPN.UseVisualStyleBackColor = true;
            this.btnInPN.Click += new System.EventHandler(this.btnInPN_Click);
            // 
            // cmMaSp
            // 
            this.cmMaSp.FormattingEnabled = true;
            this.cmMaSp.Location = new System.Drawing.Point(213, 121);
            this.cmMaSp.Name = "cmMaSp";
            this.cmMaSp.Size = new System.Drawing.Size(268, 29);
            this.cmMaSp.TabIndex = 37;
            // 
            // cmMaPN
            // 
            this.cmMaPN.FormattingEnabled = true;
            this.cmMaPN.Location = new System.Drawing.Point(213, 47);
            this.cmMaPN.Name = "cmMaPN";
            this.cmMaPN.Size = new System.Drawing.Size(268, 29);
            this.cmMaPN.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Phiếu Nhập";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Aqua;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(142, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(881, 55);
            this.label12.TabIndex = 28;
            this.label12.Text = "Chào Mừng Bạn Đến Với Chi Phiếu Nhập";
            // 
            // FmChiTietNH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 732);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataKh);
            this.Controls.Add(this.label12);
            this.Name = "FmChiTietNH";
            this.Text = "FmChiTietNH";
            this.Load += new System.EventHandler(this.FmChiTietNH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataCTPN)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.dataKh.ResumeLayout(false);
            this.dataKh.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DataCTPN;
        private System.Windows.Forms.GroupBox dataKh;
        private System.Windows.Forms.Button btnSuaPhieu;
        private System.Windows.Forms.Button btnXoaPhieu;
        private System.Windows.Forms.Button btnThemPhieu;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmMaSp;
        private System.Windows.Forms.ComboBox cmMaPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnInPN;
    }
}