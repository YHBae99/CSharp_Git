﻿namespace _03_Lambda
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
            this.btnColorChange_1 = new System.Windows.Forms.Button();
            this.btnColorChange_2 = new System.Windows.Forms.Button();
            this.btnColorChange_3 = new System.Windows.Forms.Button();
            this.lboxResult = new System.Windows.Forms.ListBox();
            this.lblStepCheck = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnColorChange_1
            // 
            this.btnColorChange_1.Location = new System.Drawing.Point(14, 15);
            this.btnColorChange_1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnColorChange_1.Name = "btnColorChange_1";
            this.btnColorChange_1.Size = new System.Drawing.Size(149, 29);
            this.btnColorChange_1.TabIndex = 0;
            this.btnColorChange_1.Text = "Event 함수를 호출";
            this.btnColorChange_1.UseVisualStyleBackColor = true;
            // 
            // btnColorChange_2
            // 
            this.btnColorChange_2.Location = new System.Drawing.Point(14, 51);
            this.btnColorChange_2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnColorChange_2.Name = "btnColorChange_2";
            this.btnColorChange_2.Size = new System.Drawing.Size(149, 29);
            this.btnColorChange_2.TabIndex = 1;
            this.btnColorChange_2.Text = "무명 메서드 사용";
            this.btnColorChange_2.UseVisualStyleBackColor = true;
            // 
            // btnColorChange_3
            // 
            this.btnColorChange_3.Location = new System.Drawing.Point(14, 88);
            this.btnColorChange_3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnColorChange_3.Name = "btnColorChange_3";
            this.btnColorChange_3.Size = new System.Drawing.Size(149, 29);
            this.btnColorChange_3.TabIndex = 2;
            this.btnColorChange_3.Text = "람다식 사용";
            this.btnColorChange_3.UseVisualStyleBackColor = true;
            // 
            // lboxResult
            // 
            this.lboxResult.FormattingEnabled = true;
            this.lboxResult.ItemHeight = 15;
            this.lboxResult.Location = new System.Drawing.Point(14, 171);
            this.lboxResult.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lboxResult.Name = "lboxResult";
            this.lboxResult.Size = new System.Drawing.Size(404, 139);
            this.lboxResult.TabIndex = 3;
            // 
            // lblStepCheck
            // 
            this.lblStepCheck.AutoSize = true;
            this.lblStepCheck.Location = new System.Drawing.Point(14, 148);
            this.lblStepCheck.Name = "lblStepCheck";
            this.lblStepCheck.Size = new System.Drawing.Size(15, 15);
            this.lblStepCheck.TabIndex = 4;
            this.lblStepCheck.Text = "-";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(333, 109);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(86, 29);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "다음";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(332, 72);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(86, 29);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "초기화";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 326);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblStepCheck);
            this.Controls.Add(this.lboxResult);
            this.Controls.Add(this.btnColorChange_3);
            this.Controls.Add(this.btnColorChange_2);
            this.Controls.Add(this.btnColorChange_1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnColorChange_1;
        private System.Windows.Forms.Button btnColorChange_2;
        private System.Windows.Forms.Button btnColorChange_3;
        private System.Windows.Forms.ListBox lboxResult;
        private System.Windows.Forms.Label lblStepCheck;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnReset;
    }
}

