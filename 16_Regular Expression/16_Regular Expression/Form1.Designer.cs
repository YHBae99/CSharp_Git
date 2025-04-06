namespace _16_Regular_Expression
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
            this.btnDataCheck = new System.Windows.Forms.Button();
            this.tboxCheckData = new System.Windows.Forms.TextBox();
            this.cboxRegexName = new System.Windows.Forms.ComboBox();
            this.dgRegex = new System.Windows.Forms.DataGridView();
            this.lblData = new System.Windows.Forms.Label();
            this.lblSample = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.rdoMatch = new System.Windows.Forms.RadioButton();
            this.rdoIsMatch = new System.Windows.Forms.RadioButton();
            this.rdoSplit = new System.Windows.Forms.RadioButton();
            this.rdoReplace = new System.Windows.Forms.RadioButton();
            this.tboxReplace = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgRegex)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDataCheck
            // 
            this.btnDataCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDataCheck.ForeColor = System.Drawing.Color.White;
            this.btnDataCheck.Location = new System.Drawing.Point(579, 14);
            this.btnDataCheck.Name = "btnDataCheck";
            this.btnDataCheck.Size = new System.Drawing.Size(114, 23);
            this.btnDataCheck.TabIndex = 1;
            this.btnDataCheck.Text = "Check";
            this.btnDataCheck.UseVisualStyleBackColor = false;
            this.btnDataCheck.Click += new System.EventHandler(this.btnDataCheck_Click);
            // 
            // tboxCheckData
            // 
            this.tboxCheckData.Location = new System.Drawing.Point(91, 17);
            this.tboxCheckData.Name = "tboxCheckData";
            this.tboxCheckData.Size = new System.Drawing.Size(484, 21);
            this.tboxCheckData.TabIndex = 4;
            // 
            // cboxRegexName
            // 
            this.cboxRegexName.FormattingEnabled = true;
            this.cboxRegexName.Location = new System.Drawing.Point(89, 18);
            this.cboxRegexName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboxRegexName.Name = "cboxRegexName";
            this.cboxRegexName.Size = new System.Drawing.Size(150, 20);
            this.cboxRegexName.TabIndex = 5;
            this.cboxRegexName.SelectedIndexChanged += new System.EventHandler(this.cboxRegexName_SelectedIndexChanged);
            // 
            // dgRegex
            // 
            this.dgRegex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRegex.Location = new System.Drawing.Point(12, 18);
            this.dgRegex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgRegex.Name = "dgRegex";
            this.dgRegex.RowHeadersWidth = 51;
            this.dgRegex.RowTemplate.Height = 27;
            this.dgRegex.Size = new System.Drawing.Size(681, 300);
            this.dgRegex.TabIndex = 6;
            // 
            // lblData
            // 
            this.lblData.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblData.Location = new System.Drawing.Point(87, 46);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(606, 23);
            this.lblData.TabIndex = 7;
            this.lblData.Text = "-";
            this.lblData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSample
            // 
            this.lblSample.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblSample.Location = new System.Drawing.Point(87, 79);
            this.lblSample.Name = "lblSample";
            this.lblSample.Size = new System.Drawing.Size(606, 23);
            this.lblSample.TabIndex = 8;
            this.lblSample.Text = "-";
            this.lblSample.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblResult.ForeColor = System.Drawing.Color.White;
            this.lblResult.Location = new System.Drawing.Point(89, 40);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(72, 23);
            this.lblResult.TabIndex = 9;
            this.lblResult.Text = "-";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdoMatch
            // 
            this.rdoMatch.AutoSize = true;
            this.rdoMatch.Checked = true;
            this.rdoMatch.Location = new System.Drawing.Point(12, 18);
            this.rdoMatch.Margin = new System.Windows.Forms.Padding(2);
            this.rdoMatch.Name = "rdoMatch";
            this.rdoMatch.Size = new System.Drawing.Size(58, 16);
            this.rdoMatch.TabIndex = 10;
            this.rdoMatch.TabStop = true;
            this.rdoMatch.Text = "Match";
            this.rdoMatch.UseVisualStyleBackColor = true;
            // 
            // rdoIsMatch
            // 
            this.rdoIsMatch.AutoSize = true;
            this.rdoIsMatch.Location = new System.Drawing.Point(74, 18);
            this.rdoIsMatch.Margin = new System.Windows.Forms.Padding(2);
            this.rdoIsMatch.Name = "rdoIsMatch";
            this.rdoIsMatch.Size = new System.Drawing.Size(68, 16);
            this.rdoIsMatch.TabIndex = 10;
            this.rdoIsMatch.Text = "IsMatch";
            this.rdoIsMatch.UseVisualStyleBackColor = true;
            // 
            // rdoSplit
            // 
            this.rdoSplit.AutoSize = true;
            this.rdoSplit.Location = new System.Drawing.Point(145, 18);
            this.rdoSplit.Margin = new System.Windows.Forms.Padding(2);
            this.rdoSplit.Name = "rdoSplit";
            this.rdoSplit.Size = new System.Drawing.Size(47, 16);
            this.rdoSplit.TabIndex = 10;
            this.rdoSplit.Text = "Split";
            this.rdoSplit.UseVisualStyleBackColor = true;
            // 
            // rdoReplace
            // 
            this.rdoReplace.AutoSize = true;
            this.rdoReplace.Location = new System.Drawing.Point(195, 18);
            this.rdoReplace.Margin = new System.Windows.Forms.Padding(2);
            this.rdoReplace.Name = "rdoReplace";
            this.rdoReplace.Size = new System.Drawing.Size(69, 16);
            this.rdoReplace.TabIndex = 10;
            this.rdoReplace.Text = "Replace";
            this.rdoReplace.UseVisualStyleBackColor = true;
            // 
            // tboxReplace
            // 
            this.tboxReplace.Location = new System.Drawing.Point(268, 16);
            this.tboxReplace.Name = "tboxReplace";
            this.tboxReplace.Size = new System.Drawing.Size(82, 21);
            this.tboxReplace.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoReplace);
            this.groupBox1.Controls.Add(this.tboxReplace);
            this.groupBox1.Controls.Add(this.rdoMatch);
            this.groupBox1.Controls.Add(this.rdoIsMatch);
            this.groupBox1.Controls.Add(this.rdoSplit);
            this.groupBox1.Location = new System.Drawing.Point(9, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(704, 45);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fuction Select";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cboxRegexName);
            this.groupBox2.Controls.Add(this.lblData);
            this.groupBox2.Controls.Add(this.lblSample);
            this.groupBox2.Location = new System.Drawing.Point(9, 62);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(704, 109);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Regex Select";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "Sample";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "Format";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "Select";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgRegex);
            this.groupBox3.Location = new System.Drawing.Point(9, 261);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(704, 329);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Regex Sample";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblErrorMessage);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.btnDataCheck);
            this.groupBox4.Controls.Add(this.tboxCheckData);
            this.groupBox4.Controls.Add(this.lblResult);
            this.groupBox4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.groupBox4.Location = new System.Drawing.Point(9, 178);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(704, 74);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Check & Result";
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblErrorMessage.ForeColor = System.Drawing.Color.White;
            this.lblErrorMessage.Location = new System.Drawing.Point(168, 40);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(525, 23);
            this.lblErrorMessage.TabIndex = 17;
            this.lblErrorMessage.Text = "-";
            this.lblErrorMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "Data";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 46);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(723, 601);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Regex Checker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgRegex)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDataCheck;
        private System.Windows.Forms.TextBox tboxCheckData;
        private System.Windows.Forms.ComboBox cboxRegexName;
        private System.Windows.Forms.DataGridView dgRegex;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblSample;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.RadioButton rdoMatch;
        private System.Windows.Forms.RadioButton rdoIsMatch;
        private System.Windows.Forms.RadioButton rdoSplit;
        private System.Windows.Forms.RadioButton rdoReplace;
        private System.Windows.Forms.TextBox tboxReplace;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

