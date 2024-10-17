using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sofia
{
    public partial class EditUserForm : Form
    {
        private Login_Regist_Form form1;
        private List<User> users_ = new List<User>();
        public EditUserForm(Login_Regist_Form _form1_)
        {
            InitializeComponent();
            form1 = _form1_;
            users_ = _form1_.users;

            // Добавляем пользователей в comboBox, исключая администратора
            foreach (var item in users_)
            {
                if (item.LastName != "admin") // Исключаем администратора
                {
                    comboBoxUsers.Items.Add(item.LastName);
                }
            }

            foreach (string position in _form1_.positions)
            {
                comboBox_position.Items.Add(position);

            }
        }


        private void button_save_Click(object sender, EventArgs e)
        {
            // Проверка заполненности полей
            if (string.IsNullOrWhiteSpace(textBox_name.Text) ||
                string.IsNullOrWhiteSpace(comboBox_position.Text) ||
                (string.IsNullOrWhiteSpace(textBox_password.Text)) ||
                (checkBox_home_num.Checked && string.IsNullOrWhiteSpace(textBox_home_num.Text)) ||
                (checkBox_mobile_num.Checked && string.IsNullOrWhiteSpace(textBox_mobile_num.Text)) ||
                (!radioButton_man.Checked && !radioButton_woman.Checked))
            {
                MessageBox.Show("Пожалуйста, заполните все обязательные поля.");
                return;
            }

            foreach (var item in users_)
            {
                item.FirstName = textBox_name.Text;
                item.Gender = radioButton_man.Checked ? "Мужской" : "Женский";
                item.Position = comboBox_position.SelectedItem.ToString();
                item.HomePhone = checkBox_home_num.Checked ? textBox_home_num.Text : null;
                item.MobilePhone = checkBox_mobile_num.Checked ? textBox_mobile_num.Text : null;
                item.Password = textBox_password.Text;
            }


            MessageBox.Show("Изменения прошли успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            comboBoxUsers.SelectedItem = null;
            ClearcomboBoxUsersFields();
        }

        private void comboBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearcomboBoxUsersFields(); // Очищаем поля перед отображением новой информации

            string lastName = comboBoxUsers.Text;

            User user = users_.Find(u => u.LastName == lastName);
            if (user != null) // Проверяем, найден ли пользователь
            {
                textBox_name.Text = user.FirstName;
                comboBox_position.Text = user.Position;
                textBox_home_num.Text = user.HomePhone;
                textBox_mobile_num.Text = user.MobilePhone;
                checkBox_home_num.Checked = !string.IsNullOrEmpty(textBox_home_num.Text);
                checkBox_mobile_num.Checked = !string.IsNullOrEmpty(textBox_mobile_num.Text);
                radioButton_man.Checked = user.Gender == "Мужской";
                radioButton_woman.Checked = user.Gender == "Женский";
                textBox_password.Text = user.Password;

                textBox_mobile_num.ReadOnly = !checkBox_mobile_num.Checked;
                textBox_home_num.ReadOnly = !checkBox_home_num.Checked;


                form1.ValidateInput(comboBoxUsers, label_secondname__check);
            }
        }
        private void ClearcomboBoxUsersFields()
        {
            textBox_name.Text = string.Empty;
            textBox_password.Text = string.Empty;
            comboBox_position.SelectedItem = null;
            textBox_home_num.Text = string.Empty;
            textBox_mobile_num.Text = string.Empty;
            checkBox_home_num.Checked = false;
            checkBox_mobile_num.Checked = false;
            radioButton_man.Checked = false;
            radioButton_woman.Checked = false;

            label_name_check.Text = "";
            label_secondname__check.Text = "";
            label_position_check.Text = "";
            label_password_check.Text = "";
            label_home_num_check.Text = "";
            label_mobile_num_check.Text = "";
            label_gender_check.Text = "";
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_home_num_TextChanged(object sender, EventArgs e)
        {
            form1.ValidatePhoneNumber(textBox_home_num);
            form1.ValidateInput(textBox_home_num, checkBox_home_num, label_home_num_check);
        }

        private void textBox_mobile_num_TextChanged(object sender, EventArgs e)
        {
            form1.ValidatePhoneNumber(textBox_mobile_num);
            form1.ValidateInput(textBox_mobile_num, checkBox_mobile_num, label_mobile_num_check);
        }

        private void checkBox_home_num_CheckedChanged(object sender, EventArgs e)
        {
            textBox_home_num.ReadOnly = !checkBox_home_num.Checked;
            form1.ValidateInput(textBox_home_num, checkBox_home_num, label_home_num_check);
        }

        private void checkBox_mobile_num_CheckedChanged(object sender, EventArgs e)
        {
            textBox_mobile_num.ReadOnly = !checkBox_mobile_num.Checked;
            form1.ValidateInput(textBox_mobile_num, checkBox_mobile_num, label_mobile_num_check);
        }

        private void buttonBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_name_TextChanged(object sender, EventArgs e)
        {
            form1.ValidateTextBox(textBox_name);
            form1.ValidateInput(textBox_name, label_name_check);
        }

        private void comboBox_position_SelectedIndexChanged(object sender, EventArgs e)
        {
            form1.ValidateInput(comboBox_position, label_position_check);
        }

        private void radioButton_man_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_woman.Enabled = !radioButton_man.Checked;
            form1.radioButton_checks(radioButton_man, label_gender_check);
        }

        private void radioButton_woman_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_man.Enabled = !radioButton_woman.Checked;
            form1.radioButton_checks(radioButton_woman, label_gender_check);
        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {
            form1.ValidateInput(textBox_password, label_password_check);
        }
    }
}
