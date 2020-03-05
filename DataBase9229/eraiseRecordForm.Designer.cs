namespace DataBase9229
{
    partial class eraiseRecordForm
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
            this.welcomeForm_Label = new System.Windows.Forms.Label();
            this.idToDelete_textBox = new System.Windows.Forms.TextBox();
            this.eraiseRecord_button = new System.Windows.Forms.Button();
            this.quitLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // welcomeForm_Label
            // 
            this.welcomeForm_Label.AutoSize = true;
            this.welcomeForm_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.welcomeForm_Label.Location = new System.Drawing.Point(0, 67);
            this.welcomeForm_Label.Name = "welcomeForm_Label";
            this.welcomeForm_Label.Size = new System.Drawing.Size(395, 25);
            this.welcomeForm_Label.TabIndex = 0;
            this.welcomeForm_Label.Text = "Enter ID of item that you want to remove\r\n";
            // 
            // idToDelete_textBox
            // 
            this.idToDelete_textBox.Location = new System.Drawing.Point(147, 119);
            this.idToDelete_textBox.Name = "idToDelete_textBox";
            this.idToDelete_textBox.Size = new System.Drawing.Size(100, 22);
            this.idToDelete_textBox.TabIndex = 1;
            // 
            // eraiseRecord_button
            // 
            this.eraiseRecord_button.Location = new System.Drawing.Point(172, 173);
            this.eraiseRecord_button.Name = "eraiseRecord_button";
            this.eraiseRecord_button.Size = new System.Drawing.Size(50, 23);
            this.eraiseRecord_button.TabIndex = 2;
            this.eraiseRecord_button.Text = "Ok";
            this.eraiseRecord_button.UseVisualStyleBackColor = true;
            this.eraiseRecord_button.Click += new System.EventHandler(this.EraiseRecord_button_Click);
            // 
            // quitLabel
            // 
            this.quitLabel.AutoSize = true;
            this.quitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.quitLabel.Location = new System.Drawing.Point(353, 9);
            this.quitLabel.Name = "quitLabel";
            this.quitLabel.Size = new System.Drawing.Size(27, 25);
            this.quitLabel.TabIndex = 3;
            this.quitLabel.Text = "X";
            this.quitLabel.Click += new System.EventHandler(this.QuitLabel_Click);
            // 
            // eraiseRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 273);
            this.Controls.Add(this.quitLabel);
            this.Controls.Add(this.eraiseRecord_button);
            this.Controls.Add(this.idToDelete_textBox);
            this.Controls.Add(this.welcomeForm_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "eraiseRecordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeForm_Label;
        private System.Windows.Forms.TextBox idToDelete_textBox;
        private System.Windows.Forms.Button eraiseRecord_button;
        private System.Windows.Forms.Label quitLabel;
    }
}