
namespace Interface_Test
{
    partial class fInnerMain
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
            this.lblInnerMain = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInnerMain
            // 
            this.lblInnerMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInnerMain.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblInnerMain.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblInnerMain.Location = new System.Drawing.Point(55, 39);
            this.lblInnerMain.Name = "lblInnerMain";
            this.lblInnerMain.Size = new System.Drawing.Size(218, 71);
            this.lblInnerMain.TabIndex = 0;
            this.lblInnerMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fInnerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 158);
            this.Controls.Add(this.lblInnerMain);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fInnerMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.fInnerMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblInnerMain;
    }
}