namespace notes
{
    public partial class Form1 : Form
    {
        private string text;
        private StreamWriter sw = new StreamWriter("C:\\Users\\Student_06\\Desktop\\C#\\TaskC-sharp-\\Классная работа\\notes\\texts.txt");
        public Form1()
        {
            InitializeComponent();
            text = "";
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            text = "Название: " + Name_textbox.Text + "\t";
            sw.WriteLine(text);
            text = "Дата: " + dateTimePicker1.Text + "\t";
            sw.WriteLine(text);
            text = "Приоритет: " + comboBox1.Text + "\t";
            sw.WriteLine(text);
            text = "Коментарий: " + comments_textBox.Text;
            sw.WriteLine(text);
            sw.Close();
        }
    }
}
