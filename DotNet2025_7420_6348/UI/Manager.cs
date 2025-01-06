using BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void customerButtton_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers();
            customers.ShowDialog();
        }
        //private void Manager_Load(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        private void salesButton_Click(object sender, EventArgs e)
        {
            Sales sales = new Sales();
            sales.ShowDialog();
        }

        private void productsButton_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            Products products = new Products(product);
            products.ShowDialog();
        }
    }
}
