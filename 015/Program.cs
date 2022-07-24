// 015. Найти третью цифру числа или сообщить, что её нет

Console.Write("Введите число: ");

//Максимальная длина числа 9
int a=Convert.ToInt32(Console.ReadLine());
int i=1;
int n;
int k;

a=Math.Abs(a); //если отрицательное число

if(a>100)
{
    while(a>i)
    {
        i=i*10;
    }

    n=i/100; //до третьей цифры
    k=i/1000; //после третьей цифры
    
    int b=(a%n)/k;
    Console.WriteLine($"Третья цифра: {b}");
}
else if(a==100)
{
    Console.WriteLine("Третья цифра: 0");
}
else
{
    Console.WriteLine("Нет третьей цифры");
}
