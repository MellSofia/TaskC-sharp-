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
            button_del = new Button();
            button_new = new Button();
            SuspendLayout();
            // 
            // comments_textBox
            // 
            comments_textBox.AcceptsReturn = true;
            comments_textBox.AcceptsTab = true;
            comments_textBox.AllowDrop = true;
            comments_textBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comments_textBox.Location = new Point(452, 92);
            comments_textBox.MaxLength = 327670;
            comments_textBox.Multiline = true;
            comments_textBox.Name = "comments_textBox";
            comments_textBox.ScrollBars = ScrollBars.Vertical;
            comments_textBox.Size = new Size(269, 321);
            comments_textBox.TabIndex = 0;
            comments_textBox.TextChanged += comments_textBox_TextChanged;
            comments_textBox.Enter += comments_textBox_Enter;
            comments_textBox.Leave += comments_textBox_Leave;
            // 
            // Name_textbox
            // 
            Name_textbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Name_textbox.Location = new Point(452, 34);
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
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Location = new Point(452, 63);
            dateTimePicker1.MaxDate = new DateTime(2024, 12, 31, 0, 0, 0, 0);
            dateTimePicker1.MinDate = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(110, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(641, 63);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(80, 23);
            comboBox1.TabIndex = 3;
            // 
            // list_notes
            // 
            list_notes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            list_notes.FormattingEnabled = true;
            list_notes.ItemHeight = 15;
            list_notes.Location = new Point(12, 34);
            list_notes.Name = "list_notes";
            list_notes.ScrollAlwaysVisible = true;
            list_notes.Size = new Size(279, 379);
            list_notes.TabIndex = 5;
            list_notes.SelectedIndexChanged += list_notes_SelectedIndexChanged;
            // 
            // button_save
            // 
            button_save.BackColor = Color.FromArgb(0, 167, 121);
            button_save.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            button_save.ForeColor = SystemColors.ButtonFace;
            button_save.ImageAlign = ContentAlignment.TopCenter;
            button_save.Location = new Point(317, 34);
            button_save.Name = "button_save";
            button_save.Size = new Size(110, 58);
            button_save.TabIndex = 4;
            button_save.Text = "Save";
            button_save.UseVisualStyleBackColor = false;
            button_save.Click += button_save_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(90, -4);
            label1.Name = "label1";
            label1.Size = new Size(108, 23);
            label1.TabIndex = 6;
            label1.Text = "List of notes";
            // 
            // label_priority
            // 
            label_priority.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label_priority.AutoSize = true;
            label_priority.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label_priority.ForeColor = SystemColors.ActiveCaptionText;
            label_priority.Location = new Point(568, 66);
            label_priority.Name = "label_priority";
            label_priority.Size = new Size(67, 15);
            label_priority.TabIndex = 7;
            label_priority.Text = "Приоритет";
            // 
            // button_del
            // 
            button_del.BackColor = Color.FromArgb(0, 167, 121);
            button_del.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            button_del.ForeColor = SystemColors.ControlLightLight;
            button_del.Location = new Point(317, 191);
            button_del.Name = "button_del";
            button_del.Size = new Size(110, 58);
            button_del.TabIndex = 8;
            button_del.Text = "Delete";
            button_del.UseVisualStyleBackColor = false;
            button_del.Visible = false;
            button_del.Click += button_del_Click;
            // 
            // button_new
            // 
            button_new.BackColor = Color.FromArgb(0, 167, 121);
            button_new.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            button_new.ForeColor = SystemColors.ControlLightLight;
            button_new.Location = new Point(317, 112);
            button_new.Name = "button_new";
            button_new.Size = new Size(110, 58);
            button_new.TabIndex = 9;
            button_new.Text = "New";
            button_new.UseVisualStyleBackColor = false;
            button_new.Click += button_new_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(53, 211, 167);
            ClientSize = new Size(744, 434);
            Controls.Add(button_new);
            Controls.Add(button_del);
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
            TopMost = true;
            Load += Form1_Load;
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
        private Button button_del;
        private Button button_new;
    }
}
