Console.Clear();
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n > 999)
{
  n /= 10;
}
if (n < 100)
{
  Console.WriteLine("Нет циферки");
}
else
  Console.WriteLine(n % 10);