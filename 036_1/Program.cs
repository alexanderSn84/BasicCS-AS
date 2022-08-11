// 36. Определить, присутствует ли в заданном массиве, некоторое число



Run();



void Run()
{
    int[] a;
    Init(out a, 3, -9, 10);
    Solve(a);
    Print(a);
}

void Init(out int[] a, int Length, int min, int max)
{
    a = new int[Length];
    Random random = new Random(); //псевдослучайные числа;
    for (int i = 0; i < a.Length; i++)
        a[i] = random.Next(min, max + 1);
}

void Solve(int[] a)
{
    int number = 400; a[1] = number; //Алгоритм линейного поиска 

    int j = 0;

    while (j < a.Length && a[j] != number)
    {
        j++;
    }

    if (j == a.Length)
    {
        System.Console.WriteLine("No");
    }
    else
    {
        System.Console.WriteLine($"Yes. {j}");
    }
}

void Print(int[] a)
{
    for (int i = 0; i < a.Length; i++)
        System.Console.Write($"{a[i],4}");
    System.Console.WriteLine();
}
