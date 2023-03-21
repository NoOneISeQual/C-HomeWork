Console.Write("Введите A: ");
double A = Convert.ToDouble(Console.ReadLine()),
count = 1;
Console.Write("Введите B: ");
int B = Convert.ToInt32(Console.ReadLine());
 for (int i = 0; i < B; i++)
{
count *= A;
}
Console.WriteLine(count);