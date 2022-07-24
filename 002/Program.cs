// 002. По двум заданным числам проверять является ли первое квадратом второго

double a,b;
string? s=Console.ReadLine();
a=Convert.ToDouble(s);
s=Console.ReadLine();
b=Convert.ToDouble(s);

if(a*a==b)
{
    Console.WriteLine($"b={b} is sqare a={a}");
}
else
{
    Console.WriteLine($"b={b} is't sqare a={a}");
}

if(a==b*b)
{
    Console.WriteLine($"a={a} is sqare b={b}");
}
else
{
    Console.WriteLine($"a={a} is't sqare b={b}");
}
