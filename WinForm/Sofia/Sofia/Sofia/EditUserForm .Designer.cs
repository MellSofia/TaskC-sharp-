
namespace Sofia
{
    partial class EditUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditUserForm));
            buttonBack = new Button();
            button_save = new Button();
            comboBox_position = new ComboBox();
            label_password = new Label();
            textBox_password = new TextBox();
            label_gender = new Label();
            label_position = new Label();
            label_surneme = new Label();
            label_name = new Label();
            textBox_name = new TextBox();
            checkBox_home_num = new CheckBox();
            checkBox_mobile_num = new CheckBox();
            textBox_home_num = new TextBox();
            radioButton_woman = new RadioButton();
            textBox_mobile_num = new TextBox();
            radioButton_man = new RadioButton();
            comboBoxUsers = new ComboBox();
            label_name_check = new Label();
            label_secondname__check = new Label();
            label_position_check = new Label();
            label_password_check = new Label();
            label_mobile_num_check = new Label();
            label_home_num_check = new Label();
            label_gender_check = new Label();
            SuspendLayout();
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(12, 12);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(75, 23);
            buttonBack.TabIndex = 11;
            buttonBack.Text = "Назад";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click_1;
            // 
            // button_save
            // 
            button_save.Location = new Point(571, 221);
            button_save.Name = "button_save";
            button_save.Size = new Size(75, 23);
            button_save.TabIndex = 8;
            button_save.Text = "Сохранить";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // comboBox_position
            // 
            comboBox_position.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_position.FormattingEnabled = true;
            comboBox_position.Location = new Point(230, 110);
            comboBox_position.Name = "comboBox_position";
            comboBox_position.Size = new Size(251, 23);
            comboBox_position.TabIndex = 41;
            comboBox_position.SelectedIndexChanged += comboBox_position_SelectedIndexChanged;
            // 
            // label_password
            // 
            label_password.AutoSize = true;
            label_password.Location = new Point(166, 267);
            label_password.Name = "label_password";
            label_password.Size = new Size(49, 15);
            label_password.TabIndex = 40;
            label_password.Text = "Пароль";
            // 
            // textBox_password
            // 
            textBox_password.Location = new Point(230, 264);
            textBox_password.Name = "textBox_password";
            textBox_password.ReadOnly = true;
            textBox_password.Size = new Size(238, 23);
            textBox_password.TabIndex = 39;
            textBox_password.TextChanged += textBox_password_TextChanged;
            // 
            // label_gender
            // 
            label_gender.AutoSize = true;
            label_gender.Location = new Point(170, 229);
            label_gender.Name = "label_gender";
            label_gender.Size = new Size(30, 15);
            label_gender.TabIndex = 38;
            label_gender.Text = "Пол";
            // 
            // label_position
            // 
            label_position.AutoSize = true;
            label_position.Location = new Point(161, 113);
            label_position.Name = "label_position";
            label_position.Size = new Size(69, 15);
            label_position.TabIndex = 37;
            label_position.Text = "Должность";
            // 
            // label_surneme
            // 
            label_surneme.AutoSize = true;
            label_surneme.Location = new Point(161, 73);
            label_surneme.Name = "label_surneme";
            label_surneme.Size = new Size(58, 15);
            label_surneme.TabIndex = 36;
            label_surneme.Text = "Фамилия";
            // 
            // label_name
            // 
            label_name.AutoSize = true;
            label_name.Location = new Point(161, 32);
            label_name.Name = "label_name";
            label_name.Size = new Size(31, 15);
            label_name.TabIndex = 35;
            label_name.Text = "Имя";
            // 
            // textBox_name
            // 
            textBox_name.Location = new Point(230, 29);
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(251, 23);
            textBox_name.TabIndex = 31;
            textBox_name.TextChanged += textBox_name_TextChanged;
            // 
            // checkBox_home_num
            // 
            checkBox_home_num.AutoSize = true;
            checkBox_home_num.Location = new Point(161, 146);
            checkBox_home_num.Name = "checkBox_home_num";
            checkBox_home_num.Size = new Size(127, 19);
            checkBox_home_num.TabIndex = 27;
            checkBox_home_num.Text = "Домашний номер";
            checkBox_home_num.UseVisualStyleBackColor = true;
            checkBox_home_num.CheckedChanged += checkBox_home_num_CheckedChanged;
            // 
            // checkBox_mobile_num
            // 
            checkBox_mobile_num.AutoSize = true;
            checkBox_mobile_num.Location = new Point(161, 186);
            checkBox_mobile_num.Name = "checkBox_mobile_num";
            checkBox_mobile_num.Size = new Size(113, 19);
            checkBox_mobile_num.TabIndex = 33;
            checkBox_mobile_num.Text = "Рабочий номер";
            checkBox_mobile_num.UseVisualStyleBackColor = true;
            checkBox_mobile_num.CheckedChanged += checkBox_mobile_num_CheckedChanged;
            // 
            // textBox_home_num
            // 
            textBox_home_num.Location = new Point(294, 146);
            textBox_home_num.Name = "textBox_home_num";
            textBox_home_num.Size = new Size(187, 23);
            textBox_home_num.TabIndex = 28;
            textBox_home_num.TextChanged += textBox_home_num_TextChanged;
            // 
            // radioButton_woman
            // 
            radioButton_woman.AutoSize = true;
            radioButton_woman.Location = new Point(393, 225);
            radioButton_woman.Name = "radioButton_woman";
            radioButton_woman.Size = new Size(75, 19);
            radioButton_woman.TabIndex = 30;
            radioButton_woman.TabStop = true;
            radioButton_woman.Text = "Женский";
            radioButton_woman.UseVisualStyleBackColor = true;
            radioButton_woman.CheckedChanged += radioButton_woman_CheckedChanged;
            // 
            // textBox_mobile_num
            // 
            textBox_mobile_num.Location = new Point(294, 184);
            textBox_mobile_num.Name = "textBox_mobile_num";
            textBox_mobile_num.Size = new Size(187, 23);
            textBox_mobile_num.TabIndex = 34;
            textBox_mobile_num.TextChanged += textBox_mobile_num_TextChanged;
            // 
            // radioButton_man
            // 
            radioButton_man.AutoSize = true;
            radioButton_man.Location = new Point(242, 225);
            radioButton_man.Name = "radioButton_man";
            radioButton_man.Size = new Size(77, 19);
            radioButton_man.TabIndex = 29;
            radioButton_man.TabStop = true;
            radioButton_man.Text = "Мужской";
            radioButton_man.UseVisualStyleBackColor = true;
            radioButton_man.CheckedChanged += radioButton_man_CheckedChanged;
            // 
            // comboBoxUsers
            // 
            comboBoxUsers.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxUsers.FormattingEnabled = true;
            comboBoxUsers.Location = new Point(230, 70);
            comboBoxUsers.Name = "comboBoxUsers";
            comboBoxUsers.Size = new Size(251, 23);
            comboBoxUsers.TabIndex = 42;
            comboBoxUsers.SelectedIndexChanged += comboBoxUsers_SelectedIndexChanged;
            // 
            // label_name_check
            // 
            label_name_check.AutoSize = true;
            label_name_check.Location = new Point(145, 32);
            label_name_check.Name = "label_name_check";
            label_name_check.Size = new Size(10, 15);
            label_name_check.TabIndex = 43;
            label_name_check.Text = " ";
            // 
            // label_secondname__check
            // 
            label_secondname__check.AutoSize = true;
            label_secondname__check.Location = new Point(145, 73);
            label_secondname__check.Name = "label_secondname__check";
            label_secondname__check.Size = new Size(10, 15);
            label_secondname__check.TabIndex = 44;
            label_secondname__check.Text = " ";
            // 
            // label_position_check
            // 
            label_position_check.AutoSize = true;
            label_position_check.Location = new Point(145, 113);
            label_position_check.Name = "label_position_check";
            label_position_check.Size = new Size(10, 15);
            label_position_check.TabIndex = 45;
            label_position_check.Text = " ";
            // 
            // label_password_check
            // 
            label_password_check.AutoSize = true;
            label_password_check.Location = new Point(145, 265);
            label_password_check.Name = "label_password_check";
            label_password_check.Size = new Size(10, 15);
            label_password_check.TabIndex = 48;
            label_password_check.Text = " ";
            // 
            // label_mobile_num_check
            // 
            label_mobile_num_check.AutoSize = true;
            label_mobile_num_check.Location = new Point(145, 187);
            label_mobile_num_check.Name = "label_mobile_num_check";
            label_mobile_num_check.Size = new Size(10, 15);
            label_mobile_num_check.TabIndex = 47;
            label_mobile_num_check.Text = " ";
            // 
            // label_home_num_check
            // 
            label_home_num_check.AutoSize = true;
            label_home_num_check.Location = new Point(145, 146);
            label_home_num_check.Name = "label_home_num_check";
            label_home_num_check.Size = new Size(10, 15);
            label_home_num_check.TabIndex = 46;
            label_home_num_check.Text = " ";
            // 
            // label_gender_check
            // 
            label_gender_check.AutoSize = true;
            label_gender_check.Location = new Point(145, 229);
            label_gender_check.Name = "label_gender_check";
            label_gender_check.Size = new Size(10, 15);
            label_gender_check.TabIndex = 49;
            label_gender_check.Text = " ";
            // 
            // EditUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label_gender_check);
            Controls.Add(label_password_check);
            Controls.Add(label_mobile_num_check);
            Controls.Add(label_home_num_check);
            Controls.Add(label_position_check);
            Controls.Add(label_secondname__check);
            Controls.Add(label_name_check);
            Controls.Add(comboBoxUsers);
            Controls.Add(comboBox_position);
            Controls.Add(label_password);
            Controls.Add(textBox_password);
            Controls.Add(label_gender);
            Controls.Add(label_position);
            Controls.Add(label_surneme);
            Controls.Add(label_name);
            Controls.Add(textBox_name);
            Controls.Add(checkBox_home_num);
            Controls.Add(checkBox_mobile_num);
            Controls.Add(textBox_home_num);
            Controls.Add(radioButton_woman);
            Controls.Add(textBox_mobile_num);
            Controls.Add(radioButton_man);
            Controls.Add(buttonBack);
            Controls.Add(button_save);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EditUserForm";
            Text = "EditUserForm";
            Load += EditUserForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void EditUserForm_Load(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        #endregion
        private Button buttonBack;
        private Button button_save;
        private ComboBox comboBox_position;
        private Label label_password;
        private TextBox textBox_password;
        private Label label_gender;
        private Label label_position;
        private Label label_surneme;
        private Label label_name;
        private TextBox textBox_name;
        private CheckBox checkBox_home_num;
        private CheckBox checkBox_mobile_num;
        private TextBox textBox_home_num;
        private RadioButton radioButton_woman;
        private TextBox textBox_mobile_num;
        private RadioButton radioButton_man;
        private ComboBox comboBoxUsers;
        private Label label_name_check;
        private Label label_secondname__check;
        private Label label_position_check;
        private Label label_password_check;
        private Label label_mobile_num_check;
        private Label label_home_num_check;
        private Label label_gender_check;
    }
}