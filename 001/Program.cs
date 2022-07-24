// 001. Вывести квадрат числа

//Ввести с клавиатуры целое число и вывести квадрат этого числа на экран
int a,b;
string? s;
s=Console.ReadLine();
a=Convert.ToInt32(s);
b=a*a;
Console.WriteLine($"{a}^2={b}");

//Ввести с клавиатуры число и вывести квадрат этого числа на экран
double c,d;
string? s1;
s1=Console.ReadLine();
c=Convert.ToDouble(s1);
d=c*c;
Console.WriteLine($"{c}^2={d}");
