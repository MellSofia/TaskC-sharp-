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
            list_notes = new ListBox();
            button_save = new Button();
            label1 = new Label();
            label_priority = new Label();
            SuspendLayout();
            // 
            // comments_textBox
            // 
            comments_textBox.AcceptsReturn = true;
            comments_textBox.AcceptsTab = true;
            comments_textBox.AllowDrop = true;
            comments_textBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comments_textBox.Location = new Point(441, 85);
            comments_textBox.Multiline = true;
            comments_textBox.Name = "comments_textBox";
            comments_textBox.Size = new Size(269, 298);
            comments_textBox.TabIndex = 0;
            // 
            // Name_textbox
            // 
            Name_textbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Name_textbox.Location = new Point(441, 27);
            Name_textbox.MaxLength = 500;
            Name_textbox.Name = "Name_textbox";
            Name_textbox.Size = new Size(269, 23);
            Name_textbox.TabIndex = 1;
            Name_textbox.Enter += Name_textbox_Enter;
            Name_textbox.Leave += Name_textbox_Leave;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker1.Location = new Point(441, 56);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(110, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(630, 56);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(80, 23);
            comboBox1.TabIndex = 3;
            // 
            // list_notes
            // 
            list_notes.FormattingEnabled = true;
            list_notes.ItemHeight = 15;
            list_notes.Location = new Point(12, 34);
            list_notes.Name = "list_notes";
            list_notes.Size = new Size(279, 349);
            list_notes.TabIndex = 5;
            list_notes.SelectedIndexChanged += list_notes_SelectedIndexChanged;
            // 
            // button_save
            // 
            button_save.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_save.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_save.Location = new Point(314, 54);
            button_save.Name = "button_save";
            button_save.Size = new Size(110, 58);
            button_save.TabIndex = 4;
            button_save.Text = "Save";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 15);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 6;
            label1.Text = "label1";
            // 
            // label_priority
            // 
            label_priority.AutoSize = true;
            label_priority.Location = new Point(557, 59);
            label_priority.Name = "label_priority";
            label_priority.Size = new Size(67, 15);
            label_priority.TabIndex = 7;
            label_priority.Text = "Приоритет";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(744, 422);
            Controls.Add(label_priority);
            Controls.Add(label1);
            Controls.Add(list_notes);
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
        private ListBox list_notes;
        private Label label1;
        private Label label_priority;
    }
}
