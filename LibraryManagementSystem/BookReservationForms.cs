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
    public partial class BookReservationForms : Form
    {
        public BookReservationForms()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void BookReservationForms_Load(object sender, EventArgs e)
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
            BookBorrowingForms mainForm = new BookBorrowingForms();
            mainForm.Show();
            this.Hide();
        }

        private void btnBookReturning_Click(object sender, EventArgs e)
        {
            BookReturningForms mainForm = new BookReturningForms();
            mainForm.Show();
            this.Hide();
        }

        private void btnPenalty_Click(object sender, EventArgs e)
        {
            Penalty mainForm = new Penalty();
            mainForm.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Login mainForm = new Login();
            mainForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnBookList_Click(object sender, EventArgs e)
        {
            BookListForm mainForm = new BookListForm();
            mainForm.Show();
            this.Hide();
        }
    }
}
