using System.ComponentModel;
using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;

namespace WinForms_01_10_24
{
    public partial class Form1 : Form
    {
        private Test test;

        public Form1()
        {
            InitializeComponent();
            test = new Test();

            // Привязка 
            label1.DataBindings.Add(new Binding("Text", test, "Field1", true, DataSourceUpdateMode.OnPropertyChanged));
            label2.DataBindings.Add(new Binding("Text", test, "Field2", true, DataSourceUpdateMode.OnPropertyChanged));
            label3.DataBindings.Add(new Binding("Text", test, "Field3", true, DataSourceUpdateMode.OnPropertyChanged));
            textBox1.DataBindings.Add(new Binding("Text", test, "Field1", true, DataSourceUpdateMode.OnPropertyChanged));
            textBox2.DataBindings.Add(new Binding("Text", test, "Field2", true, DataSourceUpdateMode.OnPropertyChanged));
            textBox3.DataBindings.Add(new Binding("Text", test, "Field3", true, DataSourceUpdateMode.OnPropertyChanged));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            test.Field1 = "Новое значение 1";
            Controls.Add(button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            test.Field2 = "Новое значение 2";
            Controls.Add(button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            test.Field3 = "Новое значение 3";
            Controls.Add(button3);
        }
    }

    public class Test : INotifyPropertyChanged
    {
        private string field1;
        private string field2;
        private string field3;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Field1
        {
            get => field1;
            set
            {
                if (field1 != value)
                {
                    field1 = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Field2
        {
            get => field2;
            set
            {
                if (field2 != value)
                {
                    field2 = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Field3
        {
            get => field3;
            set
            {
                if (field3 != value)
                {
                    field3 = value;
                    OnPropertyChanged();
                }
            }
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
