namespace UI
{
    partial class cashier
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            submit = new Button();
            productId = new TextBox();
            amount = new NumericUpDown();
            productIdLabel = new Label();
            label1 = new Label();
            addProduct = new Button();
            productsInOrderList = new ListBox();
            priceLabel = new Label();
            totalPrice = new Label();
            productsInStockGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)amount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productsInStockGrid).BeginInit();
            SuspendLayout();
            // 
            // submit
            // 
            submit.Location = new Point(433, 280);
            submit.Margin = new Padding(3, 2, 3, 2);
            submit.Name = "submit";
            submit.Size = new Size(246, 33);
            submit.TabIndex = 2;
            submit.Text = "Submit Order";
            submit.UseVisualStyleBackColor = true;
            // 
            // productId
            // 
            productId.Location = new Point(117, 261);
            productId.Margin = new Padding(3, 2, 3, 2);
            productId.Name = "productId";
            productId.Size = new Size(127, 23);
            productId.TabIndex = 1;
            // 
            // amount
            // 
            amount.Location = new Point(117, 290);
            amount.Margin = new Padding(3, 2, 3, 2);
            amount.Name = "amount";
            amount.Size = new Size(127, 23);
            amount.TabIndex = 2;
            amount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // productIdLabel
            // 
            productIdLabel.AutoSize = true;
            productIdLabel.Location = new Point(23, 261);
            productIdLabel.Name = "productIdLabel";
            productIdLabel.Size = new Size(83, 15);
            productIdLabel.TabIndex = 3;
            productIdLabel.Text = "Product Code:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 291);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 4;
            label1.Text = "Amount:";
            // 
            // addProduct
            // 
            addProduct.Location = new Point(263, 260);
            addProduct.Margin = new Padding(3, 2, 3, 2);
            addProduct.Name = "addProduct";
            addProduct.Size = new Size(151, 52);
            addProduct.TabIndex = 5;
            addProduct.Text = "Add Product";
            addProduct.UseVisualStyleBackColor = true;
            // 
            // productsInOrderList
            // 
            productsInOrderList.BackColor = SystemColors.Menu;
            productsInOrderList.BorderStyle = BorderStyle.FixedSingle;
            productsInOrderList.ForeColor = SystemColors.WindowText;
            productsInOrderList.FormattingEnabled = true;
            productsInOrderList.ItemHeight = 15;
            productsInOrderList.Location = new Point(433, 20);
            productsInOrderList.Margin = new Padding(3, 2, 3, 2);
            productsInOrderList.Name = "productsInOrderList";
            productsInOrderList.Size = new Size(246, 227);
            productsInOrderList.TabIndex = 6;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new Point(433, 260);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(65, 15);
            priceLabel.TabIndex = 7;
            priceLabel.Text = "Total Price:";
            // 
            // totalPrice
            // 
            totalPrice.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            totalPrice.AutoSize = true;
            totalPrice.Location = new Point(498, 261);
            totalPrice.Name = "totalPrice";
            totalPrice.Size = new Size(168, 15);
            totalPrice.TabIndex = 8;
            totalPrice.Text = "I am enjoying every moment...";
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
            productsInStockGrid.Location = new Point(23, 20);
            productsInStockGrid.Name = "productsInStockGrid";
            productsInStockGrid.Size = new Size(394, 227);
            productsInStockGrid.TabIndex = 9;
            // 
            // cashier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(productsInStockGrid);
            Controls.Add(totalPrice);
            Controls.Add(priceLabel);
            Controls.Add(productsInOrderList);
            Controls.Add(addProduct);
            Controls.Add(label1);
            Controls.Add(productIdLabel);
            Controls.Add(amount);
            Controls.Add(productId);
            Controls.Add(submit);
            Margin = new Padding(3, 2, 3, 2);
            Name = "cashier";
            Text = "Cashier";
            ((System.ComponentModel.ISupportInitialize)amount).EndInit();
            ((System.ComponentModel.ISupportInitialize)productsInStockGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button submit;
        private TextBox productId;
        private NumericUpDown amount;
        private Label productIdLabel;
        private Label label1;
        private Button addProduct;
        private ListBox productsInOrderList;
        private Label priceLabel;
        private Label totalPrice;
        private DataGridView productsInStockGrid;
    }
}
