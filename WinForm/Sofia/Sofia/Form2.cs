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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void checkBox_home_num_CheckedChanged(object sender, EventArgs e)
        {
            textBox_home_num.ReadOnly = !checkBox_home_num.Checked;

        }

        private void checkBox_work_num_CheckedChanged(object sender, EventArgs e)
        {
            textBox_work_num.ReadOnly = !checkBox_work_num.Checked;
        }

        private void radioButton_man_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_woman.Enabled = !radioButton_man.Checked;
        }
        private void radioButton_woman_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_man.Enabled = !radioButton_woman.Checked;

        }

        private void button_sent_Click(object sender, EventArgs e)
        {
            if ((textBox_name.Text == "") || (textBox_surname.Text == "") || 
                ((!radioButton_man.Checked) & (!radioButton_woman.Checked) ) 
                || ((checkBox_home_num.Checked) & (textBox_home_num.Text == ""))
                || ((checkBox_work_num.Checked) & (textBox_work_num.Text == "")))
            {
                MessageBox.Show("Не все поля заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Все поля заполнены", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
