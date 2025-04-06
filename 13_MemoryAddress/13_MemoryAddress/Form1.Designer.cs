namespace _13_MemoryAddress
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
            this.lblOriginData = new System.Windows.Forms.Label();
            this.lblCopyData = new System.Windows.Forms.Label();
            this.lblOrgData = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOrigin = new System.Windows.Forms.Button();
            this.gbox = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            this.tboxInt = new System.Windows.Forms.TextBox();
            this.tboxChar = new System.Windows.Forms.TextBox();
            this.tboxIntArray = new System.Windows.Forms.TextBox();
            this.tboxClassNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rdoEqual = new System.Windows.Forms.RadioButton();
            this.rdoSallowCopy = new System.Windows.Forms.RadioButton();
            this.rdoDeepCopy = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ucOrg1 = new _13_MemoryAddress.ucMemoryAddress();
            this.ucOrg2 = new _13_MemoryAddress.ucMemoryAddress();
            this.ucOrg3 = new _13_MemoryAddress.ucMemoryAddress();
            this.ucOrg4 = new _13_MemoryAddress.ucMemoryAddress();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ucCopy4 = new _13_MemoryAddress.ucMemoryAddress();
            this.ucCopy3 = new _13_MemoryAddress.ucMemoryAddress();
            this.ucCopy2 = new _13_MemoryAddress.ucMemoryAddress();
            this.ucCopy1 = new _13_MemoryAddress.ucMemoryAddress();
            this.groupBox1.SuspendLayout();
            this.gbox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOriginData
            // 
            this.lblOriginData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOriginData.Location = new System.Drawing.Point(9, 19);
            this.lblOriginData.Name = "lblOriginData";
            this.lblOriginData.Size = new System.Drawing.Size(200, 25);
            this.lblOriginData.TabIndex = 13;
            this.lblOriginData.Text = "-";
            this.lblOriginData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCopyData
            // 
            this.lblCopyData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCopyData.Location = new System.Drawing.Point(48, 19);
            this.lblCopyData.Name = "lblCopyData";
            this.lblCopyData.Size = new System.Drawing.Size(161, 25);
            this.lblCopyData.TabIndex = 14;
            this.lblCopyData.Text = "-";
            this.lblCopyData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOrgData
            // 
            this.lblOrgData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOrgData.Location = new System.Drawing.Point(48, 49);
            this.lblOrgData.Name = "lblOrgData";
            this.lblOrgData.Size = new System.Drawing.Size(161, 25);
            this.lblOrgData.TabIndex = 15;
            this.lblOrgData.Text = "-";
            this.lblOrgData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOrigin);
            this.groupBox1.Controls.Add(this.lblOriginData);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 52);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Origin Data";
            // 
            // btnOrigin
            // 
            this.btnOrigin.Location = new System.Drawing.Point(215, 19);
            this.btnOrigin.Name = "btnOrigin";
            this.btnOrigin.Size = new System.Drawing.Size(60, 25);
            this.btnOrigin.TabIndex = 21;
            this.btnOrigin.Text = "Origin";
            this.btnOrigin.UseVisualStyleBackColor = true;
            this.btnOrigin.Click += new System.EventHandler(this.btnOrigin_Click);
            // 
            // gbox
            // 
            this.gbox.Controls.Add(this.label8);
            this.gbox.Controls.Add(this.label1);
            this.gbox.Controls.Add(this.btnCopy);
            this.gbox.Controls.Add(this.lblCopyData);
            this.gbox.Controls.Add(this.lblOrgData);
            this.gbox.Location = new System.Drawing.Point(12, 163);
            this.gbox.Name = "gbox";
            this.gbox.Size = new System.Drawing.Size(284, 84);
            this.gbox.TabIndex = 21;
            this.gbox.TabStop = false;
            this.gbox.Text = "a = b";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 12);
            this.label8.TabIndex = 23;
            this.label8.Text = "Copy";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
            this.label1.TabIndex = 23;
            this.label1.Text = "Origin";
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(215, 19);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(60, 55);
            this.btnCopy.TabIndex = 22;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // tboxInt
            // 
            this.tboxInt.Location = new System.Drawing.Point(96, 70);
            this.tboxInt.Name = "tboxInt";
            this.tboxInt.Size = new System.Drawing.Size(36, 21);
            this.tboxInt.TabIndex = 26;
            this.tboxInt.Text = "10";
            // 
            // tboxChar
            // 
            this.tboxChar.Location = new System.Drawing.Point(263, 70);
            this.tboxChar.Name = "tboxChar";
            this.tboxChar.Size = new System.Drawing.Size(36, 21);
            this.tboxChar.TabIndex = 27;
            this.tboxChar.Text = "A";
            // 
            // tboxIntArray
            // 
            this.tboxIntArray.Location = new System.Drawing.Point(96, 98);
            this.tboxIntArray.Name = "tboxIntArray";
            this.tboxIntArray.Size = new System.Drawing.Size(36, 21);
            this.tboxIntArray.TabIndex = 28;
            this.tboxIntArray.Text = "5";
            // 
            // tboxClassNumber
            // 
            this.tboxClassNumber.Location = new System.Drawing.Point(263, 98);
            this.tboxClassNumber.Name = "tboxClassNumber";
            this.tboxClassNumber.Size = new System.Drawing.Size(36, 21);
            this.tboxClassNumber.TabIndex = 29;
            this.tboxClassNumber.Text = "200";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 12);
            this.label4.TabIndex = 30;
            this.label4.Text = "1. Int";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(147, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 12);
            this.label5.TabIndex = 30;
            this.label5.Text = "2. Char";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 12);
            this.label6.TabIndex = 30;
            this.label6.Text = "3. Int Array";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(147, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 12);
            this.label7.TabIndex = 30;
            this.label7.Text = "4. Class Inner Int";
            // 
            // rdoEqual
            // 
            this.rdoEqual.AutoSize = true;
            this.rdoEqual.Checked = true;
            this.rdoEqual.Location = new System.Drawing.Point(21, 135);
            this.rdoEqual.Name = "rdoEqual";
            this.rdoEqual.Size = new System.Drawing.Size(55, 16);
            this.rdoEqual.TabIndex = 31;
            this.rdoEqual.TabStop = true;
            this.rdoEqual.Text = "Equal";
            this.rdoEqual.UseVisualStyleBackColor = true;
            // 
            // rdoSallowCopy
            // 
            this.rdoSallowCopy.AutoSize = true;
            this.rdoSallowCopy.Location = new System.Drawing.Point(83, 135);
            this.rdoSallowCopy.Name = "rdoSallowCopy";
            this.rdoSallowCopy.Size = new System.Drawing.Size(95, 16);
            this.rdoSallowCopy.TabIndex = 31;
            this.rdoSallowCopy.Text = "Sallow Copy";
            this.rdoSallowCopy.UseVisualStyleBackColor = true;
            // 
            // rdoDeepCopy
            // 
            this.rdoDeepCopy.AutoSize = true;
            this.rdoDeepCopy.Location = new System.Drawing.Point(184, 135);
            this.rdoDeepCopy.Name = "rdoDeepCopy";
            this.rdoDeepCopy.Size = new System.Drawing.Size(86, 16);
            this.rdoDeepCopy.TabIndex = 31;
            this.rdoDeepCopy.Text = "Deep Copy";
            this.rdoDeepCopy.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ucOrg4);
            this.groupBox2.Controls.Add(this.ucOrg3);
            this.groupBox2.Controls.Add(this.ucOrg2);
            this.groupBox2.Controls.Add(this.ucOrg1);
            this.groupBox2.Location = new System.Drawing.Point(302, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(239, 235);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Origin Address";
            // 
            // ucOrg1
            // 
            this.ucOrg1.Location = new System.Drawing.Point(6, 27);
            this.ucOrg1.Name = "ucOrg1";
            this.ucOrg1.Size = new System.Drawing.Size(231, 25);
            this.ucOrg1.StrAddress = "-";
            this.ucOrg1.StrName = "Name";
            this.ucOrg1.StrValue = "-";
            this.ucOrg1.TabIndex = 0;
            // 
            // ucOrg2
            // 
            this.ucOrg2.Location = new System.Drawing.Point(6, 58);
            this.ucOrg2.Name = "ucOrg2";
            this.ucOrg2.Size = new System.Drawing.Size(231, 25);
            this.ucOrg2.StrAddress = "-";
            this.ucOrg2.StrName = "Name";
            this.ucOrg2.StrValue = "-";
            this.ucOrg2.TabIndex = 0;
            // 
            // ucOrg3
            // 
            this.ucOrg3.Location = new System.Drawing.Point(6, 89);
            this.ucOrg3.Name = "ucOrg3";
            this.ucOrg3.Size = new System.Drawing.Size(231, 25);
            this.ucOrg3.StrAddress = "-";
            this.ucOrg3.StrName = "Name";
            this.ucOrg3.StrValue = "-";
            this.ucOrg3.TabIndex = 0;
            // 
            // ucOrg4
            // 
            this.ucOrg4.Location = new System.Drawing.Point(6, 120);
            this.ucOrg4.Name = "ucOrg4";
            this.ucOrg4.Size = new System.Drawing.Size(231, 25);
            this.ucOrg4.StrAddress = "-";
            this.ucOrg4.StrName = "Name";
            this.ucOrg4.StrValue = "-";
            this.ucOrg4.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ucCopy4);
            this.groupBox3.Controls.Add(this.ucCopy3);
            this.groupBox3.Controls.Add(this.ucCopy2);
            this.groupBox3.Controls.Add(this.ucCopy1);
            this.groupBox3.Location = new System.Drawing.Point(547, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(239, 235);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Copy Address";
            // 
            // ucCopy4
            // 
            this.ucCopy4.Location = new System.Drawing.Point(6, 120);
            this.ucCopy4.Name = "ucCopy4";
            this.ucCopy4.Size = new System.Drawing.Size(231, 25);
            this.ucCopy4.StrAddress = "-";
            this.ucCopy4.StrName = "Name";
            this.ucCopy4.StrValue = "-";
            this.ucCopy4.TabIndex = 0;
            // 
            // ucCopy3
            // 
            this.ucCopy3.Location = new System.Drawing.Point(6, 89);
            this.ucCopy3.Name = "ucCopy3";
            this.ucCopy3.Size = new System.Drawing.Size(231, 25);
            this.ucCopy3.StrAddress = "-";
            this.ucCopy3.StrName = "Name";
            this.ucCopy3.StrValue = "-";
            this.ucCopy3.TabIndex = 0;
            // 
            // ucCopy2
            // 
            this.ucCopy2.Location = new System.Drawing.Point(6, 58);
            this.ucCopy2.Name = "ucCopy2";
            this.ucCopy2.Size = new System.Drawing.Size(231, 25);
            this.ucCopy2.StrAddress = "-";
            this.ucCopy2.StrName = "Name";
            this.ucCopy2.StrValue = "-";
            this.ucCopy2.TabIndex = 0;
            // 
            // ucCopy1
            // 
            this.ucCopy1.Location = new System.Drawing.Point(6, 27);
            this.ucCopy1.Name = "ucCopy1";
            this.ucCopy1.Size = new System.Drawing.Size(231, 25);
            this.ucCopy1.StrAddress = "-";
            this.ucCopy1.StrName = "Name";
            this.ucCopy1.StrValue = "-";
            this.ucCopy1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 255);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.rdoDeepCopy);
            this.Controls.Add(this.rdoSallowCopy);
            this.Controls.Add(this.rdoEqual);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tboxClassNumber);
            this.Controls.Add(this.tboxIntArray);
            this.Controls.Add(this.tboxChar);
            this.Controls.Add(this.tboxInt);
            this.Controls.Add(this.gbox);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.gbox.ResumeLayout(false);
            this.gbox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblOriginData;
        private System.Windows.Forms.Label lblCopyData;
        private System.Windows.Forms.Label lblOrgData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOrigin;
        private System.Windows.Forms.GroupBox gbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.TextBox tboxInt;
        private System.Windows.Forms.TextBox tboxChar;
        private System.Windows.Forms.TextBox tboxIntArray;
        private System.Windows.Forms.TextBox tboxClassNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rdoEqual;
        private System.Windows.Forms.RadioButton rdoSallowCopy;
        private System.Windows.Forms.RadioButton rdoDeepCopy;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private ucMemoryAddress ucOrg1;
        private ucMemoryAddress ucOrg4;
        private ucMemoryAddress ucOrg3;
        private ucMemoryAddress ucOrg2;
        private System.Windows.Forms.GroupBox groupBox3;
        private ucMemoryAddress ucCopy4;
        private ucMemoryAddress ucCopy3;
        private ucMemoryAddress ucCopy2;
        private ucMemoryAddress ucCopy1;
    }
}

