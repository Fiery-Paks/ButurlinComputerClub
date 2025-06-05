namespace WindowsFormsAppComputerClub.Forms
{
    partial class FormSessions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label computer_idLabel;
            System.Windows.Forms.Label end_timeLabel;
            System.Windows.Forms.Label start_timeLabel;
            System.Windows.Forms.Label total_costLabel;
            System.Windows.Forms.Label label1;
            this.sessionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.computer_idComboBox = new System.Windows.Forms.ComboBox();
            this.end_timeLabelData = new System.Windows.Forms.Label();
            this.start_timeLabelData = new System.Windows.Forms.Label();
            this.total_costTextBox = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCanceled = new System.Windows.Forms.Button();
            this.computersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxTime = new System.Windows.Forms.ComboBox();
            computer_idLabel = new System.Windows.Forms.Label();
            end_timeLabel = new System.Windows.Forms.Label();
            start_timeLabel = new System.Windows.Forms.Label();
            total_costLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sessionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(975, 5);
            // 
            // labelName
            // 
            this.labelName.Size = new System.Drawing.Size(752, 33);
            this.labelName.Text = "Добавление сессии";
            // 
            // sessionsBindingSource
            // 
            this.sessionsBindingSource.DataSource = typeof(WindowsFormsAppComputerClub.Models.Sessions);
            // 
            // computer_idLabel
            // 
            computer_idLabel.AutoSize = true;
            computer_idLabel.BackColor = System.Drawing.Color.Transparent;
            computer_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            computer_idLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            computer_idLabel.Location = new System.Drawing.Point(56, 160);
            computer_idLabel.Name = "computer_idLabel";
            computer_idLabel.Size = new System.Drawing.Size(142, 25);
            computer_idLabel.TabIndex = 17;
            computer_idLabel.Text = "computer id:";
            // 
            // computer_idComboBox
            // 
            this.computer_idComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sessionsBindingSource, "computer_id", true));
            this.computer_idComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sessionsBindingSource, "computer_id", true));
            this.computer_idComboBox.DataSource = this.computersBindingSource;
            this.computer_idComboBox.DisplayMember = "name";
            this.computer_idComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.computer_idComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.computer_idComboBox.FormattingEnabled = true;
            this.computer_idComboBox.Location = new System.Drawing.Point(239, 157);
            this.computer_idComboBox.Name = "computer_idComboBox";
            this.computer_idComboBox.Size = new System.Drawing.Size(249, 33);
            this.computer_idComboBox.TabIndex = 18;
            this.computer_idComboBox.ValueMember = "id";
            this.computer_idComboBox.SelectedIndexChanged += new System.EventHandler(this.TimeCostCountingChanged);
            // 
            // end_timeLabel
            // 
            end_timeLabel.AutoSize = true;
            end_timeLabel.BackColor = System.Drawing.Color.Transparent;
            end_timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            end_timeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            end_timeLabel.Location = new System.Drawing.Point(56, 248);
            end_timeLabel.Name = "end_timeLabel";
            end_timeLabel.Size = new System.Drawing.Size(109, 25);
            end_timeLabel.TabIndex = 19;
            end_timeLabel.Text = "end time:";
            // 
            // end_timeLabelData
            // 
            this.end_timeLabelData.BackColor = System.Drawing.Color.Transparent;
            this.end_timeLabelData.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sessionsBindingSource, "end_time", true));
            this.end_timeLabelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.end_timeLabelData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.end_timeLabelData.Location = new System.Drawing.Point(239, 251);
            this.end_timeLabelData.Name = "end_timeLabelData";
            this.end_timeLabelData.Size = new System.Drawing.Size(249, 23);
            this.end_timeLabelData.TabIndex = 20;
            this.end_timeLabelData.Text = "label1";
            // 
            // start_timeLabel
            // 
            start_timeLabel.AutoSize = true;
            start_timeLabel.BackColor = System.Drawing.Color.Transparent;
            start_timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            start_timeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            start_timeLabel.Location = new System.Drawing.Point(56, 296);
            start_timeLabel.Name = "start_timeLabel";
            start_timeLabel.Size = new System.Drawing.Size(117, 25);
            start_timeLabel.TabIndex = 21;
            start_timeLabel.Text = "start time:";
            // 
            // start_timeLabelData
            // 
            this.start_timeLabelData.BackColor = System.Drawing.Color.Transparent;
            this.start_timeLabelData.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sessionsBindingSource, "start_time", true));
            this.start_timeLabelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.start_timeLabelData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.start_timeLabelData.Location = new System.Drawing.Point(239, 299);
            this.start_timeLabelData.Name = "start_timeLabelData";
            this.start_timeLabelData.Size = new System.Drawing.Size(249, 23);
            this.start_timeLabelData.TabIndex = 22;
            this.start_timeLabelData.Text = "label1";
            // 
            // total_costLabel
            // 
            total_costLabel.AutoSize = true;
            total_costLabel.BackColor = System.Drawing.Color.Transparent;
            total_costLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            total_costLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            total_costLabel.Location = new System.Drawing.Point(61, 345);
            total_costLabel.Name = "total_costLabel";
            total_costLabel.Size = new System.Drawing.Size(116, 25);
            total_costLabel.TabIndex = 25;
            total_costLabel.Text = "total cost:";
            // 
            // total_costTextBox
            // 
            this.total_costTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sessionsBindingSource, "total_cost", true));
            this.total_costTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.total_costTextBox.Location = new System.Drawing.Point(244, 345);
            this.total_costTextBox.Name = "total_costTextBox";
            this.total_costTextBox.ReadOnly = true;
            this.total_costTextBox.Size = new System.Drawing.Size(249, 31);
            this.total_costTextBox.TabIndex = 26;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(64, 398);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(160, 42);
            this.buttonSave.TabIndex = 27;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCanceled
            // 
            this.buttonCanceled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonCanceled.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCanceled.Location = new System.Drawing.Point(360, 398);
            this.buttonCanceled.Name = "buttonCanceled";
            this.buttonCanceled.Size = new System.Drawing.Size(160, 42);
            this.buttonCanceled.TabIndex = 28;
            this.buttonCanceled.Text = "Отменить";
            this.buttonCanceled.UseVisualStyleBackColor = false;
            this.buttonCanceled.Visible = false;
            // 
            // computersBindingSource
            // 
            this.computersBindingSource.DataSource = typeof(WindowsFormsAppComputerClub.Models.Computers);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            label1.Location = new System.Drawing.Point(58, 207);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(148, 25);
            label1.TabIndex = 29;
            label1.Text = "time interval:";
            // 
            // comboBoxTime
            // 
            this.comboBoxTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sessionsBindingSource, "computer_id", true));
            this.comboBoxTime.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sessionsBindingSource, "computer_id", true));
            this.comboBoxTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.comboBoxTime.FormattingEnabled = true;
            this.comboBoxTime.Items.AddRange(new object[] {
            "1 час",
            "2 часа",
            "3 часа",
            "4 часа",
            "5 часов",
            "6 часов",
            "Не выбрано"});
            this.comboBoxTime.Location = new System.Drawing.Point(241, 204);
            this.comboBoxTime.Name = "comboBoxTime";
            this.comboBoxTime.Size = new System.Drawing.Size(249, 33);
            this.comboBoxTime.TabIndex = 30;
            this.comboBoxTime.SelectedIndexChanged += new System.EventHandler(this.TimeCostCountingChanged);
            // 
            // FormSessions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 467);
            this.Controls.Add(label1);
            this.Controls.Add(this.comboBoxTime);
            this.Controls.Add(this.buttonCanceled);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(computer_idLabel);
            this.Controls.Add(this.computer_idComboBox);
            this.Controls.Add(end_timeLabel);
            this.Controls.Add(this.end_timeLabelData);
            this.Controls.Add(start_timeLabel);
            this.Controls.Add(this.start_timeLabelData);
            this.Controls.Add(total_costLabel);
            this.Controls.Add(this.total_costTextBox);
            this.Name = "FormSessions";
            this.Text = "FormSessions";
            this.Load += new System.EventHandler(this.FormSessions_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.buttonBack, 0);
            this.Controls.SetChildIndex(this.labelName, 0);
            this.Controls.SetChildIndex(this.total_costTextBox, 0);
            this.Controls.SetChildIndex(total_costLabel, 0);
            this.Controls.SetChildIndex(this.start_timeLabelData, 0);
            this.Controls.SetChildIndex(start_timeLabel, 0);
            this.Controls.SetChildIndex(this.end_timeLabelData, 0);
            this.Controls.SetChildIndex(end_timeLabel, 0);
            this.Controls.SetChildIndex(this.computer_idComboBox, 0);
            this.Controls.SetChildIndex(computer_idLabel, 0);
            this.Controls.SetChildIndex(this.buttonSave, 0);
            this.Controls.SetChildIndex(this.buttonCanceled, 0);
            this.Controls.SetChildIndex(this.comboBoxTime, 0);
            this.Controls.SetChildIndex(label1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.sessionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource sessionsBindingSource;
        private System.Windows.Forms.ComboBox computer_idComboBox;
        private System.Windows.Forms.Label end_timeLabelData;
        private System.Windows.Forms.Label start_timeLabelData;
        private System.Windows.Forms.TextBox total_costTextBox;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCanceled;
        private System.Windows.Forms.BindingSource computersBindingSource;
        private System.Windows.Forms.ComboBox comboBoxTime;
    }
}