namespace TicketPurchaseApp
{
    partial class TicketPurchaseUI
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
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.numberOfTicketsTextBox = new System.Windows.Forms.TextBox();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.NumberOfTicketsLabel = new System.Windows.Forms.Label();
            this.purchaseButton = new System.Windows.Forms.Button();
            this.detailsButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(317, 41);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(218, 20);
            this.customerNameTextBox.TabIndex = 0;
            // 
            // numberOfTicketsTextBox
            // 
            this.numberOfTicketsTextBox.Location = new System.Drawing.Point(317, 67);
            this.numberOfTicketsTextBox.Name = "numberOfTicketsTextBox";
            this.numberOfTicketsTextBox.Size = new System.Drawing.Size(217, 20);
            this.numberOfTicketsTextBox.TabIndex = 1;
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Location = new System.Drawing.Point(212, 44);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(82, 13);
            this.customerNameLabel.TabIndex = 2;
            this.customerNameLabel.Text = "Customer Name";
            // 
            // NumberOfTicketsLabel
            // 
            this.NumberOfTicketsLabel.AutoSize = true;
            this.NumberOfTicketsLabel.Location = new System.Drawing.Point(212, 70);
            this.NumberOfTicketsLabel.Name = "NumberOfTicketsLabel";
            this.NumberOfTicketsLabel.Size = new System.Drawing.Size(94, 13);
            this.NumberOfTicketsLabel.TabIndex = 3;
            this.NumberOfTicketsLabel.Text = "Number of Tickets";
            // 
            // purchaseButton
            // 
            this.purchaseButton.Location = new System.Drawing.Point(215, 137);
            this.purchaseButton.Name = "purchaseButton";
            this.purchaseButton.Size = new System.Drawing.Size(79, 22);
            this.purchaseButton.TabIndex = 4;
            this.purchaseButton.Text = "Purchase";
            this.purchaseButton.UseVisualStyleBackColor = true;
            this.purchaseButton.Click += new System.EventHandler(this.purchaseButton_Click);
            // 
            // detailsButton
            // 
            this.detailsButton.Location = new System.Drawing.Point(299, 137);
            this.detailsButton.Name = "detailsButton";
            this.detailsButton.Size = new System.Drawing.Size(75, 23);
            this.detailsButton.TabIndex = 5;
            this.detailsButton.Text = "Details";
            this.detailsButton.UseVisualStyleBackColor = true;
            this.detailsButton.Click += new System.EventHandler(this.detailsButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(379, 137);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(459, 137);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "One Ticket 380 Taka.";
            // 
            // TicketPurchaseUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 388);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.detailsButton);
            this.Controls.Add(this.purchaseButton);
            this.Controls.Add(this.NumberOfTicketsLabel);
            this.Controls.Add(this.customerNameLabel);
            this.Controls.Add(this.numberOfTicketsTextBox);
            this.Controls.Add(this.customerNameTextBox);
            this.Name = "TicketPurchaseUI";
            this.Text = "Ticket Purchase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.TextBox numberOfTicketsTextBox;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.Label NumberOfTicketsLabel;
        private System.Windows.Forms.Button purchaseButton;
        private System.Windows.Forms.Button detailsButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
    }
}

