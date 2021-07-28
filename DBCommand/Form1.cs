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

        private void buttonProcedure_Click(object sender, EventArgs e)
        {
            StringBuilder results = new StringBuilder();
            sqlCommandProcedure.CommandType = CommandType.StoredProcedure;
            sqlCommandProcedure.CommandText = "CustomerDetails.sp_GetCustomersWithPositiveBal";
            sqlConnection1.Open();

            SqlDataReader reader = sqlCommandProcedure.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    results.Append(reader[i].ToString() + "\t");
                }
                results.Append(Environment.NewLine);
            }
            reader.Close();
            sqlCommandProcedure.Connection.Close();
            textBoxResults.Text = results.ToString();
        }

        private void buttonNewTable_Click(object sender, EventArgs e)
        {
            sqlCommandNewTable.CommandText = "CREATE TABLE [ShareDetails].[ShareTypes]" +
                "([TypeId][bigint] IDENTITY(1, 1) NOT NULL, [TypeDecs] [nvarchar](50) NOT NULL)";
            sqlConnection1.Open();
            bool exCaught = false;
            try
            {
                sqlCommandNewTable.ExecuteNonQuery();
            }
            catch (SqlException sqlex)
            {
                exCaught = true;
                MessageBox.Show(sqlex.Message);
            }
            finally
            {
                sqlConnection1.Close();
            }
            if (!exCaught)
                MessageBox.Show("Table has been created");
        }

        private void buttonGetWithParam_Click(object sender, EventArgs e)
        {
            StringBuilder results = new StringBuilder();
            sqlCommandWithParam.CommandType = CommandType.Text;
            sqlCommandWithParam.Parameters["@titleId"].Value = textBoxParam.Text;
            sqlCommandWithParam.CommandText = "SELECT CustomerId, CustomerFirstName, CustomerLastName " +
                "FROM CustomerDetails.Customers WHERE CustomerTitleId = @titleId";
            sqlCommandWithParam.Connection.Open();

            SqlDataReader reader = sqlCommandWithParam.ExecuteReader();
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

        private void buttonParamProcedure_Click(object sender, EventArgs e)
        {
            sqlCommandParamProcedure.CommandType = CommandType.StoredProcedure;
            sqlCommandParamProcedure.Parameters["@decs"].Value = textBoxShareDecs.Text;
            sqlCommandParamProcedure.Parameters["@tickerId"].Value = textBoxTickerId.Text;
            sqlCommandParamProcedure.Parameters["@currentPrice"].Value = Convert.ToDecimal(textBoxCurrPrice.Text);
            sqlCommandParamProcedure.Connection.Open();
            bool exCaught = false;
            try
            {
                sqlCommandParamProcedure.ExecuteNonQuery();
            }
            catch (SqlException sqlex)
            {
                exCaught = true;
                MessageBox.Show(sqlex.Message);
            }
            finally
            {
                sqlCommandParamProcedure.Connection.Close();
            }
            if (!exCaught)
                MessageBox.Show("New Share has been added");
        }
    }
}
