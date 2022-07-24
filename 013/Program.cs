// 013. Удалить вторую цифру трёхзначного числа

Console.Write("Введите число: ");
int a=Convert.ToInt32(Console.ReadLine());

int b=a/100; // Первая цифра
int c=a%10; // Последняя цифра
Console.WriteLine($"{b}{c} ");
