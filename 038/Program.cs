// 38.	В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int[] a = new int[123];
Random random = new Random(); //псевдослучайные числа;
int c = 0;

for (int i = 0; i < a.Length; i++)
{
    a[i] = random.Next(-200, 300);
    Console.Write($"{a[i],5}");
}

Console.WriteLine();

for (int j = 0; j < a.Length; j++)
{
    if (a[j] >= 10 && a[j] <= 99)
    {
        c += 1;
    }
}
Console.Write($"количество элементов из отрезка [10,99] --> {c}");
