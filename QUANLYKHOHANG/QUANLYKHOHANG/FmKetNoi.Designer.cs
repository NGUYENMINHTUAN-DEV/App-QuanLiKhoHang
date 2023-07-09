
namespace QUANLYKHOHANG
{
    partial class FmKetNoi
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
            this.btn_ketnoi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.txt_tencsdl = new System.Windows.Forms.TextBox();
            this.txt_tenmay = new System.Windows.Forms.TextBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ketnoi
            // 
            this.btn_ketnoi.Location = new System.Drawing.Point(155, 351);
            this.btn_ketnoi.Name = "btn_ketnoi";
            this.btn_ketnoi.Size = new System.Drawing.Size(75, 23);
            this.btn_ketnoi.TabIndex = 4;
            this.btn_ketnoi.Text = "Kết Nối";
            this.btn_ketnoi.UseVisualStyleBackColor = true;
            this.btn_ketnoi.Click += new System.EventHandler(this.btn_ketnoi_Click);
            this.btn_ketnoi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_ketnoi_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_pass);
            this.groupBox1.Controls.Add(this.txt_user);
            this.groupBox1.Controls.Add(this.txt_tencsdl);
            this.groupBox1.Controls.Add(this.txt_tenmay);
            this.groupBox1.Controls.Add(this.btn_thoat);
            this.groupBox1.Controls.Add(this.btn_ketnoi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(641, 395);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kết nối hệ thống";
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(172, 253);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(271, 26);
            this.txt_pass.TabIndex = 9;
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(172, 179);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(271, 26);
            this.txt_user.TabIndex = 8;
            // 
            // txt_tencsdl
            // 
            this.txt_tencsdl.Location = new System.Drawing.Point(172, 122);
            this.txt_tencsdl.Name = "txt_tencsdl";
            this.txt_tencsdl.Size = new System.Drawing.Size(271, 26);
            this.txt_tencsdl.TabIndex = 7;
            // 
            // txt_tenmay
            // 
            this.txt_tenmay.Location = new System.Drawing.Point(172, 65);
            this.txt_tenmay.Name = "txt_tenmay";
            this.txt_tenmay.Size = new System.Drawing.Size(271, 26);
            this.txt_tenmay.TabIndex = 6;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(439, 351);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_thoat.TabIndex = 5;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên CSDL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên máy:";
            // 
            // FmKetNoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 419);
            this.Controls.Add(this.groupBox1);
            this.Name = "FmKetNoi";
            this.Text = "FmKetNoi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FmKetNoi_FormClosing);
            this.Load += new System.EventHandler(this.FmKetNoi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ketnoi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.TextBox txt_tencsdl;
        private System.Windows.Forms.TextBox txt_tenmay;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}