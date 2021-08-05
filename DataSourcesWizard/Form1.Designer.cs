
namespace DataSourcesWizard
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.apressFinancialDataSet = new DataSourcesWizard.ApressFinancialDataSet();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new DataSourcesWizard.ApressFinancialDataSetTableAdapters.CustomersTableAdapter();
            this.customerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerTitleIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerOtherInitialsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountTypeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clearBalanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unclearBalanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAddedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apressFinancialDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIdDataGridViewTextBoxColumn,
            this.customerTitleIdDataGridViewTextBoxColumn,
            this.customerFirstNameDataGridViewTextBoxColumn,
            this.customerOtherInitialsDataGridViewTextBoxColumn,
            this.customerLastNameDataGridViewTextBoxColumn,
            this.addressIdDataGridViewTextBoxColumn,
            this.accountNumberDataGridViewTextBoxColumn,
            this.accountTypeIdDataGridViewTextBoxColumn,
            this.clearBalanceDataGridViewTextBoxColumn,
            this.unclearBalanceDataGridViewTextBoxColumn,
            this.dateAddedDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(14, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(774, 432);
            this.dataGridView1.TabIndex = 0;
            // 
            // apressFinancialDataSet
            // 
            this.apressFinancialDataSet.DataSetName = "ApressFinancialDataSet";
            this.apressFinancialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.apressFinancialDataSet;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // customerIdDataGridViewTextBoxColumn
            // 
            this.customerIdDataGridViewTextBoxColumn.DataPropertyName = "CustomerId";
            this.customerIdDataGridViewTextBoxColumn.HeaderText = "CustomerId";
            this.customerIdDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.customerIdDataGridViewTextBoxColumn.Name = "customerIdDataGridViewTextBoxColumn";
            this.customerIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerIdDataGridViewTextBoxColumn.Width = 200;
            // 
            // customerTitleIdDataGridViewTextBoxColumn
            // 
            this.customerTitleIdDataGridViewTextBoxColumn.DataPropertyName = "CustomerTitleId";
            this.customerTitleIdDataGridViewTextBoxColumn.HeaderText = "CustomerTitleId";
            this.customerTitleIdDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.customerTitleIdDataGridViewTextBoxColumn.Name = "customerTitleIdDataGridViewTextBoxColumn";
            this.customerTitleIdDataGridViewTextBoxColumn.Width = 200;
            // 
            // customerFirstNameDataGridViewTextBoxColumn
            // 
            this.customerFirstNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerFirstName";
            this.customerFirstNameDataGridViewTextBoxColumn.HeaderText = "CustomerFirstName";
            this.customerFirstNameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.customerFirstNameDataGridViewTextBoxColumn.Name = "customerFirstNameDataGridViewTextBoxColumn";
            this.customerFirstNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // customerOtherInitialsDataGridViewTextBoxColumn
            // 
            this.customerOtherInitialsDataGridViewTextBoxColumn.DataPropertyName = "CustomerOtherInitials";
            this.customerOtherInitialsDataGridViewTextBoxColumn.HeaderText = "CustomerOtherInitials";
            this.customerOtherInitialsDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.customerOtherInitialsDataGridViewTextBoxColumn.Name = "customerOtherInitialsDataGridViewTextBoxColumn";
            this.customerOtherInitialsDataGridViewTextBoxColumn.Width = 200;
            // 
            // customerLastNameDataGridViewTextBoxColumn
            // 
            this.customerLastNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerLastName";
            this.customerLastNameDataGridViewTextBoxColumn.HeaderText = "CustomerLastName";
            this.customerLastNameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.customerLastNameDataGridViewTextBoxColumn.Name = "customerLastNameDataGridViewTextBoxColumn";
            this.customerLastNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // addressIdDataGridViewTextBoxColumn
            // 
            this.addressIdDataGridViewTextBoxColumn.DataPropertyName = "AddressId";
            this.addressIdDataGridViewTextBoxColumn.HeaderText = "AddressId";
            this.addressIdDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.addressIdDataGridViewTextBoxColumn.Name = "addressIdDataGridViewTextBoxColumn";
            this.addressIdDataGridViewTextBoxColumn.Width = 200;
            // 
            // accountNumberDataGridViewTextBoxColumn
            // 
            this.accountNumberDataGridViewTextBoxColumn.DataPropertyName = "AccountNumber";
            this.accountNumberDataGridViewTextBoxColumn.HeaderText = "AccountNumber";
            this.accountNumberDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.accountNumberDataGridViewTextBoxColumn.Name = "accountNumberDataGridViewTextBoxColumn";
            this.accountNumberDataGridViewTextBoxColumn.Width = 200;
            // 
            // accountTypeIdDataGridViewTextBoxColumn
            // 
            this.accountTypeIdDataGridViewTextBoxColumn.DataPropertyName = "AccountTypeId";
            this.accountTypeIdDataGridViewTextBoxColumn.HeaderText = "AccountTypeId";
            this.accountTypeIdDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.accountTypeIdDataGridViewTextBoxColumn.Name = "accountTypeIdDataGridViewTextBoxColumn";
            this.accountTypeIdDataGridViewTextBoxColumn.Width = 200;
            // 
            // clearBalanceDataGridViewTextBoxColumn
            // 
            this.clearBalanceDataGridViewTextBoxColumn.DataPropertyName = "ClearBalance";
            this.clearBalanceDataGridViewTextBoxColumn.HeaderText = "ClearBalance";
            this.clearBalanceDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.clearBalanceDataGridViewTextBoxColumn.Name = "clearBalanceDataGridViewTextBoxColumn";
            this.clearBalanceDataGridViewTextBoxColumn.Width = 200;
            // 
            // unclearBalanceDataGridViewTextBoxColumn
            // 
            this.unclearBalanceDataGridViewTextBoxColumn.DataPropertyName = "UnclearBalance";
            this.unclearBalanceDataGridViewTextBoxColumn.HeaderText = "UnclearBalance";
            this.unclearBalanceDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.unclearBalanceDataGridViewTextBoxColumn.Name = "unclearBalanceDataGridViewTextBoxColumn";
            this.unclearBalanceDataGridViewTextBoxColumn.Width = 200;
            // 
            // dateAddedDataGridViewTextBoxColumn
            // 
            this.dateAddedDataGridViewTextBoxColumn.DataPropertyName = "DateAdded";
            this.dateAddedDataGridViewTextBoxColumn.HeaderText = "DateAdded";
            this.dateAddedDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.dateAddedDataGridViewTextBoxColumn.Name = "dateAddedDataGridViewTextBoxColumn";
            this.dateAddedDataGridViewTextBoxColumn.Width = 200;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apressFinancialDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ApressFinancialDataSet apressFinancialDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private ApressFinancialDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerTitleIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerOtherInitialsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountTypeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clearBalanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unclearBalanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAddedDataGridViewTextBoxColumn;
    }
}

