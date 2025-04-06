namespace Display_Number_MVP
{
    partial class frmMain
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
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblNumberString = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.tboxThreadTime = new System.Windows.Forms.TextBox();
            this.tboxMultiple = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblThreadStatus = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumber
            // 
            this.lblNumber.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblNumber.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNumber.Location = new System.Drawing.Point(157, 59);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(176, 29);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "1";
            this.lblNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNumberString
            // 
            this.lblNumberString.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblNumberString.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNumberString.Location = new System.Drawing.Point(157, 94);
            this.lblNumberString.Name = "lblNumberString";
            this.lblNumberString.Size = new System.Drawing.Size(176, 29);
            this.lblNumberString.TabIndex = 1;
            this.lblNumberString.Text = "0";
            this.lblNumberString.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(90, 119);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(86, 29);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tboxThreadTime
            // 
            this.tboxThreadTime.Location = new System.Drawing.Point(181, 27);
            this.tboxThreadTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxThreadTime.Name = "tboxThreadTime";
            this.tboxThreadTime.Size = new System.Drawing.Size(152, 25);
            this.tboxThreadTime.TabIndex = 3;
            this.tboxThreadTime.Text = "100";
            // 
            // tboxMultiple
            // 
            this.tboxMultiple.Location = new System.Drawing.Point(181, 60);
            this.tboxMultiple.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxMultiple.Name = "tboxMultiple";
            this.tboxMultiple.Size = new System.Drawing.Size(152, 25);
            this.tboxMultiple.TabIndex = 4;
            this.tboxMultiple.Text = "1.2";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(274, 119);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(86, 29);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "1. Thread Loop Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "2. Number Multiple";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tboxThreadTime);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tboxMultiple);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setting Value";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblThreadStatus);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblNumber);
            this.groupBox2.Controls.Add(this.lblNumberString);
            this.groupBox2.Location = new System.Drawing.Point(12, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(348, 139);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Result Value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Number (String)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Number (Double)";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(182, 119);
            this.btnStop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(86, 29);
            this.btnStop.TabIndex = 10;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Thread 동작 상태";
            // 
            // lblThreadStatus
            // 
            this.lblThreadStatus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblThreadStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblThreadStatus.Location = new System.Drawing.Point(157, 24);
            this.lblThreadStatus.Name = "lblThreadStatus";
            this.lblThreadStatus.Size = new System.Drawing.Size(176, 29);
            this.lblThreadStatus.TabIndex = 11;
            this.lblThreadStatus.Text = "정지";
            this.lblThreadStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 306);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStart);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblNumberString;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox tboxThreadTime;
        private System.Windows.Forms.TextBox tboxMultiple;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblThreadStatus;
        private System.Windows.Forms.Label label5;
    }
}

