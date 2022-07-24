// 010. Показать последнюю цифру трёхзначного числа

Console.Write("Введите число: ");
int a=Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Последняя цифра: {a%10}"); //Деление с остатком
