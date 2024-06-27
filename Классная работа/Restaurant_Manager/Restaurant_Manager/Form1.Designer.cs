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
            btn_start_order = new Button();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            table_listDishes = new TableLayoutPanel();
            groupBox_add_dish = new GroupBox();
            btn_dish_del = new Button();
            label6 = new Label();
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
            list_products = new ListBox();
            load_page.SuspendLayout();
            panel1.SuspendLayout();
            groupBox_add_dish.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)newDish_cost).BeginInit();
            penal_dish_ProdList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)prod_load_amount).BeginInit();
            SuspendLayout();
            // 
            // load_page
            // 
            load_page.Controls.Add(btn_start_order);
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
            load_page.Controls.Add(list_products);
            load_page.Dock = DockStyle.Fill;
            load_page.Location = new Point(0, 0);
            load_page.Name = "load_page";
            load_page.Size = new Size(784, 661);
            load_page.TabIndex = 0;
            // 
            // btn_start_order
            // 
            btn_start_order.BackColor = SystemColors.ButtonHighlight;
            btn_start_order.FlatStyle = FlatStyle.System;
            btn_start_order.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btn_start_order.ForeColor = SystemColors.ButtonFace;
            btn_start_order.Location = new Point(629, 3);
            btn_start_order.Name = "btn_start_order";
            btn_start_order.Size = new Size(152, 52);
            btn_start_order.TabIndex = 14;
            btn_start_order.Text = "Добавить заказ";
            btn_start_order.UseVisualStyleBackColor = false;
            btn_start_order.Click += btn_start_order_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(416, 64);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 13;
            label5.Text = "цена за штуку";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(259, 64);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 12;
            label4.Text = "кол-во";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(314, 64);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 11;
            label1.Text = "название блюда";
            // 
            // panel1
            // 
            panel1.Controls.Add(table_listDishes);
            panel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            panel1.Location = new Point(259, 87);
            panel1.Name = "panel1";
            panel1.Size = new Size(241, 571);
            panel1.TabIndex = 10;
            // 
            // table_listDishes
            // 
            table_listDishes.AutoSize = true;
            table_listDishes.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            table_listDishes.ColumnCount = 3;
            table_listDishes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            table_listDishes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            table_listDishes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            table_listDishes.Dock = DockStyle.Top;
            table_listDishes.Location = new Point(0, 0);
            table_listDishes.Name = "table_listDishes";
            table_listDishes.RowCount = 2;
            table_listDishes.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            table_listDishes.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            table_listDishes.Size = new Size(241, 3);
            table_listDishes.TabIndex = 0;
            // 
            // groupBox_add_dish
            // 
            groupBox_add_dish.Controls.Add(btn_dish_del);
            groupBox_add_dish.Controls.Add(label6);
            groupBox_add_dish.Controls.Add(newDish_cost);
            groupBox_add_dish.Controls.Add(btn_addProd_to_new_dish);
            groupBox_add_dish.Controls.Add(penal_dish_ProdList);
            groupBox_add_dish.Controls.Add(chProd_for_dish);
            groupBox_add_dish.Controls.Add(btn_load_new_dishes);
            groupBox_add_dish.Controls.Add(NewDish_name);
            groupBox_add_dish.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBox_add_dish.Location = new Point(506, 101);
            groupBox_add_dish.Name = "groupBox_add_dish";
            groupBox_add_dish.Size = new Size(266, 557);
            groupBox_add_dish.TabIndex = 9;
            groupBox_add_dish.TabStop = false;
            groupBox_add_dish.Text = "Добавление блюда";
            // 
            // btn_dish_del
            // 
            btn_dish_del.FlatStyle = FlatStyle.System;
            btn_dish_del.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btn_dish_del.Location = new Point(182, 522);
            btn_dish_del.Name = "btn_dish_del";
            btn_dish_del.Size = new Size(78, 29);
            btn_dish_del.TabIndex = 9;
            btn_dish_del.Text = "Удалить";
            btn_dish_del.UseVisualStyleBackColor = true;
            btn_dish_del.Visible = false;
            btn_dish_del.Click += btn_dish_del_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(230, 27);
            label6.Name = "label6";
            label6.Size = new Size(30, 17);
            label6.TabIndex = 8;
            label6.Text = "руб";
            // 
            // newDish_cost
            // 
            newDish_cost.Location = new Point(173, 22);
            newDish_cost.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            newDish_cost.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            newDish_cost.Name = "newDish_cost";
            newDish_cost.Size = new Size(57, 29);
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
            penal_dish_ProdList.Size = new Size(254, 424);
            penal_dish_ProdList.TabIndex = 4;
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
            table_dish_ProdList.RowCount = 1;
            table_dish_ProdList.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            table_dish_ProdList.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            table_dish_ProdList.Size = new Size(254, 2);
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
            btn_load_new_dishes.FlatStyle = FlatStyle.System;
            btn_load_new_dishes.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btn_load_new_dishes.Location = new Point(6, 522);
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
            NewDish_name.Enter += NewDish_name_Enter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Emoji", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(530, 64);
            label3.Name = "label3";
            label3.Size = new Size(218, 28);
            label3.TabIndex = 8;
            label3.Text = "Добавить блюдо";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(295, 18);
            label2.Name = "label2";
            label2.Size = new Size(171, 28);
            label2.TabIndex = 7;
            label2.Text = "Список блюд";
            // 
            // label_list_prod
            // 
            label_list_prod.AutoSize = true;
            label_list_prod.Font = new Font("Segoe UI Emoji", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_list_prod.Location = new Point(12, 18);
            label_list_prod.Name = "label_list_prod";
            label_list_prod.Size = new Size(233, 28);
            label_list_prod.TabIndex = 5;
            label_list_prod.Text = "Список продуктов";
            // 
            // btn_prod_load
            // 
            btn_prod_load.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btn_prod_load.Location = new Point(161, 49);
            btn_prod_load.Name = "btn_prod_load";
            btn_prod_load.Size = new Size(92, 32);
            btn_prod_load.TabIndex = 4;
            btn_prod_load.Text = "Загрузить";
            btn_prod_load.UseVisualStyleBackColor = true;
            btn_prod_load.Click += btn_prod_load_Click;
            // 
            // prod_load_amount
            // 
            prod_load_amount.Location = new Point(122, 57);
            prod_load_amount.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            prod_load_amount.Name = "prod_load_amount";
            prod_load_amount.Size = new Size(33, 23);
            prod_load_amount.TabIndex = 3;
            // 
            // prod_load_name
            // 
            prod_load_name.FormattingEnabled = true;
            prod_load_name.Location = new Point(12, 56);
            prod_load_name.Name = "prod_load_name";
            prod_load_name.Size = new Size(104, 23);
            prod_load_name.TabIndex = 2;
            // 
            // list_products
            // 
            list_products.BackColor = SystemColors.ControlLightLight;
            list_products.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            list_products.FormattingEnabled = true;
            list_products.ItemHeight = 21;
            list_products.Location = new Point(12, 87);
            list_products.Name = "list_products";
            list_products.Size = new Size(241, 571);
            list_products.TabIndex = 0;
            list_products.SelectedIndexChanged += list_products_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(784, 661);
            Controls.Add(load_page);
            Name = "Form1";
            Text = "Form1";
            load_page.ResumeLayout(false);
            load_page.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox_add_dish.ResumeLayout(false);
            groupBox_add_dish.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)newDish_cost).EndInit();
            penal_dish_ProdList.ResumeLayout(false);
            penal_dish_ProdList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)prod_load_amount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel load_page;
        private Button btn_prod_load;
        private NumericUpDown prod_load_amount;
        private ComboBox prod_load_name;
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
        private TableLayoutPanel table_listDishes;
        private Label label5;
        private Label label4;
        private Label label6;
        private Button btn_dish_del;
        private Button btn_start_order;
    }
}
