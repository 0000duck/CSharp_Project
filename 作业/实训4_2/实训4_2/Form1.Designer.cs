namespace 实训4_2
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtboxHour = new System.Windows.Forms.TextBox();
            this.txtboxMinute = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxSecond = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(234, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(35, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtboxHour
            // 
            this.txtboxHour.Location = new System.Drawing.Point(12, 12);
            this.txtboxHour.Name = "txtboxHour";
            this.txtboxHour.Size = new System.Drawing.Size(50, 21);
            this.txtboxHour.TabIndex = 1;
            this.txtboxHour.TextChanged += new System.EventHandler(this.txtboxHour_TextChanged);
            // 
            // txtboxMinute
            // 
            this.txtboxMinute.Location = new System.Drawing.Point(91, 12);
            this.txtboxMinute.Name = "txtboxMinute";
            this.txtboxMinute.Size = new System.Drawing.Size(50, 21);
            this.txtboxMinute.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "：";
            // 
            // txtboxSecond
            // 
            this.txtboxSecond.Location = new System.Drawing.Point(170, 12);
            this.txtboxSecond.Name = "txtboxSecond";
            this.txtboxSecond.Size = new System.Drawing.Size(50, 21);
            this.txtboxSecond.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 55);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtboxSecond);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxMinute);
            this.Controls.Add(this.txtboxHour);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "实训4_2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtboxHour;
        private System.Windows.Forms.TextBox txtboxMinute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxSecond;
        private System.Windows.Forms.Label label2;
    }
}

