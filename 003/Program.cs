// 003. Даны два числа. Показать большее и меньшее число

int a;
int b;
Console.Write("Введите первое число: ");
a=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
b=Convert.ToInt32(Console.ReadLine());
if(a>b)
{
    Console.WriteLine($"{a} > {b}");
}
else
{
    Console.WriteLine($"{a} < {b}");
}