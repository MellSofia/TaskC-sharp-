using System.Diagnostics.Metrics;

namespace dz_WinFormApp._29._05._24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void decr_button_Click(object sender, EventArgs e)
        {
            counter -= 1;
            show_text.Text = counter.ToString();
        }

        private void incr_button_Click(object sender, EventArgs e)
        {
            counter += 1;
            show_text.Text = counter.ToString();
        }
    }
}
