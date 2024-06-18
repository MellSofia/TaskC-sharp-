using System.Diagnostics;
using System.Text;

namespace Restaurant_Manager
{
    public partial class Form1 : Form
    {
        string FilePath_poducts = "data/products.txt";
        string FilePath_dishes = "data/dishes";
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
        }
        private void btn_prod_load_Click(object sender, EventArgs e)
        {
            bool flag = true;
            if (prod_load_name.Text == "")
            {
                flag = false;
                MessageBox.Show("Напишите название продукта");
            }
            if (flag)
            {
                using (StreamWriter sw = new StreamWriter(FilePath_poducts))
                {


                    // исправить дублирование продуктов -
                    // добавление уже существующего продукта
                    // должно обновлять данные в списке и в файле
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

                    /*//СТОРКА ДЛЯ НАЗВАНИЙ ПРОДУКТОВ
                    List<string> prod_name = new List<string>();
                    //ЦИКЛ ГДЕ ПРОДУКТЫ(list_products.Items) БУДУТ КЛАСТЬСЯ ИЗ list_products В СТРОКУ ВЫШЕ)
                    foreach (var i in prod_load_name.Items)
                    {
                        string temp = i.ToString();
                        prod_name.Add(temp.Substring(temp.IndexOf('-') + 2));
                    }
                    if (list_products.Items.Contains(prod_load_name.Text))
                    {
                        list_products.Items[list_products.Items.IndexOf(prod_load_name.Text)] = $"{prod_load_amount.Value} - {prod_load_name.Text}";
                    }
                    else
                    {
                        list_products.Items.Add($"{prod_load_amount.Value} - {prod_load_name.Text}");
                    }
                    foreach (var item in list_products.Items)
                    {
                        sw.Write($"{item}");
                    }*/
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

        private void btn_add_dishes_Click(object sender, EventArgs e)
        {

        }

        private void penal_dish_ProdList_Paint(object sender, PaintEventArgs e)
        {

        }

        private void load_page_Paint(object sender, PaintEventArgs e)
        {

        }

        private void prod_load_amount_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_addProd_to_new_dish_Click(object sender, EventArgs e)
        {

        }
        private void NewDish_prod_list_numUpDown_Del(object sender, EventArgs e)
        {
            if ((((NumericUpDown)sender).Value) == 0)
            {
                table_dish_ProdList.Controls.Remove((Label)((NumericUpDown)sender).Tag);

                ((NumericUpDown)sender).Dispose();
            }
        }

        private void anonLable(String text)
        {
            Label t = new Label();
            t.Text = text;
            table_dish_ProdList.Controls.Add(t);
            NumericUpDown n = new NumericUpDown();
            n.Minimum = 0;
            n.Maximum = 100;
            n.Tag = t;
            n.ValueChanged += NewDish_prod_list_numUpDown_Del;
            table_dish_ProdList.Controls.Add(n);

        }

        private void prod_load_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            anonLable(chProd_for_dish.Text);
            chProd_for_dish.Text = "";
        }

        private void list_dishes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
