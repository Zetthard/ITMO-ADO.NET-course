
namespace DBCommand
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
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.buttonGetData = new System.Windows.Forms.Button();
            this.textBoxResults = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=DESKTOP-4A84H8M\\SQLEXPRESS;Initial Catalog=ApressFinancial;Integrated" +
    " Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandText = "SELECT CustomerId, CustomerFirstName, CustomerLastName\r\nFROM  CustomerDetails.Cus" +
    "tomers";
            this.sqlCommand1.Connection = this.sqlConnection1;
            // 
            // buttonGetData
            // 
            this.buttonGetData.Location = new System.Drawing.Point(22, 22);
            this.buttonGetData.Name = "buttonGetData";
            this.buttonGetData.Size = new System.Drawing.Size(158, 73);
            this.buttonGetData.TabIndex = 0;
            this.buttonGetData.Text = "Get Data";
            this.buttonGetData.UseVisualStyleBackColor = true;
            this.buttonGetData.Click += new System.EventHandler(this.buttonGetData_Click);
            // 
            // textBoxResults
            // 
            this.textBoxResults.Location = new System.Drawing.Point(226, 21);
            this.textBoxResults.Multiline = true;
            this.textBoxResults.Name = "textBoxResults";
            this.textBoxResults.Size = new System.Drawing.Size(514, 190);
            this.textBoxResults.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxResults);
            this.Controls.Add(this.buttonGetData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Windows.Forms.Button buttonGetData;
        private System.Windows.Forms.TextBox textBoxResults;
    }
}

