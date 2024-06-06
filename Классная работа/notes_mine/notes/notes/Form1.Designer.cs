namespace notes
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comments_textBox = new TextBox();
            Name_textbox = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            button_save = new Button();
            SuspendLayout();
            // 
            // comments_textBox
            // 
            comments_textBox.AcceptsReturn = true;
            comments_textBox.AcceptsTab = true;
            comments_textBox.AllowDrop = true;
            comments_textBox.Anchor = AnchorStyles.None;
            comments_textBox.Location = new Point(3, 61);
            comments_textBox.Multiline = true;
            comments_textBox.Name = "comments_textBox";
            comments_textBox.Size = new Size(254, 198);
            comments_textBox.TabIndex = 0;
            // 
            // Name_textbox
            // 
            Name_textbox.Anchor = AnchorStyles.None;
            Name_textbox.Location = new Point(3, 3);
            Name_textbox.MaxLength = 500;
            Name_textbox.Name = "Name_textbox";
            Name_textbox.Size = new Size(254, 23);
            Name_textbox.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.None;
            dateTimePicker1.Location = new Point(3, 32);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(152, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.None;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1", "2", "3" });
            comboBox1.Location = new Point(156, 32);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(101, 23);
            comboBox1.TabIndex = 3;
            // 
            // button_save
            // 
            button_save.Anchor = AnchorStyles.None;
            button_save.Location = new Point(3, 265);
            button_save.Name = "button_save";
            button_save.Size = new Size(254, 33);
            button_save.TabIndex = 4;
            button_save.Text = "Save";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(261, 307);
            Controls.Add(button_save);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(Name_textbox);
            Controls.Add(comments_textBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox comments_textBox;
        private TextBox Name_textbox;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private Button button_save;
    }
}
