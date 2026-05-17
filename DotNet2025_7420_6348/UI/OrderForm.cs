using BO;
using BlApi;

namespace UI
{
    public partial class OrderForm : Form
    {
        BO.Order order;
        public OrderForm(BO.Order order)
        {
            InitializeComponent();
            this.order = order;


            // Products in stock grid
            productsInStockGrid.DataSource = Factory.Get().Product.ReadAll();
            productsInStockGrid.Columns["Id"].FillWeight = 50;
            productsInStockGrid.Columns["Name"].FillWeight = 150;

            // Products in order grid
            productsInOrder.DataSource = order.Products;
        }

        private void addProduct_Click(object sender, EventArgs e)
        {
            Product product = productsInStockGrid.CurrentRow?.DataBoundItem as Product;
            ProductInOrder productInOrder;
            if (product != null)
            {
                productInOrder = new ProductInOrder(product.Id, product.Name, product.Price, (int)amountSelector.Value, new List<SaleOfProduct>(), 0);
                Factory.Get().Order.CalcTotalPriceForProduct(productInOrder);
                order.Products.Add(productInOrder);
            }
            else
            {
                if (productId.Text.Length > 0)
                {
                    int productCode;
                    if (int.TryParse(productId.Text, out productCode))
                    {
                        product = Factory.Get().Product.Read(productCode);
                        if (product != null)
                        {
                            productInOrder = new ProductInOrder(product.Id, product.Name, product.Price, (int)amountSelector.Value, new List<SaleOfProduct>(), 0);
                            order.Products.Add(productInOrder);
                        }
                        else
                        {
                            //add error
                        }
                    }
                    else
                    {
                        //add error
                    }
                }
            }
            productsInOrder.DataSource = null;
            productsInOrder.DataSource = order.Products;
        }
    }
}
