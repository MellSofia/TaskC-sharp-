namespace Restaurant_Manager
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            panel1 = new Panel();
            table_order_listDish = new TableLayoutPanel();
            btn_order_newDish = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            total_cost = new Label();
            choose_dish = new ComboBox();
            btn_total_calc = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(233, 48);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Кол-во";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(table_order_listDish);
            panel1.Location = new Point(12, 66);
            panel1.Name = "panel1";
            panel1.Size = new Size(324, 535);
            panel1.TabIndex = 1;
            // 
            // table_order_listDish
            // 
            table_order_listDish.AutoSize = true;
            table_order_listDish.ColumnCount = 3;
            table_order_listDish.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            table_order_listDish.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            table_order_listDish.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            table_order_listDish.Dock = DockStyle.Top;
            table_order_listDish.Location = new Point(0, 0);
            table_order_listDish.Name = "table_order_listDish";
            table_order_listDish.RowCount = 2;
            table_order_listDish.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            table_order_listDish.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            table_order_listDish.Size = new Size(324, 0);
            table_order_listDish.TabIndex = 0;
            table_order_listDish.Click += table_order_listDish_Click;
            // 
            // btn_order_newDish
            // 
            btn_order_newDish.Font = new Font("Segoe UI", 14.25F);
            btn_order_newDish.Location = new Point(223, 12);
            btn_order_newDish.Name = "btn_order_newDish";
            btn_order_newDish.Size = new Size(113, 33);
            btn_order_newDish.TabIndex = 2;
            btn_order_newDish.Text = "Добавить блюдо";
            btn_order_newDish.UseVisualStyleBackColor = true;
            btn_order_newDish.Click += btn_order_newDish_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 48);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 3;
            label2.Text = "Название блюда";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(301, 48);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 4;
            label3.Text = "Цена";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F);
            label4.Location = new Point(133, 612);
            label4.Name = "label4";
            label4.Size = new Size(84, 32);
            label4.TabIndex = 5;
            label4.Text = "Итого:";
            // 
            // total_cost
            // 
            total_cost.AutoSize = true;
            total_cost.Font = new Font("Segoe UI", 18F);
            total_cost.Location = new Point(223, 612);
            total_cost.Name = "total_cost";
            total_cost.Size = new Size(27, 32);
            total_cost.TabIndex = 6;
            total_cost.Text = "0";
            // 
            // choose_dish
            // 
            choose_dish.DropDownStyle = ComboBoxStyle.DropDownList;
            choose_dish.Font = new Font("Segoe UI", 14.25F);
            choose_dish.FormattingEnabled = true;
            choose_dish.Location = new Point(12, 12);
            choose_dish.Name = "choose_dish";
            choose_dish.Size = new Size(205, 33);
            choose_dish.TabIndex = 7;
            // 
            // btn_total_calc
            // 
            btn_total_calc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btn_total_calc.Location = new Point(12, 612);
            btn_total_calc.Name = "btn_total_calc";
            btn_total_calc.Size = new Size(99, 32);
            btn_total_calc.TabIndex = 8;
            btn_total_calc.Text = "Посчитать";
            btn_total_calc.UseVisualStyleBackColor = true;
            btn_total_calc.Click += btn_total_calc_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 661);
            Controls.Add(btn_total_calc);
            Controls.Add(choose_dish);
            Controls.Add(total_cost);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btn_order_newDish);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form2";
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private TableLayoutPanel table_order_listDish;
        private Button btn_order_newDish;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label total_cost;
        private ComboBox choose_dish;
        private Button btn_total_calc;
    }
}