// 41.	В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

int[] a = new int[10];
Random random = new Random(); //псевдослучайные числа;
int min = 0;
int max = 0;

for (int i = 0; i < a.Length; i++)
{
    a[i] = random.Next(-10, 10);
    Console.Write($"{a[i],5}");
}

Console.WriteLine();

for (int j = 0; j < a.Length; j++)
{
    if (a[j] <= min)
    {
        min = a[j];
    }
    if (a[j] >= max)
    {
        max = a[j];
    }
}

int Razn(int ax, int an)
{
    int r;
    if (an < 0)
    {
        r = an + ax;
    }
    else
    {
        r = ax - an;
    }
    return r;
}

Console.WriteLine($"Минимальное значение массива {min}, максимальное значение массива {max}");
Console.Write("Разница между минимальным и максимальным элементом --> " + Razn(max, min));
