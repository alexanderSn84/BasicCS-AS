// 28.	Определить количество цифр в числе. Сделать подпрограмму.

int CountDigits(int N)
{
    if (N == 0) return 1;
    int k = 0;
    while (N != 0)
    {
        k++;
        N /= 10;
    }
    return k;
}

Console.WriteLine(CountDigits(1569988));
