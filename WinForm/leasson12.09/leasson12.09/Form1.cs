namespace leasson12._09
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.AcceptButton = buttonEnt;
            this.CancelButton = buttonEx;
        }

        private void buttonEnt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Нажата кнопка Вход");
        }

        private void buttonEx_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonNewForm_Click(object sender, EventArgs e)
        {
            SecondForm f2 = new SecondForm();
            f2.Show();
        }
    }
}
