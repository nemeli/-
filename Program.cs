﻿void Print1DArr(string[] arr)
{
    Console.Write("[");
    for(int i=0;i<arr.LongLength-1;i++)
    {
   
        Console.Write($"{arr[i]},");
    }
    Console.WriteLine($"{arr[arr.LongLength-1]}]");
    
}

string[] SortingArray(string[] mas, int lenStr)
{
    string[] resultMas=Array.Empty<string>();
    for(int i=0;i<mas.Length;i++)
    {
        if(mas[i].Length<lenStr)
        {
            resultMas=resultMas.Concat(new string[]{mas[i]}).ToArray();
        }
    }
    return resultMas;
}

Console.WriteLine("Напишите массив со знаками пробела для каждого элемента");
string arr= Console.ReadLine()??"0";
string[] masl = arr.Split(' ');
string[] result=SortingArray(masl,4);
Print1DArr(result);
