using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Restaurant_Manager
{
    public partial class Form2 : Form
    {
        string FilePath_dishes = "data/dishes";

        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            bool flag2 = true;
            if (flag2)
            {
                string filePath = $"{FilePath_dishes}/# {dish_name.Text}.txt";
                if (File.Exists(filePath)) { File.Delete(filePath); }
                using (FileStream fs = new FileStream(filePath, FileMode.Create))
                {
                    using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
                    {
                        sw.WriteLine(dish_name.Text);;
                        foreach (var item in dish_content.Text)
                        {
                            sw.Write($"{item}");
                        }
                    }
                }
                dish_name.Text = "";
                dish_content.Text = "";   
            }
        }
    }
}
