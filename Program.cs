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
static string[] FilterStrings(string[] strings)
    {
        int count = 0;

        // Первый проход: определить количество подходящих строк.
        for (int i = 0; i < strings.Length; i++)
        {
            if (strings[i].Length <= 3)
            {
                count++;
            }
        }
        // Создать новый массив с подходящими строками.
        string[] filteredStrings = new string[count];
        int index = 0;