// 024.	Вывести на экран таблицу квадратов чисел от 1 до N

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

int i = 1;

while (i <= a)
{
    Console.WriteLine($"{i} ^ 2 = {Math.Pow(Convert.ToDouble(i), 2)}");
    i++;
}
