namespace MySchool
{
    partial class CourseFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvCourse = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.CourseId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Required = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrelectionCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExperimentCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCourse
            // 
            this.dgvCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CourseId,
            this.CourseName,
            this.CourseClass,
            this.Required,
            this.Credit,
            this.PrelectionCredit,
            this.ExperimentCredit});
            this.dgvCourse.Location = new System.Drawing.Point(22, 23);
            this.dgvCourse.Name = "dgvCourse";
            this.dgvCourse.RowTemplate.Height = 23;
            this.dgvCourse.Size = new System.Drawing.Size(732, 206);
            this.dgvCourse.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "提示:选中行再按<DEL>键可删除该行数据。双击末尾空行,可添加新纪录。";
            // 
            // tbnSave
            // 
            this.tbnSave.Location = new System.Drawing.Point(195, 288);
            this.tbnSave.Name = "tbnSave";
            this.tbnSave.Size = new System.Drawing.Size(91, 23);
            this.tbnSave.TabIndex = 2;
            this.tbnSave.Text = "保存更新（S）";
            this.tbnSave.UseVisualStyleBackColor = true;
            this.tbnSave.Click += new System.EventHandler(this.tbnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(373, 288);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "取消更新（C）";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // CourseId
            // 
            this.CourseId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CourseId.HeaderText = "课程ID";
            this.CourseId.Name = "CourseId";
            // 
            // CourseName
            // 
            this.CourseName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CourseName.HeaderText = "课程名称";
            this.CourseName.Name = "CourseName";
            // 
            // CourseClass
            // 
            this.CourseClass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CourseClass.HeaderText = "课程类别";
            this.CourseClass.Name = "CourseClass";
            // 
            // Required
            // 
            this.Required.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Required.HeaderText = "是否必修";
            this.Required.Name = "Required";
            // 
            // Credit
            // 
            this.Credit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Credit.HeaderText = "学分";
            this.Credit.Name = "Credit";
            // 
            // PrelectionCredit
            // 
            this.PrelectionCredit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PrelectionCredit.HeaderText = "理论学时";
            this.PrelectionCredit.Name = "PrelectionCredit";
            // 
            // ExperimentCredit
            // 
            this.ExperimentCredit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ExperimentCredit.HeaderText = "实验学时";
            this.ExperimentCredit.Name = "ExperimentCredit";
            // 
            // CourseFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 408);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tbnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCourse);
            this.Name = "CourseFrm";
            this.Text = "CourseFrm";
            this.Load += new System.EventHandler(this.CourseFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCourse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tbnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn Required;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credit;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrelectionCredit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExperimentCredit;
    }
}