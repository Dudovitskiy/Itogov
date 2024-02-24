//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
//длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
//лучше обойтись исключительно массивами.
using Sistem;

class Program
{
    static void Main(string[]args)
    {
        string[] inputArr = { "Hello", "2", "world", ":-)" };

        string[] filteredArr = filtrdArry(inputArr);

        Console.WriteLine("Новый Массив");
        foreach (string str in filteredArr)
        {
            Console.WriteLine(str);
        }




    }















}