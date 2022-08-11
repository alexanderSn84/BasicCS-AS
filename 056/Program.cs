// 56.	Написать программу, которая обменивает элементы первой строки и последней строки

int[,] arr = Create2DArray(6, 5, -10, 20); ;
Print(arr);

System.Console.WriteLine("========================================");

int obmen = 0;
int numIndex = 1;
int numLine = 0;
for (int j = 0; j < arr.GetLength(1); j++)
{
    obmen = arr[arr.GetLength(0) - numIndex, j];
    arr[arr.GetLength(0) - numIndex, j] = arr[numLine, j];
    arr[numLine, j] = obmen;
}

Print(arr);




int[,] Create2DArray(int n, int m, int min, int max)
{
    int[,] a = new int[n, m];
    Random random = new Random();
    for (int i = 0; i < a.GetLength(0); i++)
        for (int j = 0; j < a.GetLength(1); j++)
            a[i, j] = random.Next(min, max + 1);
    return a;
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
