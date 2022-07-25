// 016.	Дано число. Проверить кратно ли оно 7 и 23

int a=Convert.ToInt32(Console.ReadLine()); // 7*23=161
bool b=a%7==0 && a%23==0;

if(b)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine("Не кратно");
}
