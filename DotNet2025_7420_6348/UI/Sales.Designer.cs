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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales));
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
            saleProductIdInput.Location = new Point(491, 105);
            saleProductIdInput.Name = "saleProductIdInput";
            saleProductIdInput.Size = new Size(189, 27);
            saleProductIdInput.TabIndex = 40;
            // 
            // priceAfterDiscountInput
            // 
            priceAfterDiscountInput.Location = new Point(491, 233);
            priceAfterDiscountInput.Name = "priceAfterDiscountInput";
            priceAfterDiscountInput.Size = new Size(189, 27);
            priceAfterDiscountInput.TabIndex = 41;
            // 
            // priceAfterDiscountLabel
            // 
            priceAfterDiscountLabel.AutoSize = true;
            priceAfterDiscountLabel.Font = new Font("Segoe UI", 12F);
            priceAfterDiscountLabel.Location = new Point(491, 205);
            priceAfterDiscountLabel.Name = "priceAfterDiscountLabel";
            priceAfterDiscountLabel.Size = new Size(179, 28);
            priceAfterDiscountLabel.TabIndex = 36;
            priceAfterDiscountLabel.Text = "Price after discount";
            // 
            // amountNeededLabel
            // 
            amountNeededLabel.AutoSize = true;
            amountNeededLabel.Font = new Font("Segoe UI", 12F);
            amountNeededLabel.Location = new Point(491, 141);
            amountNeededLabel.Name = "amountNeededLabel";
            amountNeededLabel.Size = new Size(157, 28);
            amountNeededLabel.TabIndex = 37;
            amountNeededLabel.Text = "Amount needed:";
            // 
            // saleProductIdLabel
            // 
            saleProductIdLabel.AutoSize = true;
            saleProductIdLabel.Font = new Font("Segoe UI", 12F);
            saleProductIdLabel.Location = new Point(491, 75);
            saleProductIdLabel.Name = "saleProductIdLabel";
            saleProductIdLabel.Size = new Size(268, 28);
            saleProductIdLabel.TabIndex = 38;
            saleProductIdLabel.Text = "Sale for product: (product ID)";
            // 
            // saleIdLabel
            // 
            saleIdLabel.AutoSize = true;
            saleIdLabel.Font = new Font("Segoe UI", 12F);
            saleIdLabel.Location = new Point(491, 15);
            saleIdLabel.Name = "saleIdLabel";
            saleIdLabel.Size = new Size(87, 28);
            saleIdLabel.TabIndex = 39;
            saleIdLabel.Text = "Sale's id:";
            // 
            // updateSaleButton
            // 
            updateSaleButton.Location = new Point(319, 375);
            updateSaleButton.Name = "updateSaleButton";
            updateSaleButton.Size = new Size(145, 67);
            updateSaleButton.TabIndex = 33;
            updateSaleButton.Text = "update the selected sale";
            updateSaleButton.UseVisualStyleBackColor = true;
            updateSaleButton.Click += updateSaleButton_Click;
            // 
            // deleteSaleButton
            // 
            deleteSaleButton.Location = new Point(166, 375);
            deleteSaleButton.Name = "deleteSaleButton";
            deleteSaleButton.Size = new Size(149, 67);
            deleteSaleButton.TabIndex = 34;
            deleteSaleButton.Text = "delete the selected sale";
            deleteSaleButton.UseVisualStyleBackColor = true;
            deleteSaleButton.Click += deleteSaleButton_Click;
            // 
            // addSaleButton
            // 
            addSaleButton.Location = new Point(14, 375);
            addSaleButton.Name = "addSaleButton";
            addSaleButton.Size = new Size(145, 67);
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
            salesGrid.Location = new Point(14, 16);
            salesGrid.Margin = new Padding(3, 4, 3, 4);
            salesGrid.Name = "salesGrid";
            salesGrid.RowHeadersWidth = 51;
            salesGrid.Size = new Size(450, 352);
            salesGrid.TabIndex = 32;
            salesGrid.SelectionChanged += salesGrid_selectionChanged;
            // 
            // wrongSaleDetails
            // 
            wrongSaleDetails.ContainerControl = this;
            // 
            // saleIdInput
            // 
            saleIdInput.Location = new Point(491, 40);
            saleIdInput.Name = "saleIdInput";
            saleIdInput.Size = new Size(189, 27);
            saleIdInput.TabIndex = 43;
            // 
            // amountNeededInput
            // 
            amountNeededInput.Location = new Point(491, 172);
            amountNeededInput.Margin = new Padding(3, 4, 3, 4);
            amountNeededInput.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            amountNeededInput.Name = "amountNeededInput";
            amountNeededInput.Size = new Size(190, 27);
            amountNeededInput.TabIndex = 44;
            amountNeededInput.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // clubCustomerCheckBox
            // 
            clubCustomerCheckBox.AutoSize = true;
            clubCustomerCheckBox.Font = new Font("Segoe UI", 12F);
            clubCustomerCheckBox.Location = new Point(491, 395);
            clubCustomerCheckBox.Margin = new Padding(3, 4, 3, 4);
            clubCustomerCheckBox.Name = "clubCustomerCheckBox";
            clubCustomerCheckBox.Size = new Size(279, 32);
            clubCustomerCheckBox.TabIndex = 45;
            clubCustomerCheckBox.Text = "Sale for club customers only";
            clubCustomerCheckBox.UseVisualStyleBackColor = true;
            // 
            // beginningDateInput
            // 
            beginningDateInput.Location = new Point(491, 295);
            beginningDateInput.Margin = new Padding(3, 4, 3, 4);
            beginningDateInput.Name = "beginningDateInput";
            beginningDateInput.Size = new Size(228, 27);
            beginningDateInput.TabIndex = 46;
            // 
            // beginningDateLabel
            // 
            beginningDateLabel.AutoSize = true;
            beginningDateLabel.Font = new Font("Segoe UI", 12F);
            beginningDateLabel.Location = new Point(491, 267);
            beginningDateLabel.Name = "beginningDateLabel";
            beginningDateLabel.Size = new Size(144, 28);
            beginningDateLabel.TabIndex = 47;
            beginningDateLabel.Text = "Beginning date";
            // 
            // endingDateLabel
            // 
            endingDateLabel.AutoSize = true;
            endingDateLabel.Font = new Font("Segoe UI", 12F);
            endingDateLabel.Location = new Point(491, 329);
            endingDateLabel.Name = "endingDateLabel";
            endingDateLabel.Size = new Size(117, 28);
            endingDateLabel.TabIndex = 49;
            endingDateLabel.Text = "Ending date";
            // 
            // endingDateInput
            // 
            endingDateInput.Location = new Point(491, 359);
            endingDateInput.Margin = new Padding(3, 4, 3, 4);
            endingDateInput.Name = "endingDateInput";
            endingDateInput.Size = new Size(228, 27);
            endingDateInput.TabIndex = 48;
            // 
            // Sales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 451);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
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