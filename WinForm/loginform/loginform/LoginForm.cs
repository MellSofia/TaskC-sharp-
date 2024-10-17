using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginform
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            string username = textBox_user_name.Text;
            string password = textBox_password.Text;

            // Простая проверка логина
            if (username == "admin" && password == "admin")
            {
                MessageBox.Show("Войти как администратор?", "Выбор входа", MessageBoxButtons.YesNo);
                if(MessageBoxButtons.YesNo == 0)
                {
                    
                }
                else
                {

                }
                this.Close();
            }
            else if (username == "user" && password == "userpass")
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Неверное имя пользователя или пароль");
            }
        }
    }
}
