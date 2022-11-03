﻿/*
 Задача: Написать программу, которая из имеющегося массива строк 
 формирует новый массив из строк, длина которых 
 меньше, либо равна 3 символам. 
 Первоначальный массив можно ввести с клавиатуры, 
 либо задать на старте выполнения алгоритма. 
 При решении не рекомендуется пользоваться коллекциями, 
 лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → [] 
*/
Console.WriteLine("Введите строковые значения массива через пробел.");
Console.Write("По окончанию ввода нажмите клавишу Enter: ");
string[] InArray = Console.ReadLine().Split(" ");
string[] OutArray = new string[CountDataArray(InArray, 3)];

for (int i = 0, j = 0; i < InArray.Length; i++)
{
    if (InArray[i].Length <= CountDataArray(InArray, 3))
    {
        OutArray[j] = InArray[i];
        j++;
    }
}

# region Подсчет данных в массиве меньше или равно заданной длины
int CountDataArray(string[] InArray, int n)
{
    int count = 0;
    for (int i = 0; i < InArray.Length; i++)
    {
        if (InArray[i].Length <= n)
        {
            count++;
        }
    }
    return count;
}

#endregion