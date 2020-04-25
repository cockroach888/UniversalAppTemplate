namespace DawnXZ.DawnGAT
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ssrMainbar = new System.Windows.Forms.StatusStrip();
            this.tssLblVer = new System.Windows.Forms.ToolStripStatusLabel();
            this.ssrMainbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // ssrMainbar
            // 
            this.ssrMainbar.BackColor = System.Drawing.Color.Transparent;
            this.ssrMainbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssLblVer});
            this.ssrMainbar.Location = new System.Drawing.Point(0, 540);
            this.ssrMainbar.Name = "ssrMainbar";
            this.ssrMainbar.Padding = new System.Windows.Forms.Padding(19, 0, 1, 0);
            this.ssrMainbar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ssrMainbar.Size = new System.Drawing.Size(784, 22);
            this.ssrMainbar.SizingGrip = false;
            this.ssrMainbar.TabIndex = 8;
            this.ssrMainbar.Text = "状态栏";
            // 
            // tssLblVer
            // 
            this.tssLblVer.ForeColor = System.Drawing.Color.White;
            this.tssLblVer.Name = "tssLblVer";
            this.tssLblVer.Size = new System.Drawing.Size(95, 17);
            this.tssLblVer.Text = "内部专用版 v1.0";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(85)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.ssrMainbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "通用应用程序模板";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.ssrMainbar.ResumeLayout(false);
            this.ssrMainbar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip ssrMainbar;
        private System.Windows.Forms.ToolStripStatusLabel tssLblVer;
    }
}