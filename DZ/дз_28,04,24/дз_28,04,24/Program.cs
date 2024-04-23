using System;

public interface IVehicle
{
    string Name { get; }
    bool Move(int chance);
}

public abstract class Vehicle : IVehicle
{
    public string Name { get; protected set; }
    protected Random random = new Random();

    public abstract bool Move(int chance);
}

public abstract class Car : Vehicle
{
    public override bool Move(int chance)
    {
        // Пусть шанс поломки для машины будет 20%
        return chance > 20;
    }
}

public abstract class Truck : Vehicle
{
    public override bool Move(int chance)
    {
        // Пусть шанс поломки для грузовика будет 30%
        return chance > 30;
    }
}

public class Solaris : Car
{
    public Solaris()
    {
        Name = "Solaris";
    }
}

public class Rio : Car
{
    public Rio()
    {
        Name = "Rio";
    }
}

public class Kamaz : Truck
{
    public Kamaz()
    {
        Name = "Kamaz";
    }
}

public class Vaz : Truck
{
    public Vaz()
    {
        Name = "Vaz";
    }
}

public static class VehicleExtensions
{
    public static string VehicleStatus(this IVehicle vehicle)
    {
        if (vehicle.Move(new Random().Next(1, 101)))
        {
            return $"{vehicle.Name} едет";
        }
        else
        {
            return $"{vehicle.Name} сломался";
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        IVehicle[] vehicles = new IVehicle[]
        {
            new Solaris(),
            new Rio(),
            new Kamaz(),
            new Vaz()
        };

        foreach (var vehicle in vehicles)
        {
            Console.WriteLine(vehicle.VehicleStatus());
        }

        Console.ReadKey();
    }
}