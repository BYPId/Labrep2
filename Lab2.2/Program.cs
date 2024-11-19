using System;

class Program
{
    static double A = 0, B = 0;

    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Меню:");
            Console.WriteLine("1. Ввести A");
            Console.WriteLine("2. Ввести B");
            Console.WriteLine("3. Выполнить операцию '+'");
            Console.WriteLine("4. Выполнить операцию '-'");
            Console.WriteLine("5. Выполнить операцию '*'");
            Console.WriteLine("6. Выполнить операцию '/'");
            Console.WriteLine("7. Выход");
            Console.Write("Выберите пункт меню: ");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    EnterA();
                    break;
                case "2":
                    EnterB();
                    break;
                case "3":
                    Add();
                    break;
                case "4":
                    Subtract();
                    break;
                case "5":
                    Multiply();
                    break;
                case "6":
                    Divide();
                    break;
                case "7":
                    return;
                default:
                    Console.WriteLine("Неверный выбор, попробуйте снова.");
                    break;
            }
        }
    }

    static void EnterA()
    {
        Console.Write("Введите значение A: ");
        A = Convert.ToDouble(Console.ReadLine());
    }

    static void EnterB()
    {
        Console.Write("Введите значение B: ");
        B = Convert.ToDouble(Console.ReadLine());
    }

    static void Add()
    {
        Console.WriteLine($"Результат: {A} + {B} = {A + B}");
        Console.ReadKey();
    }

    static void Subtract()
    {
        Console.WriteLine($"Результат: {A} - {B} = {A - B}");
        Console.ReadKey();
    }

    static void Multiply()
    {
        Console.WriteLine($"Результат: {A} * {B} = {A * B}");
        Console.ReadKey();
    }

    static void Divide()
    {
        if (B == 0)
        {
            Console.WriteLine("Ошибка: Деление на 0 невозможно.");
        }
        else
        {
            Console.WriteLine($"Результат: {A} / {B} = {A / B}");
        }
        Console.ReadKey();
    }
}
