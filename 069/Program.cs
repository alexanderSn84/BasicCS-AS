// 69.	Найти сумму элементов от M до N, N и M заданы

int S(int m, int n)
{
    if (m < n) return S(m + 1, n) + m;
    else return m;
}
System.Console.WriteLine(S(0, 4));