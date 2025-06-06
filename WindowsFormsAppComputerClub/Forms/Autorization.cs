using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppComputerClub.Models;

namespace WindowsFormsAppComputerClub.Forms
{
    public partial class Autorization: Form
    {
        public static Users users;
        public Autorization()
        {
            InitializeComponent();
        }
        private void buttonEnter_Click(object sender, EventArgs e)
        {
            Model1 model1 = new Model1();
            users = model1.Users.FirstOrDefault(x => x.login == loginTextBox.Text && x.password == passwordTextBox.Text);
            if (users != null)
            {
                switch (users.role_id)
                {
                    case 1:
                        FormAdmin from = new FormAdmin();
                        from.Show();
                        Hide();
                        break;

                    case 2:
                        FormUser from1 = new FormUser();
                        from1.Show();
                        Hide();
                        break;
                }
            }
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            loginTextBox.Text = "admin";
            passwordTextBox.Text = "admin111";
        }
    }
}
