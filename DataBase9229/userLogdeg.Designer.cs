namespace DataBase9229
{
    partial class userLogdeg
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
            this.dataGridView_Items = new System.Windows.Forms.DataGridView();
            this.session_label = new System.Windows.Forms.Label();
            this.chooseType_Box = new System.Windows.Forms.ComboBox();
            this.proceedFilter_Button = new System.Windows.Forms.Button();
            this.appendRecord_button = new System.Windows.Forms.Button();
            this.deleteRecord_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Items)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Items
            // 
            this.dataGridView_Items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Items.Location = new System.Drawing.Point(15, 49);
            this.dataGridView_Items.Name = "dataGridView_Items";
            this.dataGridView_Items.RowHeadersWidth = 51;
            this.dataGridView_Items.RowTemplate.Height = 24;
            this.dataGridView_Items.Size = new System.Drawing.Size(750, 475);
            this.dataGridView_Items.TabIndex = 0;
            // 
            // session_label
            // 
            this.session_label.AutoSize = true;
            this.session_label.Location = new System.Drawing.Point(12, 527);
            this.session_label.Name = "session_label";
            this.session_label.Size = new System.Drawing.Size(72, 17);
            this.session_label.TabIndex = 1;
            this.session_label.Text = "User login";
            // 
            // chooseType_Box
            // 
            this.chooseType_Box.FormattingEnabled = true;
            this.chooseType_Box.Items.AddRange(new object[] {
            "Все",
            "Мониторы",
            "Компьютеры",
            "Ноутбуки",
            "Видеокарты",
            "Планшеты",
            "Телефоны",
            "Телевизоры",
            "Передатчики",
            "Другое"});
            this.chooseType_Box.Location = new System.Drawing.Point(391, 12);
            this.chooseType_Box.Name = "chooseType_Box";
            this.chooseType_Box.Size = new System.Drawing.Size(121, 24);
            this.chooseType_Box.TabIndex = 2;
            // 
            // proceedFilter_Button
            // 
            this.proceedFilter_Button.Location = new System.Drawing.Point(546, 12);
            this.proceedFilter_Button.Name = "proceedFilter_Button";
            this.proceedFilter_Button.Size = new System.Drawing.Size(75, 23);
            this.proceedFilter_Button.TabIndex = 3;
            this.proceedFilter_Button.Text = "Proceed";
            this.proceedFilter_Button.UseVisualStyleBackColor = true;
            this.proceedFilter_Button.Click += new System.EventHandler(this.Button1_Click);
            // 
            // appendRecord_button
            // 
            this.appendRecord_button.Location = new System.Drawing.Point(15, 13);
            this.appendRecord_button.Name = "appendRecord_button";
            this.appendRecord_button.Size = new System.Drawing.Size(91, 23);
            this.appendRecord_button.TabIndex = 4;
            this.appendRecord_button.Text = "Add Record";
            this.appendRecord_button.UseVisualStyleBackColor = true;
            this.appendRecord_button.Click += new System.EventHandler(this.AppendRecord_button_Click);
            // 
            // deleteRecord_button
            // 
            this.deleteRecord_button.Location = new System.Drawing.Point(112, 13);
            this.deleteRecord_button.Name = "deleteRecord_button";
            this.deleteRecord_button.Size = new System.Drawing.Size(91, 23);
            this.deleteRecord_button.TabIndex = 5;
            this.deleteRecord_button.Text = "Delete Rec";
            this.deleteRecord_button.UseVisualStyleBackColor = true;
            // 
            // userLogdeg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.deleteRecord_button);
            this.Controls.Add(this.appendRecord_button);
            this.Controls.Add(this.proceedFilter_Button);
            this.Controls.Add(this.chooseType_Box);
            this.Controls.Add(this.session_label);
            this.Controls.Add(this.dataGridView_Items);
            this.Name = "userLogdeg";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Items)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Items;
        private System.Windows.Forms.ComboBox chooseType_Box;
        private System.Windows.Forms.Button proceedFilter_Button;
        public System.Windows.Forms.Label session_label;
        private System.Windows.Forms.Button appendRecord_button;
        private System.Windows.Forms.Button deleteRecord_button;
    }
}