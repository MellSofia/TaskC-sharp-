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
        private string note_comment_hint = "“екст заметки.";
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
                list_notes.Items.Add(Path.GetFileNameWithoutExtension(i.Name));
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            bool flag = true;
            foreach (var i in Name_textbox.Text)
            {
                if (i == '.' || i == '?' || i == '/' || i == '\\' || i == '\'' || i == '\"' || i == '*' || i == '<' || i == '>' || i == '|')
                {
                    flag = false;
                    MessageBox.Show("название не должно содержать . ? , / и тому подобные ");
                }
            }
            if (Name_textbox.Text == note_name_hint || Name_textbox.Text == "")
            {
                flag = false;
                MessageBox.Show("название не должно быть пустым");
            }
            if (comments_textBox.Text == note_comment_hint || comments_textBox.Text == "")
            {
                flag = false;
                MessageBox.Show("текст заметки не должен быть пустым");
            }
            if (comboBox1.Text == "")
            {
                flag = false;
                MessageBox.Show("приоритет заметки не должен быть пустым");
            }
            if (!comboBox1.Items.Contains(comboBox1.Text))
            {
                flag = false;
                MessageBox.Show("пожалуйста, выберите приоритет из списка");
            }

            if (flag)
            {
                string filePath = $"data/# {Name_textbox.Text}.txt";
                if (File.Exists(filePath)) { File.Delete(filePath); }
                using (FileStream fs = new FileStream(filePath, FileMode.Create))
                {
                    using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
                    {
                        sw.WriteLine(comboBox1.Text);
                        sw.WriteLine(dateTimePicker1.Text);
                        foreach (var item in comments_textBox.Text)
                        {
                            sw.Write($"{item}");
                        }
                    }
                }
                if (list_notes.FindString($"# {Name_textbox.Text}") != -1)
                {
                    list_notes.Items.Remove($"# {Name_textbox.Text}");
                }

                list_notes.Items.Add($"# {Name_textbox.Text}");
                comments_textBox.Text = "";
                Name_textbox.Text = "";
                comboBox1.Text = "";
                dateTimePicker1.Text = "";
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
            if (Name_textbox.Text == ""
                || Name_textbox.Text == note_name_hint
                || Name_textbox.Text == null)
            {
                Name_textbox.ForeColor = Color.Gray;
                Name_textbox.Text = note_name_hint;
            }
        }

        private void list_notes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_notes.SelectedItem != null)
            {
                string selectNote = list_notes.SelectedItem.ToString();

                string filePath = $"data/{selectNote}.txt";

                using (FileStream fs = new FileStream(filePath, FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs, Encoding.UTF8))
                    {
                        Name_textbox.Text = selectNote.Substring(selectNote.IndexOf('#') + 2);
                        comboBox1.Text = sr.ReadLine();
                        dateTimePicker1.Text = sr.ReadLine();
                        comments_textBox.Text = sr.ReadToEnd();
                        button_del.Visible = true;
                    }

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comments_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void comments_textBox_Enter(object sender, EventArgs e)
        {
            comments_textBox.ForeColor = Color.Black;
            if (comments_textBox.Text == note_comment_hint)
                comments_textBox.Text = "";
        }

        private void comments_textBox_Leave(object sender, EventArgs e)
        {
            if (comments_textBox.Text == ""
                || comments_textBox.Text == note_comment_hint
                || comments_textBox.Text == null)
            {
                comments_textBox.ForeColor = Color.Gray;
                comments_textBox.Text = note_comment_hint;
            }
        }

        private void button_del_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("¬ы точно хотите удалить заметку?", "—ообщение",
    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
    MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            if (res == DialogResult.Yes)
            {
                string filePath = $"data/# {Name_textbox.Text}.txt";
                if (File.Exists(filePath)) { File.Delete(filePath); }
                list_notes.Items.Remove($"# {Name_textbox.Text}");
                comments_textBox.Text = "";
                Name_textbox.Text = "";
                comboBox1.Text = "";
                dateTimePicker1.Text = "";
                button_del.Visible = false;
            }
        }

        private void button_new_Click(object sender, EventArgs e)
        {
            comments_textBox.Text = "";
            Name_textbox.Text = "";
            comboBox1.Text = "";
            dateTimePicker1.Text = "";
        }
    }
}
