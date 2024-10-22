namespace FartialClass
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
            this.lboxItem = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxItem = new System.Windows.Forms.ComboBox();
            this.cBoxRate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numCount = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tboxResult = new System.Windows.Forms.TextBox();
            this.tboxErrorMsg = new System.Windows.Forms.TextBox();
            this.tboxResult2 = new System.Windows.Forms.TextBox();
            this.btnResset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).BeginInit();
            this.SuspendLayout();
            // 
            // lboxItem
            // 
            this.lboxItem.FormattingEnabled = true;
            this.lboxItem.ItemHeight = 15;
            this.lboxItem.Location = new System.Drawing.Point(12, 12);
            this.lboxItem.Name = "lboxItem";
            this.lboxItem.Size = new System.Drawing.Size(241, 274);
            this.lboxItem.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "물건";
            // 
            // cBoxItem
            // 
            this.cBoxItem.FormattingEnabled = true;
            this.cBoxItem.Location = new System.Drawing.Point(262, 34);
            this.cBoxItem.Name = "cBoxItem";
            this.cBoxItem.Size = new System.Drawing.Size(121, 23);
            this.cBoxItem.TabIndex = 2;
            // 
            // cBoxRate
            // 
            this.cBoxRate.FormattingEnabled = true;
            this.cBoxRate.Location = new System.Drawing.Point(262, 99);
            this.cBoxRate.Name = "cBoxRate";
            this.cBoxRate.Size = new System.Drawing.Size(121, 23);
            this.cBoxRate.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "할인율(%)";
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "개수";
            // 
            // numCount
            // 
            this.numCount.Location = new System.Drawing.Point(262, 167);
            this.numCount.Name = "numCount";
            this.numCount.Size = new System.Drawing.Size(121, 25);
            this.numCount.TabIndex = 6;
            this.numCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(262, 227);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 29);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "담기";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tboxResult
            // 
            this.tboxResult.Location = new System.Drawing.Point(12, 292);
            this.tboxResult.Name = "tboxResult";
            this.tboxResult.Size = new System.Drawing.Size(241, 25);
            this.tboxResult.TabIndex = 8;
            // 
            // tboxErrorMsg
            // 
            this.tboxErrorMsg.ForeColor = System.Drawing.Color.Red;
            this.tboxErrorMsg.Location = new System.Drawing.Point(12, 354);
            this.tboxErrorMsg.Name = "tboxErrorMsg";
            this.tboxErrorMsg.Size = new System.Drawing.Size(371, 25);
            this.tboxErrorMsg.TabIndex = 9;
            // 
            // tboxResult2
            // 
            this.tboxResult2.Location = new System.Drawing.Point(12, 323);
            this.tboxResult2.Name = "tboxResult2";
            this.tboxResult2.Size = new System.Drawing.Size(241, 25);
            this.tboxResult2.TabIndex = 10;
            // 
            // btnResset
            // 
            this.btnResset.Location = new System.Drawing.Point(262, 262);
            this.btnResset.Name = "btnResset";
            this.btnResset.Size = new System.Drawing.Size(121, 29);
            this.btnResset.TabIndex = 11;
            this.btnResset.Text = "초기화";
            this.btnResset.UseVisualStyleBackColor = true;
            this.btnResset.Click += new System.EventHandler(this.btnResset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 392);
            this.Controls.Add(this.btnResset);
            this.Controls.Add(this.tboxResult2);
            this.Controls.Add(this.tboxErrorMsg);
            this.Controls.Add(this.tboxResult);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.numCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cBoxRate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cBoxItem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lboxItem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lboxItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxItem;
        private System.Windows.Forms.ComboBox cBoxRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numCount;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tboxResult;
        private System.Windows.Forms.TextBox tboxErrorMsg;
        private System.Windows.Forms.TextBox tboxResult2;
        private System.Windows.Forms.Button btnResset;
    }
}

