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
    public partial class FormUser : FormParent
    {
        private Model1 model = new Model1();
        private Sessions sessions;

        public FormUser()
        {
            InitializeComponent();
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            sessions.status = "Отменённая";
            model.SaveChanges();
            Application.OpenForms[0].Visible = true;
        }

        private void timerSession_Tick(object sender, EventArgs e)
        {
            TimeSpan timePassed = DateTime.Now - (sessions.end_time ?? DateTime.Now);
            int minutes = (int)timePassed.TotalMinutes * (-1);
            labelName.Text = $"Пользователь - {Autorization.users.full_name}, Осталось времени {minutes} минут";
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            sessions = model.Sessions.OrderByDescending(x => x.start_time).FirstOrDefault(x => x.user_id == Autorization.users.id);
            TimeSpan timePassed = DateTime.Now - (sessions.end_time ?? DateTime.Now);
            int minutes = (int)timePassed.TotalMinutes * (-1);
            labelName.Text = $"Пользователь - {Autorization.users.full_name}, Осталось времени {minutes} минут";
            timerSession.Start();
        }
    }
}
