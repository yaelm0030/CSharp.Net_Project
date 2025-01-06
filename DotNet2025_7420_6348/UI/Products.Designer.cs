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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Products));
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Menu;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            productsInStockGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            productsInStockGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Menu;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            productsInStockGrid.DefaultCellStyle = dataGridViewCellStyle2;
            productsInStockGrid.Location = new Point(11, 13);
            productsInStockGrid.Margin = new Padding(3, 4, 3, 4);
            productsInStockGrid.Name = "productsInStockGrid";
            productsInStockGrid.RowHeadersWidth = 51;
            productsInStockGrid.Size = new Size(450, 352);
            productsInStockGrid.TabIndex = 10;
            productsInStockGrid.SelectionChanged += productsInStockGrid_SelectionChanged;
            // 
            // add
            // 
            add.Location = new Point(11, 372);
            add.Name = "add";
            add.Size = new Size(145, 67);
            add.TabIndex = 11;
            add.Text = "add a new product";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // delete
            // 
            delete.Location = new Point(163, 372);
            delete.Name = "delete";
            delete.Size = new Size(149, 67);
            delete.TabIndex = 11;
            delete.Text = "delete the selected product";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // update
            // 
            update.Location = new Point(317, 372);
            update.Name = "update";
            update.Size = new Size(145, 67);
            update.TabIndex = 11;
            update.Text = "update the selected product";
            update.UseVisualStyleBackColor = true;
            update.Click += update_Click;
            // 
            // productId
            // 
            productId.AutoSize = true;
            productId.Font = new Font("Segoe UI", 12F);
            productId.Location = new Point(489, 19);
            productId.Name = "productId";
            productId.Size = new Size(121, 28);
            productId.TabIndex = 12;
            productId.Text = "product's id:";
            // 
            // prodId
            // 
            prodId.Location = new Point(489, 49);
            prodId.Name = "prodId";
            prodId.ReadOnly = true;
            prodId.Size = new Size(189, 27);
            prodId.TabIndex = 13;
            // 
            // prodCategory
            // 
            prodCategory.FormattingEnabled = true;
            prodCategory.Location = new Point(489, 203);
            prodCategory.Name = "prodCategory";
            prodCategory.Size = new Size(189, 28);
            prodCategory.TabIndex = 14;
            // 
            // prodAmountInStock
            // 
            prodAmountInStock.Location = new Point(489, 335);
            prodAmountInStock.Name = "prodAmountInStock";
            prodAmountInStock.Size = new Size(189, 27);
            prodAmountInStock.TabIndex = 13;
            // 
            // prodName
            // 
            prodName.Location = new Point(489, 124);
            prodName.Name = "prodName";
            prodName.Size = new Size(189, 27);
            prodName.TabIndex = 13;
            // 
            // productName
            // 
            productName.AutoSize = true;
            productName.Font = new Font("Segoe UI", 12F);
            productName.Location = new Point(489, 95);
            productName.Name = "productName";
            productName.Size = new Size(152, 28);
            productName.TabIndex = 12;
            productName.Text = "product's name:";
            // 
            // productCayegory
            // 
            productCayegory.AutoSize = true;
            productCayegory.Font = new Font("Segoe UI", 12F);
            productCayegory.Location = new Point(489, 171);
            productCayegory.Name = "productCayegory";
            productCayegory.Size = new Size(181, 28);
            productCayegory.TabIndex = 12;
            productCayegory.Text = "product's category:";
            // 
            // productPrice
            // 
            productPrice.AutoSize = true;
            productPrice.Font = new Font("Segoe UI", 12F);
            productPrice.Location = new Point(489, 244);
            productPrice.Name = "productPrice";
            productPrice.Size = new Size(147, 28);
            productPrice.TabIndex = 12;
            productPrice.Text = "product's price:";
            // 
            // amountInStock
            // 
            amountInStock.AutoSize = true;
            amountInStock.Font = new Font("Segoe UI", 12F);
            amountInStock.Location = new Point(489, 305);
            amountInStock.Name = "amountInStock";
            amountInStock.Size = new Size(156, 28);
            amountInStock.TabIndex = 12;
            amountInStock.Text = "amount in stock:";
            // 
            // prodPrice
            // 
            prodPrice.Location = new Point(489, 273);
            prodPrice.Name = "prodPrice";
            prodPrice.Size = new Size(189, 27);
            prodPrice.TabIndex = 13;
            // 
            // wrongDetails
            // 
            wrongDetails.ContainerControl = this;
            // 
            // Products
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
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