// 017.	Дано число обозначающее день недели. Выяснить является номер дня недели выходным

Console.Write("Введите номер дня недели: ");
int a=Convert.ToInt32(Console.ReadLine());

if(a>=1 && a<=5)
{
    Console.WriteLine("Будний день");
}
else if(a>=6 && a<=7)
{
    Console.WriteLine("Выходной день");
}
else
{
    Console.WriteLine("Неверно введено число");
}
