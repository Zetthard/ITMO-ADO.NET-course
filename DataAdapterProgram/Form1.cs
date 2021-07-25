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

namespace DataAdapterProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private SqlConnection apressConnection = 
            new SqlConnection(@"Data Source=DESKTOP-4A84H8M\SQLEXPRESS;Initial Catalog=ApressFinancial;Integrated Security=True");

        private SqlDataAdapter sqlDataAdapter1;
        private DataSet apFinDataSet = new DataSet("ApressFinancial");
        private DataTable customersTable = new DataTable("Customers");

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlDataAdapter1 = new SqlDataAdapter("SELECT * FROM [CustomerDetails].[Customers]", apressConnection);
            apFinDataSet.Tables.Add(customersTable);
            sqlDataAdapter1.Fill(apFinDataSet.Tables["Customers"]);
            dataGridView1.DataSource = apFinDataSet.Tables["Customers"];

            SqlCommandBuilder commands = new SqlCommandBuilder(sqlDataAdapter1);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            apFinDataSet.EndInit();
            sqlDataAdapter1.Update(apFinDataSet.Tables["Customers"]);
        }
    }
}
