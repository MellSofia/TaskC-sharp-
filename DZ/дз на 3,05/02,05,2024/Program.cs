using System;

class Program
{
    static void Main(string[] args)
    {
        Vector v1 = new Vector(1, 2);
        Vector v2 = new Vector(3, 4);

        // Использование перегруженного оператора сложения
        Vector v3 = v1 + v2;
        Console.WriteLine($"v3: {v3}");

        // Использование перегруженного оператора умножения на число
        Vector v4 = v1 * 2;
        Console.WriteLine($"v4: {v4}");

        // Использование перегруженных операторов сравнения
        bool areEqual = v1 == v2;
        Console.WriteLine($"areEqual: {areEqual}");

        // Использование перегруженных операторов приведения типов
        Vector v5 = 5.0; // implicit conversion from double to Vector
        Console.WriteLine($"v5: {v5}");

        double angle = (double)v1; // explicit conversion from Vector to double
        Console.WriteLine($"angle: {angle}");
    }

    public class Vector
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Vector(double x, double y)
        {
            X = x;
            Y = y;
        }

        // Перегрузка оператора сложения
        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector(v1.X + v2.X, v1.Y + v2.Y);
        }

        // Перегрузка оператора умножения на число
        public static Vector operator *(Vector v, double scalar)
        {
            return new Vector(v.X * scalar, v.Y * scalar);
        }

        // Перегрузка операторов сравнения
        public static bool operator ==(Vector v1, Vector v2)
        {
            if (ReferenceEquals(v1, v2))
            {
                return true;
            }

            if (ReferenceEquals(v1, null) || ReferenceEquals(v2, null))
            {
                return false;
            }

            return v1.X == v2.X && v1.Y == v2.Y;
        }

        public static bool operator !=(Vector v1, Vector v2)
        {
            return !(v1 == v2);
        }

        // Перегрузка операторов приведения типов
        public static implicit operator Vector(double scalar)
        {
            return new Vector(scalar, scalar);
        }

        public static explicit operator double(Vector v)
        {
            return Math.Atan2(v.Y, v.X);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return this == (Vector)obj;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (X.GetHashCode() * 397) ^ Y.GetHashCode();
            }
        }

        public override string ToString()
        {
            return $"Vector({X}, {Y})";
        }
    }
}
