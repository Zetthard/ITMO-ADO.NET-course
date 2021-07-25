using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreatingDataTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private DataTable customersTable = new DataTable("Customers");

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = customersTable;
            customersTable.Columns.Add("CustomerID", Type.GetType("System.String"));
            customersTable.Columns.Add("CompanyName", Type.GetType("System.String"));
            customersTable.Columns.Add("ContactName", Type.GetType("System.String"));
            customersTable.Columns.Add("ContactTitle", Type.GetType("System.String"));
            customersTable.Columns.Add("Address", Type.GetType("System.String"));
            customersTable.Columns.Add("City", Type.GetType("System.String"));
            customersTable.Columns.Add("Country", Type.GetType("System.String"));
            customersTable.Columns.Add("Phone", Type.GetType("System.String"));

            DataColumn[] keyColumns = new DataColumn[1];
            keyColumns[0] = customersTable.Columns["CustomerID"];
            customersTable.PrimaryKey = keyColumns;

            customersTable.Columns["CustomerID"].AllowDBNull = false;
            customersTable.Columns["CompanyName"].AllowDBNull = false;
        }

        private void buttonAddRow_Click(object sender, EventArgs e)
        {
            DataRow customerRow1 = customersTable.NewRow();
            object[] CustRecord =  {"ALFKI", "Alfreds Futterkiste", "Maria Anders",
                "Sales Representative", "Obere Str. 57", "Berlin", "Germany", "030-0074321"};

            customerRow1.ItemArray = CustRecord;
            customersTable.Rows.Add(customerRow1);
        }
    }
}
