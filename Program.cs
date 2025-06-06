using System;

class Program
{
    // Функция для сложения двух чисел
    static int Add(int a, int b)
    {
        return a + b;
    }
    
    // Функция для проверки, является ли число четным
    static bool IsEven(int number)
    {
        return number % 2 == 0;
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
    }
} 