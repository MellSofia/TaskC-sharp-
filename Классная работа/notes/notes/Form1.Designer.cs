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
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // comments_textBox
            // 
            comments_textBox.AcceptsReturn = true;
            comments_textBox.AcceptsTab = true;
            comments_textBox.AllowDrop = true;
            comments_textBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comments_textBox.Location = new Point(262, 174);
            comments_textBox.Multiline = true;
            comments_textBox.Name = "comments_textBox";
            comments_textBox.Size = new Size(246, 74);
            comments_textBox.TabIndex = 0;
            // 
            // Name_textbox
            // 
            Name_textbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Name_textbox.Location = new Point(262, 131);
            Name_textbox.MaxLength = 500;
            Name_textbox.Name = "Name_textbox";
            Name_textbox.Size = new Size(246, 23);
            Name_textbox.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker1.Location = new Point(262, 153);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(150, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(409, 153);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(99, 23);
            comboBox1.TabIndex = 3;
            // 
            // button_save
            // 
            button_save.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_save.Location = new Point(587, 342);
            button_save.Name = "button_save";
            button_save.Size = new Size(146, 58);
            button_save.TabIndex = 4;
            button_save.Text = "Save";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // textBox1
            // 
            textBox1.AcceptsReturn = true;
            textBox1.AcceptsTab = true;
            textBox1.AllowDrop = true;
            textBox1.Location = new Point(12, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(232, 388);
            textBox1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(745, 412);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
    }
}
