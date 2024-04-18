using System;

public abstract class Vehicle
{
    protected string name;
    protected Random rand = new Random();

    public Vehicle(string name)
    {
        this.name = name;
    }

    public virtual bool Move(int chance)
    {
        return chance > rand.Next(100);
    }
}

public abstract class Car : Vehicle
{
    public Car(string name) : base(name) { }
}

public abstract class Truck : Vehicle
{
    public Truck(string name) : base(name) { }
}

public class Solaris : Car
{
    public Solaris() : base("Solaris") { }

    public override string ToString()
    {
        return Move(rand.Next(100)) ? $"{name} едет" : $"{name} сломался";
    }
}

public class Rio : Car
{
    public Rio() : base("Rio") { }

    public override string ToString()
    {
        return Move(rand.Next(100)) ? $"{name} едет" : $"{name} сломался";
    }
}

public class Kamaz : Truck
{
    public Kamaz() : base("Kamaz") { }

    public override string ToString()
    {
        return Move(rand.Next(100)) ? $"{name} едет" : $"{name} сломался";
    }
}

public class Vaz : Truck
{
    public Vaz() : base("Vaz") { }

    public override string ToString()
    {
        return Move(rand.Next(100)) ? $"{name} едет" : $"{name} сломался";
    }
}

class Program
{
    static void Main()
    {
        Vehicle[] vehicles = new Vehicle[] { new Solaris(), new Rio(), new Kamaz(), new Vaz() };

        foreach (var vehicle in vehicles)
        {
            Console.WriteLine(vehicle);
        }
    }
}
