namespace loginform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_logInSistem_Click(object sender, EventArgs e)
        {
            LoginForm f2 = new LoginForm();
            f2.Owner = this;
            f2.ShowDialog(this);
        }
    }
}
