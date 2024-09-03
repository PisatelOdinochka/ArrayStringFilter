using System;

class Program
{
    static void Main()
    {
        // Ввод массива строк
        Console.WriteLine("Введите строки через пробел:");
        string[] inputArray = Console.ReadLine().Split(' ');

        // Вызов метода для фильтрации строк по длине
        string[] resultArray = FilterStrings(inputArray);

        // Вывод результата
        Console.WriteLine("Массив строк, длина которых меньше или равна 3 символам:");
        PrintArray(resultArray);
    }