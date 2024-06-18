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
            dish_name = new TextBox();
            dish_name_list = new Label();
            label1 = new Label();
            dish_content = new TextBox();
            btn_save = new Button();
            SuspendLayout();
            // 
            // dish_name
            // 
            dish_name.Location = new Point(116, 15);
            dish_name.Name = "dish_name";
            dish_name.Size = new Size(270, 23);
            dish_name.TabIndex = 0;
            // 
            // dish_name_list
            // 
            dish_name_list.AutoSize = true;
            dish_name_list.Location = new Point(12, 18);
            dish_name_list.Name = "dish_name_list";
            dish_name_list.Size = new Size(98, 15);
            dish_name_list.TabIndex = 1;
            dish_name_list.Text = "Название блюда";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 55);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 2;
            label1.Text = "Содержимое";
            label1.Click += label1_Click;
            // 
            // dish_content
            // 
            dish_content.Location = new Point(12, 83);
            dish_content.Multiline = true;
            dish_content.Name = "dish_content";
            dish_content.Size = new Size(353, 355);
            dish_content.TabIndex = 3;
            // 
            // btn_save
            // 
            btn_save.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btn_save.Location = new Point(618, 587);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(154, 62);
            btn_save.TabIndex = 4;
            btn_save.Text = "Загрузить";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 661);
            Controls.Add(btn_save);
            Controls.Add(dish_content);
            Controls.Add(label1);
            Controls.Add(dish_name_list);
            Controls.Add(dish_name);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox dish_name;
        private Label dish_name_list;
        private Label label1;
        private TextBox dish_content;
        private Button btn_save;
    }
}