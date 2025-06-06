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
    public partial class FormUserSessions : FormParent
    {
        private Model1 model = new Model1();
        public FormUserSessions()
        {
            InitializeComponent();
        }
        private void FormUserSessions_Load(object sender, EventArgs e)
        {

            usersBindingSource.DataSource = model.Users.Where(x => x.role_id == 2).ToList();
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            Users users = (Users)usersBindingSource.Current;
            FormAddUpdateSessions form = new FormAddUpdateSessions(model, users);
            form.Show();
            Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormShowSessions form = new FormShowSessions();
            form.Show();
        }
    }
}
