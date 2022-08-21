// Задача 64: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

Number(1, 5);
Console.WriteLine();



void Number(int m, int n)
{
    if (m <= n) Number(m, n - 1);
    else return;
    Console.Write($"{n,5}");
}