using System;

class Calculator 
{
    static void Main()
    {
        int choice;
        double num1, num2;

        do
        {
            Console.WriteLine("Выберите операцию (1-9):");
            Console.WriteLine("1. Сложение");
            Console.WriteLine("2. Вычитание");
            Console.WriteLine("3. Умножение");
            Console.WriteLine("4. Деление");
            Console.WriteLine("5. Возведение в степень");
            Console.WriteLine("6. Квадратный корень");
            Console.WriteLine("7. От числа 1%");
            Console.WriteLine("8. Факториал");
            Console.WriteLine("9. Выйти из программы");

            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.Write("Введите первое число: ");
                        num1 = double.Parse(Console.ReadLine());
                        Console.Write("Введите второе число: ");
                        num2 = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Результат: {num1 + num2}");
                        break;

                    case 2:
                        Console.Write("Введите первое число: ");
                        num1 = double.Parse(Console.ReadLine());
                        Console.Write("Введите второе число: ");
                        num2 = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Результат: {num1 - num2}");
                        break;

                    case 3:
                        Console.Write("Введите первое число: ");
                        num1 = double.Parse(Console.ReadLine());
                        Console.Write("Введите второе число: ");
                        num2 = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Результат: {num1 * num2}");
                        break;

                    case 4:
                        Console.Write("Введите первое число: ");
                        num1 = double.Parse(Console.ReadLine());
                        Console.Write("Введите второе число: ");
                        num2 = double.Parse(Console.ReadLine());
                        if (num2 == 0)
                        {
                            Console.WriteLine("Ошибка: Деление на ноль!");
                        }
                        else
                        {
                            Console.WriteLine($"Результат: {num1 / num2}");
                        }
                        break;

                    case 5:
                        Console.Write("Введите число: ");
                        num1 = double.Parse(Console.ReadLine());
                        Console.Write("Введите степень: ");
                        int power = int.Parse(Console.ReadLine());
                        double result = 1;
                        for (int i = 0; i < power; i++)
                        {
                            result *= num1;
                        }
                        Console.WriteLine($"Результат: {result}");
                        break;

                    case 6:
                        Console.Write("Введите число: ");
                        num1 = double.Parse(Console.ReadLine());
                        if (num1 < 0)
                        {
                            Console.WriteLine("Ошибка: Квадратный корень из отрицательного числа!");
                        }
                        else
                        {
                            Console.WriteLine($"Результат: {Math.Sqrt(num1)}");
                        }
                        break;

                    case 7:
                        Console.Write("Введите число: ");
                        num1 = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Результат: {num1 * 0.01}");
                        break;

                    case 8:
                        Console.Write("Введите число: ");
                        num1 = double.Parse(Console.ReadLine());
                        long factorial = 1;
                        for (int i = 1; i <= num1; i++)
                        {
                            factorial *= i;
                        }
                        Console.WriteLine($"Результат: {factorial}");
                        break;

                    case 9:
                        Console.WriteLine("Выход из программы.");
                        break;

                    default:
                        Console.WriteLine("Ошибка: Некорректный выбор операции.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Ошибка: Введите число от 1 до 9.");
            }
        }
        while (choice != 9);
    }
}