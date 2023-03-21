Console.Write("Введите A: ");
double A = Convert.ToDouble(Console.ReadLine());
double n = 1;
Console.Write("Введите B: ");
int B = Convert.ToInt32(Console.ReadLine());
 for (int i = 0; i < B; i++)
{
n *= A;
}
Console.WriteLine(n);