namespace FamilyCareHospital.Interfaces
{
    partial class ViewForm
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
            this.crystalReportViewerLabReport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewerLabReport
            // 
            this.crystalReportViewerLabReport.ActiveViewIndex = -1;
            this.crystalReportViewerLabReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerLabReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerLabReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.crystalReportViewerLabReport.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerLabReport.Name = "crystalReportViewerLabReport";
            this.crystalReportViewerLabReport.Size = new System.Drawing.Size(1184, 585);
            this.crystalReportViewerLabReport.TabIndex = 0;
            // 
            // ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.crystalReportViewerLabReport);
            this.Name = "ViewForm";
            this.Text = "ViewForm";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerLabReport;
    }
}