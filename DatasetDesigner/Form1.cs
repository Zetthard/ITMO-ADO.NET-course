using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatasetDesigner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGetCustomers_Click(object sender, EventArgs e)
        {
            ApressFinDataSet apressFinDataSet1 = new ApressFinDataSet();
            ApressFinDataSetTableAdapters.CustomersTableAdapter customersTableAdapter1 = 
                new ApressFinDataSetTableAdapters.CustomersTableAdapter();
            customersTableAdapter1.Fill(apressFinDataSet1.Customers);
            
            foreach (ApressFinDataSet.CustomersRow customersRow in apressFinDataSet1.Customers.Rows)
            {
                listBoxGetCustomers.Items.Add(customersRow.CustomerFirstName + " " + customersRow.CustomerLastName);
            }
        }
    }
}
