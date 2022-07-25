// 027.	Возведите число А в натуральную степень B используя цикл

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень числа: ");
int b = Convert.ToInt32(Console.ReadLine());

int i = 1;
int st = 1;

while (i <= b)
{
    st *= a;
    i++;
}

Console.WriteLine($"{a} ^ {b} = {st}");
