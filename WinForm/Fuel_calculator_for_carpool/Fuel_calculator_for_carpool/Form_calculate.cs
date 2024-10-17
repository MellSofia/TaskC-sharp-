using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuel_calculator_for_carpool
{
    public partial class Form_calculate : Form
    {
        private Form_add form_add_;
        public Form_calculate(Form_add _form_add_)
        {
            InitializeComponent();
            form_add_ = _form_add_;
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_culculate_Click(object sender, EventArgs e)
        {
            if (this.Owner is Form_add formAdd)
            {
                if (formAdd.carpool_depots == null || !formAdd.carpool_depots.Any())
                {
                    MessageBox.Show("Нет доступных транспортных средств для отображения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                double mileagePassenger = (double)numericUpDown_Passenger_cars.Value;
                double mileageTruck = (double)numericUpDown_Truck.Value;
                double mileageBus = (double)numericUpDown_Bus.Value;

                if (mileagePassenger <= 0 && mileageTruck <= 0 && mileageBus <= 0)
                {
                    MessageBox.Show("Введите пробег для хотя бы одного типа транспортного средства.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                CalculateFuelConsumption(formAdd.carpool_depots, mileagePassenger, mileageTruck, mileageBus);
            }
            else
            {
                MessageBox.Show("Ошибка: форма не является владельцем.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalculateFuelConsumption(List<Vehicle> vehicles, double mileagePassenger, double mileageTruck, double mileageBus)
        {
            Dictionary<string, double> resoursec = new Dictionary<string, double>();

            foreach (var vehicle in vehicles)
            {
                string fuel = "";
                double fuelConsumption = 0;

                if (vehicle.Purpose == "Легковое")
                {
                    fuelConsumption = mileagePassenger * vehicle.FuelConsumption / 100;
                }
                else if (vehicle.Purpose == "Грузовое")
                {
                    fuelConsumption = mileageTruck * vehicle.FuelConsumption / 100;
                }
                else if (vehicle.Purpose == "Автобус")
                {
                    fuelConsumption = mileageBus * vehicle.FuelConsumption / 100;
                }
                if (!resoursec.ContainsKey(fuel))
                {
                    resoursec.Add(fuel, fuelConsumption);
                }
                else
                {
                    resoursec[fuel] += fuelConsumption;
                }
            }

            if (resoursec.Count > 0)
            {
                string resultMessage = "Расход топлива:\n";
                foreach (var res in resoursec)
                {
                    resultMessage += $"{res.Key}: {res.Value:F2} л\n";
                }
                MessageBox.Show(resultMessage, "Результаты расчета", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("В автопарке нет машин!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private string Determining_FuelType(string fuel)
        {
            return fuel switch
            {
                "Дизель летний" => "Дизель летний",
                "Дизель зимний" => "Дизель зимний",
                "Газ водород" => "Газ водород",
                "Газ метан" => "Газ метан",
                _ => fuel,
            };
        }
        public void PrintAllVehicles(List<Vehicle> carpool_depots)
        {
            if (carpool_depots.Count == 0)
            {
                MessageBox.Show("Нет доступных транспортных средств.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            StringBuilder sb = new StringBuilder();
            foreach (var vehicle in carpool_depots)
            {
                sb.AppendLine($"{vehicle.Name} - {vehicle.Purpose} - {vehicle.FuelType}");
            }

            MessageBox.Show(sb.ToString(), "Список транспортных средств", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
