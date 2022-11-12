// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше или равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

using System;
using static System.Console;

string[] array = new string[6] { "your", "hello", "2", "world", ":-)", "win" };
var str = string.Join(" ", array);
WriteLine("[{0}]", string.Join(", ", array));
WriteLine();
WriteLine("[{0}]", string.Join(", ", GetNewArray(array)));

string[] GetNewArray(string[] array)
{
    int j = 0;
    string[] newArray = new string[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    Array.Resize(ref newArray, j);
    return newArray;
}

