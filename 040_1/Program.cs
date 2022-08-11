// 40. Задан массив a из N элементов. Заполнить массив случайными числами от 1 до 10.
//Создайте массив, который является произведением пар чисел в одномерном массиве a.
//Парой считаем первый и последний элемент, второй и предпоследний и т.д.

int[] a, b;
Init(out a, 8, 1, 10);
Solve(a, out b);
Print(a, b);

void Init(out int[] a, int Length, int min, int max)
{
    a = new int[Length];
    Random random = new Random(); //псевдослучайные числа;
    for (int i = 0; i < a.Length; i++)
        a[i] = random.Next(min, max + 1);
}

void Solve(int[] a, out int[] multiplication)
{

    multiplication = new int[a.Length / 2];

    for (int i = 0; i < a.Length / 2; i++)
        multiplication[i] = a[i] * a[a.Length - i - 1];
}

void Print(int[] a1, int[] b1)
{
    for (int i = 0; i < a1.Length; i++)
        Console.Write($"{a1[i],4}");
    System.Console.WriteLine();

    for (int i = 0; i < b1.Length; i++)
        Console.Write($"{b1[i],4}");
    System.Console.WriteLine();
}