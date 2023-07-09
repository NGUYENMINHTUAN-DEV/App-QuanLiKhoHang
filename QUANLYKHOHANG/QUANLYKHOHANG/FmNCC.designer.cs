namespace QUANLYKHOHANG
{
    partial class FmNCC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmNCC));
            this.label12 = new System.Windows.Forms.Label();
            this.dataKh = new System.Windows.Forms.GroupBox();
            this.btnSuaNCC = new System.Windows.Forms.Button();
            this.btnXoaNCC = new System.Windows.Forms.Button();
            this.btnThemNCC = new System.Windows.Forms.Button();
            this.txtDcNCC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DataNCC = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataKh.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataNCC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Aqua;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(184, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(862, 55);
            this.label12.TabIndex = 24;
            this.label12.Text = "Chào Mừng Bạn Đến Với Nhà Cung Cấp";
            // 
            // dataKh
            // 
            this.dataKh.Controls.Add(this.btnSuaNCC);
            this.dataKh.Controls.Add(this.btnXoaNCC);
            this.dataKh.Controls.Add(this.btnThemNCC);
            this.dataKh.Controls.Add(this.txtDcNCC);
            this.dataKh.Controls.Add(this.label3);
            this.dataKh.Controls.Add(this.txtTenNCC);
            this.dataKh.Controls.Add(this.label2);
            this.dataKh.Controls.Add(this.txtMaNCC);
            this.dataKh.Controls.Add(this.label1);
            this.dataKh.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataKh.Location = new System.Drawing.Point(17, 93);
            this.dataKh.Name = "dataKh";
            this.dataKh.Size = new System.Drawing.Size(1173, 269);
            this.dataKh.TabIndex = 25;
            this.dataKh.TabStop = false;
            this.dataKh.Text = "Thông Tin Nhà Cung Cấp";
            // 
            // btnSuaNCC
            // 
            this.btnSuaNCC.Enabled = false;
            this.btnSuaNCC.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaNCC.Image")));
            this.btnSuaNCC.Location = new System.Drawing.Point(667, 192);
            this.btnSuaNCC.Name = "btnSuaNCC";
            this.btnSuaNCC.Size = new System.Drawing.Size(103, 77);
            this.btnSuaNCC.TabIndex = 32;
            this.btnSuaNCC.UseVisualStyleBackColor = true;
            this.btnSuaNCC.Click += new System.EventHandler(this.btnSuaNCC_Click);
            // 
            // btnXoaNCC
            // 
            this.btnXoaNCC.BackColor = System.Drawing.SystemColors.Control;
            this.btnXoaNCC.Enabled = false;
            this.btnXoaNCC.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaNCC.Image")));
            this.btnXoaNCC.Location = new System.Drawing.Point(421, 192);
            this.btnXoaNCC.Name = "btnXoaNCC";
            this.btnXoaNCC.Size = new System.Drawing.Size(103, 77);
            this.btnXoaNCC.TabIndex = 33;
            this.btnXoaNCC.UseVisualStyleBackColor = false;
            this.btnXoaNCC.Click += new System.EventHandler(this.btnXoaNCC_Click);
            // 
            // btnThemNCC
            // 
            this.btnThemNCC.BackColor = System.Drawing.SystemColors.Control;
            this.btnThemNCC.Image = ((System.Drawing.Image)(resources.GetObject("btnThemNCC.Image")));
            this.btnThemNCC.Location = new System.Drawing.Point(194, 184);
            this.btnThemNCC.Name = "btnThemNCC";
            this.btnThemNCC.Size = new System.Drawing.Size(99, 85);
            this.btnThemNCC.TabIndex = 32;
            this.btnThemNCC.UseVisualStyleBackColor = false;
            this.btnThemNCC.Click += new System.EventHandler(this.btnThemNCC_Click);
            // 
            // txtDcNCC
            // 
            this.txtDcNCC.Location = new System.Drawing.Point(847, 78);
            this.txtDcNCC.Multiline = true;
            this.txtDcNCC.Name = "txtDcNCC";
            this.txtDcNCC.Size = new System.Drawing.Size(295, 61);
            this.txtDcNCC.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(626, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Địa Chỉ Nhà Cung Cấp";
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Location = new System.Drawing.Point(216, 126);
            this.txtTenNCC.Multiline = true;
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(258, 36);
            this.txtTenNCC.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Nhà Cung Cấp";
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Location = new System.Drawing.Point(216, 40);
            this.txtMaNCC.Multiline = true;
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(258, 36);
            this.txtMaNCC.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Nhà Cung Cấp";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DataNCC);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 378);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1187, 284);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Nhà Cung Cấp";
            // 
            // DataNCC
            // 
            this.DataNCC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataNCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.DataNCC.Location = new System.Drawing.Point(6, 28);
            this.DataNCC.Name = "DataNCC";
            this.DataNCC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataNCC.Size = new System.Drawing.Size(1175, 256);
            this.DataNCC.TabIndex = 0;
            this.DataNCC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataNCC_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MA_NCC";
            this.Column1.HeaderText = "Mã Nhà Cung Cấp";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TEN_NCC";
            this.Column2.HeaderText = "Tên Nhà Cung Cấp";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DIACHI_NCC";
            this.Column3.HeaderText = "Địa Chỉ Nhà Cung Cấp";
            this.Column3.Name = "Column3";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FmNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 664);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataKh);
            this.Controls.Add(this.label12);
            this.Name = "FmNCC";
            this.Text = "Nhà Cung Cấp";
            this.Load += new System.EventHandler(this.FmNCC_Load);
            this.dataKh.ResumeLayout(false);
            this.dataKh.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataNCC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox dataKh;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDcNCC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DataNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btnThemNCC;
        private System.Windows.Forms.Button btnXoaNCC;
        private System.Windows.Forms.Button btnSuaNCC;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}