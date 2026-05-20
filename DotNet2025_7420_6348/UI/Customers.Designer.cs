namespace UI
{
    partial class Customers
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
            customerNameInput = new TextBox();
            customerPhoneNumberInput = new TextBox();
            customerPhoneNumberLabel = new Label();
            customerAddressLabel = new Label();
            customerNameLabel = new Label();
            customerIdLabel = new Label();
            updateCustomerButton = new Button();
            deleteCustomerButton = new Button();
            addCustomerButton = new Button();
            customersGrid = new DataGridView();
            wrongCustomerDetails = new ErrorProvider(components);
            customerAddressInput = new TextBox();
            customerIdInput = new TextBox();
            ((System.ComponentModel.ISupportInitialize)customersGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wrongCustomerDetails).BeginInit();
            SuspendLayout();
            // 
            // customerNameInput
            // 
            customerNameInput.Location = new Point(429, 108);
            customerNameInput.Margin = new Padding(3, 2, 3, 2);
            customerNameInput.Name = "customerNameInput";
            customerNameInput.Size = new Size(166, 23);
            customerNameInput.TabIndex = 24;
            // 
            // customerPhoneNumberInput
            // 
            customerPhoneNumberInput.Location = new Point(429, 249);
            customerPhoneNumberInput.Margin = new Padding(3, 2, 3, 2);
            customerPhoneNumberInput.Name = "customerPhoneNumberInput";
            customerPhoneNumberInput.Size = new Size(166, 23);
            customerPhoneNumberInput.TabIndex = 25;
            // 
            // customerPhoneNumberLabel
            // 
            customerPhoneNumberLabel.AutoSize = true;
            customerPhoneNumberLabel.Font = new Font("Segoe UI", 12F);
            customerPhoneNumberLabel.Location = new Point(429, 227);
            customerPhoneNumberLabel.Name = "customerPhoneNumberLabel";
            customerPhoneNumberLabel.Size = new Size(199, 21);
            customerPhoneNumberLabel.TabIndex = 20;
            customerPhoneNumberLabel.Text = "Customer's phone number:";
            // 
            // customerAddressLabel
            // 
            customerAddressLabel.AutoSize = true;
            customerAddressLabel.Font = new Font("Segoe UI", 12F);
            customerAddressLabel.Location = new Point(429, 156);
            customerAddressLabel.Name = "customerAddressLabel";
            customerAddressLabel.Size = new Size(150, 21);
            customerAddressLabel.TabIndex = 21;
            customerAddressLabel.Text = "Customer's address:";
            // 
            // customerNameLabel
            // 
            customerNameLabel.AutoSize = true;
            customerNameLabel.Font = new Font("Segoe UI", 12F);
            customerNameLabel.Location = new Point(429, 85);
            customerNameLabel.Name = "customerNameLabel";
            customerNameLabel.Size = new Size(135, 21);
            customerNameLabel.TabIndex = 22;
            customerNameLabel.Text = "Customer's name:";
            // 
            // customerIdLabel
            // 
            customerIdLabel.AutoSize = true;
            customerIdLabel.Font = new Font("Segoe UI", 12F);
            customerIdLabel.Location = new Point(429, 13);
            customerIdLabel.Name = "customerIdLabel";
            customerIdLabel.Size = new Size(109, 21);
            customerIdLabel.TabIndex = 23;
            customerIdLabel.Text = "Customer's id:";
            // 
            // updateCustomerButton
            // 
            updateCustomerButton.Location = new Point(278, 278);
            updateCustomerButton.Margin = new Padding(3, 2, 3, 2);
            updateCustomerButton.Name = "updateCustomerButton";
            updateCustomerButton.Size = new Size(127, 50);
            updateCustomerButton.TabIndex = 16;
            updateCustomerButton.Text = "update the selected customer";
            updateCustomerButton.UseVisualStyleBackColor = true;
            updateCustomerButton.Click += updateCustomerButton_Click;
            // 
            // deleteCustomerButton
            // 
            deleteCustomerButton.Location = new Point(144, 278);
            deleteCustomerButton.Margin = new Padding(3, 2, 3, 2);
            deleteCustomerButton.Name = "deleteCustomerButton";
            deleteCustomerButton.Size = new Size(130, 50);
            deleteCustomerButton.TabIndex = 17;
            deleteCustomerButton.Text = "delete the selected customer";
            deleteCustomerButton.UseVisualStyleBackColor = true;
            deleteCustomerButton.Click += deleteCustomerButton_Click;
            // 
            // addCustomerButton
            // 
            addCustomerButton.Location = new Point(11, 278);
            addCustomerButton.Margin = new Padding(3, 2, 3, 2);
            addCustomerButton.Name = "addCustomerButton";
            addCustomerButton.Size = new Size(127, 50);
            addCustomerButton.TabIndex = 18;
            addCustomerButton.Text = "add a new customer";
            addCustomerButton.UseVisualStyleBackColor = true;
            addCustomerButton.Click += addCustomerButton_Click;
            // 
            // customersGrid
            // 
            customersGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            customersGrid.BackgroundColor = SystemColors.Menu;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Menu;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            customersGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            customersGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Menu;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            customersGrid.DefaultCellStyle = dataGridViewCellStyle2;
            customersGrid.Location = new Point(11, 9);
            customersGrid.Name = "customersGrid";
            customersGrid.RowHeadersWidth = 51;
            customersGrid.Size = new Size(394, 264);
            customersGrid.TabIndex = 15;
            customersGrid.SelectionChanged += customersGrid_selectionChanged;
            // 
            // wrongCustomerDetails
            // 
            wrongCustomerDetails.ContainerControl = this;
            // 
            // customerAddressInput
            // 
            customerAddressInput.Location = new Point(429, 179);
            customerAddressInput.Margin = new Padding(3, 2, 3, 2);
            customerAddressInput.Name = "customerAddressInput";
            customerAddressInput.Size = new Size(166, 23);
            customerAddressInput.TabIndex = 30;
            // 
            // customerIdInput
            // 
            customerIdInput.Location = new Point(429, 36);
            customerIdInput.Margin = new Padding(3, 2, 3, 2);
            customerIdInput.Name = "customerIdInput";
            customerIdInput.Size = new Size(166, 23);
            customerIdInput.TabIndex = 31;
            // 
            // Customers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(687, 335);
            Controls.Add(customerIdInput);
            Controls.Add(customerAddressInput);
            Controls.Add(customerNameInput);
            Controls.Add(customerPhoneNumberInput);
            Controls.Add(customerPhoneNumberLabel);
            Controls.Add(customerAddressLabel);
            Controls.Add(customerNameLabel);
            Controls.Add(customerIdLabel);
            Controls.Add(updateCustomerButton);
            Controls.Add(deleteCustomerButton);
            Controls.Add(addCustomerButton);
            Controls.Add(customersGrid);
            Name = "Customers";
            Text = "Customers";
            ((System.ComponentModel.ISupportInitialize)customersGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)wrongCustomerDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox prodCategory;
        private TextBox customerNameInput;
        private TextBox customerPhoneNumberInput;
        private Label customerPhoneNumberLabel;
        private Label customerAddressLabel;
        private Label customerNameLabel;
        private Label customerIdLabel;
        private Button updateCustomerButton;
        private Button deleteCustomerButton;
        private Button addCustomerButton;
        private DataGridView customersGrid;
        private ErrorProvider wrongCustomerDetails;
        private TextBox customerAddressInput;
        private TextBox customerIdInput;
    }
}