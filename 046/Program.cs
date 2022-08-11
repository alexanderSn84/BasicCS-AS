// 46.	Показать числа Фибоначчи

Console.Write("Введите длину последовательности: ");
int dp = Convert.ToInt32(Console.ReadLine());
long rezultat;
long f1 = 0;
long f2 = 1;

for (int i = 0; i <= dp; i++)
{
    rezultat = f1;
    if (i != dp) Console.Write($"{rezultat}, ");
    else Console.Write(rezultat);
    f1 += f2;
    f2 = rezultat;
}
Console.WriteLine();
