// 35.	Написать программу замены элементов массива на противоположные

int[] a;
Init(out a);
ZamenaNaProtivopol(a);

void Init(out int[] a, int Length=8, int min=-14, int max=25)
{
    a = new int[Length];
    Random random = new Random(); //псевдослучайные числа;
    for (int i = 0; i < a.Length; i++)
    {
        a[i] = random.Next(min, max + 1);
        Console.Write($"{a[i],4}");
    }
    Console.WriteLine();
}

void ZamenaNaProtivopol(int[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        a[i] /= -1;
        Console.Write($"{a[i],4}");
    }
    Console.WriteLine();
}
