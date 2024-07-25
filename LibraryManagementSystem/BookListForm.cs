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
    public partial class BookListForm : Form
    {
        private string selectedBookTitle;
        private ListView bookListView; // Declare the ListView
        private LibraryManager libraryManager; // Create an instance of your LibraryManager class


        public BookListForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            // Initialize your LibraryManager
            this.libraryManager = LibraryManager.Instance;
            LibraryManager.AddBooksToListView(lvBookList);

            // Subscribe to the TextChanged event for search functionality
            SearchBar.TextChanged += textBoxSearch_TextChanged;
            this.MaximizeBox = false;

        }

        private void btnBookList_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBorrowerList_Click(object sender, EventArgs e)
        {
            BookBorrower mainForm = new BookBorrower();
            mainForm.Show();
            this.Hide();
        }

        private void btnBookBorrowing_Click(object sender, EventArgs e)
        {
            //string bookTitle = "Some Book Title";
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

        private void btnPenalty_Click_1(object sender, EventArgs e)
        {
            Penalty mainForm = new Penalty();
            mainForm.Show();
            this.Hide();
        }

        private Button lastClickedButton; // Variable to store the last clicked button

        

       

        // Inside your BookListForm class
        private void BookListForm_Load(object sender, EventArgs e)
        {
            libraryManager.UpdateListView(lvBookList);
        }



        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BGPANEL_Paint(object sender, PaintEventArgs e)
        {

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

        

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = SearchBar.Text.ToLower();

            // Clear the existing items
            lvBookList.Items.Clear();

            // Add the items based on the filtered state of your books
            foreach (var book in libraryManager.Books)
            {
                if (book.Title.ToLower().Contains(searchTerm) ||
                    book.Author.ToLower().Contains(searchTerm) ||
                    book.ISBN.ToLower().Contains(searchTerm) ||
                    book.Category.ToString().ToLower().Contains(searchTerm))
                {
                    ListViewItem item = new ListViewItem(new[]
                    {
                book.Title,
                book.ISBN,
                book.Category.ToString(),
                book.Author,
                book.Year.ToString(),
                book.Publisher,
                book.Status.ToString(),
                // Add more properties as needed
            });

                    lvBookList.Items.Add(item);
                }
            }
        }


        // non fiction picture bo
    }
}
