namespace Sofia
{
    partial class Form2
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
            checkBox_home_num = new CheckBox();
            textBox_home_num = new TextBox();
            radioButton_man = new RadioButton();
            radioButton_woman = new RadioButton();
            textBox_name = new TextBox();
            textBox_surname = new TextBox();
            textBox_work_num = new TextBox();
            checkBox_work_num = new CheckBox();
            button_sent = new Button();
            SuspendLayout();
            // 
            // checkBox_home_num
            // 
            checkBox_home_num.AutoSize = true;
            checkBox_home_num.Location = new Point(220, 95);
            checkBox_home_num.Name = "checkBox_home_num";
            checkBox_home_num.Size = new Size(127, 19);
            checkBox_home_num.TabIndex = 0;
            checkBox_home_num.Text = "Домашний номер";
            checkBox_home_num.UseVisualStyleBackColor = true;
            checkBox_home_num.CheckedChanged += checkBox_home_num_CheckedChanged;
            // 
            // textBox_home_num
            // 
            textBox_home_num.Location = new Point(353, 93);
            textBox_home_num.Name = "textBox_home_num";
            textBox_home_num.Size = new Size(118, 23);
            textBox_home_num.TabIndex = 1;
            // 
            // radioButton_man
            // 
            radioButton_man.AutoSize = true;
            radioButton_man.Location = new Point(220, 174);
            radioButton_man.Name = "radioButton_man";
            radioButton_man.Size = new Size(77, 19);
            radioButton_man.TabIndex = 2;
            radioButton_man.TabStop = true;
            radioButton_man.Text = "Мужской";
            radioButton_man.UseVisualStyleBackColor = true;
            radioButton_man.CheckedChanged += radioButton_man_CheckedChanged;
            // 
            // radioButton_woman
            // 
            radioButton_woman.AutoSize = true;
            radioButton_woman.Location = new Point(371, 174);
            radioButton_woman.Name = "radioButton_woman";
            radioButton_woman.Size = new Size(75, 19);
            radioButton_woman.TabIndex = 3;
            radioButton_woman.TabStop = true;
            radioButton_woman.Text = "Женский";
            radioButton_woman.UseVisualStyleBackColor = true;
            radioButton_woman.CheckedChanged += radioButton_woman_CheckedChanged;
            // 
            // textBox_name
            // 
            textBox_name.Location = new Point(220, 12);
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(251, 23);
            textBox_name.TabIndex = 4;
            // 
            // textBox_surname
            // 
            textBox_surname.Location = new Point(220, 53);
            textBox_surname.Name = "textBox_surname";
            textBox_surname.Size = new Size(251, 23);
            textBox_surname.TabIndex = 5;
            // 
            // textBox_work_num
            // 
            textBox_work_num.Location = new Point(353, 135);
            textBox_work_num.Name = "textBox_work_num";
            textBox_work_num.Size = new Size(118, 23);
            textBox_work_num.TabIndex = 7;
            // 
            // checkBox_work_num
            // 
            checkBox_work_num.AutoSize = true;
            checkBox_work_num.Location = new Point(220, 137);
            checkBox_work_num.Name = "checkBox_work_num";
            checkBox_work_num.Size = new Size(113, 19);
            checkBox_work_num.TabIndex = 6;
            checkBox_work_num.Text = "Рабочий номер";
            checkBox_work_num.UseVisualStyleBackColor = true;
            checkBox_work_num.CheckedChanged += checkBox_work_num_CheckedChanged;
            // 
            // button_sent
            // 
            button_sent.Location = new Point(618, 47);
            button_sent.Name = "button_sent";
            button_sent.Size = new Size(139, 67);
            button_sent.TabIndex = 8;
            button_sent.Text = "Отправить";
            button_sent.UseVisualStyleBackColor = true;
            button_sent.Click += button_sent_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_sent);
            Controls.Add(textBox_work_num);
            Controls.Add(checkBox_work_num);
            Controls.Add(textBox_surname);
            Controls.Add(textBox_name);
            Controls.Add(radioButton_woman);
            Controls.Add(radioButton_man);
            Controls.Add(textBox_home_num);
            Controls.Add(checkBox_home_num);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox_home_num;
        private TextBox textBox_home_num;
        private RadioButton radioButton_man;
        private RadioButton radioButton_woman;
        private TextBox textBox_name;
        private TextBox textBox_surname;
        private TextBox textBox_work_num;
        private CheckBox checkBox_work_num;
        private Button button_sent;
    }
}