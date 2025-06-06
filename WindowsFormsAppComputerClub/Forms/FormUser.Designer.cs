namespace WindowsFormsAppComputerClub.Forms
{
    partial class FormUser
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
            this.timerSession = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(1236, 5);
            // 
            // buttonBack
            // 
            this.buttonBack.Size = new System.Drawing.Size(228, 42);
            this.buttonBack.Text = "Закончить сессию";
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelName
            // 
            this.labelName.Location = new System.Drawing.Point(278, 42);
            this.labelName.Size = new System.Drawing.Size(920, 33);
            this.labelName.Text = "";
            // 
            // timerSession
            // 
            this.timerSession.Interval = 10000;
            this.timerSession.Tick += new System.EventHandler(this.timerSession_Tick);
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 112);
            this.MaximumSize = new System.Drawing.Size(1226, 151);
            this.MinimumSize = new System.Drawing.Size(1226, 151);
            this.Name = "FormUser";
            this.Text = "FormUser";
            this.Load += new System.EventHandler(this.FormUser_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerSession;
    }
}