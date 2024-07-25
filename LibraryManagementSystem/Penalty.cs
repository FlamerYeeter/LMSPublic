using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class Penalty : Form
    {
        private string selectedBookTitle;
        public Penalty()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Login mainForm = new Login();
                mainForm.Show();
                this.Hide();
            }
        }

        private void Penalty_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtAmountDue.Clear();
            txtAmountPaid.Clear();
            txtChange.Clear();

            // Clear the panel
            panelReceipt.Controls.Clear();
        }

        private void btnBookList_Click(object sender, EventArgs e)
        {
            BookListForm mainForm = new BookListForm();
            mainForm.Show();
            this.Hide();
        }

        private void btnBorrowerList_Click(object sender, EventArgs e)
        {
            BookBorrower mainForm = new BookBorrower();
            mainForm.Show();
            this.Hide();
        }

        private void btnBookBorrowing_Click(object sender, EventArgs e)
        {
            BookBorrowingForms mainForm = new BookBorrowingForms(selectedBookTitle);
            mainForm.Show();
            this.Hide();
        }

        private void btnBookReturning_Click(object sender, EventArgs e)
        {
            BookReturningForms mainForm = new BookReturningForms();
            mainForm.Show();
            this.Hide();
        }

        private void btnBookReservation_Click(object sender, EventArgs e)
        {
            BookReservationsForms mainForm = new BookReservationsForms();
            mainForm.Show();
            this.Hide();
        }
        // Add this method to set the penalty information
        public void SetPenaltyInfo(float penaltyAmount)
        {
            // Assuming you have a textbox named txtAmountDue
            txtAmountDue.Text = penaltyAmount.ToString("0.00");
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtAmountPaid.Text, out double amountPaid))
            {
                string borrowerName = "John Doe"; // Replace with actual borrower name
                List<string> booksBorrowed = new List<string> { "Book 1", "Book 2" }; // Replace with actual book titles
                List<string> booksReturned = new List<string> { "Book 3" }; // Replace with actual book titles

                double amountDue = double.Parse(txtAmountDue.Text);
                double change = amountPaid - amountDue;

                txtChange.Text = change.ToString("0.00");

                DisplayReceipt(amountDue, amountPaid, change, borrowerName, booksBorrowed, booksReturned);
            }
            else
            {
                MessageBox.Show("Please enter a valid amount for Amount Paid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DisplayReceipt(double amountDue, double amountPaid, double change, string borrowerName, List<string> booksBorrowed, List<string> booksReturned)
        {
            panelReceipt.Controls.Clear();

            Label lblAmountDue = new Label();
            lblAmountDue.Text = $"Amount Due: {amountDue.ToString("0.00")}";
            lblAmountDue.AutoSize = true;
            lblAmountDue.Location = new System.Drawing.Point(10, 10);

            Label lblAmountPaid = new Label();
            lblAmountPaid.Text = $"Amount Paid: {amountPaid.ToString("0.00")}";
            lblAmountPaid.AutoSize = true;
            lblAmountPaid.Location = new System.Drawing.Point(10, 30);

            Label lblChange = new Label();
            lblChange.Text = $"Change: {change.ToString("0.00")}";
            lblChange.AutoSize = true;
            lblChange.Location = new System.Drawing.Point(10, 50);

            Label lblBorrowerName = new Label();
            lblBorrowerName.Text = $"Borrower: {borrowerName}";
            lblBorrowerName.AutoSize = true;
            lblBorrowerName.Location = new System.Drawing.Point(10, 70);

            Label lblBooksBorrowed = new Label();
            lblBooksBorrowed.Text = "Books Borrowed:";
            lblBooksBorrowed.AutoSize = true;
            lblBooksBorrowed.Location = new System.Drawing.Point(10, 90);

            int yPos = 110;
            foreach (var book in booksBorrowed)
            {
                Label lblBook = new Label();
                lblBook.Text = $"- {book}";
                lblBook.AutoSize = true;
                lblBook.Location = new System.Drawing.Point(20, yPos);
                panelReceipt.Controls.Add(lblBook);
                yPos += 20;
            }

            Label lblBooksReturned = new Label();
            lblBooksReturned.Text = "Books Returned:";
            lblBooksReturned.AutoSize = true;
            lblBooksReturned.Location = new System.Drawing.Point(10, yPos + 10);

            yPos += 30;
            foreach (var book in booksReturned)
            {
                Label lblBook = new Label();
                lblBook.Text = $"- {book}";
                lblBook.AutoSize = true;
                lblBook.Location = new System.Drawing.Point(20, yPos);
                panelReceipt.Controls.Add(lblBook);
                yPos += 20;
            }

            panelReceipt.Controls.Add(lblAmountDue);
            panelReceipt.Controls.Add(lblAmountPaid);
            panelReceipt.Controls.Add(lblChange);
            panelReceipt.Controls.Add(lblBorrowerName);
            panelReceipt.Controls.Add(lblBooksBorrowed);
            panelReceipt.Controls.Add(lblBooksReturned);
        }
    }
}
