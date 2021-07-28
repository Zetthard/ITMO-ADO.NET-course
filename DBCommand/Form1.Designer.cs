
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
            this.buttonProcedure = new System.Windows.Forms.Button();
            this.sqlCommandProcedure = new System.Data.SqlClient.SqlCommand();
            this.buttonNewTable = new System.Windows.Forms.Button();
            this.sqlCommandNewTable = new System.Data.SqlClient.SqlCommand();
            this.buttonGetWithParam = new System.Windows.Forms.Button();
            this.textBoxParam = new System.Windows.Forms.TextBox();
            this.sqlCommandWithParam = new System.Data.SqlClient.SqlCommand();
            this.buttonParamProcedure = new System.Windows.Forms.Button();
            this.textBoxShareDecs = new System.Windows.Forms.TextBox();
            this.sqlCommandParamProcedure = new System.Data.SqlClient.SqlCommand();
            this.textBoxTickerId = new System.Windows.Forms.TextBox();
            this.textBoxCurrPrice = new System.Windows.Forms.TextBox();
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
            this.buttonGetData.Location = new System.Drawing.Point(22, 26);
            this.buttonGetData.Name = "buttonGetData";
            this.buttonGetData.Size = new System.Drawing.Size(158, 69);
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
            // buttonProcedure
            // 
            this.buttonProcedure.Location = new System.Drawing.Point(22, 117);
            this.buttonProcedure.Name = "buttonProcedure";
            this.buttonProcedure.Size = new System.Drawing.Size(158, 68);
            this.buttonProcedure.TabIndex = 2;
            this.buttonProcedure.Text = "Run Procedure";
            this.buttonProcedure.UseVisualStyleBackColor = true;
            this.buttonProcedure.Click += new System.EventHandler(this.buttonProcedure_Click);
            // 
            // sqlCommandProcedure
            // 
            this.sqlCommandProcedure.Connection = this.sqlConnection1;
            // 
            // buttonNewTable
            // 
            this.buttonNewTable.Location = new System.Drawing.Point(583, 234);
            this.buttonNewTable.Name = "buttonNewTable";
            this.buttonNewTable.Size = new System.Drawing.Size(157, 66);
            this.buttonNewTable.TabIndex = 3;
            this.buttonNewTable.Text = "New Table";
            this.buttonNewTable.UseVisualStyleBackColor = true;
            this.buttonNewTable.Click += new System.EventHandler(this.buttonNewTable_Click);
            // 
            // sqlCommandNewTable
            // 
            this.sqlCommandNewTable.Connection = this.sqlConnection1;
            // 
            // buttonGetWithParam
            // 
            this.buttonGetWithParam.Location = new System.Drawing.Point(226, 234);
            this.buttonGetWithParam.Name = "buttonGetWithParam";
            this.buttonGetWithParam.Size = new System.Drawing.Size(157, 43);
            this.buttonGetWithParam.TabIndex = 4;
            this.buttonGetWithParam.Text = "Get ...";
            this.buttonGetWithParam.UseVisualStyleBackColor = true;
            this.buttonGetWithParam.Click += new System.EventHandler(this.buttonGetWithParam_Click);
            // 
            // textBoxParam
            // 
            this.textBoxParam.Location = new System.Drawing.Point(22, 246);
            this.textBoxParam.Name = "textBoxParam";
            this.textBoxParam.Size = new System.Drawing.Size(158, 31);
            this.textBoxParam.TabIndex = 5;
            this.textBoxParam.Text = "1";
            // 
            // sqlCommandWithParam
            // 
            this.sqlCommandWithParam.Connection = this.sqlConnection1;
            this.sqlCommandWithParam.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@titleId", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, "")});
            // 
            // buttonParamProcedure
            // 
            this.buttonParamProcedure.Location = new System.Drawing.Point(587, 365);
            this.buttonParamProcedure.Name = "buttonParamProcedure";
            this.buttonParamProcedure.Size = new System.Drawing.Size(153, 69);
            this.buttonParamProcedure.TabIndex = 6;
            this.buttonParamProcedure.Text = "Add Share";
            this.buttonParamProcedure.UseVisualStyleBackColor = true;
            this.buttonParamProcedure.Click += new System.EventHandler(this.buttonParamProcedure_Click);
            // 
            // textBoxShareDecs
            // 
            this.textBoxShareDecs.Location = new System.Drawing.Point(22, 365);
            this.textBoxShareDecs.Name = "textBoxShareDecs";
            this.textBoxShareDecs.Size = new System.Drawing.Size(158, 31);
            this.textBoxShareDecs.TabIndex = 7;
            this.textBoxShareDecs.Text = "Com Star Balt";
            // 
            // sqlCommandParamProcedure
            // 
            this.sqlCommandParamProcedure.CommandText = "ShareDetails.spu_AddShare";
            this.sqlCommandParamProcedure.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommandParamProcedure.Connection = this.sqlConnection1;
            this.sqlCommandParamProcedure.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@decs", System.Data.SqlDbType.NVarChar),
            new System.Data.SqlClient.SqlParameter("@tickerId", System.Data.SqlDbType.NVarChar),
            new System.Data.SqlClient.SqlParameter("@currentPrice", System.Data.SqlDbType.Decimal)});
            // 
            // textBoxTickerId
            // 
            this.textBoxTickerId.Location = new System.Drawing.Point(213, 365);
            this.textBoxTickerId.Name = "textBoxTickerId";
            this.textBoxTickerId.Size = new System.Drawing.Size(158, 31);
            this.textBoxTickerId.TabIndex = 8;
            this.textBoxTickerId.Text = "CSB";
            // 
            // textBoxCurrPrice
            // 
            this.textBoxCurrPrice.Location = new System.Drawing.Point(400, 365);
            this.textBoxCurrPrice.Name = "textBoxCurrPrice";
            this.textBoxCurrPrice.Size = new System.Drawing.Size(158, 31);
            this.textBoxCurrPrice.TabIndex = 9;
            this.textBoxCurrPrice.Text = "3,40000";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxCurrPrice);
            this.Controls.Add(this.textBoxTickerId);
            this.Controls.Add(this.textBoxShareDecs);
            this.Controls.Add(this.buttonParamProcedure);
            this.Controls.Add(this.textBoxParam);
            this.Controls.Add(this.buttonGetWithParam);
            this.Controls.Add(this.buttonNewTable);
            this.Controls.Add(this.buttonProcedure);
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
        private System.Windows.Forms.Button buttonProcedure;
        private System.Data.SqlClient.SqlCommand sqlCommandProcedure;
        private System.Windows.Forms.Button buttonNewTable;
        private System.Data.SqlClient.SqlCommand sqlCommandNewTable;
        private System.Windows.Forms.Button buttonGetWithParam;
        private System.Windows.Forms.TextBox textBoxParam;
        private System.Data.SqlClient.SqlCommand sqlCommandWithParam;
        private System.Windows.Forms.Button buttonParamProcedure;
        private System.Windows.Forms.TextBox textBoxShareDecs;
        private System.Data.SqlClient.SqlCommand sqlCommandParamProcedure;
        private System.Windows.Forms.TextBox textBoxTickerId;
        private System.Windows.Forms.TextBox textBoxCurrPrice;
    }
}

