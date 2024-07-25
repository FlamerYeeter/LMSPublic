using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibraryManagementSystem
{
    public partial class BookBorrower : Form
    {
        
        private string selectedBookTitle;

        public BookBorrower()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeListViewColumnsForStudents();
            InitializeListViewColumnsForTeachers();
            this.MaximizeBox = false;
        }

        private void BookBorrower_Load(object sender, EventArgs e)
        {

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

        private void btnPenalty_Click(object sender, EventArgs e)
        {
            Penalty mainForm = new Penalty();
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

        private void btnBookList_Click(object sender, EventArgs e)
        {
            BookListForm mainForm = new BookListForm();
            mainForm.Show();
            this.Hide();
        }

        private void btnBorrowerTeacher_Click(object sender, EventArgs e)
        {
            InitializeListViewColumnsForTeachers();
        }

        private void btnBorrowerStudent_Click(object sender, EventArgs e)
        {
            InitializeListViewColumnsForStudents();
        }
        private void InitializeListViewColumnsForStudents()
        {
            // Clear existing columns
            listViewBorrower.Columns.Clear();
            listViewBorrower.Clear(); //it can be change anytime

            // Add columns for students
            listViewBorrower.Columns.Add("", 30);
            listViewBorrower.Columns.Add("Name", 150);
            listViewBorrower.Columns.Add("Student ID", 100);
            listViewBorrower.Columns.Add("Year", 80);
            listViewBorrower.Columns.Add("Section", 80);
        }
        private void InitializeListViewColumnsForTeachers()
        {
            // Clear existing columns
            listViewBorrower.Columns.Clear();
            listViewBorrower.Clear(); //it can be change anytime

            // Add columns for teachers
            listViewBorrower.Columns.Add("", 30);
            listViewBorrower.Columns.Add("Name", 150);
            listViewBorrower.Columns.Add("Employee ID", 120);
            listViewBorrower.Columns.Add("Department", 150);
        }
    }
}
