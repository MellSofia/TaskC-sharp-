using System;
using System.Collections.Generic;

class Generator
{
    /// <summary>
    /// count = индекс
    /// </summary>
    /// <param name="count"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    public static IEnumerable<int> Fibonacci(int count)
    {
        count++;
        if (count < 0)
            throw new ArgumentException("Count cannot be less than zero.", nameof(count));

        int current = 0, next = 1;

        for (int i = 0; i < count; i++)
        {
            yield return current;
            int temp = current + next;
            current = next;
            next = temp;
        }
    }
}

class Program1
{
    static void Main()
    {
        foreach (int i in Generator.Fibonacci(0))
        {
            Console.WriteLine(i);
        }
    }
}


/*class Program2
{
    static void Main()
    {
        string text = "Перефразируй эти ответы..."; // Замените эту строку на ваш текст
        Dictionary<char, int> letterCounts = new Dictionary<char, int>();

        foreach (char c in text.ToLower())
        {
            if (char.IsLetter(c))
            {
                if (letterCounts.ContainsKey(c))
                    letterCounts[c]++;
                else
                    letterCounts[c] = 1;
            }
        }

        foreach (KeyValuePair<char, int> pair in letterCounts)
        {
            Console.WriteLine($"Буква '{pair.Key}' встречается {pair.Value} раз");
        }
    }
}*/

