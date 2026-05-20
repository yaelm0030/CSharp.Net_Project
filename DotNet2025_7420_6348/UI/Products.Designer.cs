namespace UI
{
    partial class Products
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            productsInStockGrid = new DataGridView();
            add = new Button();
            delete = new Button();
            update = new Button();
            productId = new Label();
            prodId = new TextBox();
            prodCategory = new ComboBox();
            prodAmountInStock = new TextBox();
            prodName = new TextBox();
            productName = new Label();
            productCayegory = new Label();
            productPrice = new Label();
            amountInStock = new Label();
            prodPrice = new TextBox();
            wrongDetails = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)productsInStockGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wrongDetails).BeginInit();
            SuspendLayout();
            // 
            // productsInStockGrid
            // 
            productsInStockGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            productsInStockGrid.BackgroundColor = SystemColors.Menu;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Menu;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            productsInStockGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            productsInStockGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Menu;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            productsInStockGrid.DefaultCellStyle = dataGridViewCellStyle6;
            productsInStockGrid.Location = new Point(10, 10);
            productsInStockGrid.Name = "productsInStockGrid";
            productsInStockGrid.RowHeadersWidth = 51;
            productsInStockGrid.Size = new Size(394, 264);
            productsInStockGrid.TabIndex = 10;
            productsInStockGrid.SelectionChanged += productsInStockGrid_SelectionChanged;
            // 
            // add
            // 
            add.Location = new Point(10, 279);
            add.Margin = new Padding(3, 2, 3, 2);
            add.Name = "add";
            add.Size = new Size(127, 50);
            add.TabIndex = 11;
            add.Text = "add a new product";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // delete
            // 
            delete.Location = new Point(143, 279);
            delete.Margin = new Padding(3, 2, 3, 2);
            delete.Name = "delete";
            delete.Size = new Size(130, 50);
            delete.TabIndex = 11;
            delete.Text = "delete the selected product";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // update
            // 
            update.Location = new Point(277, 279);
            update.Margin = new Padding(3, 2, 3, 2);
            update.Name = "update";
            update.Size = new Size(127, 50);
            update.TabIndex = 11;
            update.Text = "update the selected product";
            update.UseVisualStyleBackColor = true;
            update.Click += update_Click;
            // 
            // productId
            // 
            productId.AutoSize = true;
            productId.Font = new Font("Segoe UI", 12F);
            productId.Location = new Point(428, 14);
            productId.Name = "productId";
            productId.Size = new Size(95, 21);
            productId.TabIndex = 12;
            productId.Text = "product's id:";
            // 
            // prodId
            // 
            prodId.Location = new Point(428, 37);
            prodId.Margin = new Padding(3, 2, 3, 2);
            prodId.Name = "prodId";
            prodId.ReadOnly = true;
            prodId.Size = new Size(166, 23);
            prodId.TabIndex = 13;
            // 
            // prodCategory
            // 
            prodCategory.FormattingEnabled = true;
            prodCategory.Location = new Point(428, 152);
            prodCategory.Margin = new Padding(3, 2, 3, 2);
            prodCategory.Name = "prodCategory";
            prodCategory.Size = new Size(166, 23);
            prodCategory.TabIndex = 14;
            // 
            // prodAmountInStock
            // 
            prodAmountInStock.Location = new Point(428, 251);
            prodAmountInStock.Margin = new Padding(3, 2, 3, 2);
            prodAmountInStock.Name = "prodAmountInStock";
            prodAmountInStock.Size = new Size(166, 23);
            prodAmountInStock.TabIndex = 13;
            // 
            // prodName
            // 
            prodName.Location = new Point(428, 93);
            prodName.Margin = new Padding(3, 2, 3, 2);
            prodName.Name = "prodName";
            prodName.Size = new Size(166, 23);
            prodName.TabIndex = 13;
            // 
            // productName
            // 
            productName.AutoSize = true;
            productName.Font = new Font("Segoe UI", 12F);
            productName.Location = new Point(428, 71);
            productName.Name = "productName";
            productName.Size = new Size(121, 21);
            productName.TabIndex = 12;
            productName.Text = "product's name:";
            // 
            // productCayegory
            // 
            productCayegory.AutoSize = true;
            productCayegory.Font = new Font("Segoe UI", 12F);
            productCayegory.Location = new Point(428, 128);
            productCayegory.Name = "productCayegory";
            productCayegory.Size = new Size(142, 21);
            productCayegory.TabIndex = 12;
            productCayegory.Text = "product's category:";
            // 
            // productPrice
            // 
            productPrice.AutoSize = true;
            productPrice.Font = new Font("Segoe UI", 12F);
            productPrice.Location = new Point(428, 183);
            productPrice.Name = "productPrice";
            productPrice.Size = new Size(116, 21);
            productPrice.TabIndex = 12;
            productPrice.Text = "product's price:";
            // 
            // amountInStock
            // 
            amountInStock.AutoSize = true;
            amountInStock.Font = new Font("Segoe UI", 12F);
            amountInStock.Location = new Point(428, 229);
            amountInStock.Name = "amountInStock";
            amountInStock.Size = new Size(124, 21);
            amountInStock.TabIndex = 12;
            amountInStock.Text = "amount in stock:";
            // 
            // prodPrice
            // 
            prodPrice.Location = new Point(428, 205);
            prodPrice.Margin = new Padding(3, 2, 3, 2);
            prodPrice.Name = "prodPrice";
            prodPrice.Size = new Size(166, 23);
            prodPrice.TabIndex = 13;
            // 
            // wrongDetails
            // 
            wrongDetails.ContainerControl = this;
            // 
            // Products
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(prodCategory);
            Controls.Add(prodName);
            Controls.Add(prodPrice);
            Controls.Add(prodAmountInStock);
            Controls.Add(prodId);
            Controls.Add(amountInStock);
            Controls.Add(productPrice);
            Controls.Add(productCayegory);
            Controls.Add(productName);
            Controls.Add(productId);
            Controls.Add(update);
            Controls.Add(delete);
            Controls.Add(add);
            Controls.Add(productsInStockGrid);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Products";
            Text = "Products";
            ((System.ComponentModel.ISupportInitialize)productsInStockGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)wrongDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView productsInStockGrid;
        private Button add;
        private Button delete;
        private Button update;
        private Label productId;
        private TextBox prodId;
        private ComboBox prodCategory;
        private TextBox prodAmountInStock;
        private TextBox prodName;
        private Label productName;
        //private Label label1;
        //private Label label2;
        private Label amountInStock;
        private TextBox prodPrice;
        private Label productCayegory;
        private Label productPrice;
        private ErrorProvider wrongDetails;
    }
}