using System;

namespace LibraryManagementSystem
{
    internal class Library
    {
        public Library()
        {
        }

        internal void BorrowBook(BookBorrowingForms.User borrower, Book selectedBook, DateTime borrowDate, DateTime dueDate)
        {
            throw new NotImplementedException();
        }

        internal void BorrowBook(BookBorrowingFormsStudent.User student, Book selectedBook, DateTime borrowDate, DateTime dueDate)
        {
            throw new NotImplementedException();
        }

        internal Book GetBookById(int bookId)
        {
            throw new NotImplementedException();
        }

        internal BookBorrowingForms.User GetUserById(int borrowerId)
        {
            throw new NotImplementedException();
        }
    }
}