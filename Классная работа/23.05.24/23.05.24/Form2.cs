using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23._05._24
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Main_Form a)
        {
            InitializeComponent();
            BackgroundImage = a.BackgroundImage;
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
