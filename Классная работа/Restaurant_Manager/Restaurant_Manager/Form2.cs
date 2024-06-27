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
        private List<Order_item> order_list;
        private List<string> dish_list;

        public Form2(List<string> _dish_list)
        {

            InitializeComponent();

            dish_list = new List<string>();
            dish_list.AddRange(_dish_list);

            choose_dish.Items.Clear();
            foreach (var d in dish_list)
                choose_dish.Items.Add(d);
            order_list = new List<Order_item>();
            this.dish_list = _dish_list;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_order_newDish_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader($"data/dishes/{choose_dish.Text}.txt"))
            {
                string cost_s = sr.ReadLine();
                Order_item temp = new Order_item(
                    choose_dish.Text, Int32.Parse(cost_s),
                    (Control)table_order_listDish, order_list
                );
                order_list.Add(temp);
                temp.load(table_order_listDish.Controls);
            }
        }

        private void table_order_listDish_Click(object sender, EventArgs e)
        {

        }

        private void btn_total_calc_Click(object sender, EventArgs e)
        {
            int total = 0;
            foreach (Order_item item in order_list)
            {
                total += item.get_price();
            }
            total_cost.Text = total.ToString();
        }
    }
}
