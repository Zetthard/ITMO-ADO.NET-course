
namespace WorkingDataTable
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
            this.dataGridCustomerData = new System.Windows.Forms.DataGridView();
            this.buttonFillTable = new System.Windows.Forms.Button();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.buttonAddRow = new System.Windows.Forms.Button();
            this.buttonDeleteRow = new System.Windows.Forms.Button();
            this.textBoxCellValue = new System.Windows.Forms.TextBox();
            this.textBoxOriginalDRV = new System.Windows.Forms.TextBox();
            this.textBoxRowState = new System.Windows.Forms.TextBox();
            this.textBoxCurrentDRV = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.buttonReject = new System.Windows.Forms.Button();
            this.dataSetApressFinancial21 = new WorkingDataTable.DataSetApressFinancial2();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomerData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetApressFinancial21)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridCustomerData
            // 
            this.dataGridCustomerData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridCustomerData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCustomerData.Location = new System.Drawing.Point(14, 13);
            this.dataGridCustomerData.Name = "dataGridCustomerData";
            this.dataGridCustomerData.RowHeadersWidth = 82;
            this.dataGridCustomerData.RowTemplate.Height = 33;
            this.dataGridCustomerData.Size = new System.Drawing.Size(772, 284);
            this.dataGridCustomerData.TabIndex = 0;
            this.dataGridCustomerData.Click += new System.EventHandler(this.dataGridCustomerData_Click);
            // 
            // buttonFillTable
            // 
            this.buttonFillTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonFillTable.Location = new System.Drawing.Point(23, 330);
            this.buttonFillTable.Name = "buttonFillTable";
            this.buttonFillTable.Size = new System.Drawing.Size(183, 55);
            this.buttonFillTable.TabIndex = 1;
            this.buttonFillTable.Text = "Fill Table";
            this.buttonFillTable.UseVisualStyleBackColor = true;
            this.buttonFillTable.Click += new System.EventHandler(this.buttonFillTable_Click);
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
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=DESKTOP-4A84H8M\\SQLEXPRESS;Initial Catalog=ApressFinancial;Integrated" +
    " Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // buttonAddRow
            // 
            this.buttonAddRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddRow.Location = new System.Drawing.Point(431, 330);
            this.buttonAddRow.Name = "buttonAddRow";
            this.buttonAddRow.Size = new System.Drawing.Size(160, 55);
            this.buttonAddRow.TabIndex = 2;
            this.buttonAddRow.Text = "Add Row";
            this.buttonAddRow.UseVisualStyleBackColor = true;
            this.buttonAddRow.Click += new System.EventHandler(this.buttonAddRow_Click);
            // 
            // buttonDeleteRow
            // 
            this.buttonDeleteRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteRow.Location = new System.Drawing.Point(621, 330);
            this.buttonDeleteRow.Name = "buttonDeleteRow";
            this.buttonDeleteRow.Size = new System.Drawing.Size(160, 55);
            this.buttonDeleteRow.TabIndex = 3;
            this.buttonDeleteRow.Text = "Delete Row";
            this.buttonDeleteRow.UseVisualStyleBackColor = true;
            this.buttonDeleteRow.Click += new System.EventHandler(this.buttonDeleteRow_Click);
            // 
            // textBoxCellValue
            // 
            this.textBoxCellValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxCellValue.Location = new System.Drawing.Point(25, 441);
            this.textBoxCellValue.Name = "textBoxCellValue";
            this.textBoxCellValue.Size = new System.Drawing.Size(154, 31);
            this.textBoxCellValue.TabIndex = 4;
            // 
            // textBoxOriginalDRV
            // 
            this.textBoxOriginalDRV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxOriginalDRV.Location = new System.Drawing.Point(222, 441);
            this.textBoxOriginalDRV.Name = "textBoxOriginalDRV";
            this.textBoxOriginalDRV.Size = new System.Drawing.Size(154, 31);
            this.textBoxOriginalDRV.TabIndex = 5;
            // 
            // textBoxRowState
            // 
            this.textBoxRowState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxRowState.Location = new System.Drawing.Point(25, 492);
            this.textBoxRowState.Name = "textBoxRowState";
            this.textBoxRowState.Size = new System.Drawing.Size(154, 31);
            this.textBoxRowState.TabIndex = 6;
            // 
            // textBoxCurrentDRV
            // 
            this.textBoxCurrentDRV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxCurrentDRV.Location = new System.Drawing.Point(222, 492);
            this.textBoxCurrentDRV.Name = "textBoxCurrentDRV";
            this.textBoxCurrentDRV.Size = new System.Drawing.Size(154, 31);
            this.textBoxCurrentDRV.TabIndex = 7;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUpdate.Location = new System.Drawing.Point(431, 439);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(160, 45);
            this.buttonUpdate.TabIndex = 8;
            this.buttonUpdate.Text = "Update Value";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonAccept
            // 
            this.buttonAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAccept.Location = new System.Drawing.Point(626, 439);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(160, 45);
            this.buttonAccept.TabIndex = 9;
            this.buttonAccept.Text = "Accept";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // buttonReject
            // 
            this.buttonReject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReject.Location = new System.Drawing.Point(626, 501);
            this.buttonReject.Name = "buttonReject";
            this.buttonReject.Size = new System.Drawing.Size(160, 45);
            this.buttonReject.TabIndex = 10;
            this.buttonReject.Text = "Reject";
            this.buttonReject.UseVisualStyleBackColor = true;
            this.buttonReject.Click += new System.EventHandler(this.buttonReject_Click);
            // 
            // dataSetApressFinancial21
            // 
            this.dataSetApressFinancial21.DataSetName = "DataSetApressFinancial2";
            this.dataSetApressFinancial21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 557);
            this.Controls.Add(this.buttonReject);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.textBoxCurrentDRV);
            this.Controls.Add(this.textBoxRowState);
            this.Controls.Add(this.textBoxOriginalDRV);
            this.Controls.Add(this.textBoxCellValue);
            this.Controls.Add(this.buttonDeleteRow);
            this.Controls.Add(this.buttonAddRow);
            this.Controls.Add(this.buttonFillTable);
            this.Controls.Add(this.dataGridCustomerData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomerData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetApressFinancial21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridCustomerData;
        private System.Windows.Forms.Button buttonFillTable;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private DataSetApressFinancial2 dataSetApressFinancial21;
        private System.Windows.Forms.Button buttonAddRow;
        private System.Windows.Forms.Button buttonDeleteRow;
        private System.Windows.Forms.TextBox textBoxCellValue;
        private System.Windows.Forms.TextBox textBoxOriginalDRV;
        private System.Windows.Forms.TextBox textBoxRowState;
        private System.Windows.Forms.TextBox textBoxCurrentDRV;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.Button buttonReject;
    }
}

