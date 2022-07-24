// 006. Написать программу вычисления значения функции y = f(a)

Console.Write("Введите число: ");
int a=Convert.ToInt32(Console.ReadLine());
int y;

if(a>0)
{
    y=a*a+3;
}
else
{
    if(a==0)
    {
        y=0;
    }
    else
    {
        y=Math.Abs(a);
    }
}

Console.WriteLine($"y = {y}");
