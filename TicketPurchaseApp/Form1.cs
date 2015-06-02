using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketPurchaseApp
{
    public partial class TicketPurchaseUI : Form
    {
        private double unitPrice = 380, totalPrice;
        private int numberOfTickets;
        private string customerName;

        public TicketPurchaseUI()
        {
            InitializeComponent();
        }

        //List<string> deatils = new List<string>(); 
        private void purchaseButton_Click(object sender, EventArgs e)
        {
            numberOfTickets = Convert.ToInt32(numberOfTicketsTextBox.Text);
            customerName = customerNameTextBox.Text;

            //deatils.Add(custmerName);
            //deatils.Add(numberOfTicketsTextBox.Text);

            totalPrice = numberOfTickets*unitPrice;

            MessageBox.Show(customerName + ", Please Pay " + totalPrice + " Taka to Purchase "
                            + numberOfTickets + " Tickets");
        }

        private void detailsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cutomer Name : " + customerName + "\nUnit Price : " + unitPrice + "\nTotal Price : " +
                            totalPrice);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            customerNameTextBox.Clear();
            numberOfTicketsTextBox.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
