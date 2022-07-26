// 37.	Задать массив, заполнить случайными положительными трёхзначными числами.
//      Показать количество нечетных\четных чисел

int[] a = new int[10];
Random random = new Random(); //псевдослучайные числа;
int chet=0;
int nechet=0;

for (int i = 0; i < a.Length; i++)
{
    a[i] = random.Next(100, 1000);
    Console.Write($"{a[i],4}");
}

Console.WriteLine();

for (int j = 0; j < a.Length; j++)
{
    if(a[j]%2==0)
    {
        chet+=1;
    }
    else
    {
        nechet+=1;
    }
}

Console.Write($"количество четных чисел --> {chet}");
Console.WriteLine();
Console.Write($"количество нечетных чисел --> {nechet}");
