namespace UI
{
    partial class Cashier
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
            startOrderButton = new Button();
            clubCustomerCheckbox = new CheckBox();
            SuspendLayout();
            // 
            // startOrderButton
            // 
            startOrderButton.Location = new Point(256, 329);
            startOrderButton.Name = "startOrderButton";
            startOrderButton.Size = new Size(281, 29);
            startOrderButton.TabIndex = 0;
            startOrderButton.Text = "Start a new order";
            startOrderButton.UseVisualStyleBackColor = true;
            startOrderButton.Click += createANewOrder;
            // 
            // clubCustomerCheckbox
            // 
            clubCustomerCheckbox.AutoSize = true;
            clubCustomerCheckbox.Location = new Point(297, 299);
            clubCustomerCheckbox.Name = "clubCustomerCheckbox";
            clubCustomerCheckbox.Size = new Size(198, 24);
            clubCustomerCheckbox.TabIndex = 1;
            clubCustomerCheckbox.Text = "Are you a club customer?";
            clubCustomerCheckbox.UseVisualStyleBackColor = true;
            // 
            // Cashier
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(clubCustomerCheckbox);
            Controls.Add(startOrderButton);
            Name = "Cashier";
            Text = "StartOrderForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button startOrderButton;
        private CheckBox clubCustomerCheckbox;
    }
}