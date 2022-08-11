// 55.	Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

int[,] arr;
arr = Create2DArray(6, 5, -10, 20);
Print(arr);
System.Console.WriteLine("========================================");
System.Console.Write(Arithmetic(arr));
System.Console.WriteLine();


int[,] Create2DArray(int n, int m, int min, int max)
{
    int[,] a = new int[n, m];
    Random random = new Random();
    for (int i = 0; i < a.GetLength(0); i++)
        for (int j = 0; j < a.GetLength(1); j++)
            a[i, j] = random.Next(min, max + 1);
    return a;
}

string Arithmetic(int[,] a)
{
    // string rezultat = null!;
    string rezultat = string.Empty;
    for (int j = 0; j < a.GetLength(1); j++)
    {
        int sum = 0;
        int count = 0;
        int arifm = 0;
        for (int i = 0; i < a.GetLength(0); i++)
        {
            sum += a[i, j];
            count++;
        }
        arifm = sum / count;
        rezultat += $"{arifm.ToString(),6}";
    }
    return rezultat;
}

void Print(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
            System.Console.Write($"{a[i, j],6}");
        System.Console.WriteLine();
    }
}
