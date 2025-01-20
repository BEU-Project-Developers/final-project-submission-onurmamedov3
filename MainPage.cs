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

namespace LoginFormExmaple
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            LogIn loginForm = new LogIn();
            loginForm.Show();

            this.Close();
        }

        private void pictureBoxInfo_Click(object sender, EventArgs e)
        {
            Info infoForm = new Info();
            infoForm.Show();
            this.Close();

        }

        private void pictureBoxDoctors_Click(object sender, EventArgs e)
        {
            Doctor doctorForm = new Doctor();
            doctorForm.Show();
            this.Close();
        }

        private void pictureBoxPatients_Click(object sender, EventArgs e)
        {
            Patients patientsForm = new Patients();
            patientsForm.Show();
            this.Close();
        }
    }
}
