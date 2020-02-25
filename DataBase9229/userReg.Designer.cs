namespace DataBase9229
{
    partial class userReg
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.loginTextbox = new System.Windows.Forms.TextBox();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.alreadyHaveAccLabel = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.quitLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trajan Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login and Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trajan Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Personal Data";
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Location = new System.Drawing.Point(67, 165);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(169, 20);
            this.passwordTextbox.TabIndex = 2;
            this.passwordTextbox.Enter += new System.EventHandler(this.passwordTextbox_Enter);
            this.passwordTextbox.Leave += new System.EventHandler(this.passwordTextbox_Leave);
            // 
            // loginTextbox
            // 
            this.loginTextbox.Location = new System.Drawing.Point(67, 123);
            this.loginTextbox.Name = "loginTextbox";
            this.loginTextbox.Size = new System.Drawing.Size(169, 20);
            this.loginTextbox.TabIndex = 1;
            this.loginTextbox.Enter += new System.EventHandler(this.loginTextbox_Enter);
            this.loginTextbox.Leave += new System.EventHandler(this.loginTextbox_Leave);
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(67, 279);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(169, 20);
            this.nameTextbox.TabIndex = 3;
            this.nameTextbox.Enter += new System.EventHandler(this.nameTextbox_Enter);
            this.nameTextbox.Leave += new System.EventHandler(this.nameTextbox_Leave);
            // 
            // emailTextbox
            // 
            this.emailTextbox.Location = new System.Drawing.Point(67, 329);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(169, 20);
            this.emailTextbox.TabIndex = 4;
            this.emailTextbox.Enter += new System.EventHandler(this.emailTextbox_Enter);
            this.emailTextbox.Leave += new System.EventHandler(this.emailTextbox_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trajan Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Registration";
            // 
            // alreadyHaveAccLabel
            // 
            this.alreadyHaveAccLabel.AutoSize = true;
            this.alreadyHaveAccLabel.Font = new System.Drawing.Font("Trajan Pro", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alreadyHaveAccLabel.Location = new System.Drawing.Point(112, 413);
            this.alreadyHaveAccLabel.Name = "alreadyHaveAccLabel";
            this.alreadyHaveAccLabel.Size = new System.Drawing.Size(181, 28);
            this.alreadyHaveAccLabel.TabIndex = 7;
            this.alreadyHaveAccLabel.Text = "Already have an account ?\r\nLogin here";
            this.alreadyHaveAccLabel.Click += new System.EventHandler(this.alreadyHaveAccLabel_Click);
            // 
            // registerButton
            // 
            this.registerButton.Font = new System.Drawing.Font("Trajan Pro", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.Location = new System.Drawing.Point(112, 366);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(75, 23);
            this.registerButton.TabIndex = 8;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // quitLabel
            // 
            this.quitLabel.AutoSize = true;
            this.quitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quitLabel.Location = new System.Drawing.Point(274, 9);
            this.quitLabel.Name = "quitLabel";
            this.quitLabel.Size = new System.Drawing.Size(19, 18);
            this.quitLabel.TabIndex = 9;
            this.quitLabel.Text = "X";
            this.quitLabel.Click += new System.EventHandler(this.quitLabel_Click);
            // 
            // userReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 450);
            this.Controls.Add(this.quitLabel);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.alreadyHaveAccLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.emailTextbox);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.loginTextbox);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "userReg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.userReg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.TextBox loginTextbox;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.TextBox emailTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label alreadyHaveAccLabel;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label quitLabel;
    }
}