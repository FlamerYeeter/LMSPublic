using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LibraryManagementSystem.LibraryManager;

namespace LibraryManagementSystem
{
    public partial class BookReservationsForms : Form
    {

        private string selectedBookTitle;
        private LibraryManager libraryManager; // Create an instance of your LibraryManager class
        public BookReservationsForms()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.libraryManager = LibraryManager.Instance; // Create an instance of your LibraryManager class
            LibraryManager libraryManager = LibraryManager.Instance;
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve values from ComboBox controls
                string bookNameCombo1 = comboBox1SelectbookTitle.SelectedItem?.ToString();
                string bookNameCombo2 = comboBox2SelectBookTitle.SelectedItem?.ToString();
                string bookNameCombo3 = comboBox3SelectBookTitle.SelectedItem?.ToString();
                string bookNameCombo4 = comboBox4SelectBookTitle.SelectedItem?.ToString();
                string bookNameCombo5 = comboBox5SelectBookTitle.SelectedItem?.ToString();

                // Check if none of the ComboBoxes have a selected book
                if (string.IsNullOrEmpty(bookNameCombo1) && string.IsNullOrEmpty(bookNameCombo2) &&
                    string.IsNullOrEmpty(bookNameCombo3) && string.IsNullOrEmpty(bookNameCombo4) &&
                    string.IsNullOrEmpty(bookNameCombo5))
                {
                    MessageBox.Show("Please select at least one book");
                    return;
                }

                // Filter out empty or null book names
                List<string> selectedBookNames = new List<string>
        {
            bookNameCombo1, bookNameCombo2, bookNameCombo3, bookNameCombo4, bookNameCombo5
        }.Where(name => !string.IsNullOrEmpty(name)).ToList();

                // Validate that the user has selected between 1 and 5 books
                if (selectedBookNames.Count < 1 || selectedBookNames.Count > 5)
                {
                    MessageBox.Show("Please select between 1 and 5 books");
                    return;
                }

                // Now you can proceed with retrieving the selected books and performing the reserve operation
                List<Book> selectedBooks = selectedBookNames.Select(name => libraryManager.GetBookByName(name)).ToList();

                // Check if any selected book is null
                if (selectedBooks.All(book => book == null))
                {
                    MessageBox.Show("No valid books selected");
                    return;
                }

                // Assuming you have the user who wants to reserve the book (you need to get this information)
                // For demonstration purposes, let's assume the user is a Teacher

                ReserveUser person = new ReserveUser
                {
                    PersonID = 1, // You need to set the actual Teacher ID
                    UserName = textBoxBorrower.Text,
                    Department = "SampleDepartment"
                };

                // Reserve each book for the borrower
                foreach (var selectedBook in selectedBooks)
                {
                    libraryManager.ReserveBook(person, selectedBook);
                    // Optionally, show a success message or update UI for each book
                }

                // Optionally, update UI or show a success message
                MessageBox.Show($"Books reserved successfully by {person.UserName}!");
            }
            catch (Exception ex)
            {
                // Handle the exception (e.g., display an error message or log the exception)
                MessageBox.Show($"Error: {ex.Message}");
            }
        }



        private void linkLabelAdd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void comboBox2SelectBookTitle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            comboBox1SelectbookTitle.Items.Clear();
            comboBox2SelectBookTitle.Items.Clear();
            comboBox3SelectBookTitle.Items.Clear();
            comboBox4SelectBookTitle.Items.Clear();
            comboBox5SelectBookTitle.Items.Clear();
            textBoxBorrower.Clear();
        }

        private void BookReservationsForms_Load(object sender, EventArgs e)
        {

        }
    }
}
