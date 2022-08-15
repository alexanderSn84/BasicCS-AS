// 70.	Найти сумму цифр числа

int Sum(int n)
{
    if (n > 0) return Sum(n / 10) + n % 10;
    else return 0;
}
System.Console.WriteLine(Sum(124));