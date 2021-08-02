using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using CodeFirst;

namespace CustomerManager
{
    public partial class CustomerViewer : Form
    {
        public CustomerViewer()
        {
            InitializeComponent();
        }

        SampleContext context = new SampleContext();

        byte[] photo;

        private void buttonAddData_Click(object sender, EventArgs e)
        {
            try
            {
                Customer customer = new Customer
                {
                    Name = textBoxFirstName.Text, // + " " + textBoxLastName.Text
                    Email = textBoxAddress.Text,
                    Age = Int32.Parse(textBoxAge.Text),
                    Photo = photo,
                    Orders = listBoxOrderList.SelectedItems.OfType<Order>().ToList()
                };
                context.Customers.Add(customer);
                context.SaveChanges();
                Output();
                textBoxFirstName.Text = String.Empty;
                textBoxLastName.Text = String.Empty;
                textBoxAddress.Text = String.Empty;
                textBoxAge.Text = String.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.ToString());
            }
        }

        private void buttonChooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Image bm = new Bitmap(dialog.OpenFile());

                ImageConverter converter = new ImageConverter();
                photo = (byte[])converter.ConvertTo(bm, typeof(byte[]));
            }
        }

        private void Output()
        {
            if (radioButtonCustomers.Checked == true)
                dataGridViewData.DataSource = context.Customers.ToList();
            else if (radioButtonOrders.Checked == true)
                dataGridViewData.DataSource = context.Orders.ToList();
        }

        private void buttonShowData_Click(object sender, EventArgs e)
        {
            Output();
            var query = from b in context.Customers
                        orderby b.Name
                        select b;
            comboBoxCustomerList.DataSource = query.ToList();
            listBoxOrderList.DataSource = context.Orders.ToList();
        }

        private void CustomerViewer_Load(object sender, EventArgs e)
        {
            context.Orders.Add(new Order { ProductName = "Аудио", Quantity = 12, PurchaseDate = DateTime.Parse("12.01.2016") });
            context.Orders.Add(new Order { ProductName = "Видео", Quantity = 22, PurchaseDate = DateTime.Parse("10.01.2016") });
            context.SaveChanges();
        }
    }
}
