using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LibraryManagementSystem.Login;

namespace LibraryManagementSystem
{
    public partial class BookBorrowingFormsStudent : Form
    {
        private TextBox bookIdTextBox;
        private TextBox borrowerIdTextBox;
        private DateTimePicker borrowDateTimePicker;
        private DateTimePicker dueDateTimePicker;
        private LibraryManager libraryManager; // Create an instance of your LibraryManager class
        private string selectedBookTitle;


        public BookBorrowingFormsStudent(string bookTitle)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.libraryManager = LibraryManager.Instance; // Create an instance of your LibraryManager class
            LibraryManager libraryManager = LibraryManager.Instance;

            // Initialize DateTimePicker controls
            borrowDateTimePicker = new DateTimePicker();
            dueDateTimePicker = new DateTimePicker();

            // Add DateTimePicker controls to the form's controls
            this.Controls.Add(borrowDateTimePicker);
            this.Controls.Add(dueDateTimePicker);
            this.selectedBookTitle = bookTitle;
            this.MaximizeBox = false;
        }


        internal class Book
        {
            public object Title { get; internal set; }
        }

        private void teacherRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (teacherRadio.Checked)
            {
                // Redirect to TeacherForm
                BookBorrowingForms mainForm = new BookBorrowingForms(selectedBookTitle);
                mainForm.Show();
                this.Hide(); // Optional: Hide the main form
            }
        }

        private void btnBorrowerList_Click(object sender, EventArgs e)
        {
            BookBorrower mainForm = new BookBorrower();
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

        private void label8_Click(object sender, EventArgs e)
        {
        }

        public class User
        {
            public string UserName { get; set; }
            // Other properties and methods...
        }


        private void borrowButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve values from ComboBox controls
                string bookNameCombo2 = bookSelectedCombo2.Text;
                string bookNameCombo3 = bookSelectedCombo3.Text;
                string bookNameCombo = bookSelectedCombo.Text;

                // Check if none of the ComboBoxes have a selected book
                if (string.IsNullOrEmpty(bookNameCombo2) && string.IsNullOrEmpty(bookNameCombo3) && string.IsNullOrEmpty(bookNameCombo))
                {
                    MessageBox.Show("Please select at least one book");
                    return;
                }

                // Filter out empty or null book names
                List<string> selectedBookNames = new List<string>
                {
                    bookNameCombo2, bookNameCombo3, bookNameCombo
                }.Where(name => !string.IsNullOrEmpty(name)).ToList();

                // Validate that the user has selected between 1 and 3 books
                if (selectedBookNames.Count < 1 || selectedBookNames.Count > 3)
                {
                    MessageBox.Show("Please select between 1 and 3 books");
                    return;
                }

                // Now you can proceed with retrieving the selected books and performing the borrow operation
                List<LibraryManagementSystem.Book> selectedBooks = selectedBookNames.Select(name => libraryManager.GetBookByName(name)).ToList();

                string borrowerName = borrowerTextBox.Text.Trim();
                if (string.IsNullOrEmpty(borrowerName))
                {
                    MessageBox.Show("Invalid or empty Borrower Name");
                    return;
                }

                int borrowerId;
                if (!int.TryParse(studentIDtextBox.Text, out borrowerId))
                {
                    MessageBox.Show("Invalid Borrower ID");
                    return;
                }

                string yearLevel = cbYrLevel.Text; // Retrieve the year level
                string section = sectionTextBox.Text; // Retrieve the section

                // Attempt to convert string variables to the appropriate data types
                if (string.IsNullOrEmpty(yearLevel))
                {
                    MessageBox.Show($"Invalid numeric value for yearLevel: {yearLevel}");
                    return;
                }

                // Add new student after borrowing the books
                libraryManager.AddNewStudent(borrowerId, borrowerName, yearLevel, section);

                // Retrieve the user
                LibraryManagementSystem.User borrower = libraryManager.GetUserById(borrowerId.ToString());

                if (borrower == null)
                {
                    MessageBox.Show($"Borrower with ID '{borrowerId}' not found");
                    return;
                }

                if (!(borrower is LibraryManagementSystem.Student student))
                {
                    MessageBox.Show($"User with ID '{borrowerId}' is not a student");
                    return;
                }

                // Check if Borrow Date is in the present or future
                DateTime borrowDate = dateBorrowed.Value;
                DateTime dueDate = dueDateTimePicker.Value;

                if (borrowDate < DateTime.Today)
                {
                    MessageBox.Show("Borrow Date must be today or a future date");
                    return;
                }

                // Check if the duration is within the allowed range (3 days)
                TimeSpan borrowingDuration = dueDate - borrowDate;
                if (borrowingDuration.TotalDays > 3)
                {
                    MessageBox.Show("Students can borrow a book for a maximum of 3 days.");
                    return;
                }

                // Borrow each book for the student
                foreach (var selectedBook in selectedBooks)
                {
                    if (selectedBook != null)
                    {
                        libraryManager.BorrowBook(student, selectedBook, borrowDate, dueDate);
                        // Optionally, show a success message or update UI for each book
                    }
                    else
                    {
                        MessageBox.Show("One of the selected books is null");
                    }
                }

                // Optionally, update UI or show a success message
            }
            catch (Exception ex)
            {
                // Handle the exception (e.g., display an error message or log the exception)
                MessageBox.Show($"Error: {ex.Message}");
            }
        }


        private void BookBorrowingFormsStudent_Load(object sender, EventArgs e)
        {
            // Set the MinDate for the DateTimePicker controls to prevent selection of past dates
            borrowDateTimePicker.MinDate = DateTime.Now;
            dueDateTimePicker.MinDate = DateTime.Now;

            // Add your code for the BookBorrowingFormsStudent_Load event here
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

        private void label6_Click(object sender, EventArgs e)
        {
            // Add your code for the label6_Click event here
        }

        private void borrowerTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Add your code for the borrowerTextBox_KeyPress event here
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32)
            {
                e.Handled = true; // Allow only letters, backspace, and space
            }
        }

        private void btnBookList_Click_1(object sender, EventArgs e)
        {
            BookListForm mainForm = new BookListForm();
            mainForm.Show();
            this.Hide();
        }

        private void cancelBorrow_Click(object sender, EventArgs e)
        {
            borrowerTextBox.Clear();
            studentIDtextBox.Clear();
            cbYrLevel.Items.Clear();
            bookSelectedCombo.Items.Clear();
            bookSelectedCombo2.Items.Clear();
            bookSelectedCombo3.Items.Clear();
            
        }
    }
}
