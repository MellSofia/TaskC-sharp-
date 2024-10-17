namespace Fuel_calculator_for_carpool
{
    partial class Form_add
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
            textBox_name = new TextBox();
            label_name = new Label();
            comboBox_purpose = new ComboBox();
            label_purpose = new Label();
            labelFuel = new Label();
            comboBox_fuel_type = new ComboBox();
            comboBox_fuel_subtype = new ComboBox();
            label_fuel_subtype = new Label();
            label_fuel_consumption = new Label();
            textBox_fuel_consumption = new TextBox();
            label_fuel_info = new Label();
            label_AverageSpeed = new Label();
            textBox_AverageSpeed = new TextBox();
            label_km_in_hour = new Label();
            button_add_Vehicle = new Button();
            listBox_carpool_depots = new ListBox();
            button_calculate = new Button();
            SuspendLayout();
            // 
            // textBox_name
            // 
            textBox_name.Location = new Point(303, 103);
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(100, 23);
            textBox_name.TabIndex = 0;
            // 
            // label_name
            // 
            label_name.AutoSize = true;
            label_name.Location = new Point(224, 103);
            label_name.Name = "label_name";
            label_name.Size = new Size(31, 15);
            label_name.TabIndex = 1;
            label_name.Text = "Имя";
            // 
            // comboBox_purpose
            // 
            comboBox_purpose.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_purpose.FormattingEnabled = true;
            comboBox_purpose.Items.AddRange(new object[] { "Легковое", "Грузовое", "Автобус" });
            comboBox_purpose.Location = new Point(303, 138);
            comboBox_purpose.Name = "comboBox_purpose";
            comboBox_purpose.Size = new Size(121, 23);
            comboBox_purpose.TabIndex = 2;
            // 
            // label_purpose
            // 
            label_purpose.AutoSize = true;
            label_purpose.Location = new Point(224, 138);
            label_purpose.Name = "label_purpose";
            label_purpose.Size = new Size(73, 15);
            label_purpose.TabIndex = 3;
            label_purpose.Text = "Назначение";
            // 
            // labelFuel
            // 
            labelFuel.AutoSize = true;
            labelFuel.Location = new Point(226, 181);
            labelFuel.Name = "labelFuel";
            labelFuel.Size = new Size(54, 15);
            labelFuel.TabIndex = 4;
            labelFuel.Text = "Топливо";
            // 
            // comboBox_fuel_type
            // 
            comboBox_fuel_type.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_fuel_type.FormattingEnabled = true;
            comboBox_fuel_type.Items.AddRange(new object[] { "Газ", "Дизель", "Бензин" });
            comboBox_fuel_type.Location = new Point(303, 178);
            comboBox_fuel_type.Name = "comboBox_fuel_type";
            comboBox_fuel_type.Size = new Size(121, 23);
            comboBox_fuel_type.TabIndex = 5;
            comboBox_fuel_type.SelectedIndexChanged += comboBox_fuel_type_SelectedIndexChanged;
            // 
            // comboBox_fuel_subtype
            // 
            comboBox_fuel_subtype.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_fuel_subtype.Enabled = false;
            comboBox_fuel_subtype.FormattingEnabled = true;
            comboBox_fuel_subtype.Location = new Point(336, 213);
            comboBox_fuel_subtype.Name = "comboBox_fuel_subtype";
            comboBox_fuel_subtype.Size = new Size(121, 23);
            comboBox_fuel_subtype.TabIndex = 7;
            // 
            // label_fuel_subtype
            // 
            label_fuel_subtype.AutoSize = true;
            label_fuel_subtype.Location = new Point(226, 216);
            label_fuel_subtype.Name = "label_fuel_subtype";
            label_fuel_subtype.Size = new Size(104, 15);
            label_fuel_subtype.TabIndex = 6;
            label_fuel_subtype.Text = "Топливо подтивы";
            // 
            // label_fuel_consumption
            // 
            label_fuel_consumption.AutoSize = true;
            label_fuel_consumption.Location = new Point(226, 248);
            label_fuel_consumption.Name = "label_fuel_consumption";
            label_fuel_consumption.Size = new Size(93, 15);
            label_fuel_consumption.TabIndex = 8;
            label_fuel_consumption.Text = "Расход топлива";
            // 
            // textBox_fuel_consumption
            // 
            textBox_fuel_consumption.Location = new Point(325, 245);
            textBox_fuel_consumption.Name = "textBox_fuel_consumption";
            textBox_fuel_consumption.Size = new Size(46, 23);
            textBox_fuel_consumption.TabIndex = 9;
            textBox_fuel_consumption.KeyPress += NumericTextBox_KeyPress;
            // 
            // label_fuel_info
            // 
            label_fuel_info.AutoSize = true;
            label_fuel_info.Location = new Point(377, 248);
            label_fuel_info.Name = "label_fuel_info";
            label_fuel_info.Size = new Size(114, 15);
            label_fuel_info.TabIndex = 10;
            label_fuel_info.Text = "ед. топлива/100 км;";
            // 
            // label_AverageSpeed
            // 
            label_AverageSpeed.AutoSize = true;
            label_AverageSpeed.Location = new Point(226, 280);
            label_AverageSpeed.Name = "label_AverageSpeed";
            label_AverageSpeed.Size = new Size(106, 15);
            label_AverageSpeed.TabIndex = 11;
            label_AverageSpeed.Text = "Средняя скорость";
            // 
            // textBox_AverageSpeed
            // 
            textBox_AverageSpeed.Location = new Point(333, 277);
            textBox_AverageSpeed.Name = "textBox_AverageSpeed";
            textBox_AverageSpeed.Size = new Size(100, 23);
            textBox_AverageSpeed.TabIndex = 12;
            textBox_AverageSpeed.KeyPress += NumericTextBox_KeyPress;
            // 
            // label_km_in_hour
            // 
            label_km_in_hour.AutoSize = true;
            label_km_in_hour.Location = new Point(442, 282);
            label_km_in_hour.Name = "label_km_in_hour";
            label_km_in_hour.Size = new Size(37, 15);
            label_km_in_hour.TabIndex = 13;
            label_km_in_hour.Text = "км/ч.";
            // 
            // button_add_Vehicle
            // 
            button_add_Vehicle.Location = new Point(491, 103);
            button_add_Vehicle.Name = "button_add_Vehicle";
            button_add_Vehicle.Size = new Size(99, 28);
            button_add_Vehicle.TabIndex = 14;
            button_add_Vehicle.Text = "Добавлить";
            button_add_Vehicle.UseVisualStyleBackColor = true;
            button_add_Vehicle.Click += button_add_Vehicle_Click;
            // 
            // listBox_carpool_depots
            // 
            listBox_carpool_depots.FormattingEnabled = true;
            listBox_carpool_depots.ItemHeight = 15;
            listBox_carpool_depots.Location = new Point(596, 102);
            listBox_carpool_depots.Name = "listBox_carpool_depots";
            listBox_carpool_depots.ScrollAlwaysVisible = true;
            listBox_carpool_depots.Size = new Size(164, 169);
            listBox_carpool_depots.TabIndex = 15;
            listBox_carpool_depots.SelectedIndexChanged += listBox_carpool_depots_SelectedIndexChanged;
            // 
            // button_calculate
            // 
            button_calculate.Location = new Point(596, 278);
            button_calculate.Name = "button_calculate";
            button_calculate.Size = new Size(164, 23);
            button_calculate.TabIndex = 16;
            button_calculate.Text = "Рассчитать";
            button_calculate.UseVisualStyleBackColor = true;
            button_calculate.Click += button_calculate_Click;
            // 
            // Form_add
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_calculate);
            Controls.Add(listBox_carpool_depots);
            Controls.Add(button_add_Vehicle);
            Controls.Add(label_km_in_hour);
            Controls.Add(textBox_AverageSpeed);
            Controls.Add(label_AverageSpeed);
            Controls.Add(label_fuel_info);
            Controls.Add(textBox_fuel_consumption);
            Controls.Add(label_fuel_consumption);
            Controls.Add(comboBox_fuel_subtype);
            Controls.Add(label_fuel_subtype);
            Controls.Add(comboBox_fuel_type);
            Controls.Add(labelFuel);
            Controls.Add(label_purpose);
            Controls.Add(comboBox_purpose);
            Controls.Add(label_name);
            Controls.Add(textBox_name);
            Name = "Form_add";
            Text = "Form_add";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_name;
        private Label label_name;
        private ComboBox comboBox_purpose;
        private Label label_;
        private Label label_purpose;
        private Label labelFuel;
        private ComboBox comboBox_fuel_type;
        private ComboBox comboBox_fuel_subtype;
        private Label label_fuel_subtype;
        private Label label_fuel_consumption;
        private TextBox textBox_fuel_consumption;
        private Label label_fuel_info;
        private Label label_AverageSpeed;
        private TextBox textBox_AverageSpeed;
        private Label label_km_in_hour;
        private Button button_add_Vehicle;
        private ListBox listBox_carpool_depots;
        private Button button_calculate;
    }
}
