using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите строки через запятую:");
        string input = Console.ReadLine();
        string[] inputStrings = input.Split(',');

        string[] filteredStrings = FilterStrings(inputStrings);

        Console.WriteLine("Результат фильтрации:");
        foreach (string str in filteredStrings)
        {
            Console.WriteLine(str);
        }
    }
