using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBindingComplex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonBindGrid_Click(object sender, EventArgs e)
        {
            financialProductsTableAdapter1.Fill(apressFinancialDataSet1.FinancialProducts);
            BindingSource productsBindingSource = new BindingSource(apressFinancialDataSet1, "FinancialProducts");
            dataGridProducts.DataSource = productsBindingSource;
            bindingNavigator1.BindingSource = productsBindingSource;
        }
    }
}
