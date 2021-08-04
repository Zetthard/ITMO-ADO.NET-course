
namespace CourseManager
{
    partial class CourseViewer
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
            this.comboBoxDepartmentList = new System.Windows.Forms.ComboBox();
            this.buttonCloseForm = new System.Windows.Forms.Button();
            this.dataGridViewCourse = new System.Windows.Forms.DataGridView();
            this.buttonSaveChanges = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxDepartmentList
            // 
            this.comboBoxDepartmentList.FormattingEnabled = true;
            this.comboBoxDepartmentList.Location = new System.Drawing.Point(19, 29);
            this.comboBoxDepartmentList.Name = "comboBoxDepartmentList";
            this.comboBoxDepartmentList.Size = new System.Drawing.Size(188, 33);
            this.comboBoxDepartmentList.TabIndex = 0;
            this.comboBoxDepartmentList.SelectedIndexChanged += new System.EventHandler(this.comboBoxDepartmentList_SelectedIndexChanged);
            // 
            // buttonCloseForm
            // 
            this.buttonCloseForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCloseForm.Location = new System.Drawing.Point(530, 346);
            this.buttonCloseForm.Name = "buttonCloseForm";
            this.buttonCloseForm.Size = new System.Drawing.Size(121, 46);
            this.buttonCloseForm.TabIndex = 1;
            this.buttonCloseForm.Text = "Закрыть";
            this.buttonCloseForm.UseVisualStyleBackColor = true;
            this.buttonCloseForm.Click += new System.EventHandler(this.buttonCloseForm_Click);
            // 
            // dataGridViewCourse
            // 
            this.dataGridViewCourse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCourse.Location = new System.Drawing.Point(17, 81);
            this.dataGridViewCourse.Name = "dataGridViewCourse";
            this.dataGridViewCourse.RowHeadersWidth = 82;
            this.dataGridViewCourse.RowTemplate.Height = 33;
            this.dataGridViewCourse.Size = new System.Drawing.Size(744, 184);
            this.dataGridViewCourse.TabIndex = 2;
            // 
            // buttonSaveChanges
            // 
            this.buttonSaveChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSaveChanges.Location = new System.Drawing.Point(30, 346);
            this.buttonSaveChanges.Name = "buttonSaveChanges";
            this.buttonSaveChanges.Size = new System.Drawing.Size(129, 46);
            this.buttonSaveChanges.TabIndex = 3;
            this.buttonSaveChanges.Text = "Обновить";
            this.buttonSaveChanges.UseVisualStyleBackColor = true;
            this.buttonSaveChanges.Click += new System.EventHandler(this.buttonSaveChanges_Click);
            // 
            // CourseViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 281);
            this.Controls.Add(this.buttonSaveChanges);
            this.Controls.Add(this.dataGridViewCourse);
            this.Controls.Add(this.buttonCloseForm);
            this.Controls.Add(this.comboBoxDepartmentList);
            this.Name = "CourseViewer";
            this.Text = "Course Viewer";
            this.Load += new System.EventHandler(this.CourseViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDepartmentList;
        private System.Windows.Forms.Button buttonCloseForm;
        private System.Windows.Forms.DataGridView dataGridViewCourse;
        private System.Windows.Forms.Button buttonSaveChanges;
    }
}

