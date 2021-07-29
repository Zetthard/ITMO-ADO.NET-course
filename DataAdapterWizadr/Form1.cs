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

namespace DataAdapterWizadr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dataSetApressFinancial1.Customers;
            sqlDataAdapter1.Fill(dataSetApressFinancial1.Customers);
        }

        private void buttonSaveChange_Click(object sender, EventArgs e)
        {
            sqlDataAdapter1.Update(dataSetApressFinancial1);
        }

        private void sqlDataAdapter1_RowUpdating(object sender, SqlRowUpdatingEventArgs e)
        {
            DataSetApressFinancial.CustomersRow custRow = (DataSetApressFinancial.CustomersRow)e.Row;
            DialogResult response = MessageBox.Show("Continue updating " + custRow.CustomerId.ToString() + "?", "Continue update?", MessageBoxButtons.YesNo);

            if (response == DialogResult.No)
                e.Status = UpdateStatus.SkipCurrentRow;
        }

        private void sqlDataAdapter1_RowUpdated(object sender, SqlRowUpdatedEventArgs e)
        {
            DataSetApressFinancial.CustomersRow custRow = (DataSetApressFinancial.CustomersRow)e.Row;
            MessageBox.Show(custRow.CustomerId.ToString() + " has been updated");
            dataSetApressFinancial1.Customers.Clear();
            sqlDataAdapter1.Fill(dataSetApressFinancial1.Customers);
        }

        private void sqlDataAdapter1_FillError(object sender, FillErrorEventArgs e)
        {
            DialogResult errorResponse = MessageBox.Show("The following error has occured while filling the Dataset: " 
                + e.Errors.Message.ToString() + "Continue trying to fill?", "Fill Error", MessageBoxButtons.YesNo);

            if (errorResponse == DialogResult.Yes)
                e.Continue = true;
            else
                e.Continue = false;
        }
    }
}
