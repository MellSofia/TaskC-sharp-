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
            string way = "notes_files\\" + Name_textbox.Text + ".txt"; //�� ���������� � bin\Debug\net8.0-windows\notes_files
            StreamWriter sw = new StreamWriter(way);
            texts = "��������: " + Name_textbox.Text + "\t";
            sw.WriteLine(texts);
            texts = "����: " + dateTimePicker1.Text + "\t";
            sw.WriteLine(texts);
            texts = "���������: " + comboBox1.Text + "\t";
            sw.WriteLine(texts);
            texts = "����������: " + comments_textBox.Text;
/*            texts = $"{"��������: " + Name_textbox.Text}";
            texts += $"{"����: " + dateTimePicker1.Text}";
            texts += $"{"���������: " + comboBox1.Text}";
            texts += $"{"����������: " + comments_textBox.Text}";*/
            sw.WriteLine(texts);
            sw.Close();
            comments_textBox.Text = "";
            Name_textbox.Text = "";
            dateTimePicker1.Text = "";
            comboBox1.Text = "";
        }
    }
}
