// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше или равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

using System;
using static System.Console;

string[] array = new string[4] { "hello", "2", "world", ":-)" };
var str = string.Join(" ", array);
WriteLine("[{0}]", string.Join(", ", array));
WriteLine();
WriteLine("[{0}]", string.Join(", ", GetArray(array)));

string[] GetArray(string[] array)
{
    //string result = string.Empty;
    string[] arr = new string[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (array[i].Length <= 3)
            arr[i] = array[i];

        // result = Convert.ToString(array[i]);
    }
    return arr;
}