using System;

class Program
{
    // Функция для сложения двух чисел
    static int Add(int a, int b)
    {
        return a + b;
    }
    
   

   
    static void Main(string[] args)
    {
        Console.WriteLine("Демонстрация работы функций:");

        // Тестирование функции сложения
        int sum = Add(5, 3);
        Console.WriteLine($"5 + 3 = {sum}");
    }
} 