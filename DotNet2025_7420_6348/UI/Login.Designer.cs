namespace UI
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            cashierButton = new Button();
            mangerButton = new Button();
            date = new Label();
            realDate = new Label();
            welcome = new Label();
            SuspendLayout();
            // 
            // cashierButton
            // 
            cashierButton.Location = new Point(201, 278);
            cashierButton.Margin = new Padding(5);
            cashierButton.Name = "cashierButton";
            cashierButton.Size = new Size(415, 100);
            cashierButton.TabIndex = 0;
            cashierButton.Text = "for loging in as a cashier";
            cashierButton.UseVisualStyleBackColor = true;
            cashierButton.Click += cashierButton_Click;
            // 
            // mangerButton
            // 
            mangerButton.Location = new Point(201, 148);
            mangerButton.Margin = new Padding(5);
            mangerButton.Name = "mangerButton";
            mangerButton.Size = new Size(415, 100);
            mangerButton.TabIndex = 0;
            mangerButton.Text = "for loging in as a manager";
            mangerButton.UseVisualStyleBackColor = true;
            mangerButton.Click += mangerButton_Click;
            // 
            // date
            // 
            date.AutoSize = true;
            date.Location = new Point(757, 22);
            date.Name = "date";
            date.Size = new Size(0, 20);
            date.TabIndex = 1;
            // 
            // realDate
            // 
            realDate.AutoSize = true;
            realDate.Location = new Point(621, 33);
            realDate.Name = "realDate";
            realDate.Size = new Size(39, 20);
            realDate.TabIndex = 2;
            realDate.Text = "date";
            // 
            // welcome
            // 
            welcome.AutoSize = true;
            welcome.Font = new Font("Segoe UI", 20F);
            welcome.Location = new Point(117, 81);
            welcome.Margin = new Padding(10, 0, 10, 0);
            welcome.Name = "welcome";
            welcome.Padding = new Padding(10, 0, 10, 0);
            welcome.Size = new Size(617, 46);
            welcome.TabIndex = 3;
            welcome.Text = "good morning, welcome to out shop....";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(welcome);
            Controls.Add(realDate);
            Controls.Add(date);
            Controls.Add(mangerButton);
            Controls.Add(cashierButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button cashierButton;
        private Button mangerButton;
        private Label date;
        private Label realDate;
        private Label welcome;
    }
}