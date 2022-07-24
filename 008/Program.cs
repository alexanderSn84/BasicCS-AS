// 008. Показать числа от -N до N
int a;
int b;
int razn;
int i=0;
Console.Write("Введите первое число: ");
a=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
b=Convert.ToInt32(Console.ReadLine());
if(a>b)
{
    razn=a-b;
    while(i<=razn)
    {
        Console.Write($"{b+i} ");
        i=i+1;
    }
}
else
{
    razn=b-a;
    while(i<=razn)
    {
        Console.Write($"{a+i} ");
        i=i+1;
    }
}
