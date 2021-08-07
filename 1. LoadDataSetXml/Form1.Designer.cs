
namespace _1.LoadDataSetXml
{
    partial class Form1
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
            this.personGrid = new System.Windows.Forms.DataGridView();
            this.courseGrid = new System.Windows.Forms.DataGridView();
            this.buttonLoadSchema = new System.Windows.Forms.Button();
            this.buttonLoadData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.personGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // personGrid
            // 
            this.personGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.personGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personGrid.Location = new System.Drawing.Point(12, 11);
            this.personGrid.Name = "personGrid";
            this.personGrid.RowHeadersWidth = 82;
            this.personGrid.RowTemplate.Height = 33;
            this.personGrid.Size = new System.Drawing.Size(1346, 291);
            this.personGrid.TabIndex = 0;
            // 
            // courseGrid
            // 
            this.courseGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.courseGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseGrid.Location = new System.Drawing.Point(11, 408);
            this.courseGrid.Name = "courseGrid";
            this.courseGrid.RowHeadersWidth = 82;
            this.courseGrid.RowTemplate.Height = 33;
            this.courseGrid.Size = new System.Drawing.Size(1346, 291);
            this.courseGrid.TabIndex = 1;
            // 
            // buttonLoadSchema
            // 
            this.buttonLoadSchema.Location = new System.Drawing.Point(35, 721);
            this.buttonLoadSchema.Name = "buttonLoadSchema";
            this.buttonLoadSchema.Size = new System.Drawing.Size(154, 69);
            this.buttonLoadSchema.TabIndex = 2;
            this.buttonLoadSchema.Text = "Load Schema";
            this.buttonLoadSchema.UseVisualStyleBackColor = true;
            this.buttonLoadSchema.Click += new System.EventHandler(this.buttonLoadSchema_Click);
            // 
            // buttonLoadData
            // 
            this.buttonLoadData.Location = new System.Drawing.Point(229, 721);
            this.buttonLoadData.Name = "buttonLoadData";
            this.buttonLoadData.Size = new System.Drawing.Size(155, 69);
            this.buttonLoadData.TabIndex = 3;
            this.buttonLoadData.Text = "Load Data";
            this.buttonLoadData.UseVisualStyleBackColor = true;
            this.buttonLoadData.Click += new System.EventHandler(this.buttonLoadData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 812);
            this.Controls.Add(this.buttonLoadData);
            this.Controls.Add(this.buttonLoadSchema);
            this.Controls.Add(this.courseGrid);
            this.Controls.Add(this.personGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.personGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView personGrid;
        private System.Windows.Forms.DataGridView courseGrid;
        private System.Windows.Forms.Button buttonLoadSchema;
        private System.Windows.Forms.Button buttonLoadData;
    }
}

