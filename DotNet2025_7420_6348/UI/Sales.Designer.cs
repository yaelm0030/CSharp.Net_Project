namespace UI
{
    partial class Sales
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
            saleProductIdInput = new TextBox();
            priceAfterDiscountInput = new TextBox();
            priceAfterDiscountLabel = new Label();
            amountNeededLabel = new Label();
            saleProductIdLabel = new Label();
            saleIdLabel = new Label();
            updateSaleButton = new Button();
            deleteSaleButton = new Button();
            addSaleButton = new Button();
            salesGrid = new DataGridView();
            wrongSaleDetails = new ErrorProvider(components);
            saleIdInput = new TextBox();
            amountNeededInput = new NumericUpDown();
            clubCustomerCheckBox = new CheckBox();
            beginningDateInput = new DateTimePicker();
            beginningDateLabel = new Label();
            endingDateLabel = new Label();
            endingDateInput = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)salesGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wrongSaleDetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)amountNeededInput).BeginInit();
            SuspendLayout();
            // 
            // saleProductIdInput
            // 
            saleProductIdInput.Location = new Point(430, 79);
            saleProductIdInput.Margin = new Padding(3, 2, 3, 2);
            saleProductIdInput.Name = "saleProductIdInput";
            saleProductIdInput.Size = new Size(166, 23);
            saleProductIdInput.TabIndex = 40;
            // 
            // priceAfterDiscountInput
            // 
            priceAfterDiscountInput.Location = new Point(430, 175);
            priceAfterDiscountInput.Margin = new Padding(3, 2, 3, 2);
            priceAfterDiscountInput.Name = "priceAfterDiscountInput";
            priceAfterDiscountInput.Size = new Size(166, 23);
            priceAfterDiscountInput.TabIndex = 41;
            // 
            // priceAfterDiscountLabel
            // 
            priceAfterDiscountLabel.AutoSize = true;
            priceAfterDiscountLabel.Font = new Font("Segoe UI", 12F);
            priceAfterDiscountLabel.Location = new Point(430, 154);
            priceAfterDiscountLabel.Name = "priceAfterDiscountLabel";
            priceAfterDiscountLabel.Size = new Size(143, 21);
            priceAfterDiscountLabel.TabIndex = 36;
            priceAfterDiscountLabel.Text = "Price after discount";
            // 
            // amountNeededLabel
            // 
            amountNeededLabel.AutoSize = true;
            amountNeededLabel.Font = new Font("Segoe UI", 12F);
            amountNeededLabel.Location = new Point(430, 106);
            amountNeededLabel.Name = "amountNeededLabel";
            amountNeededLabel.Size = new Size(124, 21);
            amountNeededLabel.TabIndex = 37;
            amountNeededLabel.Text = "Amount needed:";
            // 
            // saleProductIdLabel
            // 
            saleProductIdLabel.AutoSize = true;
            saleProductIdLabel.Font = new Font("Segoe UI", 12F);
            saleProductIdLabel.Location = new Point(430, 56);
            saleProductIdLabel.Name = "saleProductIdLabel";
            saleProductIdLabel.Size = new Size(211, 21);
            saleProductIdLabel.TabIndex = 38;
            saleProductIdLabel.Text = "Sale for product: (product ID)";
            // 
            // saleIdLabel
            // 
            saleIdLabel.AutoSize = true;
            saleIdLabel.Font = new Font("Segoe UI", 12F);
            saleIdLabel.Location = new Point(430, 11);
            saleIdLabel.Name = "saleIdLabel";
            saleIdLabel.Size = new Size(70, 21);
            saleIdLabel.TabIndex = 39;
            saleIdLabel.Text = "Sale's id:";
            // 
            // updateSaleButton
            // 
            updateSaleButton.Location = new Point(279, 281);
            updateSaleButton.Margin = new Padding(3, 2, 3, 2);
            updateSaleButton.Name = "updateSaleButton";
            updateSaleButton.Size = new Size(127, 50);
            updateSaleButton.TabIndex = 33;
            updateSaleButton.Text = "update the selected sale";
            updateSaleButton.UseVisualStyleBackColor = true;
            updateSaleButton.Click += updateSaleButton_Click;
            // 
            // deleteSaleButton
            // 
            deleteSaleButton.Location = new Point(145, 281);
            deleteSaleButton.Margin = new Padding(3, 2, 3, 2);
            deleteSaleButton.Name = "deleteSaleButton";
            deleteSaleButton.Size = new Size(130, 50);
            deleteSaleButton.TabIndex = 34;
            deleteSaleButton.Text = "delete the selected sale";
            deleteSaleButton.UseVisualStyleBackColor = true;
            deleteSaleButton.Click += deleteSaleButton_Click;
            // 
            // addSaleButton
            // 
            addSaleButton.Location = new Point(12, 281);
            addSaleButton.Margin = new Padding(3, 2, 3, 2);
            addSaleButton.Name = "addSaleButton";
            addSaleButton.Size = new Size(127, 50);
            addSaleButton.TabIndex = 35;
            addSaleButton.Text = "add a new sale";
            addSaleButton.UseVisualStyleBackColor = true;
            addSaleButton.Click += addSaleButton_Click;
            // 
            // salesGrid
            // 
            salesGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            salesGrid.BackgroundColor = SystemColors.Menu;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Menu;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            salesGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            salesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Menu;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            salesGrid.DefaultCellStyle = dataGridViewCellStyle2;
            salesGrid.Location = new Point(12, 12);
            salesGrid.Name = "salesGrid";
            salesGrid.RowHeadersWidth = 51;
            salesGrid.Size = new Size(394, 264);
            salesGrid.TabIndex = 32;
            salesGrid.SelectionChanged += salesGrid_selectionChanged;
            // 
            // wrongSaleDetails
            // 
            wrongSaleDetails.ContainerControl = this;
            // 
            // saleIdInput
            // 
            saleIdInput.Location = new Point(430, 30);
            saleIdInput.Margin = new Padding(3, 2, 3, 2);
            saleIdInput.Name = "saleIdInput";
            saleIdInput.Size = new Size(166, 23);
            saleIdInput.TabIndex = 43;
            // 
            // amountNeededInput
            // 
            amountNeededInput.Location = new Point(430, 129);
            amountNeededInput.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            amountNeededInput.Name = "amountNeededInput";
            amountNeededInput.Size = new Size(166, 23);
            amountNeededInput.TabIndex = 44;
            amountNeededInput.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // clubCustomerCheckBox
            // 
            clubCustomerCheckBox.AutoSize = true;
            clubCustomerCheckBox.Font = new Font("Segoe UI", 12F);
            clubCustomerCheckBox.Location = new Point(430, 296);
            clubCustomerCheckBox.Name = "clubCustomerCheckBox";
            clubCustomerCheckBox.Size = new Size(225, 25);
            clubCustomerCheckBox.TabIndex = 45;
            clubCustomerCheckBox.Text = "Sale for club customers only";
            clubCustomerCheckBox.UseVisualStyleBackColor = true;
            // 
            // beginningDateInput
            // 
            beginningDateInput.Location = new Point(430, 221);
            beginningDateInput.Name = "beginningDateInput";
            beginningDateInput.Size = new Size(200, 23);
            beginningDateInput.TabIndex = 46;
            // 
            // beginningDateLabel
            // 
            beginningDateLabel.AutoSize = true;
            beginningDateLabel.Font = new Font("Segoe UI", 12F);
            beginningDateLabel.Location = new Point(430, 200);
            beginningDateLabel.Name = "beginningDateLabel";
            beginningDateLabel.Size = new Size(114, 21);
            beginningDateLabel.TabIndex = 47;
            beginningDateLabel.Text = "Beginning date";
            // 
            // endingDateLabel
            // 
            endingDateLabel.AutoSize = true;
            endingDateLabel.Font = new Font("Segoe UI", 12F);
            endingDateLabel.Location = new Point(430, 247);
            endingDateLabel.Name = "endingDateLabel";
            endingDateLabel.Size = new Size(92, 21);
            endingDateLabel.TabIndex = 49;
            endingDateLabel.Text = "Ending date";
            // 
            // endingDateInput
            // 
            endingDateInput.Location = new Point(430, 269);
            endingDateInput.Name = "endingDateInput";
            endingDateInput.Size = new Size(200, 23);
            endingDateInput.TabIndex = 48;
            // 
            // Sales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(683, 338);
            Controls.Add(endingDateLabel);
            Controls.Add(endingDateInput);
            Controls.Add(beginningDateLabel);
            Controls.Add(beginningDateInput);
            Controls.Add(clubCustomerCheckBox);
            Controls.Add(amountNeededInput);
            Controls.Add(saleProductIdInput);
            Controls.Add(priceAfterDiscountInput);
            Controls.Add(priceAfterDiscountLabel);
            Controls.Add(amountNeededLabel);
            Controls.Add(saleProductIdLabel);
            Controls.Add(saleIdLabel);
            Controls.Add(updateSaleButton);
            Controls.Add(deleteSaleButton);
            Controls.Add(addSaleButton);
            Controls.Add(salesGrid);
            Controls.Add(saleIdInput);
            Name = "Sales";
            Text = "Sales";
            ((System.ComponentModel.ISupportInitialize)salesGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)wrongSaleDetails).EndInit();
            ((System.ComponentModel.ISupportInitialize)amountNeededInput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox saleProductIdInput;
        private TextBox priceAfterDiscountInput;
        private Label priceAfterDiscountLabel;
        private Label amountNeededLabel;
        private Label saleProductIdLabel;
        private Label saleIdLabel;
        private Button updateSaleButton;
        private Button deleteSaleButton;
        private Button addSaleButton;
        private DataGridView salesGrid;
        private ErrorProvider wrongSaleDetails;
        private TextBox saleIdInput;
        private NumericUpDown amountNeededInput;
        private CheckBox clubCustomerCheckBox;
        private Label endingDateLabel;
        private DateTimePicker endingDateInput;
        private Label beginningDateLabel;
        private DateTimePicker beginningDateInput;
    }
}