// 25.	Вывести на экран кубы чисел от 1 до N

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Число" + "\t" + "Куб");

int i = 1;

while (i <= a)
{
    Console.WriteLine(i + "\t" + Math.Pow(Convert.ToDouble(i), 3));
    i++;
}
