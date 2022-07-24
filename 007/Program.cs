// 007. Выяснить является ли число чётным

Console.Write("Введите число: ");
int a=Convert.ToInt32(Console.ReadLine());

if(a%2==0) //Деление с остатком
{
    Console.WriteLine("Число является чётным");
}
else
{
    Console.WriteLine("Число нечётное");
}
