using System;

public class Money
{
    public int Hryvnias { get; private set; }
    public int Kopecks { get; private set; }

    public Money(int hryvnias, int kopecks)
    {
        if (hryvnias < 0 || kopecks < 0)
            throw new InvalidOperationException("Банкрот");
        Hryvnias = hryvnias;
        Kopecks = kopecks;
    }

    public static Money operator +(Money m1, Money m2)
    {
        int hryvnias = m1.Hryvnias + m2.Hryvnias;
        int kopecks = m1.Kopecks + m2.Kopecks;
        if (kopecks >= 100)
        {
            hryvnias++;
            kopecks -= 100;
        }
        return new Money(hryvnias, kopecks);
    }

    public static Money operator -(Money m1, Money m2)
    {
        int hryvnias = m1.Hryvnias - m2.Hryvnias;
        int kopecks = m1.Kopecks - m2.Kopecks;
        if (kopecks < 0)
        {
            hryvnias--;
            kopecks += 100;
        }
        if (hryvnias < 0 || kopecks < 0)
            throw new InvalidOperationException("Банкрот");
        return new Money(hryvnias, kopecks);
    }

    public static Money operator *(Money m, int number)
    {
        int totalKopecks = (m.Hryvnias * 100 + m.Kopecks) * number;
        int hryvnias = totalKopecks / 100;
        int kopecks = totalKopecks % 100;
        return new Money(hryvnias, kopecks);
    }

    public static Money operator /(Money m, int number)
    {
        if (number <= 0)
            throw new InvalidOperationException("Некорректное значение делителя.");
        int totalKopecks = m.Hryvnias * 100 + m.Kopecks;
        totalKopecks /= number;
        int hryvnias = totalKopecks / 100;
        int kopecks = totalKopecks % 100;
        return new Money(hryvnias, kopecks);
    }

    public static Money operator ++(Money m)
    {
        return m + new Money(0, 1);
    }

    public static Money operator --(Money m)
    {
        return m - new Money(0, 1);
    }

    // Операторы сравнения
    public static bool operator <(Money m1, Money m2)
    {
        if (m1.Hryvnias == m2.Hryvnias)
            return m1.Kopecks < m2.Kopecks;
        return m1.Hryvnias < m2.Hryvnias;
    }

    public static bool operator >(Money m1, Money m2)
    {
        if (m1.Hryvnias == m2.Hryvnias)
            return m1.Kopecks > m2.Kopecks;
        return m1.Hryvnias > m2.Hryvnias;
    }

    public static bool operator ==(Money m1, Money m2)
    {
        return m1.Hryvnias == m2.Hryvnias && m1.Kopecks == m2.Kopecks;
    }

    public static bool operator !=(Money m1, Money m2)
    {
        return !(m1 == m2);
    }
}

class Program
{
    static void Main()
    {
        var money1 = new Money(10, 50);
        var money2 = new Money(5, 75);

        var sum = money1 + money2;
        var diff = money1 - money2;
        var mult = money1 * 2;
        var div = money1 / 2;

        Console.WriteLine($"Сумма: {sum.Hryvnias} гривен {sum.Kopecks} копеек");
        Console.WriteLine($"Разность: {diff.Hryvnias} гривен {diff.Kopecks} копеек");
        Console.WriteLine($"Умножение: {mult.Hryvnias} гривен {mult.Kopecks} копеек");
        Console.WriteLine($"Деление: {div.Hryvnias} гривен {div.Kopecks} копеек");

        if (money1 > money2)
            Console.WriteLine("Первая сумма больше второй");
        else if (money1 < money2)
            Console.WriteLine("Вторая сумма больше первой");
        else
            Console.WriteLine("Суммы равны");
    }
}
