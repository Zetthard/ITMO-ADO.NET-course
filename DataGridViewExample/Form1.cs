using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'schoolDataSet.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.schoolDataSet.Course);
            DataColumn location = new DataColumn("Location");
            location.Expression = "Credits + ',' + DepartmentId";
            schoolDataSet.Course.Columns.Add(location);
        }

        private void buttonAddColumn_Click(object sender, EventArgs e)
        {
            DataGridViewTextBoxColumn locationColumn = new DataGridViewTextBoxColumn();
            locationColumn.Name = "LocationColumn";
            locationColumn.HeaderText = "Location";
            locationColumn.DataPropertyName = "Location";
            dataGridView1.Columns.Add(locationColumn);
        }

        private void buttonDeleteColumn_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Columns.Remove("LocationColumn");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonGetCell_Click(object sender, EventArgs e)
        {
            string currentCellInfo;
            currentCellInfo = dataGridView1.CurrentCell.Value.ToString() + "; ";
            currentCellInfo += "Column: " + dataGridView1.CurrentCell.OwningColumn.DataPropertyName + "; ";
            currentCellInfo += "Column Index: " + dataGridView1.CurrentCell.ColumnIndex.ToString() + "; ";
            currentCellInfo += "Row Index: " + dataGridView1.CurrentCell.RowIndex.ToString();
            label1.Text = currentCellInfo;
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].DataPropertyName == "Title")
            {
                if (e.FormattedValue.ToString() == "")
                {
                    dataGridView1.Rows[e.RowIndex].ErrorText = "Title is a required field";
                    e.Cancel = true;
                }
                else
                    dataGridView1.Rows[e.RowIndex].ErrorText = "";
            }
        }

        private void buttonApplyStyle_Click(object sender, EventArgs e)
        {
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
        }
    }
}
