using DalApi;

namespace UI
{
    public partial class cashier : Form
    {
        public cashier()
        {
            InitializeComponent();
            productsList.DataSource = Factory.Get.Product.ReadAll();
        }
    }
}
