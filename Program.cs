﻿//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
//длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
//лучше обойтись исключительно массивами.

















    static string[] filtrArray(string[] arr)
    {
        int count = 0;
        foreach(string str in arr)
            if (str.Lenght <= 3)
            {
                count++;
            }

        string[] filteredArr = new string[count];
        int index = 0;
        foreach(string str in arr)
        {
            if(str.Lenght <= 3)
            {
               filteredArr[index] = str;
               index++; 
            }
        }
        return filteredArr;
        
    }