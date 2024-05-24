namespace _23._05._24
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
//            button1.Click += button1_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {
/*            MessageBox.Show("Hello");*/
              Form2 f2 = new Form2(this);
            Main_Form f = new Main_Form();
            f.Show();
            f2.Show(); 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
/*            System.Drawing.Drawing2D.GraphicsPath myPath = new System.Drawing.Drawing2D.GraphicsPath();
            myPath.AddEllipse(0,0,this.Width,this.Height);
            Region myRegion = new Region(myPath);
            this.Region = myRegion;*/
            Button helloButton = new Button();
            helloButton.BackColor=Color.White;
        }
    }
}
