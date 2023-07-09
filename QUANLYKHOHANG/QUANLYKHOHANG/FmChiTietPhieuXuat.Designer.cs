
namespace QUANLYKHOHANG
{
    partial class FmChiTietPhieuXuat
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cmMaPX = new System.Windows.Forms.ComboBox();
            this.crystalReportPhieuXuat = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 99.15612F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.8438818F));
            this.tableLayoutPanel1.Controls.Add(this.cmMaPX, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.crystalReportPhieuXuat, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.423424F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 96.57658F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(978, 555);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cmMaPX
            // 
            this.cmMaPX.FormattingEnabled = true;
            this.cmMaPX.Location = new System.Drawing.Point(3, 3);
            this.cmMaPX.Name = "cmMaPX";
            this.cmMaPX.Size = new System.Drawing.Size(346, 21);
            this.cmMaPX.TabIndex = 0;
            this.cmMaPX.SelectedIndexChanged += new System.EventHandler(this.cmMaPX_SelectedIndexChanged);
            // 
            // crystalReportPhieuXuat
            // 
            this.crystalReportPhieuXuat.ActiveViewIndex = -1;
            this.crystalReportPhieuXuat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportPhieuXuat.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportPhieuXuat.Location = new System.Drawing.Point(3, 22);
            this.crystalReportPhieuXuat.Name = "crystalReportPhieuXuat";
            this.crystalReportPhieuXuat.Size = new System.Drawing.Size(963, 530);
            this.crystalReportPhieuXuat.TabIndex = 1;
            // 
            // FmChiTietPhieuXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 570);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FmChiTietPhieuXuat";
            this.Text = "FmChiTietPhieuXuat";
            this.Load += new System.EventHandler(this.FmChiTietPhieuXuat_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cmMaPX;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportPhieuXuat;
    }
}