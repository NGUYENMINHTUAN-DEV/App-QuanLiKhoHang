
namespace QUANLYKHOHANG
{
    partial class FmChiTietXH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmChiTietXH));
            this.cmMaSpX = new System.Windows.Forms.ComboBox();
            this.cmMaPX = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DataCTPX = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dataKh = new System.Windows.Forms.GroupBox();
            this.btnSuaPhieuX = new System.Windows.Forms.Button();
            this.btnXoaPhieuX = new System.Windows.Forms.Button();
            this.btnThemPhieuX = new System.Windows.Forms.Button();
            this.txtSoLuongX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInPX = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataCTPX)).BeginInit();
            this.dataKh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmMaSpX
            // 
            this.cmMaSpX.FormattingEnabled = true;
            this.cmMaSpX.Location = new System.Drawing.Point(213, 121);
            this.cmMaSpX.Name = "cmMaSpX";
            this.cmMaSpX.Size = new System.Drawing.Size(268, 29);
            this.cmMaSpX.TabIndex = 37;
            // 
            // cmMaPX
            // 
            this.cmMaPX.FormattingEnabled = true;
            this.cmMaPX.Location = new System.Drawing.Point(213, 47);
            this.cmMaPX.Name = "cmMaPX";
            this.cmMaPX.Size = new System.Drawing.Size(268, 29);
            this.cmMaPX.TabIndex = 36;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DataCTPX);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(1, 333);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1187, 284);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Phiếu Xuất";
            // 
            // DataCTPX
            // 
            this.DataCTPX.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataCTPX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataCTPX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.DataCTPX.Location = new System.Drawing.Point(6, 28);
            this.DataCTPX.Name = "DataCTPX";
            this.DataCTPX.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataCTPX.Size = new System.Drawing.Size(1175, 250);
            this.DataCTPX.TabIndex = 0;
            this.DataCTPX.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataCTPX_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Phiếu Xuất";
            // 
            // dataKh
            // 
            this.dataKh.Controls.Add(this.btnInPX);
            this.dataKh.Controls.Add(this.cmMaSpX);
            this.dataKh.Controls.Add(this.cmMaPX);
            this.dataKh.Controls.Add(this.btnSuaPhieuX);
            this.dataKh.Controls.Add(this.btnXoaPhieuX);
            this.dataKh.Controls.Add(this.btnThemPhieuX);
            this.dataKh.Controls.Add(this.txtSoLuongX);
            this.dataKh.Controls.Add(this.label3);
            this.dataKh.Controls.Add(this.label2);
            this.dataKh.Controls.Add(this.label1);
            this.dataKh.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataKh.Location = new System.Drawing.Point(1, 58);
            this.dataKh.Name = "dataKh";
            this.dataKh.Size = new System.Drawing.Size(1173, 269);
            this.dataKh.TabIndex = 32;
            this.dataKh.TabStop = false;
            this.dataKh.Text = "Thông Tin Chi Tiết Phiếu Xuất";
            // 
            // btnSuaPhieuX
            // 
            this.btnSuaPhieuX.Enabled = false;
            this.btnSuaPhieuX.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaPhieuX.Image")));
            this.btnSuaPhieuX.Location = new System.Drawing.Point(714, 192);
            this.btnSuaPhieuX.Name = "btnSuaPhieuX";
            this.btnSuaPhieuX.Size = new System.Drawing.Size(103, 77);
            this.btnSuaPhieuX.TabIndex = 32;
            this.btnSuaPhieuX.UseVisualStyleBackColor = true;
            this.btnSuaPhieuX.Click += new System.EventHandler(this.btnSuaPhieuX_Click);
            // 
            // btnXoaPhieuX
            // 
            this.btnXoaPhieuX.BackColor = System.Drawing.SystemColors.Control;
            this.btnXoaPhieuX.Enabled = false;
            this.btnXoaPhieuX.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaPhieuX.Image")));
            this.btnXoaPhieuX.Location = new System.Drawing.Point(454, 192);
            this.btnXoaPhieuX.Name = "btnXoaPhieuX";
            this.btnXoaPhieuX.Size = new System.Drawing.Size(103, 77);
            this.btnXoaPhieuX.TabIndex = 33;
            this.btnXoaPhieuX.UseVisualStyleBackColor = false;
            this.btnXoaPhieuX.Click += new System.EventHandler(this.btnXoaPhieuX_Click);
            // 
            // btnThemPhieuX
            // 
            this.btnThemPhieuX.BackColor = System.Drawing.SystemColors.Control;
            this.btnThemPhieuX.Image = ((System.Drawing.Image)(resources.GetObject("btnThemPhieuX.Image")));
            this.btnThemPhieuX.Location = new System.Drawing.Point(194, 184);
            this.btnThemPhieuX.Name = "btnThemPhieuX";
            this.btnThemPhieuX.Size = new System.Drawing.Size(99, 85);
            this.btnThemPhieuX.TabIndex = 32;
            this.btnThemPhieuX.UseVisualStyleBackColor = false;
            this.btnThemPhieuX.Click += new System.EventHandler(this.btnThemPhieuX_Click);
            // 
            // txtSoLuongX
            // 
            this.txtSoLuongX.Location = new System.Drawing.Point(762, 79);
            this.txtSoLuongX.Multiline = true;
            this.txtSoLuongX.Name = "txtSoLuongX";
            this.txtSoLuongX.Size = new System.Drawing.Size(295, 36);
            this.txtSoLuongX.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(579, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số Lượng";
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
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Aqua;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(131, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(870, 55);
            this.label12.TabIndex = 31;
            this.label12.Text = "Chào Mừng Bạn Đến Với Chi Phiếu Xuất";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MAPH_XH";
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
            // btnInPX
            // 
            this.btnInPX.Enabled = false;
            this.btnInPX.Image = ((System.Drawing.Image)(resources.GetObject("btnInPX.Image")));
            this.btnInPX.Location = new System.Drawing.Point(954, 198);
            this.btnInPX.Name = "btnInPX";
            this.btnInPX.Size = new System.Drawing.Size(103, 71);
            this.btnInPX.TabIndex = 49;
            this.btnInPX.UseVisualStyleBackColor = true;
            this.btnInPX.Click += new System.EventHandler(this.btnInPX_Click);
            // 
            // FmChiTietXH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 614);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataKh);
            this.Controls.Add(this.label12);
            this.Name = "FmChiTietXH";
            this.Text = "FmChiTietXH";
            this.Load += new System.EventHandler(this.FmChiTietXH_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataCTPX)).EndInit();
            this.dataKh.ResumeLayout(false);
            this.dataKh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmMaSpX;
        private System.Windows.Forms.ComboBox cmMaPX;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DataCTPX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox dataKh;
        private System.Windows.Forms.Button btnSuaPhieuX;
        private System.Windows.Forms.Button btnXoaPhieuX;
        private System.Windows.Forms.Button btnThemPhieuX;
        private System.Windows.Forms.TextBox txtSoLuongX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnInPX;
    }
}