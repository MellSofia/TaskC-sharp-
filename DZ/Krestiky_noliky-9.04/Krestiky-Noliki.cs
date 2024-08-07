using System;
class Program
{
    static bool main_flag = true;

    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        char[] a = new char[10] { '-', '-', '-', '-', '-', '-', '-', '-', '-', '-' };
        Console.WriteLine("7 8 9");
        Console.WriteLine("4 5 6");
        Console.WriteLine("1 2 3");
        Console.WriteLine();

        while (main_flag)
        {
            PrintBoard(a);

            for (int i = 0; i < 9; i++)
            {
                PlayerMove(a, i % 2 == 0 ? 'x' : 'o');
                if (!main_flag)
                {
                    Console.WriteLine("Игра прервана");
                    return;
                }
                if (CheckWinOrDraw(a, i % 2 == 0 ? 'x' : 'o'))
                {
                    return;
                }
            }
        }
    }

    static void PrintBoard(char[] a)
    {
        Console.WriteLine($"{a[7]} {a[8]} {a[9]}");
        Console.WriteLine($"{a[4]} {a[5]} {a[6]}");
        Console.WriteLine($"{a[1]} {a[2]} {a[3]}");
    }

    static void PlayerMove(char[] a, char playerSymbol)
    {
        int move;
        Console.WriteLine($"Игрок {(playerSymbol == 'x' ? "1" : "2")} ваш ход:");
        move = int.Parse(Console.ReadLine());
        while (a[move] != '-')
        {
            Console.WriteLine("Недопустимый ход. Попробуйте еще раз:");
            move = int.Parse(Console.ReadLine());
        }
        a[move] = playerSymbol;
        PrintBoard(a);
    }

    static bool CheckWinOrDraw(char[] a, char playerSymbol)
    {
        int[][] winConditions = new int[][] {
            new int[] { 1, 2, 3 },
            new int[] { 4, 5, 6 },
            new int[] { 7, 8, 9 },
            new int[] { 1, 5, 9 },
            new int[] { 3, 5, 7 },
            new int[] { 1, 4, 7 },
            new int[] { 2, 5, 8 },
            new int[] { 3, 6, 9 }
        };

        for (int i = 0; i < 8; i++)
        {
            if (a[winConditions[i][0]] == playerSymbol && a[winConditions[i][1]] == playerSymbol && a[winConditions[i][2]] == playerSymbol)
            {
                Console.WriteLine($"Игрок {(playerSymbol == 'x' ? "1" : "2")} выиграл!!");
                main_flag = false;
                return true;
            }
        }

        for (int i = 1; i <= 9; i++)
        {
            if (a[i] == '-')
                return false;
        }

        Console.WriteLine("Ничья");
        main_flag = false;
        return true;
    }
}
