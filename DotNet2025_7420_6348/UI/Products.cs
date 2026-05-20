using BlApi;
using BO;
using DO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            productsInStockGrid.DataSource = Factory.Get().Product.ReadAll();
            prodCategory.DataSource = Enum.GetValues(typeof(BO.Category));
            productsInStockGrid.Columns["Id"].FillWeight = 50;
            productsInStockGrid.Columns["Name"].FillWeight = 150;
            prodId.Text = "";
            prodName.Text = "";
            prodPrice.Text = "";
            prodAmountInStock.Text = "";
            prodCategory.Text = "";
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(prodId.Text, out int productId))
            {
                wrongDetails.SetError(prodId, "didnt manage to convert to int");

            }
            else
                product = _ibl.Product.Read(productId);
            if (!double.TryParse(prodPrice.Text, out double productPrice))
            {
                wrongDetails.SetError(prodPrice, "didnt manage to convert to double");
            }
            if (!int.TryParse(prodAmountInStock.Text, out int productamountInStock))
            {
                wrongDetails.SetError(prodAmountInStock, "didnt manage to convert to int");
            }
            BO.Category productCat = (BO.Category)Enum.Parse(typeof(BO.Category), prodCategory.Text);
            if (productCat == null)
                wrongDetails.SetError(prodAmountInStock, "didnt manage to convert to category");
            _ibl.Product.Create(product);
            productsInStockGrid.DataSource = Factory.Get().Product.ReadAll();
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
                wrongDetails.SetError(prodId, "didnt manage to convert to int");

            }
            else
                _ibl.Product.Delete(productId);

        }

        private void update_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(prodId.Text, out int productId))
            {
                wrongDetails.SetError(prodId,"didnt manage to convert to int");

            }
            else
                product = _ibl.Product.Read(productId);
            if (!double.TryParse(prodPrice.Text, out double productPrice))
            {
                wrongDetails.SetError(prodPrice, "didnt manage to convert to double");
            }
            if (!int.TryParse(prodAmountInStock.Text, out int productamountInStock))
            {
                wrongDetails.SetError(prodAmountInStock, "didnt manage to convert to int");
            }
            BO.Category productCat = (BO.Category)Enum.Parse(typeof(BO.Category), prodCategory.Text);
            if(productCat == null)
                wrongDetails.SetError(prodAmountInStock, "didnt manage to convert to category");
            _ibl.Product.Update(product);
            productsInStockGrid.DataSource = Factory.Get().Product.ReadAll();

        }

        private void Products_Load(object sender, EventArgs e)
        {
            //product = productsInStockGrid.CurrentRow?.DataBoundItem as BO.Product;
            //prodId.Text = product.Id.ToString();
            //prodName.Text = product.Name.ToString();
            //prodPrice.Text = product.Price.ToString();
            //prodAmountInStock.Text = product.InStock.ToString();
            //prodCategory.Text = product.Category.ToString();

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
