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
    public partial class FormShowSessions : FormParent
    {
        private Model1 model = new Model1();
        public FormShowSessions()
        {
            InitializeComponent();
        }
        private void FormShowSessions_Load(object sender, EventArgs e)
        {
            sessionsBindingSource.DataSource = model.Sessions.ToList();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormUserSessions form = new FormUserSessions();
            form.Show();
            Close();
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Sessions sessions = (Sessions)sessionsBindingSource.Current;
            FormAddUpdateSessions form = new FormAddUpdateSessions(model, sessions);
            form.Show();
            Close();
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormAdmin form = new FormAdmin();
            form.Show();
        }
    }
}
