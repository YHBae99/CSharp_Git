
namespace Interface_Test
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.편집EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.form생성ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subFrom생성ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.선택SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.선택Form색상변경ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pMain = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일FToolStripMenuItem,
            this.편집EToolStripMenuItem,
            this.선택SToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(700, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일FToolStripMenuItem
            // 
            this.파일FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.파일FToolStripMenuItem.Name = "파일FToolStripMenuItem";
            this.파일FToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.파일FToolStripMenuItem.Text = "파일(F)";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // 편집EToolStripMenuItem
            // 
            this.편집EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.form생성ToolStripMenuItem,
            this.subFrom생성ToolStripMenuItem});
            this.편집EToolStripMenuItem.Name = "편집EToolStripMenuItem";
            this.편집EToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.편집EToolStripMenuItem.Text = "편집(E)";
            // 
            // form생성ToolStripMenuItem
            // 
            this.form생성ToolStripMenuItem.Name = "form생성ToolStripMenuItem";
            this.form생성ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.form생성ToolStripMenuItem.Text = "Main Form 생성";
            this.form생성ToolStripMenuItem.Click += new System.EventHandler(this.form생성ToolStripMenuItem_Click);
            // 
            // subFrom생성ToolStripMenuItem
            // 
            this.subFrom생성ToolStripMenuItem.Name = "subFrom생성ToolStripMenuItem";
            this.subFrom생성ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.subFrom생성ToolStripMenuItem.Text = "Sub From 생성";
            this.subFrom생성ToolStripMenuItem.Click += new System.EventHandler(this.subFrom생성ToolStripMenuItem_Click);
            // 
            // 선택SToolStripMenuItem
            // 
            this.선택SToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.선택Form색상변경ToolStripMenuItem});
            this.선택SToolStripMenuItem.Name = "선택SToolStripMenuItem";
            this.선택SToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.선택SToolStripMenuItem.Text = "선택(S)";
            // 
            // 선택Form색상변경ToolStripMenuItem
            // 
            this.선택Form색상변경ToolStripMenuItem.Name = "선택Form색상변경ToolStripMenuItem";
            this.선택Form색상변경ToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.선택Form색상변경ToolStripMenuItem.Text = "선택 Form 색상 변경";
            this.선택Form색상변경ToolStripMenuItem.Click += new System.EventHandler(this.선택Form색상변경ToolStripMenuItem_Click);
            // 
            // pMain
            // 
            this.pMain.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMain.Location = new System.Drawing.Point(0, 24);
            this.pMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(700, 336);
            this.pMain.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 360);
            this.Controls.Add(this.pMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 편집EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem form생성ToolStripMenuItem;
        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.ToolStripMenuItem subFrom생성ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 선택SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 선택Form색상변경ToolStripMenuItem;
    }
}

