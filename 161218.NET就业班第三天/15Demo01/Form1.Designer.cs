namespace _15Demo01
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnComputer = new System.Windows.Forms.Button();
            this.btnComputerAgain = new System.Windows.Forms.Button();
            this.lblChar = new System.Windows.Forms.Label();
            this.lblOther = new System.Windows.Forms.Label();
            this.lblDigital = new System.Windows.Forms.Label();
            this.lblSpaces = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入字符:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "英文字母个数:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "空格个数:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "数字个数:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "其他字符个数:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 21);
            this.textBox1.TabIndex = 5;
            // 
            // btnComputer
            // 
            this.btnComputer.Location = new System.Drawing.Point(28, 226);
            this.btnComputer.Name = "btnComputer";
            this.btnComputer.Size = new System.Drawing.Size(75, 23);
            this.btnComputer.TabIndex = 6;
            this.btnComputer.Text = "计算";
            this.btnComputer.UseVisualStyleBackColor = true;
            this.btnComputer.Click += new System.EventHandler(this.btnComputer_Click);
            // 
            // btnComputerAgain
            // 
            this.btnComputerAgain.Location = new System.Drawing.Point(144, 226);
            this.btnComputerAgain.Name = "btnComputerAgain";
            this.btnComputerAgain.Size = new System.Drawing.Size(75, 23);
            this.btnComputerAgain.TabIndex = 7;
            this.btnComputerAgain.Text = "重新计算";
            this.btnComputerAgain.UseVisualStyleBackColor = true;
            this.btnComputerAgain.Click += new System.EventHandler(this.btnComputerAgain_Click);
            // 
            // lblChar
            // 
            this.lblChar.AutoSize = true;
            this.lblChar.Location = new System.Drawing.Point(131, 74);
            this.lblChar.Name = "lblChar";
            this.lblChar.Size = new System.Drawing.Size(11, 12);
            this.lblChar.TabIndex = 8;
            this.lblChar.Text = "0";
            // 
            // lblOther
            // 
            this.lblOther.AutoSize = true;
            this.lblOther.Location = new System.Drawing.Point(131, 180);
            this.lblOther.Name = "lblOther";
            this.lblOther.Size = new System.Drawing.Size(11, 12);
            this.lblOther.TabIndex = 9;
            this.lblOther.Text = "0";
            // 
            // lblDigital
            // 
            this.lblDigital.AutoSize = true;
            this.lblDigital.Location = new System.Drawing.Point(131, 145);
            this.lblDigital.Name = "lblDigital";
            this.lblDigital.Size = new System.Drawing.Size(11, 12);
            this.lblDigital.TabIndex = 10;
            this.lblDigital.Text = "0";
            // 
            // lblSpaces
            // 
            this.lblSpaces.AutoSize = true;
            this.lblSpaces.Location = new System.Drawing.Point(131, 108);
            this.lblSpaces.Name = "lblSpaces";
            this.lblSpaces.Size = new System.Drawing.Size(11, 12);
            this.lblSpaces.TabIndex = 11;
            this.lblSpaces.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblSpaces);
            this.Controls.Add(this.lblDigital);
            this.Controls.Add(this.lblOther);
            this.Controls.Add(this.lblChar);
            this.Controls.Add(this.btnComputerAgain);
            this.Controls.Add(this.btnComputer);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "计算字符类型个数";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnComputer;
        private System.Windows.Forms.Button btnComputerAgain;
        private System.Windows.Forms.Label lblChar;
        private System.Windows.Forms.Label lblOther;
        private System.Windows.Forms.Label lblDigital;
        private System.Windows.Forms.Label lblSpaces;
    }
}

