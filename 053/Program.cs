//53. Написать подпрограмму, поиска элемента в двумерном массиве,
// подпрограмма возвращает позицию числа. Если элемент отсутствует,
// подпрограмма возвращает -1.

int[,] arr;//объявляем массив
arr = Create2DArray(3, 4);
arr[2, 3] = 5;
Print(arr);
int i, j;

System.Console.WriteLine(Find(arr, 5, out i, out j));
System.Console.WriteLine($"i={i} j={j}");

bool Find(int[,] a, int number, out int i, out int j)
{
    for (i = 0; i < a.GetLength(0); i++)//перебираем строки
    {
        for (j = 0; j < a.GetLength(1); j++)//перебираем столбцы
            if (a[i, j] == number)
            {
                return true;
            }
    }
    j = -1;
    i = -1;
    return false;
}

void Print(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)//перебираем строки
    {
        for (int j = 0; j < a.GetLength(1); j++)//перебираем столбцы
            System.Console.Write($"{a[i, j],4}");
        System.Console.WriteLine();
    }
}

//1 способ вернуть массив
int[,] Create2DArray(int n, int m, int min = 0, int max = 100)
{
    int[,] a = new int[n, m];//создаем массив
    Random random = new Random();
    for (int i = 0; i < a.GetLength(0); i++)//перебираем строки
        for (int j = 0; j < a.GetLength(1); j++)//перебираем столбцы
            a[i, j] = random.Next(min, max + 1);
    return a;
}