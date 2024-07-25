using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public enum BookStatus
    {
        Reserved,
        Returned,
        Borrowed,
        Unknown
    }


    public enum BorrowerType
    {
        Teacher,
        Student,
        Unknown
    }

    public enum BookCategory
    {
        Fictional,
        NonFictional,
        Academics,
        Unknown
    }

    public class Teacher : User
    {
        public int TeacherID { get; set; }
        public string Department { get; set; }
        public int BooksBorrowed { get; set; }
    }

    public class Student : User
    {
        public int StudentID { get; set; }
        public string YearLevel { get; set; }
        public string Section { get; set; }
        public int Penalty { get; set; }
        public int BooksBorrowed { get; set; }
    }

    public class Book : IComparable<Book>
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public BookStatus Status { get; set; }
        public int TotalCopies { get; set; }
        public int AvailableCopies { get; set; }
        public BookCategory Category { get; set; }
        public string Publisher { get; set; }
        public int Year { get; set; }

        public int CompareTo(Book other)
        {
            if (other == null)
                return 1;

            return string.Compare(this.Title, other.Title, StringComparison.Ordinal);
        }
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
        public string BookName { get; internal set; }
    }

    public class User
    {
        public string UserName { get; set; }
        // Other properties and methods...
    }

    public class LibraryManager
    {
        private static LibraryManager _instance;
        public List<User> Users { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<Student> Students { get; set; }
        public List<Book> Books { get; set; }
        public List<BorrowedBook> BorrowedBooks { get; set; }

        public LibraryManager()
        {
            Users = new List<User>();
            Books = new List<Book>
{
    new Book
    {
        Title = "Harry Potter and The Sorcerer's Stone",
        Author = "J.K Rowling",
        ISBN = "978-0590353427",
        Status = BookStatus.Returned,
        TotalCopies = 1,
        AvailableCopies = 1,
        Category = BookCategory.Fictional,
        Year = 1997,
        Publisher = "Bloomsbury (UK) / Scholastic (US)"
    },
    new Book
    {
        Title = "Percy Jackson: The Lightning Thief",
        Author = "Rick Riordan",
        ISBN = "978-0786838653",
        Status = BookStatus.Returned,
        TotalCopies = 1,
        AvailableCopies = 1,
        Category = BookCategory.Fictional,
        Year = 2005,
        Publisher = "Disney Hyperion"
    },
    new Book
    {
        Title = "The Da Vinci Code",
        Author = "Dan Brown",
        ISBN = "978-0307474278",
        Status = BookStatus.Returned,
        TotalCopies = 1,
        AvailableCopies = 1,
        Category = BookCategory.Fictional,
        Year = 2003,
        Publisher = "Doubleday"
    },
    new Book
    {
        Title = "The Hobbit",
        Author = "J.R.R Tolkien",
        ISBN = "978-0345339683",
        Status = BookStatus.Returned,
        TotalCopies = 1,
        AvailableCopies = 1,
        Category = BookCategory.Fictional,
        Year = 1937,
        Publisher = "George Allen & Unwin"
    },
    new Book
    {
        Title = "The Hunger Games",
        Author = "Suzanne Collins",
        ISBN = "978-0439023481",
        Status = BookStatus.Returned,
        TotalCopies = 1,
        AvailableCopies = 1,
        Category = BookCategory.Fictional,
        Year = 2008,
        Publisher = "Scholastic Press"
    },
    new Book
    {
        Title = "Thinking, Fast and Slow",
        Author = "Daniel Kahneman",
        ISBN = "978-0374533557",
        Status = BookStatus.Returned,
        TotalCopies = 1,
        AvailableCopies = 1,
        Category = BookCategory.NonFictional,
        Year = 2011,
        Publisher = "Farrar, Straus and Giroux"
    },
    new Book
    {
        Title = "Quiet: The Power of Introverts",
        Author = "Susan Cain",
        ISBN = "978-0307352156",
        Status = BookStatus.Returned,
        TotalCopies = 1,
        AvailableCopies = 1,
        Category = BookCategory.NonFictional,
        Year = 2012,
        Publisher = "Susan Cain"
    },
    new Book
    {
        Title = "Sapiens: A Brief History of Humankind",
        Author = "Yuval Noah Harari",
        ISBN = "978-0062316097",
        Status = BookStatus.Returned,
        TotalCopies = 1,
        AvailableCopies = 1,
        Category = BookCategory.NonFictional,
        Year = 2014,
        Publisher = "Harper"
    },
    new Book
    {
        Title = "The Immortal Life of Henrietta Lacks",
        Author = "Rebecca Skloot",
        ISBN = "978-1400052189",
        Status = BookStatus.Returned,
        TotalCopies = 1,
        AvailableCopies = 1,
        Category = BookCategory.NonFictional,
        Year = 2010,
        Publisher = "Crown Publishing Group"
    },
    new Book
    {
        Title = "The Power of Habit",
        Author = "Charles Duhigg",
        ISBN = "978-0812981605",
        Status = BookStatus.Returned,
        TotalCopies = 1,
        AvailableCopies = 1,
        Category = BookCategory.NonFictional,
        Year = 2012,
        Publisher = "Random House"
    },
    new Book
    {
        Title = "Real Estate Finance and Investments",
        Author = "William B. Brueggeman, Jeffrey Fisher",
        ISBN = "978-0073377339",
        Status = BookStatus.Returned,
        TotalCopies = 1,
        AvailableCopies = 1,
        Category = BookCategory.Academics,
        Year = 2015,
        Publisher = "McGraw-Hill Education"
    },
    new Book
    {
        Title = "Economics: Principles, Problems, and Policies",
        Author = "Campbell R. McConnell, Stanley L. Brue, Sean Masaki Flynn",
        ISBN = "978-1305101945",
        Status = BookStatus.Returned,
        TotalCopies = 1,
        AvailableCopies = 1,
        Category = BookCategory.Academics,
        Year = 2015,
        Publisher = "Cengage Learning"
    },
    new Book
    {
        Title = "Principles of Corporate Finance",
        Author = "Richard A. Brealey, Stewart C. Myers, Franklin Allen",
        ISBN = "978-1259144387",
        Status = BookStatus.Returned,
        TotalCopies = 1,
        AvailableCopies = 1,
        Category = BookCategory.Academics,
        Year = 2016,
        Publisher = "McGraw-Hill Education"
    },
    new Book
    {
        Title = "Python for Data Analysis",
        Author = "Wes McKinney",
        ISBN = "978-1491957660",
        Status = BookStatus.Returned,
        TotalCopies = 1,
        AvailableCopies = 1,
        Category = BookCategory.Academics,
        Year = 2017,
        Publisher = "O'Reilly Media"
    },
    new Book
    {
        Title = "Cognitive Psychology",
        Author = "E. Bruce Goldstein",
        ISBN = "978-1-305-27112-6",
        Status = BookStatus.Returned,
        TotalCopies = 1,
        AvailableCopies = 1,
        Category = BookCategory.Academics,
        Year = 2020,
        Publisher = "Cengage Learning"
    },
};
            BorrowedBooks = new List<BorrowedBook>();

            // Initialize Teachers and Students lists
            Teachers = new List<Teacher>();
            Students = new List<Student>();

            // Populate Teachers and Students lists with sample data
            Teachers.AddRange(GenerateSampleTeachers());
            Students.AddRange(GenerateSampleStudents());

        }

        public static LibraryManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new LibraryManager();
                return _instance;
            }
        }

        public void BorrowBook(User borrower, Book selectedBook, DateTime borrowDate, DateTime dueDate)
        {
            // Check if the book is already borrowed or reserved
            if (IsBookReserved(selectedBook))
            {
                MessageBox.Show($"Book '{selectedBook.Title}' is already borrowed or reserved and cannot be borrowed again until it is returned.");
                return;
            }

            if (selectedBook.Status != BookStatus.Returned)
            {
                MessageBox.Show($"Book '{selectedBook.Title}' is not available for borrowing.");
                return;
            }

            int borrowerId = 0;
            BorrowerType borrowerType = BorrowerType.Unknown;
            int maxBooksAllowed = 0;

            if (borrower is Teacher teacher)
            {
                borrowerId = teacher.TeacherID;
                borrowerType = BorrowerType.Teacher;
                maxBooksAllowed = 5; // Teachers can borrow up to 5 books

                // Check if the teacher has reached the maximum number of allowed books
                if (teacher.BooksBorrowed >= maxBooksAllowed)
                {
                    MessageBox.Show($"You have already borrowed the maximum number of allowed books ({maxBooksAllowed}).");
                    return;
                }

                // Check if it's a new teacher and add to the list if needed
                if (!Teachers.Any(t => t.TeacherID == borrowerId))
                {
                    // Assuming you have necessary information to create a new teacher (e.g., department)
                    AddNewTeacher(borrowerId, borrower.UserName, teacher.Department);
                }
            }
            else if (borrower is Student student)
            {
                borrowerId = student.StudentID;
                borrowerType = BorrowerType.Student;
                maxBooksAllowed = 3; // Students can borrow up to 3 books

                // Check if the student has reached the maximum number of allowed books
                if (student.BooksBorrowed >= maxBooksAllowed)
                {
                    MessageBox.Show($"You have already borrowed the maximum number of allowed books ({maxBooksAllowed}).");
                    return;
                }

                // Check if it's a new student and add to the list if needed
                if (!Students.Any(s => s.StudentID == borrowerId))
                {
                    // Assuming you have necessary information to create a new student (e.g., year level, section)
                    AddNewStudent(borrowerId, borrower.UserName, student.YearLevel, student.Section);
                }
            }

            if (borrowerId == 0 || borrowerType == BorrowerType.Unknown)
            {
                MessageBox.Show("Invalid borrower type.");
                return;
            }

            // Check if the book is borrowed by another user
            if (IsBookBorrowed(selectedBook, borrowerId, borrowerType))
            {
                MessageBox.Show($"Book '{selectedBook.Title}' is already borrowed by you and cannot be borrowed again until it is returned.");
                return;
            }

            // Update the book status and add the entry to BorrowedBooks
            LibraryManager.Instance.UpdateBookStatus(selectedBook);

            selectedBook.Status = BookStatus.Borrowed;
            selectedBook.AvailableCopies--;

            BorrowedBooks.Add(new BorrowedBook
            {
                BookID = selectedBook.BookID,
                BorrowerID = borrowerId,
                BorrowerType = borrowerType,
                BorrowDate = borrowDate,
                DueDate = dueDate
            });

            // Update the BooksBorrowed property for both students and teachers
            if (borrower is Student studentBorrower)
            {
                studentBorrower.BooksBorrowed++;
            }
            if (borrower is Teacher teacherBorrower)
            {
                teacherBorrower.BooksBorrowed++;
            }

            MessageBox.Show($"{borrowerType} {borrower.UserName} successfully borrowed the book '{selectedBook.Title}'!");
        }


        public Book GetBookById(int bookId)
        {
            return Books.FirstOrDefault(book => book.BookID == bookId);
        }

        public User GetUserById(int borrowerId)
        {
            var teacher = Teachers.FirstOrDefault(t => t.TeacherID == borrowerId);
            if (teacher != null)
                return teacher;

            var student = Students.FirstOrDefault(s => s.StudentID == borrowerId);
            if (student != null)
                return student;

            return null;
        }

        public User GetUserById(string borrowerId)
        {
            if (int.TryParse(borrowerId, out int parsedId))
            {
                var teacher = Teachers.FirstOrDefault(t => t.TeacherID == parsedId);
                if (teacher != null)
                    return teacher;

                var student = Students.FirstOrDefault(s => s.StudentID == parsedId);
                if (student != null)
                    return student;
            }

            return null;
        }


        public Teacher GetTeacherById(string teacherId)
        {
            return Teachers.FirstOrDefault(teacher => teacher.TeacherID.ToString() == teacherId);
        }

        public bool IsBookAvailable(Book book)
        {
            return book.AvailableCopies > 0;
        }

        public bool IsBookReserved(Book book)
        {
            return BorrowedBooks.Any(bb => bb.BookID == book.BookID && bb.ReturnDate != DateTime.MinValue);
        }

        public bool IsPenaltyUnpaid(int studentId)
        {
            return Students.Any(student => student.StudentID == studentId && student.Penalty > 0);
        }
        public bool IsBookBorrowed(Book book)
        {
            return BorrowedBooks.Any(bb => bb.BookID == book.BookID && bb.ReturnDate == DateTime.MinValue);
        }
        public bool IsBookBorrowed(Book book, int borrowerId, BorrowerType borrowerType)
        {
            // Check if the book is borrowed by the same user with different due dates
            return BorrowedBooks.Any(bb => bb.BookID == book.BookID
                                         && bb.BorrowerID == borrowerId
                                         && bb.BorrowerType == borrowerType
                                         && bb.ReturnDate == DateTime.MinValue
                                         && bb.DueDate > DateTime.Now);
        }


        //public static List<Book> GenerateSampleBooks()
        //{
        //    List<Book> books = new List<Book>();

        //    books.Add(new Book { BookID = 1, Title = "Introduction to Physics", Author = "John Smith", ISBN = "123456789", Status = BookStatus.Available, TotalCopies = 3, AvailableCopies = 3, Category = BookCategory.Academics });
        //    books.Add(new Book { BookID = 2, Title = "Mathematics Fundamentals", Author = "Alice Johnson", ISBN = "987654321", Status = BookStatus.Available, TotalCopies = 2, AvailableCopies = 2, Category = BookCategory.Academics });
        //    books.Add(new Book { BookID = 3, Title = "History of World Wars", Author = "Robert Brown", ISBN = "567890123", Status = BookStatus.Available, TotalCopies = 4, AvailableCopies = 4, Category = BookCategory.Academics });

        //    books.Add(new Book { BookID = 4, Title = "The Art of Programming", Author = "David Jones", ISBN = "345678901", Status = BookStatus.Available, TotalCopies = 5, AvailableCopies = 5, Category = BookCategory.NonFictional });
        //    books.Add(new Book { BookID = 5, Title = "Economics in Modern Society", Author = "Emma White", ISBN = "678901234", Status = BookStatus.Available, TotalCopies = 2, AvailableCopies = 2, Category = BookCategory.NonFictional });
        //    books.Add(new Book { BookID = 6, Title = "Global Warming: A Comprehensive Guide", Author = "Michael Green", ISBN = "901234567", Status = BookStatus.Available, TotalCopies = 3, AvailableCopies = 3, Category = BookCategory.NonFictional });

        //    books.Add(new Book { BookID = 7, Title = "The Mystery of the Lost Key", Author = "Sophie Turner", ISBN = "234567890", Status = BookStatus.Available, TotalCopies = 3, AvailableCopies = 3, Category = BookCategory.Fictional });
        //    books.Add(new Book { BookID = 8, Title = "Science Fiction Adventure", Author = "Andrew Black", ISBN = "456789012", Status = BookStatus.Available, TotalCopies = 4, AvailableCopies = 4, Category = BookCategory.Fictional });
        //    books.Add(new Book { BookID = 9, Title = "Fantasy Realm: Dragons and Wizards", Author = "Olivia Davis", ISBN = "789012345", Status = BookStatus.Available, TotalCopies = 2, AvailableCopies = 2, Category = BookCategory.Fictional });

        //    return books;
        //}

        public static List<Book> ConvertListViewItemsToBooks(ListView listView)
        {
            List<Book> books = new List<Book>();

            foreach (ListViewItem item in listView.Items)
            {
                Book book = new Book
                {
                    Title = item.SubItems[0].Text,
                    ISBN = item.SubItems[1].Text,
                    Author = item.SubItems[3].Text,
                    // Add more properties as needed
                };

                // Parse BookCategory from the string value
                if (Enum.TryParse(item.SubItems[2].Text, out BookCategory category))
                {
                    book.Category = category;
                }
                else
                {
                    // Handle the case where category parsing fails
                    // You might want to set a default value or handle it in a different way
                    // For now, let's set it to BookCategory.Unknown
                    book.Category = BookCategory.Unknown;
                }

                // Assuming you have a BookStatus enum
                if (Enum.TryParse(item.SubItems[6].Text, out BookStatus status))
                {
                    book.Status = status;
                }
                else
                {
                    // Handle the case where status parsing fails
                    // You might want to set a default value or handle it in a different way
                    // For now, let's set it to BookStatus.Unknown
                    book.Status = BookStatus.Unknown;
                }

                // Assuming you have int and other properties in your Book class
                // You would need to parse them accordingly

                books.Add(book);
            }

            return books;
        }

        public static List<Teacher> GenerateSampleTeachers()
        {
            List<Teacher> teachers = new List<Teacher>();

            //teachers.Add(new Teacher { TeacherID = 1, UserName = "Teacher1", Department = "Physics", BooksBorrowed = 0 });
            //teachers.Add(new Teacher { TeacherID = 2, UserName = "Teacher2", Department = "Mathematics", BooksBorrowed = 0 });
            //teachers.Add(new Teacher { TeacherID = 3, UserName = "Teacher3", Department = "History", BooksBorrowed = 0 });

            return teachers;
        }

        public static List<Student> GenerateSampleStudents()
        {
            List<Student> students = new List<Student>();

            //students.Add(new Student { StudentID = 101, UserName = "Student1", YearLevel = 3, Section = "A", Penalty = 0, BooksBorrowed = 0 });
            //students.Add(new Student { StudentID = 102, UserName = "Student2", YearLevel = 2, Section = "B", Penalty = 0, BooksBorrowed = 0 });
            //students.Add(new Student { StudentID = 103, UserName = "Student3", YearLevel = 4, Section = "C", Penalty = 0, BooksBorrowed = 0 });

            return students;
        }


        // Method to add a new student to the list
        public void AddNewStudent(int studentId, string userName, string yearLevel, string section)
        {
            Students.Add(new Student { StudentID = studentId, UserName = userName, YearLevel = yearLevel, Section = section, Penalty = 0, BooksBorrowed = 0 });
        }


        // Method to add a new teacher to the list
        public void AddNewTeacher(int teacherId, string userName, string department)
        {
            Teachers.Add(new Teacher { TeacherID = teacherId, UserName = userName, Department = department, BooksBorrowed = 0 });
        }

        public Book GetBookByName(string bookName)
        {
            return Books.FirstOrDefault(book => book.Title.Trim().Equals(bookName.Trim(), StringComparison.OrdinalIgnoreCase));
        }

        public static void AddBooksToListView(ListView listView)
        {
            // Ensure the ListView is initialized
            if (listView == null)
            {
                MessageBox.Show("ListView is not initialized properly!");
                return;
            }

            // Define the column headers
            listView.Columns.Add("Title", 200);
            listView.Columns.Add("ISBN", 120);
            listView.Columns.Add("Category", 100);
            listView.Columns.Add("Author", 150);
            listView.Columns.Add("Year", 50);
            listView.Columns.Add("Publisher", 200);
            listView.Columns.Add("Status", 100);

            // Add the items to the ListView
            listView.Items.AddRange(new[]
            {
        new ListViewItem(new[]
        {
            "Harry Potter and The Sorcerer's Stone",
            "978-0590353427",
            "Fiction",
            "J.K Rowling",
            "1997",
            "Bloomsbury (UK) / Scholastic (US)",
            BookStatus.Returned.ToString() // Initial status
        }),

        new ListViewItem(new[]
        {
            "Percy Jackson: The Lightning Thief",
            "978-0786838653",
            "Fiction",
            "Rick Riordan",
            "2005",
            "Disney Hyperion",
            BookStatus.Returned.ToString() // Initial status
        }),

        new ListViewItem(new[]
        {
            "The Da Vinci Code",
            "978-0307474278",
            "Fiction",
            "Dan Brown",
            "2003",
            "Doubleday",
            BookStatus.Returned.ToString() // Initial status
        }),

        new ListViewItem(new[]
        {
            "The Hobbit",
            "978-0345339683",
            "Fiction",
            "J.R.R Tolkien",
            "1937",
            "George Allen & Unwin",
            BookStatus.Returned.ToString() // Initial status
        }),

        new ListViewItem(new[]
        {
            "The Hunger Games",
            "978-0439023481",
            "Fiction",
            "Suzanne Collins",
            "2008",
            "Scholastic Press",
            BookStatus.Returned.ToString() // Initial status
        }),

        new ListViewItem(new[]
        {
            "Thinking, Fast and Slow",
            "978-0374533557",
            "Non-Fiction",
            "Daniel Kahneman",
            "2011",
            "Farrar, Straus and Giroux",
            BookStatus.Returned.ToString() // Initial status
        }),

        new ListViewItem(new[]
        {
            "Quiet: The Power of Introverts",
            "978-0307352156",
            "Non-Fiction",
            "Susan Cain",
            "2012",
            "Susan Cain",
            BookStatus.Returned.ToString() // Initial status
        }),

        new ListViewItem(new[]
        {
            "Sapiens: A Brief History of Humankind",
            "978-0062316097",
            "Non-Fiction",
            "Yuval Noah Harari",
            "2014",
            "Harper",
            BookStatus.Returned.ToString() // Initial status
        }),

        new ListViewItem(new[]
        {
            "The Immortal Life of Henrietta Lacks",
            "978-1400052189",
            "No-Fiction",
            "Rebecca Skloot",
            "2010",
            "Crown Publishing Group",
            BookStatus.Returned.ToString() // Initial status
        }),

        new ListViewItem(new[]
        {
            "The Power of Habit",
            "978-0812981605",
            "Non-Fiction",
            "Charles Duhigg",
            "2012",
            "Random House",
            BookStatus.Returned.ToString() // Initial status
        }),

        new ListViewItem(new[]
        {
            "Real Estate Finance and Investments",
            "978-0073377339",
            "Academics",
            "William B. Brueggeman, Jeffrey Fisher",
            "2015",
            "McGraw-Hill Education",
            BookStatus.Returned.ToString() // Initial status
        }),

        new ListViewItem(new[]
        {
            "Economics: Principles, Problems, and Policies",
            "978-1305101945",
            "Academics",
            "Campbell R. McConnell, Stanley L. Brue, Sean Masaki Flynn",
            "2015",
            "Cengage Learning",
            BookStatus.Returned.ToString() // Initial status
        }),

        new ListViewItem(new[]
        {
            "Principles of Corporate Finance",
            "978-1259144387",
            "Academics",
            "Richard A. Brealey, Stewart C. Myers, Franklin Allen",
            "2016",
            "McGraw-Hill Education",
            BookStatus.Returned.ToString() // Initial status
        }),

        new ListViewItem(new[]
        {
            "Python for Data Analysis",
            "978-1491957660",
            "Academics",
            "Wes McKinney",
            "2017",
            "O'Reilly Media",
            BookStatus.Returned.ToString() // Initial status
        }),

        new ListViewItem(new[]
        {
            "Cognitive Psychology",
            "978-1-305-27112-6",
            "Academics",
            "E. Bruce Goldstein",
            "2020",
            "Cengage Learning",
            BookStatus.Returned.ToString() // Initial status
        }),
    });
        }

        public void UpdateBookStatus(Book book)
        {
            // Find the book in the list and update its status
            var foundBook = Books.FirstOrDefault(b => b.BookID == book.BookID);
            if (foundBook != null)
            {
                foundBook.Status = book.Status;
            }
        }

        public void UpdateListView(ListView listView)
        {
            // Clear the existing items
            listView.Items.Clear();

            // Add the items based on the current state of your books
            foreach (var book in Books)
            {
                ListViewItem item = new ListViewItem(new[]
                {
            book.Title,
            book.ISBN,
            book.Category.ToString(),
            book.Author,
            book.Year.ToString(), // Convert int to string
            book.Publisher,
            book.Status.ToString(),
            // Add more properties as needed
        });

                listView.Items.Add(item);
            }
        }

        public void ReserveBook(ReserveUser borrower, Book selectedBook)
        {
            // Check if the book is already borrowed or reserved
            if (IsBookReserved(selectedBook))
            {
                MessageBox.Show($"Book '{selectedBook.Title}' is already borrowed or reserved and cannot be reserved again until it is returned.");
                return;
            }

            if (selectedBook.Status != BookStatus.Returned)
            {
                MessageBox.Show($"Book '{selectedBook.Title}' is not available for reservation.");
                return;
            }

            int borrowerId = 0;
            BorrowerType borrowerType = BorrowerType.Unknown;

            if (borrower is ReserveUser teacher)
            {
                borrowerId = teacher.PersonID;
                borrowerType = BorrowerType.Teacher;

                // Check if it's a new teacher and add to the list if needed
                if (!Teachers.Any(t => t.TeacherID == borrowerId))
                {
                    // Assuming you have necessary information to create a new teacher (e.g., department)
                    AddNewTeacher(borrowerId, borrower.UserName, teacher.Department);
                }
            }

            if (borrowerId == 0 || borrowerType == BorrowerType.Unknown)
            {
                MessageBox.Show("Invalid borrower type.");
                return;
            }

            // Update the book status and add the entry to BorrowedBooks
            LibraryManager.Instance.UpdateBookStatus(selectedBook);

            selectedBook.Status = BookStatus.Reserved;
            selectedBook.AvailableCopies--;

            BorrowedBooks.Add(new BorrowedBook
            {
                BookID = selectedBook.BookID,
                BorrowerID = borrowerId,
                BorrowerType = borrowerType,
                BorrowDate = DateTime.Now, // For reservations, use the current date as the borrow date
                DueDate = DateTime.Now.AddDays(3), // Set a default due date for reservations (e.g., 3 days from today)
            });

            MessageBox.Show($"{borrower.UserName} successfully reserved the book '{selectedBook.Title}'!");
        }

        public class ReserveUser
        {
            public int PersonID { get; set; }
            public string UserName { get; set; }
            public string Department { get; set; }
        }

    }
}
