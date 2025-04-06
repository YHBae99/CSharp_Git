namespace UnitConverterApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnExecute = new Button();
            tboxValue = new TextBox();
            tboxResult = new TextBox();
            cboxType = new ComboBox();
            rdoLength = new RadioButton();
            rdoWeight = new RadioButton();
            rdoTemperature = new RadioButton();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lboxLog = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnExecute
            // 
            btnExecute.Location = new Point(465, 35);
            btnExecute.Margin = new Padding(2, 2, 2, 2);
            btnExecute.Name = "btnExecute";
            btnExecute.Size = new Size(91, 77);
            btnExecute.TabIndex = 0;
            btnExecute.Text = "변환";
            btnExecute.UseVisualStyleBackColor = true;
            btnExecute.Click += btnExecute_Click;
            // 
            // tboxValue
            // 
            tboxValue.Location = new Point(65, 58);
            tboxValue.Margin = new Padding(2, 2, 2, 2);
            tboxValue.Name = "tboxValue";
            tboxValue.Size = new Size(127, 23);
            tboxValue.TabIndex = 1;
            // 
            // tboxResult
            // 
            tboxResult.Location = new Point(65, 83);
            tboxResult.Margin = new Padding(2, 2, 2, 2);
            tboxResult.Name = "tboxResult";
            tboxResult.ReadOnly = true;
            tboxResult.Size = new Size(127, 23);
            tboxResult.TabIndex = 2;
            // 
            // cboxType
            // 
            cboxType.FormattingEnabled = true;
            cboxType.Location = new Point(65, 26);
            cboxType.Margin = new Padding(2, 2, 2, 2);
            cboxType.Name = "cboxType";
            cboxType.Size = new Size(127, 23);
            cboxType.TabIndex = 3;
            // 
            // rdoLength
            // 
            rdoLength.AutoSize = true;
            rdoLength.Location = new Point(12, 20);
            rdoLength.Margin = new Padding(2, 2, 2, 2);
            rdoLength.Name = "rdoLength";
            rdoLength.Size = new Size(62, 19);
            rdoLength.TabIndex = 4;
            rdoLength.Text = "Length";
            rdoLength.UseVisualStyleBackColor = true;
            rdoLength.CheckedChanged += rdoLength_CheckedChanged;
            // 
            // rdoWeight
            // 
            rdoWeight.AutoSize = true;
            rdoWeight.Location = new Point(76, 20);
            rdoWeight.Margin = new Padding(2, 2, 2, 2);
            rdoWeight.Name = "rdoWeight";
            rdoWeight.Size = new Size(63, 19);
            rdoWeight.TabIndex = 5;
            rdoWeight.Text = "Weight";
            rdoWeight.UseVisualStyleBackColor = true;
            rdoWeight.CheckedChanged += rdoWeight_CheckedChanged;
            // 
            // rdoTemperature
            // 
            rdoTemperature.AutoSize = true;
            rdoTemperature.Location = new Point(142, 20);
            rdoTemperature.Margin = new Padding(2, 2, 2, 2);
            rdoTemperature.Name = "rdoTemperature";
            rdoTemperature.Size = new Size(92, 19);
            rdoTemperature.TabIndex = 6;
            rdoTemperature.Text = "Temperature";
            rdoTemperature.UseVisualStyleBackColor = true;
            rdoTemperature.CheckedChanged += rdoTemperature_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdoWeight);
            groupBox1.Controls.Add(rdoTemperature);
            groupBox1.Controls.Add(rdoLength);
            groupBox1.Location = new Point(9, 9);
            groupBox1.Margin = new Padding(2, 2, 2, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 2, 2, 2);
            groupBox1.Size = new Size(244, 50);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Type";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(cboxType);
            groupBox2.Controls.Add(tboxValue);
            groupBox2.Controls.Add(tboxResult);
            groupBox2.Location = new Point(258, 9);
            groupBox2.Margin = new Padding(2, 2, 2, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2, 2, 2, 2);
            groupBox2.Size = new Size(202, 125);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Data";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 86);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 6;
            label3.Text = "결과";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 62);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 5;
            label2.Text = "입력";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 28);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 4;
            label1.Text = "From/To";
            // 
            // lboxLog
            // 
            lboxLog.FormattingEnabled = true;
            lboxLog.ItemHeight = 15;
            lboxLog.Location = new Point(9, 139);
            lboxLog.Margin = new Padding(2, 2, 2, 2);
            lboxLog.Name = "lboxLog";
            lboxLog.Size = new Size(660, 154);
            lboxLog.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(677, 298);
            Controls.Add(lboxLog);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnExecute);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "Unit Converter";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnExecute;
        private TextBox tboxValue;
        private TextBox tboxResult;
        private ComboBox cboxType;
        private RadioButton rdoLength;
        private RadioButton rdoWeight;
        private RadioButton rdoTemperature;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ListBox lboxLog;
        private Label label1;
        private Label label3;
        private Label label2;
    }
}