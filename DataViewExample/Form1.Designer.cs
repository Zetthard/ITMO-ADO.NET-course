
namespace DataViewExample
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
            this.dataGridViewCustomers = new System.Windows.Forms.DataGridView();
            this.textBoxSort = new System.Windows.Forms.TextBox();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.buttonSetDataViewProperties = new System.Windows.Forms.Button();
            this.buttonAddRow = new System.Windows.Forms.Button();
            this.apressFinancialDataSet1 = new DataViewExample.ApressFinancialDataSet();
            this.customersProductsTableAdapter1 = new DataViewExample.ApressFinancialDataSetTableAdapters.CustomersProductsTableAdapter();
            this.customersTableAdapter1 = new DataViewExample.ApressFinancialDataSetTableAdapters.CustomersTableAdapter();
            this.buttonGetOrders = new System.Windows.Forms.Button();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apressFinancialDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCustomers
            // 
            this.dataGridViewCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomers.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewCustomers.Name = "dataGridViewCustomers";
            this.dataGridViewCustomers.RowHeadersWidth = 82;
            this.dataGridViewCustomers.RowTemplate.Height = 33;
            this.dataGridViewCustomers.Size = new System.Drawing.Size(452, 406);
            this.dataGridViewCustomers.TabIndex = 0;
            // 
            // textBoxSort
            // 
            this.textBoxSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSort.Location = new System.Drawing.Point(496, 42);
            this.textBoxSort.Name = "textBoxSort";
            this.textBoxSort.Size = new System.Drawing.Size(216, 31);
            this.textBoxSort.TabIndex = 1;
            this.textBoxSort.Text = "CustomerID";
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFilter.Location = new System.Drawing.Point(496, 110);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(216, 31);
            this.textBoxFilter.TabIndex = 2;
            this.textBoxFilter.Text = "CustomerTitleId = \"1\"";
            // 
            // buttonSetDataViewProperties
            // 
            this.buttonSetDataViewProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSetDataViewProperties.Location = new System.Drawing.Point(496, 178);
            this.buttonSetDataViewProperties.Name = "buttonSetDataViewProperties";
            this.buttonSetDataViewProperties.Size = new System.Drawing.Size(216, 59);
            this.buttonSetDataViewProperties.TabIndex = 3;
            this.buttonSetDataViewProperties.Text = "Set Data View Properties";
            this.buttonSetDataViewProperties.UseVisualStyleBackColor = true;
            this.buttonSetDataViewProperties.Click += new System.EventHandler(this.buttonSetDataViewProperties_Click);
            // 
            // buttonAddRow
            // 
            this.buttonAddRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddRow.Location = new System.Drawing.Point(496, 277);
            this.buttonAddRow.Name = "buttonAddRow";
            this.buttonAddRow.Size = new System.Drawing.Size(216, 54);
            this.buttonAddRow.TabIndex = 4;
            this.buttonAddRow.Text = "Add Row";
            this.buttonAddRow.UseVisualStyleBackColor = true;
            this.buttonAddRow.Click += new System.EventHandler(this.buttonAddRow_Click);
            // 
            // apressFinancialDataSet1
            // 
            this.apressFinancialDataSet1.DataSetName = "ApressFinancialDataSet";
            this.apressFinancialDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersProductsTableAdapter1
            // 
            this.customersProductsTableAdapter1.ClearBeforeFill = true;
            // 
            // customersTableAdapter1
            // 
            this.customersTableAdapter1.ClearBeforeFill = true;
            // 
            // buttonGetOrders
            // 
            this.buttonGetOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGetOrders.Location = new System.Drawing.Point(496, 501);
            this.buttonGetOrders.Name = "buttonGetOrders";
            this.buttonGetOrders.Size = new System.Drawing.Size(153, 54);
            this.buttonGetOrders.TabIndex = 5;
            this.buttonGetOrders.Text = "Get Products";
            this.buttonGetOrders.UseVisualStyleBackColor = true;
            this.buttonGetOrders.Click += new System.EventHandler(this.buttonGetOrders_Click);
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Location = new System.Drawing.Point(12, 482);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.RowHeadersWidth = 82;
            this.dataGridViewOrders.RowTemplate.Height = 33;
            this.dataGridViewOrders.Size = new System.Drawing.Size(452, 253);
            this.dataGridViewOrders.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 758);
            this.Controls.Add(this.dataGridViewOrders);
            this.Controls.Add(this.buttonGetOrders);
            this.Controls.Add(this.buttonAddRow);
            this.Controls.Add(this.buttonSetDataViewProperties);
            this.Controls.Add(this.textBoxFilter);
            this.Controls.Add(this.textBoxSort);
            this.Controls.Add(this.dataGridViewCustomers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apressFinancialDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCustomers;
        private System.Windows.Forms.TextBox textBoxSort;
        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.Button buttonSetDataViewProperties;
        private System.Windows.Forms.Button buttonAddRow;
        private ApressFinancialDataSet apressFinancialDataSet1;
        private ApressFinancialDataSetTableAdapters.CustomersProductsTableAdapter customersProductsTableAdapter1;
        private ApressFinancialDataSetTableAdapters.CustomersTableAdapter customersTableAdapter1;
        private System.Windows.Forms.Button buttonGetOrders;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
    }
}

