namespace notes
{
    public partial class Form1 : Form
    {
        private string text;
        private StreamWriter sw = new StreamWriter("C:\\Users\\Student_06\\Desktop\\C#\\TaskC-sharp-\\�������� ������\\notes\\texts.txt");
        public Form1()
        {
            InitializeComponent();
            text = "";
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            text = "��������: " + Name_textbox.Text + "\t";
            sw.WriteLine(text);
            text = "����: " + dateTimePicker1.Text + "\t";
            sw.WriteLine(text);
            text = "���������: " + comboBox1.Text + "\t";
            sw.WriteLine(text);
            text = "����������: " + comments_textBox.Text;
            sw.WriteLine(text);
            sw.Close();
        }
    }
}
