using BO;
using BlApi;

namespace UI
{
    public partial class OrderForm : Form
    {
        BO.Order order;
        IBl _ibl = Factory.Get();
        public OrderForm(BO.Order order)
        {
            InitializeComponent();
            this.order = order;


            // Products in stock grid
            productsInStockGrid.DataSource = Factory.Get().Product.ReadAll(p => p.InStock > 0);
            productsInStockGrid.Columns["Id"].FillWeight = 50;
            productsInStockGrid.Columns["Name"].FillWeight = 150;

            // Products in order grid
            productsInOrder.DataSource = order.Products;
        }

        private void addProduct_Click(object sender, EventArgs e)
        {
            try
            {
                ProductInOrder productInOrder;
                Product product;
                if (productId.Text.Length > 0)
                {
                    int productCode;
                    if (int.TryParse(productId.Text, out productCode))
                    {
                        product = _ibl.Product.Read(productCode);
                        if (product != null)
                            _ibl.Order.AddProductToOrder(order, productCode, (int)amountSelector.Value);
                        else
                            illegalProductCode.SetError(productId, "Illegal product code");
                    }
                    else
                        illegalProductCode.SetError(productId, "Illegal product code");
                    productId.Text = "";
                }
                else
                {
                    product = productsInStockGrid.CurrentRow?.DataBoundItem as Product;
                    if (product != null)
                        _ibl.Order.AddProductToOrder(order, product.Id, (int)amountSelector.Value);
                    else
                    {

                    }
                }
                productsInOrder.DataSource = null;
                productsInOrder.DataSource = order.Products;

                productsInStockGrid.DataSource = _ibl.Product.ReadAll(p => p.InStock > 0);

            }
            catch (Exception ex)
            {
                ifInstockErr.SetError(productsInStockGrid, ex.Message);
            }
        }

        private void productId_TextChanged(object sender, EventArgs e)
        {
            if (productId.Text != "")
                illegalProductCode.Clear();
        }

        private void clearInStockError(object sender, EventArgs e)
        {
        }

        private void InStock(object sender, EventArgs e)
        {

        }

        private void clearInStockError(object sender, DataGridViewCellMouseEventArgs e)
        {
            ifInstockErr?.Clear();
        }
    }
}
