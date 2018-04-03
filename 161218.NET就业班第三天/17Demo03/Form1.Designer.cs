namespace _17Demo03
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
            this.lblNewNumber = new System.Windows.Forms.Label();
            this.lblNumberBits = new System.Windows.Forms.Label();
            this.btnComputerAgain = new System.Windows.Forms.Button();
            this.btnComputer = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNewNumber
            // 
            this.lblNewNumber.AutoSize = true;
            this.lblNewNumber.Location = new System.Drawing.Point(91, 113);
            this.lblNewNumber.Name = "lblNewNumber";
            this.lblNewNumber.Size = new System.Drawing.Size(11, 12);
            this.lblNewNumber.TabIndex = 19;
            this.lblNewNumber.Text = "0";
            // 
            // lblNumberBits
            // 
            this.lblNumberBits.AutoSize = true;
            this.lblNumberBits.Location = new System.Drawing.Point(91, 67);
            this.lblNumberBits.Name = "lblNumberBits";
            this.lblNumberBits.Size = new System.Drawing.Size(11, 12);
            this.lblNumberBits.TabIndex = 18;
            this.lblNumberBits.Text = "0";
            // 
            // btnComputerAgain
            // 
            this.btnComputerAgain.Location = new System.Drawing.Point(137, 155);
            this.btnComputerAgain.Name = "btnComputerAgain";
            this.btnComputerAgain.Size = new System.Drawing.Size(75, 23);
            this.btnComputerAgain.TabIndex = 17;
            this.btnComputerAgain.Text = "重新计算";
            this.btnComputerAgain.UseVisualStyleBackColor = true;
            this.btnComputerAgain.Click += new System.EventHandler(this.btnComputerAgain_Click);
            // 
            // btnComputer
            // 
            this.btnComputer.Location = new System.Drawing.Point(15, 155);
            this.btnComputer.Name = "btnComputer";
            this.btnComputer.Size = new System.Drawing.Size(75, 23);
            this.btnComputer.TabIndex = 16;
            this.btnComputer.Text = "计算";
            this.btnComputer.UseVisualStyleBackColor = true;
            this.btnComputer.Click += new System.EventHandler(this.btnComputer_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 21);
            this.textBox1.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "新的数字:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "数字位数:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "请输入数字:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 200);
            this.Controls.Add(this.lblNewNumber);
            this.Controls.Add(this.lblNumberBits);
            this.Controls.Add(this.btnComputerAgain);
            this.Controls.Add(this.btnComputer);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "逆序输出数字";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNewNumber;
        private System.Windows.Forms.Label lblNumberBits;
        private System.Windows.Forms.Button btnComputerAgain;
        private System.Windows.Forms.Button btnComputer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

