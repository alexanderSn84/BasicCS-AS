// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


using System;
Console.Write("Введите элементы массива: ");
string? s = Console.ReadLine();
string[] ss = s!.Split(' ', StringSplitOptions.RemoveEmptyEntries);

double[] a = Array.ConvertAll<string, double>(ss, double.Parse);

double min = a[0];
double max = a[0];

for (int i = 0; i < a.Length; i++)
{
    if (a[i] <= min) min = a[i];
    if (a[i] >= max) max = a[i];
}

double Razn(double ax, double an)
{
    double r;
    if (an < 0 && ax > 0) r = an + ax;
    else if (an < 0 && ax < 0) r = an - ax;
    else r = ax - an;
    return r;
}

Console.WriteLine($"Минимальное значение массива {min}, максимальное значение массива {max}");
Console.WriteLine("Разница между минимальным и максимальным элементом --> " + Razn(max, min));

