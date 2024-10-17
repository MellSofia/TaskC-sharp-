namespace Exam
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
            comboBox_operat_1 = new ComboBox();
            comboBox_operat_2 = new ComboBox();
            label_developer = new Label();
            textBox_part_1 = new TextBox();
            textBox_part_2 = new TextBox();
            label_result = new Label();
            button_culc = new Button();
            textBox_part_3 = new TextBox();
            button_instr = new Button();
            SuspendLayout();
            // 
            // comboBox_operat_1
            // 
            comboBox_operat_1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_operat_1.Font = new Font("Segoe UI", 15F);
            comboBox_operat_1.FormattingEnabled = true;
            comboBox_operat_1.Items.AddRange(new object[] { "+", "-", "*", "/" });
            comboBox_operat_1.Location = new Point(190, 84);
            comboBox_operat_1.Name = "comboBox_operat_1";
            comboBox_operat_1.Size = new Size(35, 36);
            comboBox_operat_1.TabIndex = 0;
            // 
            // comboBox_operat_2
            // 
            comboBox_operat_2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_operat_2.Font = new Font("Segoe UI", 15F);
            comboBox_operat_2.FormattingEnabled = true;
            comboBox_operat_2.Items.AddRange(new object[] { "+", "-", "*", "/" });
            comboBox_operat_2.Location = new Point(387, 86);
            comboBox_operat_2.Name = "comboBox_operat_2";
            comboBox_operat_2.Size = new Size(35, 36);
            comboBox_operat_2.TabIndex = 1;
            // 
            // label_developer
            // 
            label_developer.AutoSize = true;
            label_developer.Font = new Font("Segoe UI", 18F);
            label_developer.Location = new Point(12, 9);
            label_developer.Name = "label_developer";
            label_developer.Size = new Size(244, 32);
            label_developer.TabIndex = 2;
            label_developer.Text = "Разработчик:  София";
            // 
            // textBox_part_1
            // 
            textBox_part_1.Font = new Font("Segoe UI", 15F);
            textBox_part_1.Location = new Point(34, 86);
            textBox_part_1.Name = "textBox_part_1";
            textBox_part_1.Size = new Size(150, 34);
            textBox_part_1.TabIndex = 3;
            textBox_part_1.TextChanged += textBox_part_1_TextChanged;
            // 
            // textBox_part_2
            // 
            textBox_part_2.BackColor = Color.White;
            textBox_part_2.Font = new Font("Segoe UI", 15F);
            textBox_part_2.Location = new Point(231, 86);
            textBox_part_2.Name = "textBox_part_2";
            textBox_part_2.Size = new Size(150, 34);
            textBox_part_2.TabIndex = 4;
            textBox_part_2.TextChanged += textBox_part_2_TextChanged;
            // 
            // label_result
            // 
            label_result.AutoSize = true;
            label_result.Font = new Font("Segoe UI", 15F);
            label_result.Location = new Point(584, 87);
            label_result.Name = "label_result";
            label_result.Size = new Size(26, 28);
            label_result.TabIndex = 5;
            label_result.Text = "=";
            // 
            // button_culc
            // 
            button_culc.Font = new Font("Segoe UI", 12F);
            button_culc.Location = new Point(34, 153);
            button_culc.Name = "button_culc";
            button_culc.Size = new Size(135, 50);
            button_culc.TabIndex = 6;
            button_culc.Text = "Вычислить";
            button_culc.UseVisualStyleBackColor = true;
            button_culc.Click += button_culc_Click;
            // 
            // textBox_part_3
            // 
            textBox_part_3.Font = new Font("Segoe UI", 15F);
            textBox_part_3.Location = new Point(428, 86);
            textBox_part_3.Name = "textBox_part_3";
            textBox_part_3.Size = new Size(150, 34);
            textBox_part_3.TabIndex = 7;
            textBox_part_3.TextChanged += textBox_part_3_TextChanged;
            // 
            // button_instr
            // 
            button_instr.Location = new Point(262, 5);
            button_instr.Name = "button_instr";
            button_instr.Size = new Size(135, 50);
            button_instr.TabIndex = 8;
            button_instr.Text = "Инструкция";
            button_instr.UseVisualStyleBackColor = true;
            button_instr.Click += button_instr_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_instr);
            Controls.Add(textBox_part_3);
            Controls.Add(button_culc);
            Controls.Add(label_result);
            Controls.Add(textBox_part_2);
            Controls.Add(textBox_part_1);
            Controls.Add(label_developer);
            Controls.Add(comboBox_operat_2);
            Controls.Add(comboBox_operat_1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox_operat_1;
        private ComboBox comboBox_operat_2;
        private Label label_developer;
        private TextBox textBox_part_1;
        private TextBox textBox_part_2;
        private Label label_result;
        private Button button_culc;
        private TextBox textBox_part_3;
        private Button button_instr;
    }
}
