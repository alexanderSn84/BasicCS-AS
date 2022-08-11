// 34. Задать массив из 12 элементов, заполненных числами из [-9, 9].  
//Найти сумму положительных/отрицательных элементов массива

Run();




void Run()
{
    int[] a;
    int sumP, sumN;
    Init(out a, 12, -9, 9);
    Solve(a, out sumP, out sumN);
    Print(a);
    System.Console.WriteLine();
    System.Console.WriteLine($"Сумма положительных:{sumP}");
    System.Console.WriteLine($"Сумма отрицательных:{sumN}");
}

void Init(out int[] a, int Length, int min, int max)
{
    a = new int[Length];
    Random random = new Random(); //псевдослучайные числа;
    for (int i = 0; i < a.Length; i++)
        a[i] = random.Next(min, max + 1);
}

void Solve(int[] a, out int sumPositive, out int sumNegative)
{
    sumPositive = 0;
    sumNegative = 0;

    for (int i = 0; i < a.Length; i++)
    {
        if (a[i] > 0)
        {
            sumPositive += a[i];
        }
        if (a[i] < 0)
        {
            sumNegative += a[i];
        }
    }
}

void Print(int[] a)
{
    for (int i = 0; i < a.Length; i++)
        Console.Write($"{a[i],4}");
}
