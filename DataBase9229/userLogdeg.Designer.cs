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
            this.button1 = new System.Windows.Forms.Button();
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
            this.session_label.Size = new System.Drawing.Size(46, 17);
            this.session_label.TabIndex = 1;
            this.session_label.Text = "label1";
            // 
            // chooseType_Box
            // 
            this.chooseType_Box.FormattingEnabled = true;
            this.chooseType_Box.Items.AddRange(new object[] {
            "Все",
            "Мониторы",
            "Клавиатуры",
            "Ноутбуки"});
            this.chooseType_Box.Location = new System.Drawing.Point(391, 12);
            this.chooseType_Box.Name = "chooseType_Box";
            this.chooseType_Box.Size = new System.Drawing.Size(121, 24);
            this.chooseType_Box.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(546, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // userLogdeg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chooseType_Box);
            this.Controls.Add(this.session_label);
            this.Controls.Add(this.dataGridView_Items);
            this.Name = "userLogdeg";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.UserLogdeg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Items)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Items;
        private System.Windows.Forms.Label session_label;
        private System.Windows.Forms.ComboBox chooseType_Box;
        private System.Windows.Forms.Button button1;
    }
}