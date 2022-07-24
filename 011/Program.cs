// 011. Показать вторую цифру трёхзначного числа

Console.Write("Введите число: ");
int a=Convert.ToInt32(Console.ReadLine());

int b=(a%100)/10;
Console.WriteLine($"Вторая цифра числа: {b}");
