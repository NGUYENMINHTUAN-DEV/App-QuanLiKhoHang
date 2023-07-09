namespace QUANLYKHOHANG
{
    partial class FmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmDangNhap));
            this.txtTk = new System.Windows.Forms.TextBox();
            this.txtMk = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnQuenMk = new System.Windows.Forms.Button();
            this.btnDangKi = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.chHienthi = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTk
            // 
            this.txtTk.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTk.Location = new System.Drawing.Point(114, 217);
            this.txtTk.Multiline = true;
            this.txtTk.Name = "txtTk";
            this.txtTk.Size = new System.Drawing.Size(229, 30);
            this.txtTk.TabIndex = 4;
            // 
            // txtMk
            // 
            this.txtMk.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMk.Location = new System.Drawing.Point(114, 273);
            this.txtMk.Multiline = true;
            this.txtMk.Name = "txtMk";
            this.txtMk.PasswordChar = '*';
            this.txtMk.Size = new System.Drawing.Size(229, 25);
            this.txtMk.TabIndex = 5;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(40, 263);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(55, 49);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(40, 198);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(92, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnQuenMk
            // 
            this.btnQuenMk.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuenMk.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnQuenMk.Location = new System.Drawing.Point(12, 364);
            this.btnQuenMk.Name = "btnQuenMk";
            this.btnQuenMk.Size = new System.Drawing.Size(152, 44);
            this.btnQuenMk.TabIndex = 9;
            this.btnQuenMk.Text = "Quên Mật Khẩu";
            this.btnQuenMk.UseVisualStyleBackColor = true;
            this.btnQuenMk.Click += new System.EventHandler(this.btnQuenMk_Click);
            // 
            // btnDangKi
            // 
            this.btnDangKi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKi.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnDangKi.Location = new System.Drawing.Point(233, 364);
            this.btnDangKi.Name = "btnDangKi";
            this.btnDangKi.Size = new System.Drawing.Size(152, 44);
            this.btnDangKi.TabIndex = 10;
            this.btnDangKi.Text = "Đăng Kí";
            this.btnDangKi.UseVisualStyleBackColor = true;
            this.btnDangKi.Click += new System.EventHandler(this.btnDangKi_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnDangNhap.Location = new System.Drawing.Point(114, 414);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(152, 44);
            this.btnDangNhap.TabIndex = 11;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // chHienthi
            // 
            this.chHienthi.AutoSize = true;
            this.chHienthi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chHienthi.Location = new System.Drawing.Point(114, 318);
            this.chHienthi.Name = "chHienthi";
            this.chHienthi.Size = new System.Drawing.Size(159, 23);
            this.chHienthi.TabIndex = 12;
            this.chHienthi.Text = "Hiển Thị Mật Khẩu";
            this.chHienthi.UseVisualStyleBackColor = true;
            this.chHienthi.CheckedChanged += new System.EventHandler(this.chHienthi_CheckedChanged);
            // 
            // FmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 465);
            this.Controls.Add(this.chHienthi);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.btnDangKi);
            this.Controls.Add(this.btnQuenMk);
            this.Controls.Add(this.txtMk);
            this.Controls.Add(this.txtTk);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FmDangNhap";
            this.Text = "Đăng Nhập";
          
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtTk;
        private System.Windows.Forms.TextBox txtMk;
        private System.Windows.Forms.Button btnQuenMk;
        private System.Windows.Forms.Button btnDangKi;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.CheckBox chHienthi;
    }
}