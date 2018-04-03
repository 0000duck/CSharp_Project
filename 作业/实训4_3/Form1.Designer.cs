namespace 实训4_3
{
    partial class Exp4_3
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
            this.btnCreat = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.lblShow = new System.Windows.Forms.RichTextBox();
            this.txtWithdraw = new System.Windows.Forms.TextBox();
            this.txtboxSave = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCreat
            // 
            this.btnCreat.Location = new System.Drawing.Point(12, 23);
            this.btnCreat.Name = "btnCreat";
            this.btnCreat.Size = new System.Drawing.Size(95, 23);
            this.btnCreat.TabIndex = 0;
            this.btnCreat.Text = "创建账户";
            this.btnCreat.UseVisualStyleBackColor = true;
            this.btnCreat.Click += new System.EventHandler(this.btnCreat_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(12, 65);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(41, 23);
            this.btnWithdraw.TabIndex = 1;
            this.btnWithdraw.Text = "取款";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(13, 95);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(40, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "存款";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(13, 135);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(94, 23);
            this.btnQuery.TabIndex = 3;
            this.btnQuery.Text = "查询余额";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // lblShow
            // 
            this.lblShow.Location = new System.Drawing.Point(125, 23);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(134, 135);
            this.lblShow.TabIndex = 4;
            this.lblShow.Text = "";
            // 
            // txtWithdraw
            // 
            this.txtWithdraw.Location = new System.Drawing.Point(60, 65);
            this.txtWithdraw.Name = "txtWithdraw";
            this.txtWithdraw.Size = new System.Drawing.Size(47, 21);
            this.txtWithdraw.TabIndex = 5;
            // 
            // txtboxSave
            // 
            this.txtboxSave.Location = new System.Drawing.Point(59, 95);
            this.txtboxSave.Name = "txtboxSave";
            this.txtboxSave.Size = new System.Drawing.Size(48, 21);
            this.txtboxSave.TabIndex = 6;
            this.txtboxSave.TextChanged += new System.EventHandler(this.txtboxSave_TextChanged);
            // 
            // Exp4_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 178);
            this.Controls.Add(this.txtboxSave);
            this.Controls.Add(this.txtWithdraw);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.btnCreat);
            this.Name = "Exp4_3";
            this.Text = "实训4_3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreat;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.RichTextBox lblShow;
        private System.Windows.Forms.TextBox txtWithdraw;
        private System.Windows.Forms.TextBox txtboxSave;
    }
}

