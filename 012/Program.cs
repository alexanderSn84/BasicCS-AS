// 012. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int a = new Random().Next(10, 99);
Console.WriteLine(a);

int d1 = a / 10;
int d2 = a % 10;

int m = Math.Max(d1, d2);
Console.Write("max = ");
Console.WriteLine(m);
