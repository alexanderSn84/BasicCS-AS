﻿// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Sum(int m, int n)
{
    if (m < n) return Sum(m + 1, n) + m;
    return m;
}
System.Console.WriteLine(Sum(1, 15));
