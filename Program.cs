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
     // Метод фильтрации строк по длине
    static string[] FilterStrings(string[] array)
    {
        // Подсчет количества строк, длина которых <= 3
        int count = 0;
        foreach (string str in array)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }

        // Создание нового массива для хранения отфильтрованных строк
        string[] result = new string[count];
        int index = 0;

        // Заполнение нового массива подходящими строками
        foreach (string str in array)
        {
            if (str.Length <= 3)
            {
                result[index] = str;
                index++;
            }
        }

        return result;
    }
    
    // Метод для вывода массива
    static void PrintArray(string[] array)
    {
        Console.Write("[");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"\"{array[i]}\"");
            if (i < array.Length - 1) Console.Write(", ");
        }
        Console.WriteLine("]");
    }
}