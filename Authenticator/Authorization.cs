using Domain.Models;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Authenticator;

namespace Authenticator
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        public void LoginBT_Click(object sender, EventArgs e)
        {
            if (PeopleInfo.UserInfo.Login == LoginAutTB.Text && PeopleInfo.UserInfo.Password == PasswordAutTB.Text)
            {
                Form ifrm = new App();
                ifrm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Не верный логин или пароль");
            }
        }
    }
}
