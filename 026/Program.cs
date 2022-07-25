// 026.	Найти сумму чисел от 1 до А

Console.Write("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());

int s = (a * (a + 1)) / 2;

Console.WriteLine("Сумма чисел от 1 до " + a + " равна " + s);
