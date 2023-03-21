Console.Clear();
Console.Write("Введите число А: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите число B: ");
int m = int.Parse(Console.ReadLine()!);
for (int i = 0; i <= m; i++ )
{
    n*=n;
}
Console.WriteLine(n);