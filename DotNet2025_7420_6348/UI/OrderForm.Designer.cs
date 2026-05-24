namespace UI
{
    partial class OrderForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            submit = new Button();
            productId = new TextBox();
            amountSelector = new NumericUpDown();
            productIdLabel = new Label();
            label1 = new Label();
            addProduct = new Button();
            priceLabel = new Label();
            totalPrice = new Label();
            productsInStockGrid = new DataGridView();
            productsInOrder = new DataGridView();
            illegalProductCode = new ErrorProvider(components);
            ifInstockErr = new ErrorProvider(components);
            totalPriceLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)amountSelector).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productsInStockGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productsInOrder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)illegalProductCode).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ifInstockErr).BeginInit();
            SuspendLayout();
            // 
            // submit
            // 
            submit.Location = new Point(495, 373);
            submit.Name = "submit";
            submit.Size = new Size(281, 44);
            submit.TabIndex = 2;
            submit.Text = "Submit Order";
            submit.UseVisualStyleBackColor = true;
            submit.Click += submit_Click;
            // 
            // productId
            // 
            productId.Location = new Point(134, 348);
            productId.Name = "productId";
            productId.Size = new Size(145, 27);
            productId.TabIndex = 1;
            productId.TextChanged += productId_TextChanged;
            // 
            // amountSelector
            // 
            amountSelector.Location = new Point(134, 387);
            amountSelector.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            amountSelector.Name = "amountSelector";
            amountSelector.Size = new Size(145, 27);
            amountSelector.TabIndex = 2;
            amountSelector.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // productIdLabel
            // 
            productIdLabel.AutoSize = true;
            productIdLabel.Location = new Point(26, 348);
            productIdLabel.Name = "productIdLabel";
            productIdLabel.Size = new Size(102, 20);
            productIdLabel.TabIndex = 3;
            productIdLabel.Text = "Product Code:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 388);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 4;
            label1.Text = "Amount:";
            // 
            // addProduct
            // 
            addProduct.Location = new Point(301, 347);
            addProduct.Name = "addProduct";
            addProduct.Size = new Size(173, 69);
            addProduct.TabIndex = 5;
            addProduct.Text = "Add Product";
            addProduct.UseVisualStyleBackColor = true;
            addProduct.Click += addProduct_Click;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new Point(495, 347);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(81, 20);
            priceLabel.TabIndex = 7;
            priceLabel.Text = "Total Price:";
            // 
            // totalPrice
            // 
            totalPrice.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            totalPrice.AutoSize = true;
            totalPrice.Location = new Point(771, 345);
            totalPrice.Name = "totalPrice";
            totalPrice.Size = new Size(0, 20);
            totalPrice.TabIndex = 8;
            totalPrice.TextAlign = ContentAlignment.MiddleRight;
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
            productsInStockGrid.Location = new Point(26, 27);
            productsInStockGrid.Margin = new Padding(3, 4, 3, 4);
            productsInStockGrid.Name = "productsInStockGrid";
            productsInStockGrid.RowHeadersWidth = 51;
            productsInStockGrid.Size = new Size(450, 303);
            productsInStockGrid.TabIndex = 9;
            productsInStockGrid.CellMouseClick += clearInStockError;
            productsInStockGrid.RegionChanged += productId_TextChanged;
            // 
            // productsInOrder
            // 
            productsInOrder.BackgroundColor = SystemColors.Menu;
            productsInOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productsInOrder.GridColor = SystemColors.Menu;
            productsInOrder.Location = new Point(495, 27);
            productsInOrder.Name = "productsInOrder";
            productsInOrder.RowHeadersWidth = 51;
            productsInOrder.Size = new Size(281, 303);
            productsInOrder.TabIndex = 10;
            // 
            // illegalProductCode
            // 
            illegalProductCode.ContainerControl = this;
            // 
            // ifInstockErr
            // 
            ifInstockErr.ContainerControl = this;
            // 
            // totalPriceLabel
            // 
            totalPriceLabel.Anchor = AnchorStyles.Right;
            totalPriceLabel.AutoSize = true;
            totalPriceLabel.Location = new Point(757, 345);
            totalPriceLabel.Name = "totalPriceLabel";
            totalPriceLabel.Size = new Size(17, 20);
            totalPriceLabel.TabIndex = 12;
            totalPriceLabel.Text = "0";
            totalPriceLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(totalPriceLabel);
            Controls.Add(productsInOrder);
            Controls.Add(productsInStockGrid);
            Controls.Add(totalPrice);
            Controls.Add(priceLabel);
            Controls.Add(addProduct);
            Controls.Add(label1);
            Controls.Add(productIdLabel);
            Controls.Add(amountSelector);
            Controls.Add(productId);
            Controls.Add(submit);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "OrderForm";
            Text = "Order";
            ((System.ComponentModel.ISupportInitialize)amountSelector).EndInit();
            ((System.ComponentModel.ISupportInitialize)productsInStockGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)productsInOrder).EndInit();
            ((System.ComponentModel.ISupportInitialize)illegalProductCode).EndInit();
            ((System.ComponentModel.ISupportInitialize)ifInstockErr).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button submit;
        private TextBox productId;
        private NumericUpDown amountSelector;
        private Label productIdLabel;
        private Label label1;
        private Button addProduct;
        private Label priceLabel;
        private Label totalPrice;
        private DataGridView productsInStockGrid;
        private DataGridView productsInOrder;
        private ErrorProvider illegalProductCode;
        private ErrorProvider ifInstockErr;
        private Label totalPriceLabel;
    }
}
