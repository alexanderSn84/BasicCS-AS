// 029.	Подсчитать сумму цифр в числе

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

int sum(int s)
{
    int sum_ch = 0;
    while (s >= 1)
    {
        sum_ch += s % 10;
        s /= 10;
    }
    return sum_ch;
}

Console.WriteLine($"Сумма цифр в числе равна {sum(a)}");
