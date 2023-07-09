
namespace QUANLYKHOHANG
{
    partial class FmLoaiSP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmLoaiSP));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DataLSP = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataKh = new System.Windows.Forms.GroupBox();
            this.btnSuaLSP = new System.Windows.Forms.Button();
            this.btnXoaLSP = new System.Windows.Forms.Button();
            this.btnThemLSP = new System.Windows.Forms.Button();
            this.txtTenLoai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaLoai = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataLSP)).BeginInit();
            this.dataKh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DataLSP);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(1, 349);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(718, 281);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Loại SP";
            // 
            // DataLSP
            // 
            this.DataLSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataLSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataLSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.DataLSP.Location = new System.Drawing.Point(6, 28);
            this.DataLSP.Name = "DataLSP";
            this.DataLSP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataLSP.Size = new System.Drawing.Size(704, 256);
            this.DataLSP.TabIndex = 0;
            this.DataLSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataLSP_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MALOAI";
            this.Column1.HeaderText = "Mã Loại SP";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TENLOAI";
            this.Column2.HeaderText = "Tên Loại SP";
            this.Column2.Name = "Column2";
            // 
            // dataKh
            // 
            this.dataKh.Controls.Add(this.btnSuaLSP);
            this.dataKh.Controls.Add(this.btnXoaLSP);
            this.dataKh.Controls.Add(this.btnThemLSP);
            this.dataKh.Controls.Add(this.txtTenLoai);
            this.dataKh.Controls.Add(this.label2);
            this.dataKh.Controls.Add(this.txtMaLoai);
            this.dataKh.Controls.Add(this.label1);
            this.dataKh.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataKh.Location = new System.Drawing.Point(1, 74);
            this.dataKh.Name = "dataKh";
            this.dataKh.Size = new System.Drawing.Size(710, 269);
            this.dataKh.TabIndex = 29;
            this.dataKh.TabStop = false;
            this.dataKh.Text = "Thông Tin Loại Sản Phẩm";
            // 
            // btnSuaLSP
            // 
            this.btnSuaLSP.Enabled = false;
            this.btnSuaLSP.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaLSP.Image")));
            this.btnSuaLSP.Location = new System.Drawing.Point(534, 189);
            this.btnSuaLSP.Name = "btnSuaLSP";
            this.btnSuaLSP.Size = new System.Drawing.Size(103, 77);
            this.btnSuaLSP.TabIndex = 32;
            this.btnSuaLSP.UseVisualStyleBackColor = true;
            this.btnSuaLSP.Click += new System.EventHandler(this.btnSuaLSP_Click);
            // 
            // btnXoaLSP
            // 
            this.btnXoaLSP.BackColor = System.Drawing.SystemColors.Control;
            this.btnXoaLSP.Enabled = false;
            this.btnXoaLSP.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaLSP.Image")));
            this.btnXoaLSP.Location = new System.Drawing.Point(331, 189);
            this.btnXoaLSP.Name = "btnXoaLSP";
            this.btnXoaLSP.Size = new System.Drawing.Size(103, 77);
            this.btnXoaLSP.TabIndex = 33;
            this.btnXoaLSP.UseVisualStyleBackColor = false;
            this.btnXoaLSP.Click += new System.EventHandler(this.btnXoaLSP_Click);
            // 
            // btnThemLSP
            // 
            this.btnThemLSP.BackColor = System.Drawing.SystemColors.Control;
            this.btnThemLSP.Image = ((System.Drawing.Image)(resources.GetObject("btnThemLSP.Image")));
            this.btnThemLSP.Location = new System.Drawing.Point(112, 181);
            this.btnThemLSP.Name = "btnThemLSP";
            this.btnThemLSP.Size = new System.Drawing.Size(99, 85);
            this.btnThemLSP.TabIndex = 32;
            this.btnThemLSP.UseVisualStyleBackColor = false;
            this.btnThemLSP.Click += new System.EventHandler(this.btnThemLSP_Click);
            // 
            // txtTenLoai
            // 
            this.txtTenLoai.Location = new System.Drawing.Point(216, 126);
            this.txtTenLoai.Multiline = true;
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.Size = new System.Drawing.Size(258, 36);
            this.txtTenLoai.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Loại SP";
            // 
            // txtMaLoai
            // 
            this.txtMaLoai.Location = new System.Drawing.Point(216, 40);
            this.txtMaLoai.Multiline = true;
            this.txtMaLoai.Name = "txtMaLoai";
            this.txtMaLoai.Size = new System.Drawing.Size(258, 36);
            this.txtMaLoai.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Loại SP";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Aqua;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(2, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(717, 55);
            this.label12.TabIndex = 28;
            this.label12.Text = "Chào Mừng Bạn Đến Với Loại SP";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FmLoaiSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 642);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataKh);
            this.Controls.Add(this.label12);
            this.Name = "FmLoaiSP";
            this.Text = "FmLoaiSP";
            this.Load += new System.EventHandler(this.FmLoaiSP_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataLSP)).EndInit();
            this.dataKh.ResumeLayout(false);
            this.dataKh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DataLSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.GroupBox dataKh;
        private System.Windows.Forms.Button btnSuaLSP;
        private System.Windows.Forms.Button btnXoaLSP;
        private System.Windows.Forms.Button btnThemLSP;
        private System.Windows.Forms.TextBox txtTenLoai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaLoai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}