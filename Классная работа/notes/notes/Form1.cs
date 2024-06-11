using System.Runtime.Versioning;
using notes.Properties;
using static System.Net.Mime.MediaTypeNames;
using System.Text;
using System.Windows.Forms;

namespace notes
{
    public partial class Form1 : Form
    {
        private string note_name_hint = "Hазвание заметки. Hе более 500 слова";
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new object[]
            {
                "1","2","3"
            });
            DirectoryInfo dir = new DirectoryInfo("data");
            if (!dir.Exists)
            {
                dir.Create();
            }
            string[] arr;
            foreach (var i in dir.GetFiles())
            {
                list_notes.Items.Add(i.Name);
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            bool flag = true;
            if (Name_textbox.Text == note_name_hint || Name_textbox.Text == "")
            {
                flag = false;
                MessageBox.Show("Название не должно быть пусты");
            }
            if (comments_textBox.Text == note_name_hint || comments_textBox.Text == "")
            {
                flag = false;
                MessageBox.Show("Текст заметки не должно быть пусты");
            }
            if (comboBox1.Text == note_name_hint || !comboBox1.Items.Contains(comboBox1.Text))
            {
                flag = false;
                MessageBox.Show("Приоритет заметки не должно быть пусты");
            }
            if (!comboBox1.Items.Contains(comboBox1.Text))
            {
                flag = false;
                MessageBox.Show("Выберите приоритет заметки");
            }
            if (flag)
            {

                string filePath = $"{comboBox1.Text} # {Name_textbox.Text}.txt";
                if (File.Exists(filePath)) { File.Delete(filePath); }
                using (FileStream fs = new FileStream(filePath, FileMode.Create))
                {
                    using (StreamWriter sw = new StreamWriter(fs, Encoding.Unicode))
                    {
                        sw.WriteLine(comboBox1.Text);
                        sw.WriteLine(dateTimePicker1.Text);
                        foreach (var item in comments_textBox.Text)
                        {
                            sw.Write($"{item}");
                        }
                    }
                }
                list_notes.Items.Add($"{comboBox1.Text} # {Name_textbox.Text}");
                comments_textBox.Text = "";
                Name_textbox.Text = "";
                dateTimePicker1.Text = "";
                comboBox1.Text = "";
            }
        }

        private void Name_textbox_Enter(object sender, EventArgs e)
        {
            Name_textbox.ForeColor = Color.Black;
            if (Name_textbox.Text == note_name_hint)
            {
                Name_textbox.Text = "";
            }
        }

        private void Name_textbox_Leave(object sender, EventArgs e)
        {
            if (Name_textbox.Text == "" || Name_textbox.Text == note_name_hint || Name_textbox.Text == null)
            {
                Name_textbox.ForeColor = Color.Gray;
                Name_textbox.Text = note_name_hint;
            }
        }

        private void list_notes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_notes.SelectedIndex != null)
            {
                string selectNode = list_notes.SelectedIndex.ToString();
                string filePath = $"data/{selectNode}.txt";
                using (FileStream fs = new FileStream(filePath, FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs, Encoding.Unicode))
                    {
                        Name_textbox.Text = selectNode.Substring(selectNode.IndexOf('#') + 2);
                        comboBox1.Text = sr.ReadLine();
                        dateTimePicker1.Text = sr.ReadLine();
                        comments_textBox.Text = sr.ReadToEnd();
                    }
                }
            }
        }
    }
}
