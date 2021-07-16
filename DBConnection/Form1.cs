using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using System.Data.OleDb;

namespace DBConnection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection connection1 = new OleDbConnection();
        string testConnect = @"Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=ApressFinancial;Data Source=DESKTOP-4A84H8M\SQLEXPRESS";

        private void MenuItemDBConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection1.State != ConnectionState.Open)
                {
                    connection1.ConnectionString = testConnect;
                    connection1.Open();
                    MessageBox.Show("Connection to database has been establised successfully");
                }
                else
                    MessageBox.Show("Connection to database is already active");
            }
            catch
            {
                MessageBox.Show("Failed to connect to database");
            }
        }

        private void MenuItemDBDisconnect_Click(object sender, EventArgs e)
        {
            if (connection1.State == ConnectionState.Open)
            {
                connection1.Close();
                MessageBox.Show("Connection to database is closed");
            }
            else
                MessageBox.Show("Connection to database is already closed");
        }
    }
}
