using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkingDataTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridCustomerData.DataSource = dataSetApressFinancial21.Customers;
            dataGridCustomerData.MultiSelect = false;
            dataGridCustomerData.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridCustomerData.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void buttonFillTable_Click(object sender, EventArgs e)
        {
            sqlDataAdapter1.Fill(dataSetApressFinancial21.Customers);
        }

        private void buttonAddRow_Click(object sender, EventArgs e)
        {
            DataSetApressFinancial2.CustomersRow newRow = (DataSetApressFinancial2.CustomersRow)dataSetApressFinancial21.Customers.NewRow();

            newRow.CustomerTitleId = "3";
            newRow.CustomerFirstName = "Ben";
            newRow.CustomerLastName = "Davidson";
            newRow.AddressId = 231;
            newRow.AccountNumber = "SP1128004";
            newRow.ClearBalance = (decimal)34.25;
            newRow.UnclearBalance = 250;
            newRow.AccountTypeId = 1;
            newRow.DateAdded = DateTime.Today;
        
            try
            {
                dataSetApressFinancial21.Customers.Rows.Add(newRow);
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message, "Add Row failed");
            }
        }

        private DataSetApressFinancial2.CustomersRow GetSelectedRow()
        {
            string selectedCustomerId = dataGridCustomerData.CurrentRow.Cells["CustomerId"].Value.ToString();
            DataSetApressFinancial2.CustomersRow selectedRow = dataSetApressFinancial21.Customers.FindByCustomerId(Convert.ToInt64(selectedCustomerId));
            return selectedRow;
        }

        private void buttonDeleteRow_Click(object sender, EventArgs e)
        {
            GetSelectedRow().Delete();
        }

        private void UpdateRowVersionDisplay()
        {
            try
            {
                textBoxCurrentDRV.Text = GetSelectedRow()[dataGridCustomerData.CurrentCell.OwningColumn.Name, DataRowVersion.Current].ToString();
            }
            catch (Exception ex)
            {
                textBoxCurrentDRV.Text = ex.Message;
            }

            try
            {
                textBoxOriginalDRV.Text = GetSelectedRow()[dataGridCustomerData.CurrentCell.OwningColumn.Name, DataRowVersion.Original].ToString();
            }
            catch (Exception ex)
            {
                textBoxOriginalDRV.Text = ex.Message;
            }

            textBoxRowState.Text = GetSelectedRow().RowState.ToString();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            GetSelectedRow()[dataGridCustomerData.CurrentCell.OwningColumn.Name] = textBoxCellValue.Text;
            UpdateRowVersionDisplay();
        }

        private void dataGridCustomerData_Click(object sender, EventArgs e)
        {
            textBoxCellValue.Text = dataGridCustomerData.CurrentCell.Value.ToString();
            UpdateRowVersionDisplay();
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            GetSelectedRow().AcceptChanges();
            UpdateRowVersionDisplay();
        }

        private void buttonReject_Click(object sender, EventArgs e)
        {
            GetSelectedRow().RejectChanges();
            UpdateRowVersionDisplay();
        }
    }
}
