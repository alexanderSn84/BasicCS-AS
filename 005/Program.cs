// 005. Найти максимальное из трех чисел

int a;
int b;
int c;
Console.Write("Введите первое число: ");
a=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
b=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
c=Convert.ToInt32(Console.ReadLine());

if((a>=b) && (a>=c))
{
    Console.WriteLine($"max = {a}");
}
else if((a<=b) && (b>=c))
{
    Console.WriteLine($"max = {b}");
}
else
{
    Console.WriteLine($"max = {c}");
}
