using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sofia
{
    public partial class Login_Regist_Form : Form
    {
        public List<User> users = new List<User>();
        public String[] positions = new String[] { "Директор", "Управляющий", "Рабочий", "Маркетолог" };

        public Login_Regist_Form()
        {
            InitializeComponent();
            // Добавление администратора в список пользователей
            users.Add(new User
            {
                LastName = "admin",
                Password = "admin"
            });
            panel_regist.Visible = false;
            panel_login.Visible = false;
            textBox_home_num.ReadOnly = true;
            textBox_mobile_num.ReadOnly = true;
            foreach (string position in positions)
            {
                comboBox_position.Items.Add(position);
            }
            this.AcceptButton = button_enter;
        }

        

        private void button_regist_Click(object sender, EventArgs e)
        {
            panel_regist.Visible = !panel_regist.Visible;
            panel_regist.Size = new Size(600, 350);
            button_regist.Visible = !button_regist.Visible;
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            panel_login.Visible = !panel_login.Visible;
            panel_login.Size = new Size(500, 350);
            button_login.Visible = !button_login.Visible;

            comboBoxSurname.Items.Clear();

            foreach (var item in users)
            {
                comboBoxSurname.Items.Add(item.LastName);
            }
        }

        public void button_sent_Click_1(object sender, EventArgs e)
        {
            // Проверка заполненности полей
            if (string.IsNullOrWhiteSpace(textBox_surname.Text) ||
                string.IsNullOrWhiteSpace(textBox_name.Text) ||
                string.IsNullOrWhiteSpace(comboBox_position.Text) ||
                string.IsNullOrWhiteSpace(textBox_password.Text) ||
                (checkBox_home_num.Checked && string.IsNullOrWhiteSpace(textBox_home_num.Text)) ||
                (checkBox_mobile_num.Checked && string.IsNullOrWhiteSpace(textBox_mobile_num.Text)) ||
                (!radioButton_man.Checked && !radioButton_woman.Checked))
            {
                MessageBox.Show("Пожалуйста, заполните все обязательные поля.");
                return;
            }

            // Проверка на дубликаты
            if (users.Any(u => u.LastName == textBox_surname.Text && u.FirstName == textBox_name.Text))
            {
                MessageBox.Show("Такой пользователь уже существует.");
                return;
            }

            // Создание нового пользователя
            User newUser = new User
            {
                FirstName = textBox_name.Text,
                LastName = textBox_surname.Text,
                Gender = radioButton_man.Checked ? "Мужской" : "Женский",
                Position = comboBox_position.SelectedItem.ToString(),
                HomePhone = checkBox_home_num.Checked ? textBox_home_num.Text : null,
                MobilePhone = checkBox_mobile_num.Checked ? textBox_mobile_num.Text : null,
                Password = textBox_password.Text
            };

            users.Add(newUser); // Добавление нового пользователя в список
            MessageBox.Show("Регистрация прошла успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearRegistrationFields(); // Очистка полей регистрации
        }

        private void ClearRegistrationFields()
        {
            foreach (Control control in panel_regist.Controls)
            {
                if (control is TextBox textBox)
                    textBox.Text = string.Empty;
                else if (control is ComboBox comboBox)
                    comboBox.SelectedIndex = -1;
                else if (control is CheckBox checkBox)
                    checkBox.Checked = false;
                else if (control is RadioButton radioButton)
                    radioButton.Checked = false;
            }
            // Очистка индикаторов
            label_name_check.Text = "";
            label_secondname__check.Text = "";
            label_position_check.Text = "";
            label_password_check.Text = "";
            label_home_num_check.Text = "";
            label_mobile_num_check.Text = "";
            label_gender_check.Text = "";
        }

        private void button_enter_Click(object sender, EventArgs e)
        {
            string lastName = comboBoxSurname.Text;
            string password = textBoxPassword.Text;

            // Поиск пользователя по фамилии и паролю
            User user = users.Find(u => u.LastName == lastName && u.Password == password);
            if (user != null)
            {
                if (user.LastName == "admin" && user.Password == "admin")
                {
                    DialogResult result = MessageBox.Show("Хотите ли вы войти как админ?", "Подтверждение", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        EditUserForm editform = new EditUserForm(this);
                        editform.Owner = this;
                        editform.ShowDialog(this);
                    }
                    else
                    {
                        MessageBox.Show(user.ShowInfo());
                    }
                }
                else
                {
                    MessageBox.Show(user.ShowInfo());
                }
            }
            else
            {
                MessageBox.Show("Ошибка входа: неверная фамилия или пароль.");
            }

            ClearLoudFields();
        }

        private void ClearLoudFields()
        {
            comboBoxSurname.SelectedIndex = -1;
            textBoxPassword.Text = string.Empty;
        }

        private void buttonBack_Click_1(object sender, EventArgs e)
        {
            panel_login.Visible = !panel_login.Visible;
            button_login.Visible = !button_login.Visible;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel_regist.Visible = !panel_regist.Visible;
            button_regist.Visible = !button_regist.Visible;
        }

        public void ValidatePhoneNumber(TextBox textBox)
        {
            string num = textBox.Text.Trim();

            if (!string.IsNullOrEmpty(num) && !Int32.TryParse(num, out _))
            {
                MessageBox.Show("Ошибка ввода: номер должен состоять из цифр.");
                textBox.Text = string.Empty; // Очищаем поле только после предупреждения
            }
        }

        public void ValidateTextBox(TextBox textBox)
        {
            string input = textBox.Text.Trim();

            // Проверяем, состоит ли ввод только из букв
            if (!string.IsNullOrEmpty(input) && !input.All(char.IsLetter))
            {
                MessageBox.Show("Ошибка ввода: поле должно содержать только буквы.");
                textBox.Text = string.Empty; // Очищаем поле только после предупреждения
            }
        }

        public void ValidateInput(TextBox textBox, CheckBox checkBox, Label indicatorLabel)
        {
            string input = textBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(input) || !checkBox.Checked)
            {
                indicatorLabel.Text = "✗"; // Крестик для пустого поля
                indicatorLabel.ForeColor = Color.Red;
            }
            else
            {
                indicatorLabel.Text = "✓"; // Галочка для корректного ввода
                indicatorLabel.ForeColor = Color.Green;
            }
        }

        public void ValidateInput(TextBox textBox, Label indicatorLabel)
        {
            string input = textBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                indicatorLabel.Text = "✗"; // Крестик для пустого поля
                indicatorLabel.ForeColor = Color.Red;
            }
            else
            {
                indicatorLabel.Text = "✓"; // Галочка для корректного ввода
                indicatorLabel.ForeColor = Color.Green;
            }
        }

        public void ValidateInput(ComboBox comboBox, Label indicatorLabel)
        {
            if (comboBox.SelectedItem == null)
            {
                indicatorLabel.Text = "✗"; // Крестик для пустого выбора
                indicatorLabel.ForeColor = Color.Red;
            }
            else
            {
                indicatorLabel.Text = "✓"; // Галочка для корректного выбора
                indicatorLabel.ForeColor = Color.Green;
            }
        }

        private void checkBox_home_num_CheckedChanged(object sender, EventArgs e)
        {
            textBox_home_num.ReadOnly = !checkBox_home_num.Checked;
        }

        private void checkBox_mobile_num_CheckedChanged(object sender, EventArgs e)
        {
            textBox_mobile_num.ReadOnly = !checkBox_mobile_num.Checked;
        }

        private void textBox_name_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBox(textBox_name);
            ValidateInput(textBox_name, label_name_check);
        }

        private void textBox_home_num_TextChanged(object sender, EventArgs e)
        {
            ValidatePhoneNumber(textBox_home_num);
            ValidateInput(textBox_home_num, checkBox_home_num, label_home_num_check);
        }

        private void textBox_mobile_num_TextChanged(object sender, EventArgs e)
        {
            ValidatePhoneNumber(textBox_mobile_num);
            ValidateInput(textBox_mobile_num, checkBox_mobile_num, label_mobile_num_check);
        }

        private void textBox_surname_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBox(textBox_surname);
            ValidateInput(textBox_surname, label_secondname__check);
        }

        private void comboBox_position_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateInput(comboBox_position, label_position_check);
        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {
            ValidateInput(textBox_password, label_password_check);
        }

        public void radioButton_checks(RadioButton radioButton, Label indicatorLabel)
        {
            if (!radioButton.Checked)
            {
                indicatorLabel.Text = "✗"; // Крестик для пустого выбора
                indicatorLabel.ForeColor = Color.Red;
            }
            else
            {
                indicatorLabel.Text = "✓"; // Галочка для корректного выбора
                indicatorLabel.ForeColor = Color.Green;
            }
        }

        public void radioButton_man_CheckedChanged_1(object sender, EventArgs e)
        {
            radioButton_woman.Enabled = !radioButton_man.Checked;
            radioButton_checks(radioButton_man, label_gender_check);
        }

        public void radioButton_woman_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_man.Enabled = !radioButton_woman.Checked;
            radioButton_checks(radioButton_woman, label_gender_check);
        }

    }
    
