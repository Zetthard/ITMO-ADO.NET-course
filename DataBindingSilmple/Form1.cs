using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBindingSilmple
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private BindingSource productsBingingSource;

        private void Form1_Load(object sender, EventArgs e)
        {
            customersProductsTableAdapter1.Fill(apressFinancialDataSet1.CustomersProducts);
            productsBingingSource = new BindingSource(apressFinancialDataSet1, "CustomersProducts");

            textBoxProductId.DataBindings.Add("Text", productsBingingSource, "CustomerFinancialProductId");
            textBoxProductName.DataBindings.Add("Text", productsBingingSource, "AmountToCollect");
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            productsBingingSource.MovePrevious();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            productsBingingSource.MoveNext();
        }
    }
}
