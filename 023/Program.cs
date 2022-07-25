// 023.	Найти расстояние между точками в пространстве 2D

double Distance(double x1, double y1, double x2, double y2)
{
    double d;
    d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Sqrt(Math.Pow(y1 - y2, 2)));
    return d;
}

double x1 = 6, y1 = 2, x2 = 1, y2 = 1;

Console.WriteLine(Distance(x1, y1, x2, y2));
