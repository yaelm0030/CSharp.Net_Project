using BlApi;
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
    public partial class Customers : Form
    {
        IBl _ibl = Factory.Get();
        private Customer customer;

        public Customers()
        {
            InitializeComponent();
        }

        public Customers(Customer customer)
        {
            InitializeComponent();
            this.customer = customer;
        }
    }
}
