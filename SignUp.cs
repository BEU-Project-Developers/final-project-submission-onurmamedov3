using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;

namespace LoginFormExmaple
{
    public partial class SignUp : Form
    {

        private string connectionString = "Server=localhost;Database=LOGINFORM;Uid=root;Pwd=2012A2015a$;";
        public SignUp()
        {
            InitializeComponent();
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            string name = textName.Text.Trim();
            string username = textUsername.Text.Trim();
            string password = textPassword.Text.Trim();
            string confirmPassword = textConfirmPassword.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please fill out all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Users (Name, Username, Password) VALUES (@Name, @Username, @Password)";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Sign-up successful! Please log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LogIn loginForm = new LogIn();
                loginForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void haveAccountLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide(); 

            LogIn loginForm = new LogIn();
            //loginForm.ShowDialog(); 
            loginForm.Show();
            //this.Close(); 
        }
    }
}
