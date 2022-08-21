// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29


double Ackerman(double m, double n)
{
    if (m == 0 && n >= 0) return n + 1;
    if (m > 0 && n == 0) return Ackerman(m - 1, 1);
    if (m > 0 && n > 0) return Ackerman(m - 1, Ackerman(m, n - 1));
    return 0;
}
Console.WriteLine(Ackerman(3, 5));
