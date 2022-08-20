// 66.	Показать натуральные числа от 1 до N, N задано

int Number(int n)
{
    if (n < 1) return 0;
    else return Number(n - 1) + n;
}
Console.Write(Number(5));
