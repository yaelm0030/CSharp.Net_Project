
namespace UI
{
    partial class Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
            productsButton = new Button();
            salesButton = new Button();
            customerButtton = new Button();
            SuspendLayout();
            // 
            // productsButton
            // 
            productsButton.Location = new Point(249, 105);
            productsButton.Name = "productsButton";
            productsButton.Size = new Size(303, 74);
            productsButton.TabIndex = 0;
            productsButton.Text = "for products";
            productsButton.UseVisualStyleBackColor = true;
            productsButton.Click += productsButton_Click;
            // 
            // salesButton
            // 
            salesButton.Location = new Point(249, 199);
            salesButton.Name = "salesButton";
            salesButton.Size = new Size(303, 74);
            salesButton.TabIndex = 0;
            salesButton.Text = "for sales";
            salesButton.UseVisualStyleBackColor = true;
            salesButton.Click += salesButton_Click;
            // 
            // customerButtton
            // 
            customerButtton.Location = new Point(249, 292);
            customerButtton.Name = "customerButtton";
            customerButtton.Size = new Size(303, 74);
            customerButtton.TabIndex = 0;
            customerButtton.Text = "for customers";
            customerButtton.UseVisualStyleBackColor = true;
            customerButtton.Click += customerButtton_Click;
            // 
            // Manager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(customerButtton);
            Controls.Add(salesButton);
            Controls.Add(productsButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Manager";
            Text = "Manager";
            ResumeLayout(false);
        }



        #endregion

        private Button productsButton;
        private Button salesButton;
        private Button customerButtton;
    }
}