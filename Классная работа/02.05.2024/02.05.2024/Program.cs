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
        if (chance >= 30 && chance < 40)
        {
            throw new Exception($"{name} - спустилось колесо");
        }
        else if (chance >= 40 && chance < 50)
        {
            throw new Exception($"{name} - отказали тормоза");
        }
        else if (chance >= 20 && chance < 30)
        {
            throw new Exception($"{name} - разрядился двигатель");
        }
        else if (chance >= 0 && chance < 20)
        {
            throw new Exception($"{name} - зеркала сломаны");
        }
        return chance > 50;
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
        Random random = new Random(); 
        try
        {
            return Move(random.Next(100)) ? $"{name} is moving" : $"{name} is broken";
        }
        catch (Exception ex)
        {
            return $"{name} is broken - {ex.Message}";
        }
    }
}

public class Rio : Car
{
    public Rio() : base("Rio") { }

    public override string ToString()
    {
        Random random = new Random(); 
        try
        {
            return Move(random.Next(100)) ? $"{name} is moving" : $"{name} is broken";
        }
        catch (Exception ex)
        {
            return $"{name} is broken - {ex.Message}";
        }
    }
}

public class Kamaz : Truck
{
    public Kamaz() : base("Kamaz") { }

    public override string ToString()
    {
        Random random = new Random(); 
        try
        {
            return Move(random.Next(100)) ? $"{name} is moving" : $"{name} is broken";
        }
        catch (Exception ex)
        {
            return $"{name} is broken - {ex.Message}";
        }
    }
}

public class Vaz : Truck
{
    public Vaz() : base("Vaz") { }

    public override string ToString()
    {
        Random random = new Random(); 
        try
        {
            return Move(random.Next(100)) ? $"{name} is moving" : $"{name} is broken";
        }
        catch (Exception ex)
        {
            return $"{name} is broken - {ex.Message}";
        }
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