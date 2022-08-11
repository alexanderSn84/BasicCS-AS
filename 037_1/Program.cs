// 37.	Задать массив, заполнить случайными положительными трёхзначными числами.
//      Показать количество нечетных\четных чисел

Rezultat();




void Rezultat()
{
    int[] a;
    int ch, nech;
    Init(out a, 10, 100, 1000);
    Solve(a, out ch, out nech);
    Print(a);
    Console.Write($"количество четных чисел \t {ch}");
    Console.WriteLine();
    Console.Write($"количество нечетных чисел \t {nech}");
    Console.WriteLine();
}

void Init(out int[] a, int Length, int min, int max)
{
    a = new int[Length];
    Random random = new Random(); //псевдослучайные числа;
    for (int i = 0; i < a.Length; i++)
    {
        a[i] = random.Next(min, max);
    }
}

void Solve(int[] a, out int chet, out int nechet)
{
    chet = 0;
    nechet = 0;
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i] % 2 == 0) chet += 1;
        else nechet += 1;
    }
}

void Print(int[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        Console.Write($"{a[i],4}");
    }
    Console.WriteLine();
}
