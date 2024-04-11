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

        Console.WriteLine("Выберите порядок хода: 1 или 2");
        int playerOrder;
        bool f = int.TryParse(Console.ReadLine(), out playerOrder);
        while (!f)
        {
            Console.WriteLine("Ошибка!! Требуется цифра!!");
            f = int.TryParse(Console.ReadLine(), out playerOrder);
        }
        Console.WriteLine("Выберите символ для своего хода:");
        char playerSymbol = Console.ReadLine()[0];
        /*bool ps = char.TryParse(Console.ReadLine(), out playerSymbol);
        while (ps)
        {
            Console.WriteLine("Ошибка!! Требуется цифра!!");
            ps = char.TryParse(Console.ReadLine(), out playerSymbol);
        }*/
        char computerSymbol = playerSymbol == 'x' ? 'o' : 'x';

        while (main_flag)
        {
            PrintBoard(a);

            for (int i = 0; i < 9; i++)
            {
                if (i % 2 == (playerOrder - 1))
                {
                    PlayerMove(a, playerSymbol, playerOrder);
                }
                else
                {
                    PlayerMove(a, computerSymbol, 3 - playerOrder);
                }

                if (!main_flag)
                {
                    Console.WriteLine("Игра прервана");
                    return;
                }
                if (CheckWinOrDraw(a, i % 2 == (playerOrder - 1) ? playerSymbol : computerSymbol))
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

    static void PlayerMove(char[] a, char playerSymbol, int playerNumber)
    {
        int move;
        Console.WriteLine($"Игрок {playerNumber} ваш ход:");
        bool ff = int.TryParse(Console.ReadLine(), out move);
        while ((a[move] != '-') || (!ff))
        {
            Console.WriteLine("Недопустимый ход. Попробуйте еще раз:");
            ff = int.TryParse(Console.ReadLine(), out move);
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