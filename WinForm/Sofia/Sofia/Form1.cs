namespace Sofia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {

            int resalt = sum();
            label_sum.Text = resalt.ToString();
            if (resalt > 0)
            {

                label_sum.Visible = true;
            }
        }
        private int sum()
        {

            if (textBox_sum1.Text != "" && textBox_sum2.Text != "") return Int32.Parse(textBox_sum1.Text) + Int32.Parse(textBox_sum2.Text);
            MessageBox.Show("Поля сложения пустые!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return 0;
        }

        private int min()
        {
            if (textBox_sum1.Text != "" && textBox_sum2.Text != "") return Int32.Parse(textBox_sum1.Text) - Int32.Parse(textBox_sum2.Text);
            MessageBox.Show("Поля вычитания пустые!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return 0;
        }
        private void button_minus_Click(object sender, EventArgs e)
        {
            int resalt = min();
            label_sum.Text = resalt.ToString();
        }

        private int del()
        {
            if (textBox_sum1.Text != "" && textBox_sum2.Text != "") return Int32.Parse(textBox_sum1.Text) / Int32.Parse(textBox_sum2.Text);
            MessageBox.Show("Поля деления пустые!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int resalt = del();
            label_sum.Text = resalt.ToString();
        }

        private int umn()
        {
            if (textBox_sum1.Text != "" && textBox_sum2.Text != "") return Int32.Parse(textBox_sum1.Text) * Int32.Parse(textBox_sum2.Text);
            MessageBox.Show("Поля умножения пустые!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return 0;
        }

        private void button_umn_Click(object sender, EventArgs e)
        {
            int resalt = umn();
            label_sum.Text = resalt.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
