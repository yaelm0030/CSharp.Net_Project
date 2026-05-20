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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            realDate.Text = DateTime.Now.ToString();
            int hour = DateTime.Now.Hour;
            if (hour>6&&hour<=12)
                welcome.Text = "Good morning, welcome to our shop...";
            else { 
                if (hour > 12 && hour <= 18)
                welcome.Text = "Good afternoon, welcome to our shop...";
                else {
                if (hour > 18 && hour <= 22)
                welcome.Text = "Good evening, welcome to our shop...";
            else
                welcome.Text = "Good night, welcome to our shop...";
                }
            }
        }

        private void mangerButton_Click(object sender, EventArgs e)
        {
            Manager manager = new Manager();
            manager.ShowDialog();
        }

        private void cashierButton_Click(object sender, EventArgs e)
        {
            Cashier cashier = new Cashier();
            cashier.ShowDialog();
        }
    }
}
