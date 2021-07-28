using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBCommand
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGetData_Click(object sender, EventArgs e)
        {
            StringBuilder results = new StringBuilder();
            sqlCommand1.CommandType = CommandType.Text;
            sqlConnection1.Open();

            SqlDataReader reader = sqlCommand1.ExecuteReader();
            bool moreResults = false;
            do
            {
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                        results.Append(reader[i].ToString() + "\t");
                    results.Append(Environment.NewLine);
                }
                moreResults = reader.NextResult();
            }
            while (moreResults);

            reader.Close();
            sqlCommand1.Connection.Close();
            textBoxResults.Text = results.ToString();
        }
    }
}
