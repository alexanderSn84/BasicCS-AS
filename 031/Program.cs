// 031.	Показать кубы чисел, заканчивающихся на четную цифру

Console.Write("Введите число: ");

int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Число" + "\t" + "Куб");

int i = 1;

while (i <= a)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i + "\t" + Math.Pow(Convert.ToDouble(i), 3));
    }
    i++;
}
