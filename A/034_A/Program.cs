// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

using System;
Console.Write("Введите элементы массива: ");
string? s = Console.ReadLine();
char[] razdel = { ' ', ',' };
string[] ss = s!.Split(razdel, StringSplitOptions.RemoveEmptyEntries);

int chet = 0;

int[] a = Array.ConvertAll<string, int>(ss, int.Parse);
for (int i = 0; i < a.Length; i++)
{
    if (a[i] % 2 == 0) chet += 1;
}

Console.Write($"Количество четных чисел \t {chet}");
Console.WriteLine();


