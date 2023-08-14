namespace WPFMain.View
{
    partial class ReportWinForm
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
        private void InitializeComponent(Etiquetas etiquetas)
        {
            this.crystalReportViewer3 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Etiquetas1 = new WPFMain.Etiquetas();
            this.SuspendLayout();
            // 
            // crystalReportViewer2
            // 
            this.crystalReportViewer3.ActiveViewIndex = -1;
            this.crystalReportViewer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer3.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer3.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer3.Name = "crystalReportViewer3";
            this.crystalReportViewer3.ReportSource = etiquetas;
            this.crystalReportViewer3.ShowCloseButton = false;
            this.crystalReportViewer3.ShowCopyButton = false;
            this.crystalReportViewer3.ShowGroupTreeButton = false;
            this.crystalReportViewer3.ShowLogo = false;
            this.crystalReportViewer3.ShowParameterPanelButton = false;
            this.crystalReportViewer3.ShowRefreshButton = false;
            this.crystalReportViewer3.ShowTextSearchButton = false;
            this.crystalReportViewer3.ShowZoomButton = false;
            this.crystalReportViewer3.Size = new System.Drawing.Size(849, 477);
            this.crystalReportViewer3.TabIndex = 0;
            this.crystalReportViewer3.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 



            //this.crystalReportViewer2.ActiveViewIndex = -1;
            //this.crystalReportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            //this.crystalReportViewer2.Cursor = System.Windows.Forms.Cursors.Default;
            //this.crystalReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            //this.crystalReportViewer2.Location = new System.Drawing.Point(0, 0);
            //this.crystalReportViewer2.Name = "crystalReportViewer2";
            //this.crystalReportViewer2.Size = new System.Drawing.Size(941, 519);
            //this.crystalReportViewer2.TabIndex = 0;



           
            // 
            // ReportWinForm
            // 
            this.ClientSize = new System.Drawing.Size(941, 519);
            this.Controls.Add(this.crystalReportViewer3);
            this.Name = "ReportWinForm";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer3;
        private Etiquetas Etiquetas1;
        //private Etiquetas Etiquetas1;
    }
}