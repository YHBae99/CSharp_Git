﻿namespace _11.FrameModeling.ucPanel
{
    partial class ucScreen2
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSc2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "Chart 표시 화면";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(10, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(767, 2);
            this.panel1.TabIndex = 7;
            // 
            // btnSc2
            // 
            this.btnSc2.Location = new System.Drawing.Point(252, 142);
            this.btnSc2.Name = "btnSc2";
            this.btnSc2.Size = new System.Drawing.Size(290, 111);
            this.btnSc2.TabIndex = 9;
            this.btnSc2.Text = "Screen2";
            this.btnSc2.UseVisualStyleBackColor = true;
            this.btnSc2.Click += new System.EventHandler(this.btnSc2_Click);
            // 
            // ucScreen2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSc2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "ucScreen2";
            this.Size = new System.Drawing.Size(794, 395);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSc2;
    }
}
