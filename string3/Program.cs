// string3. С клавиатуры вводится строка разделенная точкой. 
// Подсчитать количество символов до точки.

string? text = Console.ReadLine();
int beforePoints = 0;
for (int i = 0; text![i] != '.'; i++) beforePoints += 1;
Console.WriteLine(beforePoints);




// string? text = Console.ReadLine();
// int beforePoints = text!.IndexOf('.');
// Console.WriteLine(beforePoints);