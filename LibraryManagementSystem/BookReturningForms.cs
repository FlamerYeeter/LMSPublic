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

namespace LibraryManagementSystem
{
    public partial class BookReturningForms : Form
    {
        private DateTime dueDate; //Added 1
        private DateTime returnDate; //Added 12
        private List<BookReturn> bookReturns = new List<BookReturn>(); //Added 11
        private LibraryManager libraryManager; // Create an instance of your LibraryManager class
        private string selectedBookTitle;

        public BookReturningForms()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.libraryManager = LibraryManager.Instance; // Create an instance of your LibraryManager class
            LibraryManager libraryManager = LibraryManager.Instance;

        }

        private void BookReturningForms_Load(object sender, EventArgs e)
        {
            teacherRadio.CheckedChanged += teacherRadio_CheckedChanged;
            studentRadio.CheckedChanged += studentRadio_CheckedChanged;

            // Call the method to populate borrowed books in the ComboBox
            PopulateBorrowedBooksComboBox();

            // other code...
        }

        private void PopulateBorrowedBooksComboBox()
        {
            // Assuming you have access to the borrowed books list from your data source
            List<BorrowedBook> borrowedBooks = GetBorrowedBooks(); // Implement this method

            // Bind the borrowed books list to the ComboBox
            borrowedBooksComboBox.DataSource = borrowedBooks;
            borrowedBooksComboBox.DisplayMember = "BookName"; // Replace with the actual property name representing the book name
            borrowedBooksComboBox.ValueMember = "BookID"; // Replace with the actual property name representing the book ID
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public class BorrowedBook
        {
            public int BookID { get; set; }
            public int BorrowerID { get; set; }
            public BorrowerType BorrowerType { get; set; }
            public DateTime BorrowDate { get; set; }
            public DateTime DueDate { get; set; }
            public DateTime ReturnDate { get; set; }
            public int Penalty { get; set; }
            public string BookName { get; set; }
            // other properties
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

        private void btnBookReservation_Click(object sender, EventArgs e)
        {
            BookReservationsForms mainForm = new BookReservationsForms();
            mainForm.Show();
            this.Hide();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (studentRadio.Checked)
            {
                // Redirect to student form or perform student-specific actions
                float penalty = CalculatePenalty(dueDate, returnDate);

                // Display the penalty in the DataGridView
                DisplayPenaltyInDataGridView(penalty);

                // Open Penalty form and pass penalty information
                Penalty penaltyForm = new Penalty();
                penaltyForm.SetPenaltyInfo(penalty);
                penaltyForm.Show();
                this.Hide();
                //btnCalculate.BackColor = Color.DodgerBlue;
            }
            else if (teacherRadio.Checked)
            {
                // For teachers, disable the button (you can also perform other actions)
                btnCalculate.Enabled = false;
                //btnCalculate.BackColor = Color.Gray;
            }
        }
        private void DisplayPenaltyInDataGridView(float penalty)
        {
            try
            {
                // Assuming you have a DataTable or a DataGridView named dataGridViewDetails
                DataTable dataTable = (DataTable)dataGridViewDetails.DataSource;

                // Assuming you have a row index for the current book return operation
                int currentRowIndex = 0; // Replace with your actual logic to get the row index

                // Assuming you have a column named "Penalty" in the DataTable
                if (dataTable != null && dataTable.Rows.Count > currentRowIndex)
                {
                    dataTable.Rows[currentRowIndex]["Penalty"] = penalty.ToString("0.00");
                }
                else
                {
                    MessageBox.Show("Invalid row index or DataTable is not properly initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating DataTable: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void teacherRadio_CheckedChanged(object sender, EventArgs e)
        {
            btnCalculate.BackColor = teacherRadio.Checked ? DefaultBackColor : btnCalculate.BackColor;
            btnCalculate.ForeColor = teacherRadio.Checked ? Color.Black : DefaultForeColor;
            dateTimeDueDate.Enabled = !teacherRadio.Checked;
        }

        private void studentRadio_CheckedChanged(object sender, EventArgs e)
        {
            btnCalculate.Enabled = studentRadio.Checked;
            btnCalculate.BackColor = studentRadio.Checked ? Color.DodgerBlue : DefaultBackColor;
            btnCalculate.ForeColor = studentRadio.Checked ? Color.White : DefaultForeColor;
            dateTimeDueDate.Enabled = studentRadio.Checked;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxBorrower.Text))
            {
                MessageBox.Show("Please enter the borrower's name.", "Crimson Library System | Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (HasPenalty()) //Added 4
            {
                MessageBox.Show("Books cannot be returned due to penalty", "Crimson Library System | Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            PerformReturnOperation();

            
           MessageBox.Show($"Books returned successfully!", "Crimson Library System", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool HasPenalty() //Added 5
        {
            // Your logic to check if there's a penalty (replace this with your actual implementation)
            return false;
        }

        private void PerformReturnOperation()
        {
            try
            {
                // Your logic for returning books

                // Assuming you have a BookReturn class or a similar structure to hold return details
                BorrowedBook borrowedBook = GetSelectedBorrowedBook(); // Implement this method to get the selected borrowed book

                if (borrowedBook != null)
                {
                    BookReturn returnDetails = new BookReturn
                    {
                        BookName = borrowedBook.BookName, // Use the BookName property of the selected book
                        Genre = "", // You might want to get this information from your data
                        Author = "", // You might want to get this information from your data
                        Penalty = CalculatePenalty(dueDate, returnDate)
                    };

                    bookReturns.Add(returnDetails);
                    UpdateDataGridView();

                    MessageBox.Show($"Books returned successfully!", "Crimson Library System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                // else: No need to display a message here; the GetSelectedBorrowedBook method handles it
            }
            catch (Exception ex)
            {
                // Handle the exception
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private BorrowedBook GetSelectedBorrowedBook()
        {
            // Assuming you have access to the selected borrowed book in the list or control
            // Implement this method to retrieve the selected borrowed book

            if (borrowedBooksComboBox.SelectedItem is BorrowedBook selectedBorrowedBook)
            {
                return selectedBorrowedBook;
            }
            else
            {
                MessageBox.Show("Please select a borrowed book for return.");
                return null;
            }
        }



        private void UpdateDataGridView() //Added 10
        {
            // Assuming you have a DataTable to bind to the DataGridView
            DataTable dataTable = ConvertToDataTable(bookReturns);

            // Bind the DataTable to the DataGridView
            dataGridViewDetails.DataSource = dataTable;
        }
        private float CalculatePenalty(DateTime dueDate, DateTime returnDate) //Added 9
        {
            // Only apply penalty for students
            if (studentRadio.Checked)
            {
                const float penaltyRatePerDay = 20.0f;

                // Calculate the difference in days, ensuring it's a positive or zero value
                int daysLate = Math.Max(0, (int)(returnDate - dueDate).TotalDays);

                // Calculate penalty only if the book is returned after the due date
                return daysLate > 0 ? daysLate * penaltyRatePerDay : 0.0f;
            }

            // No penalty for teachers
            return 0.0f;
        }

        private DataTable ConvertToDataTable(List<BookReturn> bookReturns) //Added 7
        {
            // Create a DataTable with columns representing the return details
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Book Name", typeof(string));
            dataTable.Columns.Add("Genre", typeof(string));
            dataTable.Columns.Add("Author", typeof(string));
            dataTable.Columns.Add("Penalty", typeof(float));
            // Add other columns as needed

            // Add rows to the DataTable
            foreach (var returnDetail in bookReturns)
            {
                DataRow row = dataTable.NewRow();
                row["Book Name"] = returnDetail.BookName;
                row["Genre"] = returnDetail.Genre;
                row["Author"] = returnDetail.Author;
                row["Penalty"] = returnDetail.Penalty.ToString("0.00");
                // Set values for other columns
                dataTable.Rows.Add(row);
            }

            return dataTable;
        }

        // Assuming you have a BookReturn class or a similar structure
        public class BookReturn //Added 8
        {
            public string BookName { get; set; }
            public string Genre { get; set; }
            public string Author { get; set; }
            public float Penalty { get; set;}
            // Add other properties as needed
        }

        private User GetUser()
        {
            // Implement logic to get the current user (User) from your data source
            // Return the User object
            return new User();
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

        private void textBoxBorrower_KeyPress(object sender, KeyPressEventArgs e)
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public List<BookReturningForms.BorrowedBook> GetBorrowedBooks()
        {
            // Assuming LibraryManager.Instance.BorrowedBooks is already a List<BorrowedBook>
            return LibraryManager.Instance.BorrowedBooks.Select(b => new BookReturningForms.BorrowedBook
            {
                BookID = b.BookID,
                BorrowerID = b.BorrowerID,
                BorrowerType = b.BorrowerType,
                BorrowDate = b.BorrowDate,
                DueDate = b.DueDate,
                ReturnDate = b.ReturnDate,
                Penalty = b.Penalty,
                BookName = b.BookName
                // Add other properties as needed
            }).ToList();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            textBoxBorrower.Clear();
            
            
        }
    }
}
//muntik na HAHAHAH