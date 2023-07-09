namespace QUANLYKHOHANG
{
    partial class FmChiTietPhieuNhap
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
            this.cmMaPN = new System.Windows.Forms.ComboBox();
            this.crystalReportPhieuNhap = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 99.11938F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.8806262F));
            this.tableLayoutPanel1.Controls.Add(this.cmMaPN, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.crystalReportPhieuNhap, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.638219F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95.36178F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1022, 550);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cmMaPN
            // 
            this.cmMaPN.FormattingEnabled = true;
            this.cmMaPN.Location = new System.Drawing.Point(3, 3);
            this.cmMaPN.Name = "cmMaPN";
            this.cmMaPN.Size = new System.Drawing.Size(652, 21);
            this.cmMaPN.TabIndex = 0;
            this.cmMaPN.SelectedIndexChanged += new System.EventHandler(this.cmMaPN_SelectedIndexChanged);
            // 
            // crystalReportPhieuNhap
            // 
            this.crystalReportPhieuNhap.ActiveViewIndex = -1;
            this.crystalReportPhieuNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportPhieuNhap.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportPhieuNhap.Location = new System.Drawing.Point(3, 28);
            this.crystalReportPhieuNhap.Name = "crystalReportPhieuNhap";
            this.crystalReportPhieuNhap.Size = new System.Drawing.Size(1007, 511);
            this.crystalReportPhieuNhap.TabIndex = 1;
            // 
            // FmChiTietPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 563);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FmChiTietPhieuNhap";
            this.Text = "FmChiTietPhieuNhap";
            this.Load += new System.EventHandler(this.FmChiTietPhieuNhap_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cmMaPN;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportPhieuNhap;
    }
}