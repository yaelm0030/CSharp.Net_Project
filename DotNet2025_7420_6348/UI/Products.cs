using BlApi;

namespace UI
{
    public partial class Products : Form
    {
        IBl _ibl = Factory.Get();
        private BO.Product product;

        public Products()
        {
            InitializeComponent();
            product = new BO.Product();
        }

        public Products(BO.Product product)
        {
            InitializeComponent();
            this.product = product;
            prodId.ReadOnly = true;

            productsInStockGrid.DataSource = Factory.Get().Product.ReadAll();
            prodCategory.DataSource = Enum.GetValues(typeof(BO.Category));
            productsInStockGrid.Columns["Id"].FillWeight = 50;
            productsInStockGrid.Columns["Name"].FillWeight = 150;
        }

        private void add_Click(object sender, EventArgs e)
        {
            string productName;
            double productPrice;
            BO.Category productCategory;
            int amountInStock;

            productName = prodName.Text;
            if (!double.TryParse(prodPrice.Text, out productPrice))
            {
                wrongDetails.SetError(prodPrice, "Invalid price");
            }
            else
            {
                productCategory = (BO.Category)Enum.Parse(typeof(BO.Category), prodCategory.Text);
                if (!int.TryParse(prodAmountInStock.Text, out amountInStock))
                {
                    wrongDetails.SetError(prodAmountInStock, "Invalid amount");
                }
                else
                {

                    try
                    {
                        _ibl.Product.Create(new BO.Product(1, productName, productCategory, productPrice, amountInStock));
                    }
                    catch (Exception ex)
                    {
                        wrongDetails.SetError(add, ex.Message);
                    }

                    productsInStockGrid.DataSource = Factory.Get().Product.ReadAll();
                }
            }
        }

        private void ProductCategory_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(prodId.Text, out int productId))
            {
                wrongDetails.SetError(prodId, "Invalid code");
            }
            else
                _ibl.Product.Delete(productId);
            productsInStockGrid.DataSource = Factory.Get().Product.ReadAll();
        }

        private void update_Click(object sender, EventArgs e)
        {
            int productId;
            string productName;
            double productPrice;
            BO.Category productCategory;
            int amountInStock;

            if (!int.TryParse(prodId.Text, out productId))
            {
                wrongDetails.SetError(prodId, "Invalid code");
            }
            else
            {
                productName = prodName.Text;
                if (!double.TryParse(prodPrice.Text, out productPrice))
                {
                    wrongDetails.SetError(prodPrice, "Invalid price");
                }
                else
                {
                    productCategory = (BO.Category)Enum.Parse(typeof(BO.Category), prodCategory.Text);
                    if (!int.TryParse(prodAmountInStock.Text, out amountInStock))
                    {
                        wrongDetails.SetError(prodAmountInStock, "Invalid amount");
                    }
                    else
                    {

                        try
                        {
                            _ibl.Product.Update(new BO.Product(productId, productName, productCategory, productPrice, amountInStock));
                        }
                        catch (Exception ex)
                        {
                            wrongDetails.SetError(add, ex.Message);
                        }

                        productsInStockGrid.DataSource = Factory.Get().Product.ReadAll();
                    }
                }
            }
        }

        private void productsInStockGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (productsInStockGrid.CurrentRow?.DataBoundItem is BO.Product selectedProduct)
            {
                this.product = selectedProduct; // עדכון האובייקט הנוכחי בקלאס

                // השמת הערכים בתיבות הטקסט
                prodId.Text = this.product.Id.ToString();
                prodName.Text = this.product.Name ?? "";
                prodPrice.Text = this.product.Price.ToString();
                prodAmountInStock.Text = this.product.InStock.ToString();
                prodCategory.Text = this.product.Category.ToString();
            }
        }
    }
}
