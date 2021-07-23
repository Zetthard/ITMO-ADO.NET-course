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
using System.Data.SqlClient;
using System.Configuration;

namespace DBConnection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.connection1.StateChange += new StateChangeEventHandler(this.connection_StateChange);
        }

        OleDbConnection connection1 = new OleDbConnection(); // its better to wrap in using operator
        // string testConnect = @"Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=ApressFinancial;Data Source=DESKTOP-4A84H8M\SQLEXPRESS";

        static string GetConnectionStringByName(string name)
        {
            string returnValue = null;
            ConnectionStringSettings settings =
                ConfigurationManager.ConnectionStrings[name];
            if (settings != null)
                returnValue = settings.ConnectionString;
            return returnValue;
        }

        string testConnect = GetConnectionStringByName("DBConnect.ApressConnectionString");

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
            catch (OleDbException XcpSQL)
            {
                foreach (OleDbError se in XcpSQL.Errors)
                {
                    MessageBox.Show(se.Message, "SQL Error code " + se.NativeError, 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception Xcp)
            {
                MessageBox.Show(Xcp.Message, "Unexpected exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void connection_StateChange(object sender, System.Data.StateChangeEventArgs e)
        {
            MenuItemDBConnect.Enabled =
                (e.CurrentState == ConnectionState.Closed);
            MenuItemDBDisconnect.Enabled =
                (e.CurrentState == ConnectionState.Open);
        }

        private void MenuItemConnectionsList_Click(object sender, EventArgs e)
        {
            ConnectionStringSettings myConStr = new ConnectionStringSettings();
            ConnectionStringSettingsCollection settings = ConfigurationManager.ConnectionStrings;
            
            if (settings != null)
            {
                foreach (ConnectionStringSettings css in settings)
                {
                    MessageBox.Show("name = " + css.Name);
                    MessageBox.Show("providerName = " + css.ProviderName);
                    MessageBox.Show("connectionString = " + css.ConnectionString);
                }
            }
        }
    }
}
