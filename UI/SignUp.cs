using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Buisness_App_Final.BL;
using Buisness_App_Final.DL;

namespace Buisness_App_Final.UI
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
            ControlBox = false;
        }

        private void lnkLblReturn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Opening i = new Opening();
            i.Show();
            this.Hide();
        }

        private void cmdSignUp_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text != "" && txtPassword.Text != "")
            {
                Credentials user = new Credentials(txtUsername.Text, txtPassword.Text, "Fan");
                Person people = new Person(txtUsername.Text, user);
                PersonDL.addPeopleToList(people);
                MessageBox.Show("The user has been added.");
            }

            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Fill the fields correctly");
            }
        }
    }
}
