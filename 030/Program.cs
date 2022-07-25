// 030.	Написать программу вычисления произведения чисел от 1 до N

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

int fact(int num)
{
    int i = 1;
    int b = 1;
    while (i <= num)
    {
        b *= i;
        i++;
    }
    return b;
}

Console.WriteLine($"{a}! = {fact(a)}");