public class User : INotifyPropertyChanged
    {
        private string lastName;
        private string firstName;
        private string position;
        private string homePhone;
        private string mobilePhone;
        private string gender;
        private string password;

        public event PropertyChangedEventHandler PropertyChanged;

        public string LastName
        {
            get => lastName;
            set => SetProperty(ref lastName, value);
        }

        public string FirstName
        {
            get => firstName;
            set => SetProperty(ref firstName, value);
        }

        public string Position
        {
            get => position;
            set => SetProperty(ref position, value);
        }

        public string HomePhone
        {
            get => homePhone;
            set => SetProperty(ref homePhone, value);
        }

        public string MobilePhone
        {
            get => mobilePhone;
            set => SetProperty(ref mobilePhone, value);
        }

        public string Gender
        {
            get => gender;
            set => SetProperty(ref gender, value);
        }

        public string Password
        {
            get => password;
            set => SetProperty(ref password, value);
        }

        public string ShowInfo()
        {
            string text = "Вход выполнен успешно!" +
                          "\n Фамилия: " + this.LastName +
                          "\n Имя: " + this.FirstName +
                          "\n Должность: " + this.Position;
            if (!string.IsNullOrEmpty(this.HomePhone))
            {
                text += "\n Домашний номер: " + this.HomePhone;
            }
            if (!string.IsNullOrEmpty(this.MobilePhone))
            {
                text += "\n Мобильный номер: " + this.MobilePhone;
            }
            text += "\n Пол: " + this.Gender;
            return text;
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetProperty<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (!EqualityComparer<T>.Default.Equals(field, value))
            {
                field = value;
                OnPropertyChanged(propertyName);
                return true;
            }
            return false;
        }
    }

}