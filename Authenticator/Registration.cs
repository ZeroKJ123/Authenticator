using Application.Validate;
using Domain.Models;
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

namespace Authenticator
{
    public partial class Registration : Form
    {



        public Registration()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://www.youtube.com/watch?v=dQw4w9WgXcQ") { UseShellExecute = true });
        }

        private void RegistrationBT_Click(object sender, EventArgs e)
        {
            User user = new User();

            user.FirstName = FirstTB.Text;
            user.LastName = LastTB.Text;
            user.Age = AgeTB.Text;
            user.Login = LoginTB.Text;
            user.Password = PasswordTB.Text;

            UserValidator userValidator = new UserValidator();

            List<string> errors = userValidator.Validate(user);

            if (errors.Count > 0)
            {
                string BigDick = "";

                foreach (string error in errors)
                {
                    BigDick = BigDick + ". " + error;
                }

                MessageBox.Show(BigDick);
            }
        }
    }
}
