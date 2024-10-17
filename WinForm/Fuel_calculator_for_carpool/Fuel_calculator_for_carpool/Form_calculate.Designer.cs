namespace Fuel_calculator_for_carpool
{
    partial class Form_calculate
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
            button_back = new Button();
            numericUpDown_Passenger_cars = new NumericUpDown();
            numericUpDown_Bus = new NumericUpDown();
            numericUpDown_Truck = new NumericUpDown();
            label_Passenger_Cars = new Label();
            label_Truck = new Label();
            label_Bus = new Label();
            button_culculate = new Button();
            label_Passanger_Cars_km = new Label();
            label_Truck_km = new Label();
            label_Bus_km = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Passenger_cars).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Bus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Truck).BeginInit();
            SuspendLayout();
            // 
            // button_back
            // 
            button_back.Location = new Point(12, 12);
            button_back.Name = "button_back";
            button_back.Size = new Size(99, 28);
            button_back.TabIndex = 15;
            button_back.Text = "Назад";
            button_back.UseVisualStyleBackColor = true;
            button_back.Click += button_back_Click;
            // 
            // numericUpDown_Passenger_cars
            // 
            numericUpDown_Passenger_cars.Location = new Point(240, 111);
            numericUpDown_Passenger_cars.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown_Passenger_cars.Name = "numericUpDown_Passenger_cars";
            numericUpDown_Passenger_cars.Size = new Size(73, 23);
            numericUpDown_Passenger_cars.TabIndex = 19;
            // 
            // numericUpDown_Bus
            // 
            numericUpDown_Bus.Location = new Point(240, 170);
            numericUpDown_Bus.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown_Bus.Name = "numericUpDown_Bus";
            numericUpDown_Bus.Size = new Size(73, 23);
            numericUpDown_Bus.TabIndex = 20;
            // 
            // numericUpDown_Truck
            // 
            numericUpDown_Truck.Location = new Point(240, 141);
            numericUpDown_Truck.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown_Truck.Name = "numericUpDown_Truck";
            numericUpDown_Truck.Size = new Size(73, 23);
            numericUpDown_Truck.TabIndex = 21;
            // 
            // label_Passenger_Cars
            // 
            label_Passenger_Cars.AutoSize = true;
            label_Passenger_Cars.Location = new Point(158, 115);
            label_Passenger_Cars.Name = "label_Passenger_Cars";
            label_Passenger_Cars.Size = new Size(60, 15);
            label_Passenger_Cars.TabIndex = 22;
            label_Passenger_Cars.Text = "Легковые";
            // 
            // label_Truck
            // 
            label_Truck.AutoSize = true;
            label_Truck.Location = new Point(159, 145);
            label_Truck.Name = "label_Truck";
            label_Truck.Size = new Size(59, 15);
            label_Truck.TabIndex = 23;
            label_Truck.Text = "Грузовые";
            // 
            // label_Bus
            // 
            label_Bus.AutoSize = true;
            label_Bus.Location = new Point(159, 174);
            label_Bus.Name = "label_Bus";
            label_Bus.Size = new Size(61, 15);
            label_Bus.TabIndex = 24;
            label_Bus.Text = "Автобусы";
            // 
            // button_culculate
            // 
            button_culculate.Location = new Point(468, 144);
            button_culculate.Name = "button_culculate";
            button_culculate.Size = new Size(118, 26);
            button_culculate.TabIndex = 25;
            button_culculate.Text = "Расчитать";
            button_culculate.UseVisualStyleBackColor = true;
            button_culculate.Click += button_culculate_Click;
            // 
            // label_Passanger_Cars_km
            // 
            label_Passanger_Cars_km.AutoSize = true;
            label_Passanger_Cars_km.Location = new Point(319, 115);
            label_Passanger_Cars_km.Name = "label_Passanger_Cars_km";
            label_Passanger_Cars_km.Size = new Size(22, 15);
            label_Passanger_Cars_km.TabIndex = 26;
            label_Passanger_Cars_km.Text = "км";
            // 
            // label_Truck_km
            // 
            label_Truck_km.AutoSize = true;
            label_Truck_km.Location = new Point(320, 144);
            label_Truck_km.Name = "label_Truck_km";
            label_Truck_km.Size = new Size(22, 15);
            label_Truck_km.TabIndex = 27;
            label_Truck_km.Text = "км";
            // 
            // label_Bus_km
            // 
            label_Bus_km.AutoSize = true;
            label_Bus_km.Location = new Point(320, 173);
            label_Bus_km.Name = "label_Bus_km";
            label_Bus_km.Size = new Size(22, 15);
            label_Bus_km.TabIndex = 28;
            label_Bus_km.Text = "км";
            // 
            // Form_calculate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label_Bus_km);
            Controls.Add(label_Truck_km);
            Controls.Add(label_Passanger_Cars_km);
            Controls.Add(button_culculate);
            Controls.Add(label_Bus);
            Controls.Add(label_Truck);
            Controls.Add(label_Passenger_Cars);
            Controls.Add(numericUpDown_Truck);
            Controls.Add(numericUpDown_Bus);
            Controls.Add(numericUpDown_Passenger_cars);
            Controls.Add(button_back);
            Name = "Form_calculate";
            Text = "Form_calculate";
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Passenger_cars).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Bus).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Truck).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_back;
        private NumericUpDown numericUpDown_Passenger_cars;
        private NumericUpDown numericUpDown_Bus;
        private NumericUpDown numericUpDown_Truck;
        private Label label_Passenger_Cars;
        private Label label_Truck;
        private Label label_Bus;
        private Button button_culculate;
        private Label label_Passanger_Cars_km;
        private Label label_Truck_km;
        private Label label_Bus_km;
    }
}