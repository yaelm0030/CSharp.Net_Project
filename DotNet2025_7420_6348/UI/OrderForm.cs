using BO;
using BlApi;
using System.Windows.Forms;

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
            productsInStockGrid.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn codeColumn = new DataGridViewTextBoxColumn();
            codeColumn.Name = "Id";
            codeColumn.DataPropertyName = "Id";
            codeColumn.HeaderText = "Id";
            productsInStockGrid.Columns.Add(codeColumn);

            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.Name = "Name";
            nameColumn.DataPropertyName = "Name";
            nameColumn.HeaderText = "Name";
            productsInStockGrid.Columns.Add(nameColumn);

            DataGridViewTextBoxColumn categoryColumn = new DataGridViewTextBoxColumn();
            categoryColumn.Name = "Category";
            categoryColumn.DataPropertyName = "Category";
            categoryColumn.HeaderText = "Category";
            productsInStockGrid.Columns.Add(categoryColumn);

            DataGridViewTextBoxColumn priceColumn = new DataGridViewTextBoxColumn();
            priceColumn.Name = "Price";
            priceColumn.DataPropertyName = "Price";
            priceColumn.HeaderText = "Price";
            productsInStockGrid.Columns.Add(priceColumn);

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

                amountSelector.Value = 1;
                _ibl.Order.CalcTotalPrice(order);
                totalPriceLabel.Text=order.FinalPrice.ToString();

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

        private void clearInStockError(object sender, DataGridViewCellMouseEventArgs e)
        {
            ifInstockErr?.Clear();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            _ibl.Order.DoOrder(order);
            this.Close();
        }
    }
}
