// 35.	Написать программу замены элементов массива на противоположные

int[] a = new int[8];
Random random = new Random(); //псевдослучайные числа;

for (int i = 0; i < a.Length; i++)
{
    a[i] = random.Next(-14, 25);
    Console.Write($"{a[i],4}");
}

Console.WriteLine();

for (int j = 0; j < a.Length; j++)
{
    a[j] /= -1;
    Console.Write($"{a[j],4}");
}
