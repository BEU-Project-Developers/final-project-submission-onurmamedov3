using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LoginFormExample;
using MySql.Data.MySqlClient;


namespace LoginFormExmaple
{
    public partial class LogIn : Form
    {
        private string connectionString = "Server=localhost; Database=LOGINFORM; Uid=root; Pwd=2012A2015a$;";
        private List<User> users;

        public LogIn()
        {
            InitializeComponent();

            
            try
            {
                users = GetUsersFromDatabase();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while initializing the users: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            buttonLogIn.Click += button1_Click;

            textPassword.PasswordChar = '*';  //sifre bu formada gorunecek
            this.AcceptButton = buttonLogIn;  //Enter duymesini sixanda -> daxil ol
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string username = textUsername.Text;
                string password = textPassword.Text;

                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Username and Password cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var user = users.Find(u => u.Username == username && u.Password == password);

                if (user != null)
                {
                    MessageBox.Show("Login successful! Welcome!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //NavigateBasedOnRole(user);
                    
                    MainPage mainPage = new MainPage();
                    //this.Close();
                    mainPage.Show();
                    //this.Close();

                    
                    //ClearFields();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void ClearFields()
        //{
        //    textUsername.Clear();
        //    textPassword.Clear();
        //}
        
        /*private void NavigateBasedOnRole(User user)
        {
            try
            {
                if (user.Role == "Patient")
                {
                    MessageBox.Show("Redirecting to patient portal...", "Redirect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (user.Role == "Doctor")
                {
                    MessageBox.Show("Redirecting to doctor portal...", "Redirect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Role is not recognized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while navigating based on role: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        */
        private List<User> GetUsersFromDatabase()
        {
            var users = new List<User>();

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT Username, Password FROM Users"; 

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                users.Add(new User(
                                    reader["Username"].ToString(),
                                    reader["Password"].ToString()
                                ));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while fetching users: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return users;
        }

        private void newUserLabelLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //this.Close(); evvelki pencereni baglayacaq,yeni log in penceresini
            this.Hide(); 

            SignUp signUpForm = new SignUp();
            //signUpForm.ShowDialog(); // ele edir ki,istifadeci yalniz bir pencere ile islesin,
            // yeni bu pencere baglanmamis digeri acilmayacaq
            signUpForm.Show();
            //this.Close();
        }
    }

}
