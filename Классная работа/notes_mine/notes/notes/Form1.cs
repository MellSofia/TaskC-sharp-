namespace notes
{
    public partial class Form1 : Form
    {
        private string texts;
        public Form1()
        {
            InitializeComponent();
            texts = "";
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            string way = "notes_files\\" + Name_textbox.Text + ".txt"; //Всё сохранится в bin\Debug\net8.0-windows\notes_files
            StreamWriter sw = new StreamWriter(way);
            texts = "Название: " + Name_textbox.Text + "\t";
            sw.WriteLine(texts);
            texts = "Дата: " + dateTimePicker1.Text + "\t";
            sw.WriteLine(texts);
            texts = "Приоритет: " + comboBox1.Text + "\t";
            sw.WriteLine(texts);
            texts = "Коментарий: " + comments_textBox.Text;
/*            texts = $"{"Название: " + Name_textbox.Text}";
            texts += $"{"Дата: " + dateTimePicker1.Text}";
            texts += $"{"Приоритет: " + comboBox1.Text}";
            texts += $"{"Коментарий: " + comments_textBox.Text}";*/
            sw.WriteLine(texts);
            sw.Close();
            comments_textBox.Text = "";
            Name_textbox.Text = "";
            dateTimePicker1.Text = "";
            comboBox1.Text = "";
        }
    }
}
