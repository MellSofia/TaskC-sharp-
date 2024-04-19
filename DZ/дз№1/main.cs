using System;
//№1
/*public class SortArray
{
    public static void Main(string[] args)
    {
        int[] array = { -1, 2, -3, 4, -5, 6, -7 };
        Sort(array);

        foreach (int number in array)
        {
            Console.Write(number + " ");
        }
    }

    public static void Sort(int[] array)
    {
        int negativeCount = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                int temp = array[i];
                array[i] = array[negativeCount];
                array[negativeCount] = temp;
                negativeCount++;
            }
        }
    }
}
*/

//№2
/*public class CountNumberInArray
{
    public static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5 };
        CountNumber(array);
    }

    public static void CountNumber(int[] array)
    {
        Console.WriteLine("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == number)
            {
                count++;
            }
        }
        Console.WriteLine($"Число {number} встречается в массиве {count} раз(а).");
    }
}*/

// №3
using System;

namespace TransportSelection
{
    enum VehicleType
    {
        Bike = 20, // Велосипед
        Car = 500, // Автомобиль
        Truck = 2000, // Грузовик
        SemiTruck = 10000, // Полуприцеп
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите вес груза в кг:");
            int weight = Int32.Parse(Console.ReadLine());

            VehicleType? selectedVehicle = null;
            foreach (VehicleType vehicle in Enum.GetValues(typeof(VehicleType)))
            {
                if ((int)vehicle >= weight)
                {
                    selectedVehicle = vehicle;
                    break;
                }
            }

            if (selectedVehicle.HasValue)
            {
                Console.WriteLine($"Для груза весом {weight} кг подходит {selectedVehicle}.");
            }
            else
            {
                Console.WriteLine("Для указанного веса нет подходящего транспортного средства.");
            }
        }
    }
}
