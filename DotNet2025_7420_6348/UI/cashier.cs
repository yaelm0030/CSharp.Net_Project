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
    public partial class Cashier : Form
    {
        private BO.Order order;
        public Cashier()
        {
            InitializeComponent();
        }

        private void createANewOrder(object sender, EventArgs e)
        {
            order = new BO.Order(clubCustomerCheckbox.Checked,new List<BO.ProductInOrder>(),0);
            OrderForm orderForm= new OrderForm(order);
            orderForm.ShowDialog();
        }
    }
}
