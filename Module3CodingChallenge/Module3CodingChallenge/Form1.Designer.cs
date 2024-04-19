namespace Module3CodingChallenge
{
    partial class Form1
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
            Flavor = new ComboBox();
            label1 = new Label();
            lblDescription = new Label();
            lblPrice = new Label();
            label2 = new Label();
            lblDetails = new Label();
            lblPrices = new Label();
            Cookies = new ComboBox();
            SuspendLayout();
            // 
            // Flavor
            // 
            Flavor.FormattingEnabled = true;
            Flavor.Items.AddRange(new object[] { "Vanilla", "Rocky Road", "Strawberry", "Mint" });
            Flavor.Location = new Point(245, 115);
            Flavor.Name = "Flavor";
            Flavor.Size = new Size(151, 28);
            Flavor.TabIndex = 0;
            Flavor.SelectedIndexChanged += Flavor_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 118);
            label1.Name = "label1";
            label1.Size = new Size(208, 20);
            label1.TabIndex = 1;
            label1.Text = "Choose your Ice Cream Flavor:";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(21, 181);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(85, 20);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Description";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(26, 229);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(44, 20);
            lblPrice.TabIndex = 3;
            lblPrice.Text = "Price:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 290);
            label2.Name = "label2";
            label2.Size = new Size(150, 20);
            label2.TabIndex = 5;
            label2.Text = "Choose your Cookies:";
            // 
            // lblDetails
            // 
            lblDetails.AutoSize = true;
            lblDetails.Location = new Point(64, 356);
            lblDetails.Name = "lblDetails";
            lblDetails.Size = new Size(55, 20);
            lblDetails.TabIndex = 6;
            lblDetails.Text = "Details";
            // 
            // lblPrices
            // 
            lblPrices.AutoSize = true;
            lblPrices.Location = new Point(64, 401);
            lblPrices.Name = "lblPrices";
            lblPrices.Size = new Size(44, 20);
            lblPrices.TabIndex = 7;
            lblPrices.Text = "Price:";
            // 
            // Cookies
            // 
            Cookies.AutoCompleteCustomSource.AddRange(new string[] { "Mint ", "Ice Cream ", "Brownie " });
            Cookies.FormattingEnabled = true;
            Cookies.Items.AddRange(new object[] { "Mint ", "Ice Cream", "Soft" });
            Cookies.Location = new Point(254, 293);
            Cookies.Name = "Cookies";
            Cookies.Size = new Size(151, 28);
            Cookies.TabIndex = 8;
            Cookies.SelectedIndexChanged += Cookies_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Cookies);
            Controls.Add(lblPrices);
            Controls.Add(lblDetails);
            Controls.Add(label2);
            Controls.Add(lblPrice);
            Controls.Add(lblDescription);
            Controls.Add(label1);
            Controls.Add(Flavor);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ice Cream Flavors";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox Flavor;
        private Label label1;
        private Label lblDescription;
        private Label lblPrice;
        private Label label2;
        private Label lblDetails;
        private Label lblPrices;
        private ComboBox Cookies;
    }
}
