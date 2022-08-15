// 71.	Написать программу вычисления функции Аккермана

double Ackermann(int m, int n)
{
    if ((m < 0 && n < 0) || m < 0 || n < 0) return 0;
    if (m == 0) return n + 1;
    if (m == 1) return n + 2;
    if (m == 2) return 2 * n + 3;
    if (m == 3) return Math.Pow(2, n + 3) - 3;
    if (m == 4) return PowerTower(n + 3) - 3;
    if (m == 5) return PowerTower(n + 4) - 3;
    return PowerTower(n + 5) - 3;
}
Console.WriteLine(Ackermann(4, 1));

double PowerTower(int n)
{
    if (n <= 0) return 1;
    return Math.Pow(2, PowerTower(n - 1));
}
