namespace DataBase9229
{
    partial class loginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.suggestRegistrationLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.passTextbox = new System.Windows.Forms.TextBox();
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.passLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.quitLabel = new System.Windows.Forms.Label();
            this.mainFormPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainFormPanel
            // 
            this.mainFormPanel.BackColor = System.Drawing.SystemColors.Control;
            this.mainFormPanel.Controls.Add(this.label1);
            this.mainFormPanel.Controls.Add(this.suggestRegistrationLabel);
            this.mainFormPanel.Controls.Add(this.loginButton);
            this.mainFormPanel.Controls.Add(this.passTextbox);
            this.mainFormPanel.Controls.Add(this.usernameTextbox);
            this.mainFormPanel.Controls.Add(this.passLabel);
            this.mainFormPanel.Controls.Add(this.loginLabel);
            this.mainFormPanel.Controls.Add(this.quitLabel);
            this.mainFormPanel.ForeColor = System.Drawing.Color.Black;
            this.mainFormPanel.Location = new System.Drawing.Point(2, 1);
            this.mainFormPanel.Margin = new System.Windows.Forms.Padding(2);
            this.mainFormPanel.Name = "mainFormPanel";
            this.mainFormPanel.Size = new System.Drawing.Size(305, 366);
            this.mainFormPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trajan Pro", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(112, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "Login";
            // 
            // suggestRegistrationLabel
            // 
            this.suggestRegistrationLabel.AutoSize = true;
            this.suggestRegistrationLabel.Font = new System.Drawing.Font("Trajan Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suggestRegistrationLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.suggestRegistrationLabel.Location = new System.Drawing.Point(96, 323);
            this.suggestRegistrationLabel.Name = "suggestRegistrationLabel";
            this.suggestRegistrationLabel.Size = new System.Drawing.Size(206, 32);
            this.suggestRegistrationLabel.TabIndex = 6;
            this.suggestRegistrationLabel.Text = "Don`t have an account?\r\n Register here";
            this.suggestRegistrationLabel.Click += new System.EventHandler(this.suggestRegistrationLabel_Click);
            // 
            // loginButton
            // 
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Trajan Pro", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.loginButton.Location = new System.Drawing.Point(129, 184);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(74, 31);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "Proceed";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passTextbox
            // 
            this.passTextbox.Location = new System.Drawing.Point(117, 143);
            this.passTextbox.Name = "passTextbox";
            this.passTextbox.Size = new System.Drawing.Size(123, 20);
            this.passTextbox.TabIndex = 4;
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Location = new System.Drawing.Point(117, 95);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(123, 20);
            this.usernameTextbox.TabIndex = 3;
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Font = new System.Drawing.Font("Trajan Pro", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.passLabel.Location = new System.Drawing.Point(11, 143);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(95, 19);
            this.passLabel.TabIndex = 2;
            this.passLabel.Text = "Password";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Trajan Pro", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.loginLabel.Location = new System.Drawing.Point(11, 96);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(97, 19);
            this.loginLabel.TabIndex = 1;
            this.loginLabel.Text = "UserName";
            // 
            // quitLabel
            // 
            this.quitLabel.AutoSize = true;
            this.quitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quitLabel.Location = new System.Drawing.Point(273, 7);
            this.quitLabel.Name = "quitLabel";
            this.quitLabel.Size = new System.Drawing.Size(19, 18);
            this.quitLabel.TabIndex = 0;
            this.quitLabel.Text = "X";
            this.quitLabel.Click += new System.EventHandler(this.quitLabel_Click);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 366);
            this.Controls.Add(this.mainFormPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.loginForm_Load);
            this.mainFormPanel.ResumeLayout(false);
            this.mainFormPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainFormPanel;
        private System.Windows.Forms.Label quitLabel;
        private System.Windows.Forms.TextBox passTextbox;
        private System.Windows.Forms.TextBox usernameTextbox;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label suggestRegistrationLabel;
        private System.Windows.Forms.Label label1;
    }
}

