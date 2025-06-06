using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppComputerClub.Forms
{
    public partial class FormAdmin : FormParent
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Visible = true;
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            FormShowSessions form = new FormShowSessions();
            form.Show();
            Close();
        }
    }
}
