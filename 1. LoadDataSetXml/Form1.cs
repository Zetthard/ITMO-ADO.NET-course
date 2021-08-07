using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1.LoadDataSetXml
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataSet schoolDataSet = new DataSet();

        private void buttonLoadSchema_Click(object sender, EventArgs e)
        {
            schoolDataSet.ReadXmlSchema("School.xsd");
            personGrid.DataSource = schoolDataSet.Tables["Person"];
            courseGrid.DataSource = schoolDataSet.Tables["Course"];
        }

        private void buttonLoadData_Click(object sender, EventArgs e)
        {
            schoolDataSet.ReadXml("SchoolDataSet.xml");
        }
    }
}
