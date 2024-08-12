using System;


internal class Program
{
    private static void Main(string[] args)
    {
        int choice = -1;
        while (choice != 0)
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1. In hinh chu nhat");
            Console.WriteLine("2. In hinh tam giac vuong");
            Console.WriteLine("3. In tam giac can");
            Console.WriteLine("0. Thoat");
            Console.WriteLine("Enter your choice: ");
            choice = Int32.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    for (int i = 1; i <= 3; i++)
                    {
                        for (int j = 0; j < 7; j++)
                        {
                            Console.Write("* ");
                        }
                        Console.WriteLine();
                    }
                    break;
                case 2:
                    for (int i = 1; i <= 5; i++)
                    {
                        for (int j = 0; j < i; j++)
                        {
                            Console.Write("* ");
                        }
                        Console.WriteLine();
                    }
                    break;
                case 3:
                    for (int i = 5; i >= 1; i--)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write("* ");
                        }
                        Console.WriteLine();
                    }
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("No choice!");
                    break;
            }

        }
    }
}