using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LoginFormExmaple
{
    public partial class Doctor : Form
    {
        public Doctor()
        {
            InitializeComponent();
        }

        private void buttonBackToMainMenu_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Close();
        }

        private void buttonDSave_Click(object sender, EventArgs e)
        {
            string name = textBoxDoctor.Text;
            string contact = textBoxDoctorContact.Text;
            string yoe = textBoxDoctorYOE.Text; // Years of Experience
            string age = textBoxDoctorAge.Text;
            string address = textBoxDoctorAddress.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(contact) ||
                string.IsNullOrWhiteSpace(yoe) || string.IsNullOrWhiteSpace(age) || string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Insert into the MySQL database
                using (MySqlConnection connection = new MySqlConnection("Server=localhost; Database=LOGINFORM; Uid=root; Pwd=2012A2015a$;"))
                {
                    connection.Open();
                    string query = "INSERT INTO Doctors (Name, Contact, YOE, Age, Address) VALUES (@Name, @Contact, @YOE, @Age, @Address)";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Contact", contact);
                        command.Parameters.AddWithValue("@YOE", yoe);
                        command.Parameters.AddWithValue("@Age", age);
                        command.Parameters.AddWithValue("@Address", address);
                        command.ExecuteNonQuery();
                    }
                }

                // Add to DataGridView
                dataGridViewDoctors.Rows.Add(name, contact, yoe, age, address);

                // Clear input fields after saving
                textBoxDoctor.Clear();
                textBoxDoctorContact.Clear();
                textBoxDoctorYOE.Clear();
                textBoxDoctorAge.Clear();
                textBoxDoctorAddress.Clear();

                MessageBox.Show("Data saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
