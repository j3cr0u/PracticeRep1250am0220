namespace DataBase9229
{
    partial class mainForm
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
            this.mainFormPanel = new System.Windows.Forms.Panel();
            this.suggestRegistrationLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.passTextbox = new System.Windows.Forms.TextBox();
            this.loginTextbox = new System.Windows.Forms.TextBox();
            this.passLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.quitLabel = new System.Windows.Forms.Label();
            this.mainFormPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainFormPanel
            // 
            this.mainFormPanel.BackColor = System.Drawing.Color.Teal;
            this.mainFormPanel.Controls.Add(this.suggestRegistrationLabel);
            this.mainFormPanel.Controls.Add(this.loginButton);
            this.mainFormPanel.Controls.Add(this.passTextbox);
            this.mainFormPanel.Controls.Add(this.loginTextbox);
            this.mainFormPanel.Controls.Add(this.passLabel);
            this.mainFormPanel.Controls.Add(this.loginLabel);
            this.mainFormPanel.Controls.Add(this.quitLabel);
            this.mainFormPanel.ForeColor = System.Drawing.Color.DeepPink;
            this.mainFormPanel.Location = new System.Drawing.Point(1, 2);
            this.mainFormPanel.Margin = new System.Windows.Forms.Padding(2);
            this.mainFormPanel.Name = "mainFormPanel";
            this.mainFormPanel.Size = new System.Drawing.Size(267, 367);
            this.mainFormPanel.TabIndex = 0;
            // 
            // suggestRegistrationLabel
            // 
            this.suggestRegistrationLabel.AutoSize = true;
            this.suggestRegistrationLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suggestRegistrationLabel.ForeColor = System.Drawing.Color.DeepPink;
            this.suggestRegistrationLabel.Location = new System.Drawing.Point(92, 321);
            this.suggestRegistrationLabel.Name = "suggestRegistrationLabel";
            this.suggestRegistrationLabel.Size = new System.Drawing.Size(166, 38);
            this.suggestRegistrationLabel.TabIndex = 6;
            this.suggestRegistrationLabel.Text = "Don`t have an account?\r\n Register here";
            this.suggestRegistrationLabel.Click += new System.EventHandler(this.suggestRegistrationLabel_Click);
            // 
            // loginButton
            // 
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.DeepPink;
            this.loginButton.Location = new System.Drawing.Point(95, 188);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(74, 31);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "Proceed";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passTextbox
            // 
            this.passTextbox.Location = new System.Drawing.Point(83, 147);
            this.passTextbox.Name = "passTextbox";
            this.passTextbox.Size = new System.Drawing.Size(100, 20);
            this.passTextbox.TabIndex = 4;
            // 
            // loginTextbox
            // 
            this.loginTextbox.Location = new System.Drawing.Point(83, 93);
            this.loginTextbox.Name = "loginTextbox";
            this.loginTextbox.Size = new System.Drawing.Size(100, 20);
            this.loginTextbox.TabIndex = 3;
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passLabel.ForeColor = System.Drawing.Color.DeepPink;
            this.passLabel.Location = new System.Drawing.Point(12, 142);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(51, 24);
            this.passLabel.TabIndex = 2;
            this.passLabel.Text = "Pass";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.ForeColor = System.Drawing.Color.DeepPink;
            this.loginLabel.Location = new System.Drawing.Point(13, 93);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(62, 24);
            this.loginLabel.TabIndex = 1;
            this.loginLabel.Text = "Login";
            // 
            // quitLabel
            // 
            this.quitLabel.AutoSize = true;
            this.quitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quitLabel.Location = new System.Drawing.Point(239, 7);
            this.quitLabel.Name = "quitLabel";
            this.quitLabel.Size = new System.Drawing.Size(19, 18);
            this.quitLabel.TabIndex = 0;
            this.quitLabel.Text = "X";
            this.quitLabel.Click += new System.EventHandler(this.quitLabel_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 366);
            this.Controls.Add(this.mainFormPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.mainFormPanel.ResumeLayout(false);
            this.mainFormPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainFormPanel;
        private System.Windows.Forms.Label quitLabel;
        private System.Windows.Forms.TextBox passTextbox;
        private System.Windows.Forms.TextBox loginTextbox;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label suggestRegistrationLabel;
    }
}

