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
using static System.Collections.Specialized.BitVector32;


namespace LibraryManagementSystem
{
    public partial class BookBorrowingForms : Form
    {
        private TextBox bookIdTextBox;
        private TextBox teacherIdTextBox;
        private LibraryManager libraryManager; // Create an instance of your LibraryManager class
        private string selectedBookTitle;


        public BookBorrowingForms(string bookTitle)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.libraryManager = LibraryManager.Instance; // Create an instance of your LibraryManager class
            LibraryManager libraryManager = LibraryManager.Instance;
            this.selectedBookTitle = bookTitle;
            this.MaximizeBox = false;
        }


        internal class Book
        {
            public object Title { get; internal set; }
        }

        private void unborrowedBooksList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void BookBorrowingForms_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void teacherRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void studentRadio_CheckedChanged(object sender, EventArgs e)
        {
            string selectedBookTitle = "Selected Book Title"; // Replace this with your actual code to get the book title

            if (studentRadio.Checked)
            {
                // Redirect to StudentForm
                BookBorrowingFormsStudent mainForm = new BookBorrowingFormsStudent(selectedBookTitle);
                mainForm.Show();
                this.Hide(); // Optional: Hide the main form
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void borrowerTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void departmentTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void employeeIDtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

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

        private void btnPenalty_Click(object sender, EventArgs e)
        {
            Penalty mainForm = new Penalty();
            mainForm.Show();
            this.Hide();
        }

        // Example: Assuming 'UserName' is a property in your 'User' class
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
                string bookNameCombo = bookSelectedCombo.Text;
                string bookNameCombo2 = bookSelectedCombo2.Text;
                string bookNameCombo3 = bookSelectedCombo3.Text;
                string bookNameCombo4 = bookSelectedCombo4.Text;
                string bookNameCombo5 = bookSelectedCombo5.Text;

                // Check if none of the ComboBoxes have a selected book
                if (string.IsNullOrEmpty(bookNameCombo) && string.IsNullOrEmpty(bookNameCombo2) && string.IsNullOrEmpty(bookNameCombo3) && string.IsNullOrEmpty(bookNameCombo4) && string.IsNullOrEmpty(bookNameCombo5))
                {
                    MessageBox.Show("Please select at least one book");
                    return;
                }

                // Filter out empty or null book names
                List<string> selectedBookNames = new List<string>
                {
                    bookNameCombo, bookNameCombo2, bookNameCombo3, bookNameCombo4, bookNameCombo5
                }.Where(name => !string.IsNullOrEmpty(name)).ToList();

                // Validate that the user has selected between 1 and 5 books
                if (selectedBookNames.Count < 1 || selectedBookNames.Count > 5)
                {
                    MessageBox.Show("Please select between 1 and 5 books");
                    return;
                }

                // Now you can proceed with retrieving the selected books and performing the borrow operation
                List<LibraryManagementSystem.Book> selectedBooks = selectedBookNames.Select(name => libraryManager.GetBookByName(name)).ToList();

                // Check if any selected book is null
                if (selectedBooks.All(book => book == null))
                {
                    MessageBox.Show("No valid books selected");
                    return;
                }

                string borrowerName = borrowerTextBox.Text.Trim();
                if (string.IsNullOrEmpty(borrowerName))
                {
                    MessageBox.Show("Invalid or empty Borrower Name");
                    return;
                }

                int borrowerId;
                if (!int.TryParse(employeeIDtextBox.Text, out borrowerId))
                {
                    MessageBox.Show("Invalid Borrower ID");
                    return;
                }

                // Assuming cbDepartment is a ComboBox for selecting the department
                string department = cbDepartment.Text;

                if (string.IsNullOrEmpty(department))
                {
                    MessageBox.Show("Please select a department");
                    return;
                }

                libraryManager.AddNewTeacher(borrowerId, borrowerName, department);
                // Retrieve the borrower
                LibraryManagementSystem.User borrower = libraryManager.GetUserById(borrowerId.ToString());

                if (borrower == null)
                {
                    MessageBox.Show($"Borrower with ID '{borrowerId}' not found");
                    return;
                }

                if (borrower is LibraryManagementSystem.Teacher teacher)
                {
                    // Set the department for teachers
                    teacher.Department = department;
                    libraryManager.AddNewTeacher(teacher.TeacherID, teacher.UserName, teacher.Department);
                }

                // Check if Borrow Date is in the present or future
                DateTime borrowDate = dateBorrowed.Value.Date;

                if (borrowDate < DateTime.Today)
                {
                    MessageBox.Show("Borrow Date must be today or a future date");
                    return;
                }

                // Borrow each book for the borrower
                foreach (var selectedBook in selectedBooks)
                {
                    libraryManager.BorrowBook(borrower, selectedBook, DateTime.Now, DateTime.Now.AddDays(14));
                    // Optionally, show a success message or update UI for each book
                }

                // Optionally, update UI or show a success message
            }
            catch (Exception ex)
            {
                // Handle the exception (e.g., display an error message or log the exception)
                MessageBox.Show($"Error: {ex.Message}");
            }
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


        private void borrowerTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32)
            {
                e.Handled = true; // Allow only letters, backspace, and space
            }
        }

        private void btnBookList_Click(object sender, EventArgs e)
        {
            BookListForm mainForm = new BookListForm();
            mainForm.Show();
            this.Hide();
        }

        private void bookSelectedCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cancelBorrow_Click(object sender, EventArgs e)
        {
            borrowerTextBox.Clear();
            employeeIDtextBox.Clear();
            cbDepartment.Items.Clear();
            bookSelectedCombo.Items.Clear();
            bookSelectedCombo2.Items.Clear();
            bookSelectedCombo3.Items.Clear();
            bookSelectedCombo4.Items.Clear();
            bookSelectedCombo5.Items.Clear();

        }
    }
}