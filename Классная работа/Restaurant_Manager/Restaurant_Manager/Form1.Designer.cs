namespace Restaurant_Manager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            load_page = new Panel();
            groupBox_add_dish = new GroupBox();
            newDish_cost = new NumericUpDown();
            btn_addProd_to_new_dish = new Button();
            penal_dish_ProdList = new Panel();
            table_dish_ProdList = new TableLayoutPanel();
            chProd_for_dish = new ComboBox();
            btn_load_new_dishes = new Button();
            NewDish_name = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label_list_prod = new Label();
            btn_prod_load = new Button();
            prod_load_amount = new NumericUpDown();
            prod_load_name = new ComboBox();
            list_dishes = new ListBox();
            list_products = new ListBox();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            load_page.SuspendLayout();
            groupBox_add_dish.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)newDish_cost).BeginInit();
            penal_dish_ProdList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)prod_load_amount).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // load_page
            // 
            load_page.Controls.Add(label5);
            load_page.Controls.Add(label4);
            load_page.Controls.Add(label1);
            load_page.Controls.Add(panel1);
            load_page.Controls.Add(groupBox_add_dish);
            load_page.Controls.Add(label3);
            load_page.Controls.Add(label2);
            load_page.Controls.Add(label_list_prod);
            load_page.Controls.Add(btn_prod_load);
            load_page.Controls.Add(prod_load_amount);
            load_page.Controls.Add(prod_load_name);
            load_page.Controls.Add(list_dishes);
            load_page.Controls.Add(list_products);
            load_page.Dock = DockStyle.Fill;
            load_page.Location = new Point(0, 0);
            load_page.Name = "load_page";
            load_page.Size = new Size(784, 661);
            load_page.TabIndex = 0;
            load_page.Paint += load_page_Paint;
            // 
            // groupBox_add_dish
            // 
            groupBox_add_dish.Controls.Add(newDish_cost);
            groupBox_add_dish.Controls.Add(btn_addProd_to_new_dish);
            groupBox_add_dish.Controls.Add(penal_dish_ProdList);
            groupBox_add_dish.Controls.Add(chProd_for_dish);
            groupBox_add_dish.Controls.Add(btn_load_new_dishes);
            groupBox_add_dish.Controls.Add(NewDish_name);
            groupBox_add_dish.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBox_add_dish.Location = new Point(506, 285);
            groupBox_add_dish.Name = "groupBox_add_dish";
            groupBox_add_dish.Size = new Size(266, 364);
            groupBox_add_dish.TabIndex = 9;
            groupBox_add_dish.TabStop = false;
            groupBox_add_dish.Text = "Добавление блюда";
            // 
            // newDish_cost
            // 
            newDish_cost.Location = new Point(173, 22);
            newDish_cost.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            newDish_cost.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            newDish_cost.Name = "newDish_cost";
            newDish_cost.Size = new Size(87, 29);
            newDish_cost.TabIndex = 7;
            newDish_cost.ThousandsSeparator = true;
            newDish_cost.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // btn_addProd_to_new_dish
            // 
            btn_addProd_to_new_dish.Location = new Point(173, 57);
            btn_addProd_to_new_dish.Name = "btn_addProd_to_new_dish";
            btn_addProd_to_new_dish.Size = new Size(87, 29);
            btn_addProd_to_new_dish.TabIndex = 5;
            btn_addProd_to_new_dish.Text = "Добавить";
            btn_addProd_to_new_dish.UseVisualStyleBackColor = true;
            btn_addProd_to_new_dish.Click += btn_addProd_to_new_dish_Click;
            // 
            // penal_dish_ProdList
            // 
            penal_dish_ProdList.AutoScroll = true;
            penal_dish_ProdList.Controls.Add(table_dish_ProdList);
            penal_dish_ProdList.Location = new Point(6, 92);
            penal_dish_ProdList.Name = "penal_dish_ProdList";
            penal_dish_ProdList.Size = new Size(254, 224);
            penal_dish_ProdList.TabIndex = 4;
            penal_dish_ProdList.Paint += penal_dish_ProdList_Paint;
            // 
            // table_dish_ProdList
            // 
            table_dish_ProdList.AutoSize = true;
            table_dish_ProdList.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            table_dish_ProdList.ColumnCount = 2;
            table_dish_ProdList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            table_dish_ProdList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            table_dish_ProdList.Dock = DockStyle.Top;
            table_dish_ProdList.Location = new Point(0, 0);
            table_dish_ProdList.Name = "table_dish_ProdList";
            table_dish_ProdList.RowCount = 2;
            table_dish_ProdList.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            table_dish_ProdList.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            table_dish_ProdList.Size = new Size(254, 3);
            table_dish_ProdList.TabIndex = 3;
            // 
            // chProd_for_dish
            // 
            chProd_for_dish.DropDownStyle = ComboBoxStyle.DropDownList;
            chProd_for_dish.FormattingEnabled = true;
            chProd_for_dish.Location = new Point(6, 57);
            chProd_for_dish.Name = "chProd_for_dish";
            chProd_for_dish.Size = new Size(161, 29);
            chProd_for_dish.TabIndex = 2;
            // 
            // btn_load_new_dishes
            // 
            btn_load_new_dishes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btn_load_new_dishes.Location = new Point(6, 329);
            btn_load_new_dishes.Name = "btn_load_new_dishes";
            btn_load_new_dishes.Size = new Size(254, 29);
            btn_load_new_dishes.TabIndex = 6;
            btn_load_new_dishes.Text = "Загрузить блюдо в список";
            btn_load_new_dishes.UseVisualStyleBackColor = true;
            btn_load_new_dishes.Click += btn_add_dishes_Click;
            // 
            // NewDish_name
            // 
            NewDish_name.Location = new Point(6, 22);
            NewDish_name.Name = "NewDish_name";
            NewDish_name.Size = new Size(161, 29);
            NewDish_name.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(512, 238);
            label3.Name = "label3";
            label3.Size = new Size(140, 21);
            label3.TabIndex = 8;
            label3.Text = "Добавить блюдо";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 12F);
            label2.Location = new Point(315, 120);
            label2.Name = "label2";
            label2.Size = new Size(110, 21);
            label2.TabIndex = 7;
            label2.Text = "Список блюд";
            // 
            // label_list_prod
            // 
            label_list_prod.AutoSize = true;
            label_list_prod.Font = new Font("Segoe UI Emoji", 12F);
            label_list_prod.Location = new Point(58, 120);
            label_list_prod.Name = "label_list_prod";
            label_list_prod.Size = new Size(148, 21);
            label_list_prod.TabIndex = 5;
            label_list_prod.Text = "Список продуктов";
            // 
            // btn_prod_load
            // 
            btn_prod_load.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btn_prod_load.Location = new Point(204, 147);
            btn_prod_load.Name = "btn_prod_load";
            btn_prod_load.Size = new Size(92, 32);
            btn_prod_load.TabIndex = 4;
            btn_prod_load.Text = "Загрузить";
            btn_prod_load.UseVisualStyleBackColor = true;
            btn_prod_load.Click += btn_prod_load_Click;
            // 
            // prod_load_amount
            // 
            prod_load_amount.Location = new Point(165, 155);
            prod_load_amount.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            prod_load_amount.Name = "prod_load_amount";
            prod_load_amount.Size = new Size(33, 23);
            prod_load_amount.TabIndex = 3;
            prod_load_amount.ValueChanged += prod_load_amount_ValueChanged;
            // 
            // prod_load_name
            // 
            prod_load_name.FormattingEnabled = true;
            prod_load_name.Location = new Point(55, 155);
            prod_load_name.Name = "prod_load_name";
            prod_load_name.Size = new Size(104, 23);
            prod_load_name.TabIndex = 2;
            prod_load_name.SelectedIndexChanged += prod_load_name_SelectedIndexChanged;
            // 
            // list_dishes
            // 
            list_dishes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            list_dishes.FormattingEnabled = true;
            list_dishes.ItemHeight = 21;
            list_dishes.Location = new Point(193, 12);
            list_dishes.Name = "list_dishes";
            list_dishes.Size = new Size(158, 88);
            list_dishes.TabIndex = 1;
            list_dishes.SelectedIndexChanged += list_dishes_SelectedIndexChanged;
            // 
            // list_products
            // 
            list_products.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            list_products.FormattingEnabled = true;
            list_products.ItemHeight = 21;
            list_products.Location = new Point(15, 12);
            list_products.Name = "list_products";
            list_products.Size = new Size(143, 88);
            list_products.TabIndex = 0;
            list_products.SelectedIndexChanged += list_products_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            panel1.Location = new Point(241, 285);
            panel1.Name = "panel1";
            panel1.Size = new Size(232, 358);
            panel1.TabIndex = 10;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(232, 3);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(292, 267);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 11;
            label1.Text = "название блюда";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(241, 267);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 12;
            label4.Text = "кол-во";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(389, 267);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 13;
            label5.Text = "цена за штуку";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 661);
            Controls.Add(load_page);
            Name = "Form1";
            Text = "Form1";
            load_page.ResumeLayout(false);
            load_page.PerformLayout();
            groupBox_add_dish.ResumeLayout(false);
            groupBox_add_dish.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)newDish_cost).EndInit();
            penal_dish_ProdList.ResumeLayout(false);
            penal_dish_ProdList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)prod_load_amount).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel load_page;
        private Button btn_prod_load;
        private NumericUpDown prod_load_amount;
        private ComboBox prod_load_name;
        private ListBox list_dishes;
        private ListBox list_products;
        private Label label_list_prod;
        private Button btn_load_new_dishes;
        private Label label2;
        private GroupBox groupBox_add_dish;
        private Label label3;
        private TextBox NewDish_name;
        private Panel penal_dish_ProdList;
        private TableLayoutPanel table_dish_ProdList;
        private ComboBox chProd_for_dish;
        private Button btn_addProd_to_new_dish;
        private NumericUpDown newDish_cost;
        private Label label1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label5;
        private Label label4;
    }
}
