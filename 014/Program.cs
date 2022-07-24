// Выяснить, кратно ли число заданному, если нет, вывести остаток.

Console.Write("Введите число: ");
int a=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите делитель числа: ");
int b=Convert.ToInt32(Console.ReadLine());

if(a%b==0)
{
    Console.WriteLine("Число кратно");
}
else
{
    Console.WriteLine(a%b);
}
