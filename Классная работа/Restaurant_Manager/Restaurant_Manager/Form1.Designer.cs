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
            panel_main = new Panel();
            label_list_prod = new Label();
            btn_prod_load = new Button();
            prod_load_amount = new NumericUpDown();
            prod_load_name = new ComboBox();
            list_dishes = new ListBox();
            list_products = new ListBox();
            panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)prod_load_amount).BeginInit();
            SuspendLayout();
            // 
            // panel_main
            // 
            panel_main.Controls.Add(label_list_prod);
            panel_main.Controls.Add(btn_prod_load);
            panel_main.Controls.Add(prod_load_amount);
            panel_main.Controls.Add(prod_load_name);
            panel_main.Controls.Add(list_dishes);
            panel_main.Controls.Add(list_products);
            panel_main.Dock = DockStyle.Fill;
            panel_main.Location = new Point(0, 0);
            panel_main.Name = "panel_main";
            panel_main.Size = new Size(784, 661);
            panel_main.TabIndex = 0;
            // 
            // label_list_prod
            // 
            label_list_prod.AutoSize = true;
            label_list_prod.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label_list_prod.Location = new Point(12, 238);
            label_list_prod.Name = "label_list_prod";
            label_list_prod.Size = new Size(122, 15);
            label_list_prod.TabIndex = 5;
            label_list_prod.Text = "Список продуктов";
            // 
            // btn_prod_load
            // 
            btn_prod_load.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btn_prod_load.Location = new Point(178, 256);
            btn_prod_load.Name = "btn_prod_load";
            btn_prod_load.Size = new Size(75, 23);
            btn_prod_load.TabIndex = 4;
            btn_prod_load.Text = "Загрузить";
            btn_prod_load.UseVisualStyleBackColor = true;
            btn_prod_load.Click += btn_prod_load_Click;
            // 
            // prod_load_amount
            // 
            prod_load_amount.Location = new Point(139, 256);
            prod_load_amount.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            prod_load_amount.Name = "prod_load_amount";
            prod_load_amount.Size = new Size(33, 23);
            prod_load_amount.TabIndex = 3;
            // 
            // prod_load_name
            // 
            prod_load_name.FormattingEnabled = true;
            prod_load_name.Location = new Point(12, 256);
            prod_load_name.Name = "prod_load_name";
            prod_load_name.Size = new Size(121, 23);
            prod_load_name.TabIndex = 2;
            // 
            // list_dishes
            // 
            list_dishes.FormattingEnabled = true;
            list_dishes.ItemHeight = 15;
            list_dishes.Location = new Point(269, 285);
            list_dishes.Name = "list_dishes";
            list_dishes.Size = new Size(180, 364);
            list_dishes.TabIndex = 1;
            // 
            // list_products
            // 
            list_products.FormattingEnabled = true;
            list_products.ItemHeight = 15;
            list_products.Location = new Point(12, 285);
            list_products.Name = "list_products";
            list_products.Size = new Size(241, 364);
            list_products.TabIndex = 0;
            list_products.SelectedIndexChanged += list_products_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 661);
            Controls.Add(panel_main);
            Name = "Form1";
            Text = "Form1";
            panel_main.ResumeLayout(false);
            panel_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)prod_load_amount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_main;
        private Button btn_prod_load;
        private NumericUpDown prod_load_amount;
        private ComboBox prod_load_name;
        private ListBox list_dishes;
        private ListBox list_products;
        private Label label_list_prod;
    }
}
