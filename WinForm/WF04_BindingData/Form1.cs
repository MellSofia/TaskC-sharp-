using System;


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            labelChange_1.DataBindings.Add(new Binding("Text", textBox1, "Text"));

            Binding binding = new Binding("Text", textBox2, "Text");
            binding.Format += (sender, e) => e.Value = $"Строка из текстбокса: {e.Value}";
            labelChange_2.DataBindings.Add(binding);

            Human human = new Human();
            labelChange_3.DataBindings.Add(new Binding("Text", human, "FIO"));
            textBox3.DataBindings.Add(new Binding("Text", human, "FIO"));

            //labelChange_4.DataBindings.Add(new Binding("Text", human, "FIO", false, DataSourceUpdateMode.OnPropertyChanged));
            //textBox4.DataBindings.Add(new Binding("Text", human, "FIO", false, DataSourceUpdateMode.OnPropertyChanged));
        }
    }
    
    public class Human
    {
        public string FIO { get; set; }
    }

