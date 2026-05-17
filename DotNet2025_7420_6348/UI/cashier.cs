using BO;
using BlApi;

namespace UI
{
    public partial class cashier : Form
    {
        public cashier()
        {
            InitializeComponent();

            // Products in stock grid
            productsInStockGrid.DataSource = Factory.Get().Product.ReadAll();
            productsInStockGrid.Columns["Id"].FillWeight = 50;
            productsInStockGrid.Columns["Name"].FillWeight = 150;
        }

    }
}
