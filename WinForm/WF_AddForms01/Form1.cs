namespace WF_AddForms01
{
    public partial class MainForm : Form
    {
        private SecondForm sf;
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
            sf = new SecondForm();
            sf.Owner = this;
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            sf.Show();
        }

        private void buttonShowDialog_Click(object sender, EventArgs e)
        {
            sf.ShowDialog();
        }
    }
}
