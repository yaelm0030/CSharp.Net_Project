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
            productsList = new ListBox();
            submit = new Button();
            productId = new TextBox();
            amount = new NumericUpDown();
            productIdLabel = new Label();
            label1 = new Label();
            addProduct = new Button();
            productsInOrderList = new ListBox();
            priceLabel = new Label();
            totalPrice = new Label();
            ((System.ComponentModel.ISupportInitialize)amount).BeginInit();
            SuspendLayout();
            // 
            // productsList
            // 
            productsList.BackColor = SystemColors.Menu;
            productsList.BorderStyle = BorderStyle.FixedSingle;
            productsList.ForeColor = SystemColors.WindowText;
            productsList.FormattingEnabled = true;
            productsList.Location = new Point(26, 26);
            productsList.Name = "productsList";
            productsList.Size = new Size(450, 302);
            productsList.TabIndex = 0;
            // 
            // submit
            // 
            submit.Location = new Point(495, 373);
            submit.Name = "submit";
            submit.Size = new Size(281, 44);
            submit.TabIndex = 2;
            submit.Text = "Submit Order";
            submit.UseVisualStyleBackColor = true;
            // 
            // productId
            // 
            productId.Location = new Point(134, 348);
            productId.Name = "productId";
            productId.Size = new Size(145, 27);
            productId.TabIndex = 1;
            // 
            // amount
            // 
            amount.Location = new Point(134, 386);
            amount.Name = "amount";
            amount.Size = new Size(145, 27);
            amount.TabIndex = 2;
            amount.Value = new decimal(new int[] { 1, 0, 0, 0 });
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
            // 
            // productsInOrderList
            // 
            productsInOrderList.BackColor = SystemColors.Menu;
            productsInOrderList.BorderStyle = BorderStyle.FixedSingle;
            productsInOrderList.ForeColor = SystemColors.WindowText;
            productsInOrderList.FormattingEnabled = true;
            productsInOrderList.Location = new Point(495, 26);
            productsInOrderList.Name = "productsInOrderList";
            productsInOrderList.Size = new Size(281, 302);
            productsInOrderList.TabIndex = 6;
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
            totalPrice.Location = new Point(569, 348);
            totalPrice.Name = "totalPrice";
            totalPrice.Size = new Size(207, 20);
            totalPrice.TabIndex = 8;
            totalPrice.Text = "I am enjoying every moment...";
            totalPrice.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cashier
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(totalPrice);
            Controls.Add(priceLabel);
            Controls.Add(productsInOrderList);
            Controls.Add(addProduct);
            Controls.Add(label1);
            Controls.Add(productIdLabel);
            Controls.Add(amount);
            Controls.Add(productsList);
            Controls.Add(productId);
            Controls.Add(submit);
            Name = "cashier";
            Text = "Cashier";
            ((System.ComponentModel.ISupportInitialize)amount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button submit;
        private ListBox productsList;
        private TextBox productId;
        private NumericUpDown amount;
        private Label productIdLabel;
        private Label label1;
        private Button addProduct;
        private ListBox productsInOrderList;
        private Label priceLabel;
        private Label totalPrice;
    }
}
