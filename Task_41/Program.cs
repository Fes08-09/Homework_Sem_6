// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


using System;
using static System.Console;

Clear();

WriteLine("Введите числа через пробел: ");
int[] array = GetArrayFromString(ReadLine());
WriteLine($"{string.Join(", ", array)} -> {CountPositiveNumbres(array)}");

int[] GetArrayFromString(string arrayStr)
{
    string[] arS=arrayStr.Split(new char[]{' ',',','*'},StringSplitOptions.RemoveEmptyEntries); // вот этот пример!!!
    int[] result=new int[arS.Length];
    for(int i=0; i<arS.Length;i++)
        {
        result[i]=int.Parse(arS[i]);
        }
    return result;
}

int CountPositiveNumbres(int [] arr)
{
    int count = 0;
    for(int i =0; i<arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count+=1;
        }
    }
    return count;
}