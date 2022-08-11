// 38.	В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

Rezultat();




void Rezultat()
{
    int[] a;
    int kolElementov;
    Init(out a, Length:123);
    Solve(a, out kolElementov);
    Print(a);
    Console.WriteLine($"количество элементов из отрезка [10,99] --> {kolElementov}");
}

void Init(out int[] a, int Length=60, int min=-100, int max=200)
{
    a = new int[Length];
    Random random = new Random(); //псевдослучайные числа;
    for (int i = 0; i < a.Length; i++)
    {
        a[i] = random.Next(min, max + 1);
    }
}

void Solve(int[] a, out int otrezka)
{
    otrezka = 0;
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i] >= 10 && a[i] <= 99) otrezka += 1;
    }
}

void Print(int[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        Console.Write($"{a[i],5}");
    }
    Console.WriteLine();
}
