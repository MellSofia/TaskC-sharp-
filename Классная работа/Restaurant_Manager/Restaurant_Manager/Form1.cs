using System.Text;

namespace Restaurant_Manager
{
    public partial class Form1 : Form
    {
        string FilePath_poducts = "data/products.txt";
        public Form1()
        {
            InitializeComponent();

            DirectoryInfo dir = new DirectoryInfo("data");
            if (!dir.Exists) dir.Create();
            if (!File.Exists(FilePath_poducts)) File.Create(FilePath_poducts);
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
                }
            }
        }
        private void btn_prod_load_Click(object sender, EventArgs e)
        {
            bool flag = true;
            if (prod_load_name.Text == "")
            {
                flag = false;
                MessageBox.Show("Õ‡ÔË¯ËÚÂ Ì‡Á‚‡ÌËÂ ÔÓ‰ÛÍÚ‡");
            }
            if (flag)
            {
                using (StreamWriter sw = new StreamWriter(FilePath_poducts))
                {
                    //—“Œ– ¿ ƒÀﬂ Õ¿«¬¿Õ»… œ–Œƒ” “Œ¬
                    List<string> prod_name = new List<string>();
                    //÷» À √ƒ≈ œ–Œƒ” “€(list_products.Items) ¡”ƒ”“  À¿—“‹—ﬂ »« list_products ¬ —“–Œ ” ¬€ÿ≈)
                    foreach (var i in  prod_load_name.Items)
                    {
                        string temp = i.ToString();
                        prod_name.Add(temp.Substring(temp.IndexOf('-')+2));
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
                    }
                }
            }
        }

        private void list_products_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(list_products.SelectedIndex != null)
            {
                string selectNote = list_products.SelectedIndex.ToString();

                prod_load_name.Text = selectNote.Substring(selectNote.IndexOf('-') + 2);
                prod_load_amount.Value = Int32.Parse(selectNote.Substring(0, selectNote.IndexOf('-') - 1));
            }
        }
    }
}
