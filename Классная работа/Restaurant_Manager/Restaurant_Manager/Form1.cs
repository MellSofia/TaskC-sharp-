using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Restaurant_Manager
{
    public partial class Form1 : Form
    {
        string FilePath_poducts = "data/products.txt";
        //string FilePath_dishes = "data/dishes";
        public List<string> list_prods_string = new List<string>();
        public Form1()
        {
            InitializeComponent();
            // products reader
            DirectoryInfo dir = new DirectoryInfo("data");
            if (!dir.Exists) dir.Create();
            if (!File.Exists(FilePath_poducts)) File.Create(FilePath_poducts).Close();


            list_products.Items.Clear();
            using (StreamReader sr = new StreamReader(FilePath_poducts))
            {
                list_products.Items.AddRange(sr.ReadToEnd().Split("\r\n"));
                list_products.Items.RemoveAt(list_products.Items.Count - 1);

            }

            foreach (string line in list_products.Items)
            {
                if (line.Length > 0)
                {
                    prod_load_name.Items.Add(line.Substring(line.IndexOf('-') + 2));
                    chProd_for_dish.Items.Add(line.Substring(line.IndexOf('-') + 2));
                }
            }
            // dishes reader
            DirectoryInfo dir_dishes = new DirectoryInfo("data/dishes");
            if (!dir_dishes.Exists) dir_dishes.Create();

            foreach (var i in dir_dishes.GetFiles())
            {
                using (StreamReader sr = new StreamReader($"data/dishes/{i.Name}"))
                {
                    string cost_s = sr.ReadLine();
                    string recept = sr.ReadToEnd();
                    string[] products = recept.Split('\n');

                    List<int> amount_prod = new List<int>();
                    for (int j = 0; j < products.Length - 1; j++)
                    {
                        string[] prod_amnt = products[j].Split(new char[] { ':' });
                        int amnt = Int32.Parse(prod_amnt[1]);
                        int sclad_amnt = 0;
                        foreach (var k in list_products.Items)
                        {
                            string temp = k.ToString();
                            temp = temp.Substring(temp.IndexOf('-') + 2);
                            if (temp == prod_amnt[0])
                            {
                                sclad_amnt = Int32.Parse((k.ToString()).
                                    Substring(0, k.ToString().IndexOf('-') - 1));
                                break;
                            }
                        }
                        amount_prod.Add(sclad_amnt / amnt);

                        // в этой t лежат два значения - имя продукта и его количество.
                        // далее нужно сделать целочисленное деление общего кол-ва
                        // этого продукта на складе на его количество из рецепта.
                        // полученное число добавлять в amount_prod
                    }
                    amount_prod.Sort();
                    int amount = amount_prod[0];


                    // здесь надо найти наименьшее в amount_prod и
                    // записать его в amount
                    string dish_n = i.Name.Substring(0, i.Name.IndexOf('.'));
                    Label d_name = new Label();
                    d_name.Name = dish_n;
                    d_name.Text = dish_n;
                    d_name.Click += listDish_item_Click;

                    Label d_amount = new Label();
                    d_amount.Text = amount.ToString();
                    d_name.Tag = d_amount;

                    Label d_cost = new Label();
                    d_cost.Text = cost_s;
                    d_amount.Tag = d_cost;

                    table_listDishes.Controls.Add(d_amount);
                    table_listDishes.Controls.Add(d_name);
                    table_listDishes.Controls.Add(d_cost);

                }
            }
        }


        private void btn_prod_load_Click(object sender, EventArgs e)
        {
            bool flag = true;
            if (prod_load_name.Text == "")
            {
                flag = false;
                MessageBox.Show("Напишите название блюда");
            }


            if (flag)
            {
                using (StreamWriter sw = new StreamWriter(FilePath_poducts))
                {
                    int t_i = -1;
                    string t_s = "";
                    foreach (var i in list_products.Items)
                    {
                        string temp = i.ToString();
                        temp = temp.Substring(temp.IndexOf('-') + 2);
                        if (temp == prod_load_name.Text)
                        {
                            t_i = list_products.Items.IndexOf(i);
                            t_s = i.ToString();
                            break;
                        }
                    }
                    if (t_i != -1)
                    {
                        if (prod_load_amount.Value <= 0)
                        {
                            list_products.Items.RemoveAt(t_i);  
                        }
                        else
                        {
                            list_products.Items[t_i] = $"{prod_load_amount.Value} - {prod_load_name.Text}";
                        }
                    }
                    else
                    {
                        if (prod_load_amount.Value > 0)
                        {
                            list_products.Items.Add($"{prod_load_amount.Value} - {prod_load_name.Text}");
                            chProd_for_dish.Items.Add($"{prod_load_name.Text}");
                        }
                    }

                    foreach (var item in list_products.Items)
                    {
                        sw.WriteLine($"{item}");
                    }

                }
            }
        }
        private void list_products_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_products.SelectedItem != null && list_products.SelectedItem.ToString() != "")
            {
                string selectNote = list_products.SelectedItem.ToString();
                prod_load_name.Text = selectNote.Substring(selectNote.IndexOf('-') + 2);
                if (Int32.TryParse(selectNote.Substring(0, selectNote.IndexOf('-') - 1), out int amount))
                {
                    prod_load_amount.Value = amount;
                }
            }
        }
        private void listDish_item_Click(object sender, EventArgs e)
        {
            btn_dish_del.Visible = true;

            NewDish_name.Text = ((Label)sender).Text;
            newDish_cost.Value =
                Int32.Parse(((Label)((Label)((Label)sender).Tag).Tag).Text);
            table_dish_ProdList.Controls.Clear();
            using (StreamReader sr =
                new StreamReader($"data/dishes/{((Label)sender).Text}.txt"))
            {
                string ss = sr.ReadLine();
                string recept = sr.ReadToEnd();
                string[] products = recept.Split('\n');
                for (int i = 0; i < products.Length - 1; i++)
                {
                    string[] t = products[i].Split(new char[] { ':' });

                    Label l = new Label();
                    l.Text = t[0];
                    table_dish_ProdList.Controls.Add(l);

                    NumericUpDown n = new NumericUpDown();
                    n.Minimum = 0;
                    n.Maximum = 100;
                    n.Value = Int32.Parse(t[1]);
                    n.Tag = l;
                    n.BorderStyle = BorderStyle.None;
                    n.ValueChanged += newDish_prodList_numUpDown_Del;
                    table_dish_ProdList.Controls.Add(n);
                }
            }

            if (btn_dish_del.Visible == true) { btn_load_new_dishes.Size = new Size(173, 29); }

        }


        //
        private int dish_amnt_calc(string[][] recept)
        {
            int amount = 1;
            List<int> amount_prod = new List<int>();
            for (int j = 0; j < recept.Length; j++)
            {
                int amnt = Int32.Parse(recept[j][1]);
                int sclad_amnt = 0;
                foreach (var k in list_products.Items)
                {
                    string temp = k.ToString();
                    temp = temp.Substring(temp.IndexOf('-') + 2);
                    if (temp == recept[j][0])
                    {
                        sclad_amnt = Int32.Parse((k.ToString()).
                            Substring(0, k.ToString().IndexOf('-') - 1));
                        break;
                    }
                }
                amount_prod.Add(sclad_amnt / amnt);
            }
            amount_prod.Sort();
            amount = amount_prod[0];
            return amount;
        }
        //dish list updater
        private void ListDish_update(int amount, string dish_name, int cost)
        {

            if (table_listDishes.Controls.Find(dish_name, false).Count() > 0)
            {
                ((Label)((Label)table_listDishes.
                    Controls.Find(dish_name, false)[0]).Tag).Text = amount.ToString();
                ((Label)((Label)((Label)table_listDishes.
                    Controls.Find(dish_name, false)[0]).Tag).Tag).Text = cost.ToString();
            }
            else
            {
                Label d_name = new Label();
                d_name.Name = dish_name;
                d_name.Text = dish_name;
                d_name.Width = 100;
                d_name.Click += listDish_item_Click;

                Label d_amount = new Label();
                d_amount.Text = amount.ToString();
                d_name.Tag = d_amount;

                Label d_cost = new Label();
                d_cost.Text = cost.ToString();
                d_amount.Tag = d_cost;

                table_listDishes.Controls.Add(d_amount);
                table_listDishes.Controls.Add(d_name);
                table_listDishes.Controls.Add(d_cost);
            }
        }


        private void btn_add_dishes_Click(object sender, EventArgs e)
        {

            bool flag = true;
            if (NewDish_name.Text == "")
            {
                flag = false;
                MessageBox.Show("Напишите название блюда");
            }

            if (newDish_cost.Value < newDish_cost.Minimum)
            {
                flag = false;
                MessageBox.Show("Напишите цену блюда");
            }

            if (table_dish_ProdList.Controls.Count == 0)
            {
                flag = false;
                MessageBox.Show("Выберите продукты блюда");
            }

            if (flag)
            {
                string filePath = $"data/dishes/{NewDish_name.Text}.txt";
                if (File.Exists(filePath)) { File.Delete(filePath); }

                string[][] recept = new string[table_dish_ProdList.Controls.Count / 2][];

                using (FileStream fs = new FileStream(filePath, FileMode.Create))
                {
                    using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
                    {
                        int count = 0;
                        sw.WriteLine(newDish_cost.Value);
                        foreach (var item in table_dish_ProdList.Controls)
                        {
                            if (item is Label)
                            {
                                recept[count] = new string[2];
                                string ttt = ((Label)item).Text;
                                recept[count][0] = ttt;
                                sw.Write(ttt);

                            }
                            else
                            {
                                recept[count][1] = ((NumericUpDown)item).Value.ToString();
                                sw.WriteLine($":{((NumericUpDown)item).Value}");
                                count++;
                            }
                        }
                    }
                }
                ListDish_update(dish_amnt_calc(recept), NewDish_name.Text, (int)newDish_cost.Value);
                NewDish_name.Text = "";
                newDish_cost.Value = newDish_cost.Minimum;
                chProd_for_dish.Text = "";
                table_dish_ProdList.Controls.Clear();

                btn_dish_del.Visible = false;
                btn_load_new_dishes.Size = new Size(254, 29);
            }
        }


        private void newDish_prodList_numUpDown_Del(object sender, EventArgs e)
        {
            if (((NumericUpDown)sender).Value == 0)
            {
                table_dish_ProdList.Controls.Remove((Label)((NumericUpDown)sender).Tag);

                ((NumericUpDown)sender).Dispose();
            }
        }

        private void anonLabel(String text)
        {
            Label t = new Label();
            t.Text = text;
            table_dish_ProdList.Controls.Add(t);

            NumericUpDown n = new NumericUpDown();
            n.Minimum = 0;
            n.Maximum = 100;
            n.Value = 1;
            n.Tag = t;
            n.BorderStyle = BorderStyle.None;
            n.ValueChanged += newDish_prodList_numUpDown_Del;
            table_dish_ProdList.Controls.Add(n);

        }

        private void btn_addProd_to_new_dish_Click(object sender, EventArgs e)
        {
            if(chProd_for_dish.Text.Length == 0) MessageBox.Show("Выберите продукты блюда");
            if (chProd_for_dish.Text.Length > 0)
            {
                btn_dish_del.Visible = false;
                anonLabel(chProd_for_dish.Text);
                chProd_for_dish.Text = "";
            }
        }




        private void btn_dish_del_Click(object sender, EventArgs e)
        {
            File.Delete($"data/dishes/{NewDish_name.Text}.txt");

            table_listDishes.Controls.Remove(
                (Label)
                    ((Label)
                        (table_listDishes.Controls.Find(NewDish_name.Text, true)[0]).
                            Tag).Tag
                );
            table_listDishes.Controls.Remove(
                (Label)
                        (table_listDishes.Controls.Find(NewDish_name.Text, true)[0]).
                            Tag
                );
            table_listDishes.Controls.Remove(
                table_listDishes.Controls.Find(NewDish_name.Text, true)[0]
                );
            table_dish_ProdList.Controls.Clear();
            newDish_cost.Value = newDish_cost.Minimum;
            NewDish_name.Text = "";



            btn_dish_del.Visible = false;
            btn_load_new_dishes.Size = new Size(254, 29);

        }

        private void NewDish_name_Enter(object sender, EventArgs e)
        {
            btn_dish_del.Visible = false;
        }

        private void chProd_for_dish_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_start_order_Click(object sender, EventArgs e)
        {
            List<string>dish_list = new List<string>();
            foreach (var item in table_listDishes.Controls)
            {
                if(item is Label)
                {
                    if (!((Label)item).Text.All(char.IsDigit))
                    {
                        dish_list.Add(((Label)item).Text);
                    }
                }
            }
            Form2 ord = new Form2(dish_list);
            ord.Show();
        }
    }
}