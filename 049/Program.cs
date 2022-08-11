// 49.	Показать двумерный массив размером m×n заполненный вещественными случайными числами

double[,] arr;//объявляем массив

arr = Create2DArray(3, 4);
Print(arr);

void Print(double[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)//перебираем строки
    {
        for (int j = 0; j < a.GetLength(1); j++)//перебираем столбцы
            System.Console.Write($"{a[i, j]}\t");
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

double[,] arr2;
Create2DArray2(4, 5, out arr2);
Print(arr2);

//1 способ вернуть массив
double[,] Create2DArray(int n, int m, double min = 0, double max = 100)
{
    double[,] a = new double[n, m];//создаем массив
    Random random = new Random();
    for (int i = 0; i < a.GetLength(0); i++)//перебираем строки
        for (int j = 0; j < a.GetLength(1); j++)//перебираем столбцы
            a[i, j] = Math.Round(random.NextDouble() * 100, 2);
    return a;
}

//2 способ вернуть массив
void Create2DArray2(int n, int m, out double[,] a)
{
    a = new double[n, m];//создаем массив
    Random random = new Random();
    for (int i = 0; i < a.GetLength(0); i++)//перебираем строки
        for (int j = 0; j < a.GetLength(1); j++)//перебираем столбцы
            a[i, j] = Math.Round(random.NextDouble() * 10, 2);

}