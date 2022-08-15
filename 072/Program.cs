// 72.	Написать программу возведения числа А в целую степень B

int A = Convert.ToInt32(System.Console.ReadLine());
int B = Convert.ToInt32(System.Console.ReadLine());
int Pow1(int A, int B)
{
    if (B == 0) return 1;
    else return Pow1(A, B - 1) * A;
}
System.Console.WriteLine(Pow1(A, B));