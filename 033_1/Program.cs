// 33.	Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

int[] a;
Init(out a);
Print(a);

void Init(out int[] a, int Length=8, int min=0, int max=1)
{
    a = new int[Length];
    Random random = new Random(); //псевдослучайные числа;
    for (int i = 0; i < a.Length; i++)
        a[i] = random.Next(min, max + 1);
}

void Print(int[] a)
{
    for (int i = 0; i < a.Length; i++)
        Console.Write($"{a[i],4}");
        Console.WriteLine();
}
