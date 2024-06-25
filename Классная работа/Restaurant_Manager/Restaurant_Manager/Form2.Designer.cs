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
            table_order_list_dish = new TableLayoutPanel();
            btn_order_new_dish = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Total_cost = new Label();
            ch_dish = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(249, 117);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Кол-во";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(table_order_list_dish);
            panel1.Location = new Point(12, 135);
            panel1.Name = "panel1";
            panel1.Size = new Size(324, 522);
            panel1.TabIndex = 1;
            // 
            // table_order_list_dish
            // 
            table_order_list_dish.AutoSize = true;
            table_order_list_dish.ColumnCount = 3;
            table_order_list_dish.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            table_order_list_dish.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            table_order_list_dish.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            table_order_list_dish.Dock = DockStyle.Top;
            table_order_list_dish.Location = new Point(0, 0);
            table_order_list_dish.Name = "table_order_list_dish";
            table_order_list_dish.RowCount = 2;
            table_order_list_dish.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            table_order_list_dish.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            table_order_list_dish.Size = new Size(324, 0);
            table_order_list_dish.TabIndex = 0;
            // 
            // btn_order_new_dish
            // 
            btn_order_new_dish.Location = new Point(223, 90);
            btn_order_new_dish.Name = "btn_order_new_dish";
            btn_order_new_dish.Size = new Size(113, 23);
            btn_order_new_dish.TabIndex = 2;
            btn_order_new_dish.Text = "Добавить блюдо";
            btn_order_new_dish.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 116);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 3;
            label2.Text = "Название блюда";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(301, 117);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 4;
            label3.Text = "Цена";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(83, 667);
            label4.Name = "label4";
            label4.Size = new Size(75, 30);
            label4.TabIndex = 5;
            label4.Text = "Итого:";
            // 
            // Total_cost
            // 
            Total_cost.AutoSize = true;
            Total_cost.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Total_cost.Location = new Point(164, 667);
            Total_cost.Name = "Total_cost";
            Total_cost.Size = new Size(24, 30);
            Total_cost.TabIndex = 6;
            Total_cost.Text = "0";
            // 
            // ch_dish
            // 
            ch_dish.DropDownStyle = ComboBoxStyle.DropDownList;
            ch_dish.FormattingEnabled = true;
            ch_dish.Location = new Point(12, 90);
            ch_dish.Name = "ch_dish";
            ch_dish.Size = new Size(205, 23);
            ch_dish.TabIndex = 7;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 830);
            Controls.Add(ch_dish);
            Controls.Add(Total_cost);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btn_order_new_dish);
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
        private TableLayoutPanel table_order_list_dish;
        private Button btn_order_new_dish;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label Total_cost;
        private ComboBox ch_dish;
    }
}