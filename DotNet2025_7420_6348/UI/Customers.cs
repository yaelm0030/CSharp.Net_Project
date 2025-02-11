using BlApi;

namespace UI
{
    public partial class Customers : Form
    {
        IBl _ibl = Factory.Get();

        public Customers()
        {
            InitializeComponent();
            customersGrid.DataSource = Factory.Get().Customer.ReadAll();
        }

        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            int cusId;
            string cusName;
            string cusAddress;
            string cusPhoneNumber;

            if (!int.TryParse(customerIdInput.Text, out cusId))
                wrongCustomerDetails.SetError(customerIdInput, "Invalid ID");
            else
            {
                cusName = customerNameInput.Text;
                cusAddress = customerAddressInput.Text;
                cusPhoneNumber = customerPhoneNumberInput.Text;
                try
                {
                    _ibl.Customer.Create(new BO.Customer(cusId, cusName, cusAddress, cusPhoneNumber));
                    customersGrid.DataSource = Factory.Get().Customer.ReadAll();
                }
                catch (Exception ex)
                {
                    wrongCustomerDetails.SetError(addCustomerButton, ex.Message);
                }
            }
        }

        private void deleteCustomerButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(customerIdInput.Text, out int cusId))
            {
                wrongCustomerDetails.SetError(customerIdInput, "Invalid ID");
            }
            else
                _ibl.Customer.Delete(cusId);
            customersGrid.DataSource = Factory.Get().Customer.ReadAll();
        }

        private void customersGrid_selectionChanged(object sender, EventArgs e)
        {
            if (customersGrid.CurrentRow?.DataBoundItem is BO.Customer selectedCustomer)
            {
                customerIdInput.Text = selectedCustomer.Id.ToString();
                customerNameInput.Text = selectedCustomer.Name.ToString();
                customerAddressInput.Text = selectedCustomer.Address.ToString();
                customerPhoneNumberInput.Text = selectedCustomer.PhoneNumber.ToString();
            }
        }

        private void updateCustomerButton_Click(object sender, EventArgs e)
        {
            int cusId;
            string cusName;
            string cusAddress;
            string cusPhoneNumber;

            if (!int.TryParse(customerIdInput.Text, out cusId))
                wrongCustomerDetails.SetError(customerIdInput, "Invalid ID");
            else
            {
                cusName = customerNameInput.Text;
                cusAddress = customerAddressInput.Text;
                cusPhoneNumber = customerPhoneNumberInput.Text;
                try
                {
                    _ibl.Customer.Update(new BO.Customer(cusId, cusName, cusAddress, cusPhoneNumber));
                    customersGrid.DataSource = Factory.Get().Customer.ReadAll();
                }
                catch (Exception ex)
                {
                    wrongCustomerDetails.SetError(addCustomerButton, ex.Message);
                }
            }
        }
    }
}
