namespace notes
{
    public partial class Form1 : Form
    {
        private string text;
        private StreamWriter sw = new StreamWriter("C:\\Users\\Student_08\\Documents\\Cods 21\\notes\\texts.txt");
        public Form1()
        {
            InitializeComponent();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            text = "��������: " + Name_textbox.Text + "\t";
            text += "����: " + dateTimePicker1.Text + "\t";
            text += "���������: " + comboBox1.Text + "\t";
            text += "����������: " + comments_textBox.Text;
            sw.WriteLine(text);
            sw.Close();
        }
    }
}
