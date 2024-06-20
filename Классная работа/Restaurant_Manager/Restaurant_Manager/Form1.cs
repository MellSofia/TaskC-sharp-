using System.Diagnostics;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Restaurant_Manager
{
    public partial class Form1 : Form
    {
        string FilePath_poducts = "data/products.txt";
        //private int f;
        public Form1()
        {
            InitializeComponent();

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



            DirectoryInfo dir_dishes = new DirectoryInfo("data/dishes");
            if (!dir_dishes.Exists) dir_dishes.Create();

            List<string> Dishes_name = new List<string>();
            string Dish_path = "data/dishes/";
            /*foreach (var i in dir.GetFiles())
            {
                Dishes_name.Add(i.Name);
                using (StreamReader sr = new StreamReader($"data/dishes/{i.Name}.txt"))
                {
                    list_products.Items.AddRange(sr.ReadToEnd().Split("\r\n"));
                    list_products.Items.RemoveAt(list_products.Items.Count - 1);
                }
            }*/


        }
        private void btn_prod_load_Click(object sender, EventArgs e)
        {
            bool flag = true;
            if (prod_load_name.Text == "")
            {
                flag = false;
                MessageBox.Show("Ќапишите название продукта");
            }

            if (chProd_for_dish.ToString() == "")
            {
                flag = false;
                MessageBox.Show("Ќапишите название продукта");
            }

            if (flag)
            {
                using (StreamWriter sw = new StreamWriter(FilePath_poducts))
                {


                    // исправить дублирование продуктов -
                    // добавление уже существующего продукта
                    // должно обновл€ть данные в списке и в файле
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
                        list_products.Items[
                            list_products.Items.IndexOf(
                                t_s)] =
                                $"{prod_load_amount.Value} - {prod_load_name.Text}";
                    }
                    else
                    {
                        list_products.Items.Add(
                            $"{prod_load_amount.Value} - {prod_load_name.Text}");
                        chProd_for_dish.Items.Add($"{prod_load_name.Text}");
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
            if (list_products.SelectedIndex != null)
            {
                string selectNote = list_products.SelectedItem.ToString();
                prod_load_name.Text = selectNote.Substring(selectNote.IndexOf('-') + 2);
                prod_load_amount.Value = Int32.Parse(
                    selectNote.Substring(0, selectNote.IndexOf('-') - 1));
            }
        }
        private void listDish_item_Clic(object sender, EventArgs e)
        {
            btn_dish_del.Visible = true;
            NewDish_name.Text = ((Label)sender).Text;
            newDish_cost.Value = Int32.Parse(((Label)((Label)sender).Tag).Text);

            using (StreamReader sr = new StreamReader($"data/dishes/{((Label)sender).Text}.txt"))
            {
                string recept = sr.ReadToEnd();
                string[] products = recept.Split('\n');//(\n\r)
                for(int i= 0; i<products.Length; i++) 
                {
                    string[]t = products[i].Split(new char[] {':'});

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
        //dish list updater
        private void ListDish_update(int amount, string dish_name, int cost)
        {

            if (table_listDishes.Controls.Find(dish_name, false).Count() > 0)
            {
                ((Label)((Label)table_listDishes.
                    Controls.Find(dish_name, false)[0]).Tag).Text = amount.ToString();
            }
            else
            {
                Label d_name = new Label();
                d_name.Name = dish_name;
                d_name.Text = dish_name;
                d_name.Click += listDish_item_Clic;

                Label d_amount = new Label();
                d_amount.Text = amount.ToString();
                d_name.Tag = d_amount;

                Label d_cost = new Label();
                d_cost.Text = cost.ToString();
                d_amount.Tag = d_cost;
                //d_cost.Tag = d_name;
                //d_name.Tag = d_amount;

                table_listDishes.Controls.Add(d_amount);
                table_listDishes.Controls.Add(d_name);
                table_listDishes.Controls.Add(d_cost);

            }
        }


        private void btn_add_dishes_Click(object sender, EventArgs e)
        {

            bool flag = true;

            // здесь нужно описать проверки дл€ записи блюда.
            // механика записи аналогична записи заметок (код в комментарии ниже из заметок).
            // нажатие на им€ блюда откроет данное блюдо в редакторе рецепта (тот что справа)
            // точно так же, как и в заметках.
            // список продуктов так же необходимо модифицировать выводитьс€ как таблицу
            if (NewDish_name.Text == "")
            {
                flag = false;
                MessageBox.Show("Ќапишите название блюда");
                if (newDish_cost.Value > newDish_cost.Minimum)
                {
                    if (table_dish_ProdList.Controls.Count > 0)
                    {
                    }
                    else
                    {
                        flag = false;
                        MessageBox.Show("¬ыбурите продукты блюда");
                    }
                }
                else
                {
                    flag = false;
                    MessageBox.Show("Ќапишите цену блюда");
                }
            }

            if (flag)
            {
                string filePath = $"data/dishes/{NewDish_name.Text}.txt";
                if (File.Exists(filePath)) { File.Delete(filePath); }
                using (FileStream fs = new FileStream(filePath, FileMode.Create))
                {
                    using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
                    {
                        sw.WriteLine($"Ќазвание: {NewDish_name.Text}");
                        sw.WriteLine($"÷ена: {newDish_cost.Value}");
                        sw.WriteLine($"ѕродукты:");
                        foreach (var item in table_dish_ProdList.Controls)
                        {
                            if (item is Label)
                            {
                                sw.Write($"{((Label)item).Text} ");
                            }
                            else
                            {
                                sw.WriteLine($"- {((NumericUpDown)item).Value}");
                            }
                        }
                    }
                }
                ListDish_update(1000, NewDish_name.Text, (int)newDish_cost.Value);
                NewDish_name.Text = "";
                newDish_cost.Value = newDish_cost.Minimum;
                chProd_for_dish.Text = "";
                table_dish_ProdList.Controls.Clear();
            }
        }


        private void newDish_prodList_numUpDown_Del(object sender, EventArgs e)
        {
            if ((((NumericUpDown)sender).Value) == 0)
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

        private void prod_load_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            anonLabel(chProd_for_dish.Text);
            chProd_for_dish.Text = "";
        }
        private void btn_addProd_to_new_dish_Click(object sender, EventArgs e)
        {
            anonLabel(chProd_for_dish.Text);
            chProd_for_dish.Text = "";
        }

        private void chProd_for_dish_SelectedIndexChanged(object sender, EventArgs e)
        {
            anonLabel(chProd_for_dish.Text);
            chProd_for_dish.Text = "";
        }

        private void penal_dish_ProdList_Paint(object sender, PaintEventArgs e)
        {

        }
        private void list_dishes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void table_listDishes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_dish_del_Click(object sender, EventArgs e)
        {
            //table_dish_ProdList.Controls.Remove
/*            btn_dish_del.Visible = false;
            btn_load_new_dishes.Size = new Size(254, 29);
            NewDish_name.Text = "";
            newDish_cost.Value = newDish_cost.Minimum;
            chProd_for_dish.Text = "";
            table_dish_ProdList.Controls.Clear();*/
        }

        /*        private void panel1_Paint(object sender, PaintEventArgs e)
                {

                }*/
    }
}
