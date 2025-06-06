using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using WindowsFormsAppComputerClub.Models;

namespace WindowsFormsAppComputerClub.Forms
{
    public partial class FormAddUpdateSessions : FormParent
    {
        private Model1 model;
        private Users user = null;
        private Sessions sessions = null;

        private DateTime start;
        private DateTime end;
        private decimal? cost;
        public FormAddUpdateSessions(Model1 model_, Users users_)
        {
            InitializeComponent();
            this.model = model_;
            this.user = users_;
            labelName.Text += "для пользователя с id " + user.id;
        }
        public FormAddUpdateSessions(Model1 model_, Sessions sessions_)
        {
            InitializeComponent();
            this.model = model_;
            this.sessions = sessions_;
            sessionsBindingSource.DataSource = sessions_;
            buttonCanceled.Visible = true;
            computersBindingSource.DataSource = sessions_.Computers;

        }

        private void FormSessions_Load(object sender, EventArgs e)
        {
            if (sessions == null)
            {
                computersBindingSource.DataSource = model.Computers
                        .Where(c => c.status == "Активный")
                        .Where(c => c.Sessions.All(s => s.status != "Активная"))
                        .ToList();

               
            }
            comboBoxTime.SelectedIndex = 0;
        }
        private void TimeCostCountingChanged(object sender, EventArgs e)
        {
            try
            {
                start = DateTime.Now;
                start_timeLabelData.Text = start.ToString("g");
                string strtime = ((string)comboBoxTime.SelectedItem).Replace(" часов", "").Replace(" часа", "").Replace(" час", "");
                int hours = comboBoxTime.SelectedIndex != 7 ?
                Convert.ToInt32(strtime) : 0;

                end = start.AddHours(hours);
                end_timeLabelData.Text = end.ToString("g");

                Computers selectpc = (Computers)computersBindingSource.Current;
                if (selectpc != null)
                    cost = hours * selectpc.cost_hour;
                total_costTextBox.Text = cost.ToString();
            }
            catch { }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (comboBoxTime.SelectedIndex == 7)
            {
                MessageBox.Show("Выбеите время!");
                return;
            }
            if (sessions == null)
            {
                sessions = new Sessions();
                sessions.status = "Активная";
            }
            sessions.computer_id = (int)computer_idComboBox.SelectedValue;
            sessions.user_id = user.id;
            sessions.start_time = start;
            sessions.end_time = end;
            sessions.total_cost = cost;

            model.Sessions.Add(sessions);
            model.SaveChanges();

            FormShowSessions form = new FormShowSessions();
            form.Show();
            Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormShowSessions form = new FormShowSessions();
            form.Show();
        }

        private void buttonCanceled_Click(object sender, EventArgs e)
        {
            sessions.status = "Отменённая";
            model.SaveChanges();
            MessageBox.Show("Сессия отменена");
            FormShowSessions form = new FormShowSessions();
            form.Show();
            Close();
        }
    }
}
