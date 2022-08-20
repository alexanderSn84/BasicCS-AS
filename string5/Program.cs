// string5. Определить являются ли введенные с клавиатуры символы 
// правильно записью целого числа. Вычислить сумму цифр введенного числа.


string? s = Console.ReadLine();
int sum = 0;
for (int i = 0; i < s!.Length; i++)
{
    if (char.IsDigit(s[i])) sum += (int)(char.GetNumericValue(s[i]));
    else
    {
        Console.WriteLine("Не является верной записью целого числа");
        return;
    }
}
Console.WriteLine($"Сумма цифр числа \t {sum}");
