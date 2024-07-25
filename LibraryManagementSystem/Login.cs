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
    public partial class Login : Form
    {
        private bool isPasswordVisible = false;
        private List<User> users;
        

        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;


            users = new List<User>
            {
                new User { Username = "crimson", Password = "operators" },
                //new User { Username = "user2", Password = "pass2" },
                // Add more users as needed
            };
            
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            
            string enteredUsername = textBoxUsername.Text;
            string enteredPassword = textBoxPassword.Text;

            if (IsValidLogin(enteredUsername, enteredPassword))
            {
                //MessageBox.Show("Login Successful", "Crimson Library System", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                BookListForm mainForm = new BookListForm();
                mainForm.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Invalid Login. Please try again", "Crimson Library System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Optional lang toh
                // txtUsername.Text = "";
                // txtPassword.Text = "";
            }
        }
        private bool IsValidLogin(string username, string password)
        {
            // Check if the entered username and password match any user in the list
            return users.Any(user => user.Username == username && user.Password == password);
        }



        public class User
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;
            textBoxPassword.PasswordChar = isPasswordVisible ? '\0' : '*';
        }
    }
}