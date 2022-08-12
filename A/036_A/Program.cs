// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0



using System;
Console.Write("Введите элементы массива: ");
string? s = Console.ReadLine();
char[] razdel = { ' ', ',' };
string[] ss = s!.Split(razdel, StringSplitOptions.RemoveEmptyEntries);

int sum = 0;

int[] a = Array.ConvertAll<string, int>(ss, int.Parse);
for (int i = 1; i < a.Length; i += 2)
{
    sum += a[i];
}
Console.Write(sum);
Console.WriteLine();
