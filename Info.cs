using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginFormExmaple
{
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }

        private void buttonBackToMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            MainPage mainPage = new MainPage();
            mainPage.Show();
            
        }
    }
}
