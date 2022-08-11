// 48.	Написать программу копирования массива

int[] a = new int[10];
Random rd = new Random();
Console.Write("Оригинал \n");
for (int i = 0; i < a.Length; i++)
{
    a[i] = rd.Next(0, 100);
    Console.Write($"{a[i],4}");
}
Console.WriteLine();
Console.Write("Копия \n");
for (int i = 0; i < a.Length; i++)
{
    int copyM = a[i];
    Console.Write($"{copyM,4}");
}
Console.WriteLine();
