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
            this.quitLabel = new System.Windows.Forms.Label();
            this.mainFormPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainFormPanel
            // 
            this.mainFormPanel.Controls.Add(this.quitLabel);
            this.mainFormPanel.Location = new System.Drawing.Point(1, 2);
            this.mainFormPanel.Margin = new System.Windows.Forms.Padding(2);
            this.mainFormPanel.Name = "mainFormPanel";
            this.mainFormPanel.Size = new System.Drawing.Size(598, 367);
            this.mainFormPanel.TabIndex = 0;
            // 
            // quitLabel
            // 
            this.quitLabel.AutoSize = true;
            this.quitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quitLabel.Location = new System.Drawing.Point(568, 9);
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
            this.ClientSize = new System.Drawing.Size(600, 366);
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
    }
}

