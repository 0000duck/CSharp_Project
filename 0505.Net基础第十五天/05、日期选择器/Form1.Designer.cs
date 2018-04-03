namespace _05_日期选择器
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
            this.cboYears = new System.Windows.Forms.ComboBox();
            this.cboMouths = new System.Windows.Forms.ComboBox();
            this.cboDays = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cboYears
            // 
            this.cboYears.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYears.FormattingEnabled = true;
            this.cboYears.Location = new System.Drawing.Point(89, 133);
            this.cboYears.Name = "cboYears";
            this.cboYears.Size = new System.Drawing.Size(121, 20);
            this.cboYears.TabIndex = 0;
            this.cboYears.SelectedIndexChanged += new System.EventHandler(this.cboYears_SelectedIndexChanged);
            // 
            // cboMouths
            // 
            this.cboMouths.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMouths.FormattingEnabled = true;
            this.cboMouths.Location = new System.Drawing.Point(257, 132);
            this.cboMouths.Name = "cboMouths";
            this.cboMouths.Size = new System.Drawing.Size(121, 20);
            this.cboMouths.TabIndex = 1;
            this.cboMouths.SelectedIndexChanged += new System.EventHandler(this.cboMouths_SelectedIndexChanged);
            // 
            // cboDays
            // 
            this.cboDays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDays.FormattingEnabled = true;
            this.cboDays.Location = new System.Drawing.Point(413, 132);
            this.cboDays.Name = "cboDays";
            this.cboDays.Size = new System.Drawing.Size(121, 20);
            this.cboDays.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 348);
            this.Controls.Add(this.cboDays);
            this.Controls.Add(this.cboMouths);
            this.Controls.Add(this.cboYears);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboYears;
        private System.Windows.Forms.ComboBox cboMouths;
        private System.Windows.Forms.ComboBox cboDays;
    }
}

