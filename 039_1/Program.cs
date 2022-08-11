// 39. Найти сумму чисел одномерного массива стоящих на нечетной позиции

Run();

void Run()
{
    int[] a;
    int sum;
    Init(out a, Length:4);
    Solve(a, out sum);
    Print(a);
    System.Console.WriteLine();
    System.Console.WriteLine(sum);
}

void Init(out int[] a, int Length=7, int min=0, int max=11)
{
    a = new int[Length];
    Random random = new Random(); //псевдослучайные числа;
    for (int i = 0; i < a.Length; i++)
        a[i] = random.Next(min, max + 1);
}

void Solve(int[] a, out int sumM)
{
    sumM = 0;

for (int i = 1; i < a.Length; i += 2)
    sumM += a[i];
}

void Print(int[] a)
{
    for (int i = 0; i < a.Length; i++)
        Console.Write($"{a[i],4}");
}
