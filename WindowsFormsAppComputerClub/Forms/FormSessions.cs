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
    public partial class FormSessions: FormParent
    {
        private Model1 model;
        private Users user = null;
        private Sessions sessions = null;

        private DateTime start; 
        private DateTime end;
        private decimal? cost;
        public FormSessions(Model1 model_, Users users_)
        {
            InitializeComponent();
            this.model = model_;
            this.user = users_;
        }
        public FormSessions(Model1 model_, Sessions sessions_)
        {
            InitializeComponent();
            this.model = model_;
            this.sessions = sessions_;
            sessionsBindingSource.DataSource = sessions_;
        }

        private void FormSessions_Load(object sender, EventArgs e)
        {
            computersBindingSource.DataSource = model.Computers
                    .Where(c => c.status == "Активный")
                    .Where(c => !c.Sessions.Any() || c.Sessions.All(s => s.status == "Завершённая"))
                    .ToList();

            comboBoxTime.SelectedIndex = 0;
        }
        private void TimeCostCountingChanged(object sender, EventArgs e)
        {
            start = DateTime.Now;
            start_timeLabelData.Text = start.ToString("g");
            int hours = comboBoxTime.SelectedIndex == 7 ? 
            Convert.ToInt32(((string)comboBoxTime.SelectedItem).Where(char.IsDigit).ToArray()) : 0;

            end = end.AddHours(hours);
            end_timeLabelData.Text = end.ToString("g");

            Computers selectpc = (Computers)computersBindingSource.Current;
            cost = hours * selectpc.cost_hour;
            total_costTextBox.Text = cost.ToString();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

        }
    }
}
