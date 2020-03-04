namespace DataBase9229
{
    partial class AppendRecordForm
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
            this.welcomeForm_label = new System.Windows.Forms.Label();
            this.itemType_comboBox = new System.Windows.Forms.ComboBox();
            this.discribeItemBad_richTextBox = new System.Windows.Forms.RichTextBox();
            this.applyRecord_button = new System.Windows.Forms.Button();
            this.dateTime_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.modelNameItem_richTextBox = new System.Windows.Forms.RichTextBox();
            this.signModelName_label = new System.Windows.Forms.Label();
            this.pickItemType_label = new System.Windows.Forms.Label();
            this.discribeMalfunc_label = new System.Windows.Forms.Label();
            this.specDate_label = new System.Windows.Forms.Label();
            this.quitLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // welcomeForm_label
            // 
            this.welcomeForm_label.AutoSize = true;
            this.welcomeForm_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.welcomeForm_label.Location = new System.Drawing.Point(110, 76);
            this.welcomeForm_label.Name = "welcomeForm_label";
            this.welcomeForm_label.Size = new System.Drawing.Size(181, 25);
            this.welcomeForm_label.TabIndex = 0;
            this.welcomeForm_label.Text = "Add a new record";
            // 
            // itemType_comboBox
            // 
            this.itemType_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.itemType_comboBox.FormattingEnabled = true;
            this.itemType_comboBox.Items.AddRange(new object[] {
            "Монитор",
            "Компьютер",
            "Ноутбук",
            "Видеокарта",
            "Плашет",
            "Телефон",
            "Телевизор",
            "Передатчики",
            "Другое"});
            this.itemType_comboBox.Location = new System.Drawing.Point(200, 208);
            this.itemType_comboBox.Name = "itemType_comboBox";
            this.itemType_comboBox.Size = new System.Drawing.Size(120, 33);
            this.itemType_comboBox.TabIndex = 2;
            // 
            // discribeItemBad_richTextBox
            // 
            this.discribeItemBad_richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.discribeItemBad_richTextBox.Location = new System.Drawing.Point(50, 280);
            this.discribeItemBad_richTextBox.MaxLength = 196;
            this.discribeItemBad_richTextBox.Name = "discribeItemBad_richTextBox";
            this.discribeItemBad_richTextBox.Size = new System.Drawing.Size(270, 125);
            this.discribeItemBad_richTextBox.TabIndex = 3;
            this.discribeItemBad_richTextBox.Text = "";
            // 
            // applyRecord_button
            // 
            this.applyRecord_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.applyRecord_button.Location = new System.Drawing.Point(147, 502);
            this.applyRecord_button.Name = "applyRecord_button";
            this.applyRecord_button.Size = new System.Drawing.Size(82, 33);
            this.applyRecord_button.TabIndex = 5;
            this.applyRecord_button.Text = "Apply";
            this.applyRecord_button.UseVisualStyleBackColor = true;
            this.applyRecord_button.Click += new System.EventHandler(this.ApplyRecord_button_Click);
            // 
            // dateTime_maskedTextBox
            // 
            this.dateTime_maskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.dateTime_maskedTextBox.Location = new System.Drawing.Point(200, 413);
            this.dateTime_maskedTextBox.Mask = "00-00-0000";
            this.dateTime_maskedTextBox.Name = "dateTime_maskedTextBox";
            this.dateTime_maskedTextBox.PromptChar = '.';
            this.dateTime_maskedTextBox.Size = new System.Drawing.Size(120, 30);
            this.dateTime_maskedTextBox.TabIndex = 6;
            this.dateTime_maskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // modelNameItem_richTextBox
            // 
            this.modelNameItem_richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.modelNameItem_richTextBox.Location = new System.Drawing.Point(50, 150);
            this.modelNameItem_richTextBox.Name = "modelNameItem_richTextBox";
            this.modelNameItem_richTextBox.Size = new System.Drawing.Size(270, 50);
            this.modelNameItem_richTextBox.TabIndex = 7;
            this.modelNameItem_richTextBox.Text = "";
            // 
            // signModelName_label
            // 
            this.signModelName_label.AutoSize = true;
            this.signModelName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.signModelName_label.Location = new System.Drawing.Point(35, 123);
            this.signModelName_label.Name = "signModelName_label";
            this.signModelName_label.Size = new System.Drawing.Size(302, 25);
            this.signModelName_label.TabIndex = 8;
            this.signModelName_label.Text = "Specify item model and name:";
            // 
            // pickItemType_label
            // 
            this.pickItemType_label.AutoSize = true;
            this.pickItemType_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.pickItemType_label.Location = new System.Drawing.Point(75, 211);
            this.pickItemType_label.Name = "pickItemType_label";
            this.pickItemType_label.Size = new System.Drawing.Size(107, 25);
            this.pickItemType_label.TabIndex = 9;
            this.pickItemType_label.Text = "Item type:";
            // 
            // discribeMalfunc_label
            // 
            this.discribeMalfunc_label.AutoSize = true;
            this.discribeMalfunc_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.discribeMalfunc_label.Location = new System.Drawing.Point(35, 253);
            this.discribeMalfunc_label.Name = "discribeMalfunc_label";
            this.discribeMalfunc_label.Size = new System.Drawing.Size(224, 25);
            this.discribeMalfunc_label.TabIndex = 10;
            this.discribeMalfunc_label.Text = "Discribe malfunctions:";
            // 
            // specDate_label
            // 
            this.specDate_label.AutoSize = true;
            this.specDate_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.specDate_label.Location = new System.Drawing.Point(35, 413);
            this.specDate_label.Name = "specDate_label";
            this.specDate_label.Size = new System.Drawing.Size(145, 25);
            this.specDate_label.TabIndex = 11;
            this.specDate_label.Text = "Date of issue:";
            // 
            // quitLabel
            // 
            this.quitLabel.AutoSize = true;
            this.quitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.quitLabel.Location = new System.Drawing.Point(353, 9);
            this.quitLabel.Name = "quitLabel";
            this.quitLabel.Size = new System.Drawing.Size(27, 25);
            this.quitLabel.TabIndex = 12;
            this.quitLabel.Text = "X";
            this.quitLabel.Click += new System.EventHandler(this.QuitLabel_Click);
            // 
            // AppendRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 573);
            this.Controls.Add(this.quitLabel);
            this.Controls.Add(this.specDate_label);
            this.Controls.Add(this.discribeMalfunc_label);
            this.Controls.Add(this.pickItemType_label);
            this.Controls.Add(this.signModelName_label);
            this.Controls.Add(this.modelNameItem_richTextBox);
            this.Controls.Add(this.dateTime_maskedTextBox);
            this.Controls.Add(this.applyRecord_button);
            this.Controls.Add(this.discribeItemBad_richTextBox);
            this.Controls.Add(this.itemType_comboBox);
            this.Controls.Add(this.welcomeForm_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AppendRecordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeForm_label;
        private System.Windows.Forms.ComboBox itemType_comboBox;
        private System.Windows.Forms.RichTextBox discribeItemBad_richTextBox;
        private System.Windows.Forms.Button applyRecord_button;
        private System.Windows.Forms.MaskedTextBox dateTime_maskedTextBox;
        private System.Windows.Forms.RichTextBox modelNameItem_richTextBox;
        private System.Windows.Forms.Label signModelName_label;
        private System.Windows.Forms.Label pickItemType_label;
        private System.Windows.Forms.Label discribeMalfunc_label;
        private System.Windows.Forms.Label specDate_label;
        private System.Windows.Forms.Label quitLabel;
    }
}