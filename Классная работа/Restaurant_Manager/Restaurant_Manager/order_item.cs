using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Manager
{
    class Order_item
    {
        private Label name;
        private NumericUpDown amount;
        private Label price;
        private List<Order_item> parent_list;
        private void amount_Click(object sender, EventArgs e)
        {
            if (amount.Value < 1)
            {
                TableLayoutPanel panel = name.Parent as TableLayoutPanel;
                if (panel != null)
                {
                    panel.Controls.Remove(name);
                    panel.Controls.Remove(amount);
                    panel.Controls.Remove(price);
                }
                parent_list.Remove(this);
            }
        }
        public Order_item(string _name, int _price,  Control parent,  List<Order_item> _parent_list)
        {
            parent_list = _parent_list;

            name = new Label();
            name.Name = _name;
            name.Text = _name;
            name.Parent = parent; 

            amount = new NumericUpDown();
            amount.Value = 1;
            amount.Click += amount_Click;
            amount.Parent = parent;

            price = new Label();
            price.Name = _name + "price";
            price.Text = _price.ToString();
            price.Parent = parent;
        }
        public string get_name()
        {
            return (name.Text);
        }
        public int get_price()
        {
            return (Int32.Parse(price.Text) * (int)amount.Value);
        }
        public void load( TableLayoutControlCollection con)
        {
            con.Add(name);
            con.Add(amount);
            con.Add(price);
        }
    }
}
