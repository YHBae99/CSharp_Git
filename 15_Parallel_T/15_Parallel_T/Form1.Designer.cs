namespace _15_Parallel_T
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
            this.lboxLog = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnParallelfor = new System.Windows.Forms.Button();
            this.btnfor = new System.Windows.Forms.Button();
            this.btnParallelforeach = new System.Windows.Forms.Button();
            this.btnParallelFunction = new System.Windows.Forms.Button();
            this.lboxPlayTime = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lboxLog
            // 
            this.lboxLog.FormattingEnabled = true;
            this.lboxLog.HorizontalScrollbar = true;
            this.lboxLog.ItemHeight = 12;
            this.lboxLog.Location = new System.Drawing.Point(12, 211);
            this.lboxLog.Name = "lboxLog";
            this.lboxLog.Size = new System.Drawing.Size(458, 304);
            this.lboxLog.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lboxPlayTime);
            this.groupBox1.Controls.Add(this.btnParallelFunction);
            this.groupBox1.Controls.Add(this.btnParallelforeach);
            this.groupBox1.Controls.Add(this.btnParallelfor);
            this.groupBox1.Controls.Add(this.btnfor);
            this.groupBox1.Controls.Add(this.lboxLog);
            this.groupBox1.Location = new System.Drawing.Point(12, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(480, 531);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1. Parallel";
            // 
            // btnParallelfor
            // 
            this.btnParallelfor.Location = new System.Drawing.Point(128, 18);
            this.btnParallelfor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnParallelfor.Name = "btnParallelfor";
            this.btnParallelfor.Size = new System.Drawing.Size(110, 27);
            this.btnParallelfor.TabIndex = 7;
            this.btnParallelfor.Text = "Parallel for";
            this.btnParallelfor.UseVisualStyleBackColor = true;
            this.btnParallelfor.Click += new System.EventHandler(this.btnPararallfor_Click);
            // 
            // btnfor
            // 
            this.btnfor.Location = new System.Drawing.Point(12, 18);
            this.btnfor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnfor.Name = "btnfor";
            this.btnfor.Size = new System.Drawing.Size(110, 27);
            this.btnfor.TabIndex = 6;
            this.btnfor.Text = "for";
            this.btnfor.UseVisualStyleBackColor = true;
            this.btnfor.Click += new System.EventHandler(this.btnfor_Click);
            // 
            // btnParallelforeach
            // 
            this.btnParallelforeach.Location = new System.Drawing.Point(244, 18);
            this.btnParallelforeach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnParallelforeach.Name = "btnParallelforeach";
            this.btnParallelforeach.Size = new System.Drawing.Size(110, 27);
            this.btnParallelforeach.TabIndex = 8;
            this.btnParallelforeach.Text = "Parallel foreach";
            this.btnParallelforeach.UseVisualStyleBackColor = true;
            this.btnParallelforeach.Click += new System.EventHandler(this.btnParallelforeach_Click);
            // 
            // btnParallelFunction
            // 
            this.btnParallelFunction.Location = new System.Drawing.Point(360, 18);
            this.btnParallelFunction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnParallelFunction.Name = "btnParallelFunction";
            this.btnParallelFunction.Size = new System.Drawing.Size(110, 27);
            this.btnParallelFunction.TabIndex = 9;
            this.btnParallelFunction.Text = "Parallel Function";
            this.btnParallelFunction.UseVisualStyleBackColor = true;
            this.btnParallelFunction.Click += new System.EventHandler(this.btnParallelFunction_Click);
            // 
            // lboxPlayTime
            // 
            this.lboxPlayTime.FormattingEnabled = true;
            this.lboxPlayTime.HorizontalScrollbar = true;
            this.lboxPlayTime.ItemHeight = 12;
            this.lboxPlayTime.Location = new System.Drawing.Point(12, 53);
            this.lboxPlayTime.Name = "lboxPlayTime";
            this.lboxPlayTime.Size = new System.Drawing.Size(458, 148);
            this.lboxPlayTime.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 552);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lboxLog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnfor;
        private System.Windows.Forms.Button btnParallelfor;
        private System.Windows.Forms.Button btnParallelFunction;
        private System.Windows.Forms.Button btnParallelforeach;
        private System.Windows.Forms.ListBox lboxPlayTime;
    }
}

