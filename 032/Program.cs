// 32.	Задать массив из 8 целых элементов и вывести их на экран

int N = 8;
int[] a = new int[N];
Random random = new Random(); //псевдослучайные числа;

for (int i = 0; i < a.Length; i++)
    a[i] = random.Next(-10, 101);

for (int i = 0; i < a.Length; i++)
    Console.Write($"{a[i],4}");
