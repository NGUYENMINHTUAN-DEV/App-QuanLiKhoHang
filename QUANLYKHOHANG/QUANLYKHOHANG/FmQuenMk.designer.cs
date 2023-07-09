namespace QUANLYKHOHANG
{
    partial class FmQuenMk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmQuenMk));
            this.lbDangKi = new System.Windows.Forms.Label();
            this.lbQuenMk = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnLayLaiMk = new System.Windows.Forms.Button();
            this.lbKq = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDangKi
            // 
            this.lbDangKi.AutoSize = true;
            this.lbDangKi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDangKi.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbDangKi.Location = new System.Drawing.Point(27, 293);
            this.lbDangKi.Name = "lbDangKi";
            this.lbDangKi.Size = new System.Drawing.Size(72, 21);
            this.lbDangKi.TabIndex = 16;
            this.lbDangKi.Text = "Kết Quả";
            // 
            // lbQuenMk
            // 
            this.lbQuenMk.AutoSize = true;
            this.lbQuenMk.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuenMk.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbQuenMk.Location = new System.Drawing.Point(-4, 242);
            this.lbQuenMk.Name = "lbQuenMk";
            this.lbQuenMk.Size = new System.Drawing.Size(120, 21);
            this.lbQuenMk.TabIndex = 15;
            this.lbQuenMk.Text = "Email Đăng Kí";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(128, 233);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(229, 30);
            this.txtEmail.TabIndex = 13;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // btnLayLaiMk
            // 
            this.btnLayLaiMk.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLayLaiMk.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnLayLaiMk.Location = new System.Drawing.Point(94, 375);
            this.btnLayLaiMk.Name = "btnLayLaiMk";
            this.btnLayLaiMk.Size = new System.Drawing.Size(195, 43);
            this.btnLayLaiMk.TabIndex = 17;
            this.btnLayLaiMk.Text = "Lấy Lại Mật Khẩu";
            this.btnLayLaiMk.UseVisualStyleBackColor = true;
            this.btnLayLaiMk.Click += new System.EventHandler(this.btnLayLaiMk_Click);
            // 
            // lbKq
            // 
            this.lbKq.AutoSize = true;
            this.lbKq.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKq.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbKq.Location = new System.Drawing.Point(124, 293);
            this.lbKq.Name = "lbKq";
            this.lbKq.Size = new System.Drawing.Size(0, 23);
            this.lbKq.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(78, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FmQuenMk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 420);
            this.Controls.Add(this.lbKq);
            this.Controls.Add(this.btnLayLaiMk);
            this.Controls.Add(this.lbDangKi);
            this.Controls.Add(this.lbQuenMk);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FmQuenMk";
            this.Text = "Quên Mật Khẩu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDangKi;
        private System.Windows.Forms.Label lbQuenMk;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLayLaiMk;
        private System.Windows.Forms.Label lbKq;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}