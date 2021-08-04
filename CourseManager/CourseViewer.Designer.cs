
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
            // 
            // buttonCloseForm
            // 
            this.buttonCloseForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCloseForm.Location = new System.Drawing.Point(631, 385);
            this.buttonCloseForm.Name = "buttonCloseForm";
            this.buttonCloseForm.Size = new System.Drawing.Size(121, 46);
            this.buttonCloseForm.TabIndex = 1;
            this.buttonCloseForm.Text = "Закрыть";
            this.buttonCloseForm.UseVisualStyleBackColor = true;
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
            this.dataGridViewCourse.Size = new System.Drawing.Size(765, 284);
            this.dataGridViewCourse.TabIndex = 2;
            // 
            // CourseViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewCourse);
            this.Controls.Add(this.buttonCloseForm);
            this.Controls.Add(this.comboBoxDepartmentList);
            this.Name = "CourseViewer";
            this.Text = "Course Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDepartmentList;
        private System.Windows.Forms.Button buttonCloseForm;
        private System.Windows.Forms.DataGridView dataGridViewCourse;
    }
}

