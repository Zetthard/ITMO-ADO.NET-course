using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataViewExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataView customersProductDataView;
        DataView customersDataView;

        private void Form1_Load(object sender, EventArgs e)
        {
            customersProductsTableAdapter1.Fill(apressFinancialDataSet1.CustomersProducts);
            customersTableAdapter1.Fill(apressFinancialDataSet1.Customers);

            customersDataView = new DataView(apressFinancialDataSet1.Customers);
            customersProductDataView = new DataView(apressFinancialDataSet1.CustomersProducts);
            customersDataView.Sort = "CustomerId";
            dataGridViewCustomers.DataSource = customersDataView;
        }

        private void buttonSetDataViewProperties_Click(object sender, EventArgs e)
        {
            customersDataView.Sort = textBoxSort.Text;
            customersDataView.RowFilter = textBoxFilter.Text;
        }

        private void buttonAddRow_Click(object sender, EventArgs e)
        {
            DataRowView newCustomerRow = customersDataView.AddNew();
            newCustomerRow["CustomerTitleId"] = "2";
            newCustomerRow["CustomerFirstName"] = "Marta";
            newCustomerRow["CustomerLastName"] = "Korabelova";
            newCustomerRow["AddressId"] = 4212;
            newCustomerRow["AccountNumber"] = "SP1128105";
            newCustomerRow["ClearBalance"] = (decimal)76.05;
            newCustomerRow["UnclearBalance"] = 375.50;
            newCustomerRow["AccountTypeId"] = 1;
            newCustomerRow["DateAdded"] = DateTime.Today;
            newCustomerRow.EndEdit();
        }

        private void buttonGetOrders_Click(object sender, EventArgs e)
        {
            string selectCustomerId = Convert.ToString(dataGridViewCustomers.SelectedCells[0].OwningRow.Cells["CustomerId"].Value);

            DataRowView selectedRow = customersDataView[customersDataView.Find(selectCustomerId)];
            customersProductDataView = selectedRow.CreateChildView(apressFinancialDataSet1.Relations["Customers_CustomersProducts"]);
            dataGridViewOrders.DataSource = customersProductDataView;
        }
    }
}
