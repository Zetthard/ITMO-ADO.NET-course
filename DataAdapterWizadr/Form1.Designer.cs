
namespace DataAdapterWizadr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.dataSetApressFinancial1 = new DataAdapterWizadr.DataSetApressFinancial();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonSaveChange = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetApressFinancial1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT * FROM CustomerDetails.Customers";
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText");
            this.sqlInsertCommand1.Connection = this.sqlConnection1;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@CustomerTitleId", System.Data.SqlDbType.NVarChar, 0, "CustomerTitleId"),
            new System.Data.SqlClient.SqlParameter("@CustomerFirstName", System.Data.SqlDbType.NVarChar, 0, "CustomerFirstName"),
            new System.Data.SqlClient.SqlParameter("@CustomerOtherInitials", System.Data.SqlDbType.NVarChar, 0, "CustomerOtherInitials"),
            new System.Data.SqlClient.SqlParameter("@CustomerLastName", System.Data.SqlDbType.NVarChar, 0, "CustomerLastName"),
            new System.Data.SqlClient.SqlParameter("@AddressId", System.Data.SqlDbType.BigInt, 0, "AddressId"),
            new System.Data.SqlClient.SqlParameter("@AccountNumber", System.Data.SqlDbType.NChar, 0, "AccountNumber"),
            new System.Data.SqlClient.SqlParameter("@AccountTypeId", System.Data.SqlDbType.Int, 0, "AccountTypeId"),
            new System.Data.SqlClient.SqlParameter("@ClearBalance", System.Data.SqlDbType.Money, 0, "ClearBalance"),
            new System.Data.SqlClient.SqlParameter("@UnclearBalance", System.Data.SqlDbType.Money, 0, "UnclearBalance"),
            new System.Data.SqlClient.SqlParameter("@DateAdded", System.Data.SqlDbType.Date, 0, "DateAdded")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConnection1;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@CustomerTitleId", System.Data.SqlDbType.NVarChar, 0, "CustomerTitleId"),
            new System.Data.SqlClient.SqlParameter("@CustomerFirstName", System.Data.SqlDbType.NVarChar, 0, "CustomerFirstName"),
            new System.Data.SqlClient.SqlParameter("@CustomerOtherInitials", System.Data.SqlDbType.NVarChar, 0, "CustomerOtherInitials"),
            new System.Data.SqlClient.SqlParameter("@CustomerLastName", System.Data.SqlDbType.NVarChar, 0, "CustomerLastName"),
            new System.Data.SqlClient.SqlParameter("@AddressId", System.Data.SqlDbType.BigInt, 0, "AddressId"),
            new System.Data.SqlClient.SqlParameter("@AccountNumber", System.Data.SqlDbType.NChar, 0, "AccountNumber"),
            new System.Data.SqlClient.SqlParameter("@AccountTypeId", System.Data.SqlDbType.Int, 0, "AccountTypeId"),
            new System.Data.SqlClient.SqlParameter("@ClearBalance", System.Data.SqlDbType.Money, 0, "ClearBalance"),
            new System.Data.SqlClient.SqlParameter("@UnclearBalance", System.Data.SqlDbType.Money, 0, "UnclearBalance"),
            new System.Data.SqlClient.SqlParameter("@DateAdded", System.Data.SqlDbType.Date, 0, "DateAdded"),
            new System.Data.SqlClient.SqlParameter("@Original_CustomerId", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerId", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CustomerTitleId", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerTitleId", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CustomerFirstName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerFirstName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_CustomerOtherInitials", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CustomerOtherInitials", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_CustomerOtherInitials", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerOtherInitials", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CustomerLastName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerLastName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_AddressId", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AddressId", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_AccountNumber", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AccountNumber", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_AccountTypeId", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AccountTypeId", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ClearBalance", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ClearBalance", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_UnclearBalance", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "UnclearBalance", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_DateAdded", System.Data.SqlDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DateAdded", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@CustomerId", System.Data.SqlDbType.BigInt, 8, "CustomerId")});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlConnection1;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_CustomerId", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerId", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CustomerTitleId", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerTitleId", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CustomerFirstName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerFirstName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_CustomerOtherInitials", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CustomerOtherInitials", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_CustomerOtherInitials", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerOtherInitials", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CustomerLastName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerLastName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_AddressId", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AddressId", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_AccountNumber", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AccountNumber", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_AccountTypeId", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AccountTypeId", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ClearBalance", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ClearBalance", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_UnclearBalance", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "UnclearBalance", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_DateAdded", System.Data.SqlDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DateAdded", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Customers", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("CustomerId", "CustomerId"),
                        new System.Data.Common.DataColumnMapping("CustomerTitleId", "CustomerTitleId"),
                        new System.Data.Common.DataColumnMapping("CustomerFirstName", "CustomerFirstName"),
                        new System.Data.Common.DataColumnMapping("CustomerOtherInitials", "CustomerOtherInitials"),
                        new System.Data.Common.DataColumnMapping("CustomerLastName", "CustomerLastName"),
                        new System.Data.Common.DataColumnMapping("AddressId", "AddressId"),
                        new System.Data.Common.DataColumnMapping("AccountNumber", "AccountNumber"),
                        new System.Data.Common.DataColumnMapping("AccountTypeId", "AccountTypeId"),
                        new System.Data.Common.DataColumnMapping("ClearBalance", "ClearBalance"),
                        new System.Data.Common.DataColumnMapping("UnclearBalance", "UnclearBalance"),
                        new System.Data.Common.DataColumnMapping("DateAdded", "DateAdded")})});
            this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
            this.sqlDataAdapter1.RowUpdated += new System.Data.SqlClient.SqlRowUpdatedEventHandler(this.sqlDataAdapter1_RowUpdated);
            this.sqlDataAdapter1.RowUpdating += new System.Data.SqlClient.SqlRowUpdatingEventHandler(this.sqlDataAdapter1_RowUpdating);
            this.sqlDataAdapter1.FillError += new System.Data.FillErrorEventHandler(this.sqlDataAdapter1_FillError);
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=DESKTOP-4A84H8M\\SQLEXPRESS;Initial Catalog=ApressFinancial;Integrated" +
    " Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // dataSetApressFinancial1
            // 
            this.dataSetApressFinancial1.DataSetName = "DataSetApressFinancial";
            this.dataSetApressFinancial1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(775, 232);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonSaveChange
            // 
            this.buttonSaveChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveChange.Location = new System.Drawing.Point(568, 261);
            this.buttonSaveChange.Name = "buttonSaveChange";
            this.buttonSaveChange.Size = new System.Drawing.Size(194, 63);
            this.buttonSaveChange.TabIndex = 1;
            this.buttonSaveChange.Text = "Save changes";
            this.buttonSaveChange.UseVisualStyleBackColor = true;
            this.buttonSaveChange.Click += new System.EventHandler(this.buttonSaveChange_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSaveChange);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetApressFinancial1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private DataSetApressFinancial dataSetApressFinancial1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonSaveChange;
    }
}

