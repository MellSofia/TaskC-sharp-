namespace Sofia
{
    partial class Login_Regist_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Regist_Form));
            button_sent = new Button();
            textBox_mobile_num = new TextBox();
            checkBox_mobile_num = new CheckBox();
            textBox_surname = new TextBox();
            textBox_name = new TextBox();
            radioButton_woman = new RadioButton();
            radioButton_man = new RadioButton();
            textBox_home_num = new TextBox();
            checkBox_home_num = new CheckBox();
            button_regist = new Button();
            button_login = new Button();
            panel_regist = new Panel();
            label_gender_check = new Label();
            label_password_check = new Label();
            label_mobile_num_check = new Label();
            label_home_num_check = new Label();
            label_position_check = new Label();
            label_secondname__check = new Label();
            label_name_check = new Label();
            comboBox_position = new ComboBox();
            button1 = new Button();
            label_password = new Label();
            textBox_password = new TextBox();
            label_gender = new Label();
            label_position = new Label();
            label_surneme = new Label();
            label_name = new Label();
            panel_login = new Panel();
            comboBoxSurname = new ComboBox();
            buttonBack = new Button();
            label_passord = new Label();
            label_sureName = new Label();
            button_enter = new Button();
            textBoxPassword = new TextBox();
            panel_regist.SuspendLayout();
            panel_login.SuspendLayout();
            SuspendLayout();
            // 
            // button_sent
            // 
            button_sent.Location = new Point(453, 24);
            button_sent.Name = "button_sent";
            button_sent.Size = new Size(139, 67);
            button_sent.TabIndex = 17;
            button_sent.Text = "Зарегистириваться";
            button_sent.UseVisualStyleBackColor = true;
            button_sent.Click += button_sent_Click_1;
            // 
            // textBox_mobile_num
            // 
            textBox_mobile_num.Location = new Point(250, 179);
            textBox_mobile_num.Name = "textBox_mobile_num";
            textBox_mobile_num.Size = new Size(187, 23);
            textBox_mobile_num.TabIndex = 16;
            textBox_mobile_num.TextChanged += textBox_mobile_num_TextChanged;
            // 
            // checkBox_mobile_num
            // 
            checkBox_mobile_num.AutoSize = true;
            checkBox_mobile_num.Location = new Point(117, 181);
            checkBox_mobile_num.Name = "checkBox_mobile_num";
            checkBox_mobile_num.Size = new Size(113, 19);
            checkBox_mobile_num.TabIndex = 15;
            checkBox_mobile_num.Text = "Рабочий номер";
            checkBox_mobile_num.UseVisualStyleBackColor = true;
            checkBox_mobile_num.CheckedChanged += checkBox_mobile_num_CheckedChanged;
            // 
            // textBox_surname
            // 
            textBox_surname.Location = new Point(186, 68);
            textBox_surname.Name = "textBox_surname";
            textBox_surname.Size = new Size(251, 23);
            textBox_surname.TabIndex = 14;
            textBox_surname.TextChanged += textBox_surname_TextChanged;
            // 
            // textBox_name
            // 
            textBox_name.Location = new Point(186, 24);
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(251, 23);
            textBox_name.TabIndex = 13;
            textBox_name.TextChanged += textBox_name_TextChanged;
            // 
            // radioButton_woman
            // 
            radioButton_woman.AutoSize = true;
            radioButton_woman.Location = new Point(349, 220);
            radioButton_woman.Name = "radioButton_woman";
            radioButton_woman.Size = new Size(75, 19);
            radioButton_woman.TabIndex = 12;
            radioButton_woman.TabStop = true;
            radioButton_woman.Text = "Женский";
            radioButton_woman.UseVisualStyleBackColor = true;
            radioButton_woman.CheckedChanged += radioButton_woman_CheckedChanged;
            // 
            // radioButton_man
            // 
            radioButton_man.AutoSize = true;
            radioButton_man.Location = new Point(198, 220);
            radioButton_man.Name = "radioButton_man";
            radioButton_man.Size = new Size(77, 19);
            radioButton_man.TabIndex = 11;
            radioButton_man.TabStop = true;
            radioButton_man.Text = "Мужской";
            radioButton_man.UseVisualStyleBackColor = true;
            radioButton_man.CheckedChanged += radioButton_man_CheckedChanged_1;
            // 
            // textBox_home_num
            // 
            textBox_home_num.Location = new Point(250, 141);
            textBox_home_num.Name = "textBox_home_num";
            textBox_home_num.Size = new Size(187, 23);
            textBox_home_num.TabIndex = 10;
            textBox_home_num.TextChanged += textBox_home_num_TextChanged;
            // 
            // checkBox_home_num
            // 
            checkBox_home_num.AutoSize = true;
            checkBox_home_num.Location = new Point(117, 141);
            checkBox_home_num.Name = "checkBox_home_num";
            checkBox_home_num.Size = new Size(127, 19);
            checkBox_home_num.TabIndex = 9;
            checkBox_home_num.Text = "Домашний номер";
            checkBox_home_num.UseVisualStyleBackColor = true;
            checkBox_home_num.CheckedChanged += checkBox_home_num_CheckedChanged;
            // 
            // button_regist
            // 
            button_regist.Location = new Point(287, 171);
            button_regist.Name = "button_regist";
            button_regist.Size = new Size(113, 46);
            button_regist.TabIndex = 18;
            button_regist.Text = "Регистрация";
            button_regist.UseVisualStyleBackColor = true;
            button_regist.Click += button_regist_Click;
            // 
            // button_login
            // 
            button_login.Location = new Point(426, 171);
            button_login.Name = "button_login";
            button_login.Size = new Size(113, 46);
            button_login.TabIndex = 19;
            button_login.Text = "Вход";
            button_login.UseVisualStyleBackColor = true;
            button_login.Click += button_login_Click;
            // 
            // panel_regist
            // 
            panel_regist.Controls.Add(label_gender_check);
            panel_regist.Controls.Add(label_password_check);
            panel_regist.Controls.Add(label_mobile_num_check);
            panel_regist.Controls.Add(label_home_num_check);
            panel_regist.Controls.Add(label_position_check);
            panel_regist.Controls.Add(label_secondname__check);
            panel_regist.Controls.Add(label_name_check);
            panel_regist.Controls.Add(comboBox_position);
            panel_regist.Controls.Add(button1);
            panel_regist.Controls.Add(label_password);
            panel_regist.Controls.Add(textBox_password);
            panel_regist.Controls.Add(label_gender);
            panel_regist.Controls.Add(label_position);
            panel_regist.Controls.Add(label_surneme);
            panel_regist.Controls.Add(label_name);
            panel_regist.Controls.Add(button_sent);
            panel_regist.Controls.Add(textBox_name);
            panel_regist.Controls.Add(checkBox_home_num);
            panel_regist.Controls.Add(checkBox_mobile_num);
            panel_regist.Controls.Add(textBox_surname);
            panel_regist.Controls.Add(textBox_home_num);
            panel_regist.Controls.Add(radioButton_woman);
            panel_regist.Controls.Add(textBox_mobile_num);
            panel_regist.Controls.Add(radioButton_man);
            panel_regist.Location = new Point(103, 60);
            panel_regist.Name = "panel_regist";
            panel_regist.Size = new Size(641, 384);
            panel_regist.TabIndex = 20;
            // 
            // label_gender_check
            // 
            label_gender_check.AutoSize = true;
            label_gender_check.Location = new Point(101, 224);
            label_gender_check.Name = "label_gender_check";
            label_gender_check.Size = new Size(10, 15);
            label_gender_check.TabIndex = 56;
            label_gender_check.Text = " ";
            // 
            // label_password_check
            // 
            label_password_check.AutoSize = true;
            label_password_check.Location = new Point(101, 260);
            label_password_check.Name = "label_password_check";
            label_password_check.Size = new Size(10, 15);
            label_password_check.TabIndex = 55;
            label_password_check.Text = " ";
            // 
            // label_mobile_num_check
            // 
            label_mobile_num_check.AutoSize = true;
            label_mobile_num_check.Location = new Point(101, 182);
            label_mobile_num_check.Name = "label_mobile_num_check";
            label_mobile_num_check.Size = new Size(10, 15);
            label_mobile_num_check.TabIndex = 54;
            label_mobile_num_check.Text = " ";
            // 
            // label_home_num_check
            // 
            label_home_num_check.AutoSize = true;
            label_home_num_check.Location = new Point(101, 141);
            label_home_num_check.Name = "label_home_num_check";
            label_home_num_check.Size = new Size(10, 15);
            label_home_num_check.TabIndex = 53;
            label_home_num_check.Text = " ";
            // 
            // label_position_check
            // 
            label_position_check.AutoSize = true;
            label_position_check.Location = new Point(101, 108);
            label_position_check.Name = "label_position_check";
            label_position_check.Size = new Size(10, 15);
            label_position_check.TabIndex = 52;
            label_position_check.Text = " ";
            // 
            // label_secondname__check
            // 
            label_secondname__check.AutoSize = true;
            label_secondname__check.Location = new Point(101, 68);
            label_secondname__check.Name = "label_secondname__check";
            label_secondname__check.Size = new Size(10, 15);
            label_secondname__check.TabIndex = 51;
            label_secondname__check.Text = " ";
            // 
            // label_name_check
            // 
            label_name_check.AutoSize = true;
            label_name_check.Location = new Point(101, 27);
            label_name_check.Name = "label_name_check";
            label_name_check.Size = new Size(10, 15);
            label_name_check.TabIndex = 50;
            label_name_check.Text = " ";
            // 
            // comboBox_position
            // 
            comboBox_position.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_position.FormattingEnabled = true;
            comboBox_position.Location = new Point(186, 105);
            comboBox_position.Name = "comboBox_position";
            comboBox_position.Size = new Size(251, 23);
            comboBox_position.TabIndex = 26;
            comboBox_position.SelectedIndexChanged += comboBox_position_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(18, 24);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 24;
            button1.Text = "Назад";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label_password
            // 
            label_password.AutoSize = true;
            label_password.Location = new Point(122, 262);
            label_password.Name = "label_password";
            label_password.Size = new Size(49, 15);
            label_password.TabIndex = 23;
            label_password.Text = "Пароль";
            // 
            // textBox_password
            // 
            textBox_password.Location = new Point(186, 259);
            textBox_password.Name = "textBox_password";
            textBox_password.Size = new Size(238, 23);
            textBox_password.TabIndex = 22;
            textBox_password.TextChanged += textBox_password_TextChanged;
            // 
            // label_gender
            // 
            label_gender.AutoSize = true;
            label_gender.Location = new Point(126, 224);
            label_gender.Name = "label_gender";
            label_gender.Size = new Size(30, 15);
            label_gender.TabIndex = 21;
            label_gender.Text = "Пол";
            // 
            // label_position
            // 
            label_position.AutoSize = true;
            label_position.Location = new Point(117, 108);
            label_position.Name = "label_position";
            label_position.Size = new Size(69, 15);
            label_position.TabIndex = 20;
            label_position.Text = "Должность";
            // 
            // label_surneme
            // 
            label_surneme.AutoSize = true;
            label_surneme.Location = new Point(117, 68);
            label_surneme.Name = "label_surneme";
            label_surneme.Size = new Size(58, 15);
            label_surneme.TabIndex = 19;
            label_surneme.Text = "Фамилия";
            // 
            // label_name
            // 
            label_name.AutoSize = true;
            label_name.Location = new Point(117, 27);
            label_name.Name = "label_name";
            label_name.Size = new Size(31, 15);
            label_name.TabIndex = 18;
            label_name.Text = "Имя";
            // 
            // panel_login
            // 
            panel_login.Controls.Add(comboBoxSurname);
            panel_login.Controls.Add(buttonBack);
            panel_login.Controls.Add(label_passord);
            panel_login.Controls.Add(label_sureName);
            panel_login.Controls.Add(button_enter);
            panel_login.Controls.Add(textBoxPassword);
            panel_login.Location = new Point(81, 12);
            panel_login.Name = "panel_login";
            panel_login.Size = new Size(625, 25);
            panel_login.TabIndex = 21;
            // 
            // comboBoxSurname
            // 
            comboBoxSurname.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSurname.FormattingEnabled = true;
            comboBoxSurname.Location = new Point(185, 57);
            comboBoxSurname.Name = "comboBoxSurname";
            comboBoxSurname.Size = new Size(121, 23);
            comboBoxSurname.TabIndex = 6;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(19, 27);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(75, 23);
            buttonBack.TabIndex = 5;
            buttonBack.Text = "Назад";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click_1;
            // 
            // label_passord
            // 
            label_passord.AutoSize = true;
            label_passord.Location = new Point(121, 92);
            label_passord.Name = "label_passord";
            label_passord.Size = new Size(49, 15);
            label_passord.TabIndex = 4;
            label_passord.Text = "Пароль";
            // 
            // label_sureName
            // 
            label_sureName.AutoSize = true;
            label_sureName.Location = new Point(121, 60);
            label_sureName.Name = "label_sureName";
            label_sureName.Size = new Size(58, 15);
            label_sureName.TabIndex = 3;
            label_sureName.Text = "Фамилия";
            // 
            // button_enter
            // 
            button_enter.Location = new Point(348, 60);
            button_enter.Name = "button_enter";
            button_enter.Size = new Size(75, 23);
            button_enter.TabIndex = 2;
            button_enter.Text = "Войти";
            button_enter.UseVisualStyleBackColor = true;
            button_enter.Click += button_enter_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(185, 89);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(100, 23);
            textBoxPassword.TabIndex = 1;
            // 
            // Login_Regist_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel_login);
            Controls.Add(panel_regist);
            Controls.Add(button_login);
            Controls.Add(button_regist);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login_Regist_Form";
            Text = "Login_Regist_Form";
            panel_regist.ResumeLayout(false);
            panel_regist.PerformLayout();
            panel_login.ResumeLayout(false);
            panel_login.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button_sent;
        private TextBox textBox_mobile_num;
        private CheckBox checkBox_mobile_num;
        private TextBox textBox_surname;
        private TextBox textBox_name;
        private RadioButton radioButton_woman;
        private RadioButton radioButton_man;
        private TextBox textBox_home_num;
        private CheckBox checkBox_home_num;
        private Button button_regist;
        private Button button_login;
        private Panel panel_regist;
        private Label label_name;
        private Label label_gender;
        private Label label_position;
        private Label label_surneme;
        private Panel panel_login;
        private Label label_password;
        private TextBox textBox_password;
        private Label label_passord;
        private Label label_sureName;
        private Button button_enter;
        private TextBox textBoxPassword;
        private Button buttonBack;
        private Button button1;
        private ComboBox comboBox_position;
        private ComboBox comboBoxSurname;
        public Label label_gender_check;
        public Label label_password_check;
        public Label label_mobile_num_check;
        public Label label_home_num_check;
        public Label label_position_check;
        public Label label_secondname__check;
        public Label label_name_check;
    }
}
