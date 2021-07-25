
namespace DatasetDesigner
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonGetCustomers = new System.Windows.Forms.Button();
            this.listBoxGetCustomers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonGetCustomers
            // 
            this.buttonGetCustomers.Location = new System.Drawing.Point(23, 29);
            this.buttonGetCustomers.Name = "buttonGetCustomers";
            this.buttonGetCustomers.Size = new System.Drawing.Size(163, 61);
            this.buttonGetCustomers.TabIndex = 0;
            this.buttonGetCustomers.Text = "Get Customers";
            this.buttonGetCustomers.UseVisualStyleBackColor = true;
            this.buttonGetCustomers.Click += new System.EventHandler(this.buttonGetCustomers_Click);
            // 
            // listBoxGetCustomers
            // 
            this.listBoxGetCustomers.FormattingEnabled = true;
            this.listBoxGetCustomers.ItemHeight = 25;
            this.listBoxGetCustomers.Location = new System.Drawing.Point(23, 121);
            this.listBoxGetCustomers.Name = "listBoxGetCustomers";
            this.listBoxGetCustomers.Size = new System.Drawing.Size(361, 304);
            this.listBoxGetCustomers.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxGetCustomers);
            this.Controls.Add(this.buttonGetCustomers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGetCustomers;
        private System.Windows.Forms.ListBox listBoxGetCustomers;
    }
}

