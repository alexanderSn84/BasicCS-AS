// 043.	С клавиатуры вводится число N. 
// Затем вводятся N чисел. 
// Определить сколько чисел больше 0 введено с клавиатуры.

using System;
Console.Write("Введите элементы массива: ");
string? s = Console.ReadLine();
char[] razdel = { ' ', ',' };
string[] ss = s!.Split(razdel, StringSplitOptions.RemoveEmptyEntries);

int bolsheNulya(string[] a)
{
    int bn = 0;
    for (int i = 0; i < Convert.ToInt32(a.Length); i++)
    {
        if (Convert.ToInt32(a[i]) > 0) bn++;
    }
    return bn;
}

Console.Write($"Больше нуля\t{bolsheNulya(ss)}");
Console.WriteLine();
