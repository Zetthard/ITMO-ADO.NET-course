using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SavingDataSetXML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonFill_Click(object sender, EventArgs e)
        {
            PersonDataAdapter.Fill(schoolDataSet1.Person);
            CourseDataAdapter.Fill(schoolDataSet1.Course);
            customerGrid.DataSource = schoolDataSet1.Person;
        }

        private void buttonSaveData_Click(object sender, EventArgs e)
        {
            try
            {
                schoolDataSet1.WriteXml("SchoolDataSet.xml");
                MessageBox.Show("XML file saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSaveSchema_Click(object sender, EventArgs e)
        {
            try
            {
                schoolDataSet1.WriteXmlSchema("School.xsd");
                MessageBox.Show("XML schema saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
