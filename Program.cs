using System;

class Program
{
    // Функция для сложения двух чисел
    static int Add(int a, int b)
    {
        return a + b;
    }
    
    // Функция для проверки, является ли число четным
    static bool IsEven(int numbercxz)
    {
        return numbercxz % 2 == 0;
    }

    // Функция для вычисления факториала
    static int Factorial(int n)
    {
        if (n <= 1) return 1;
        return n * Factorial(n - 1);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Демонстрация работы функций:");

        // Тестирование функции сложения
        int sum = Add(5, 3);
        Console.WriteLine($"5 + 3 = {sum}");

        // Тестирование функции проверки четности
        int number = 10;
        Console.WriteLine($"Число {number} {(IsEven(number) ? "четное" : "нечетное")}");

        // Тестирование функции факториала
        int factorialResult = Factorial(5);
        Console.WriteLine($"Факториал 5 = {factorialResult}");
    }
} 