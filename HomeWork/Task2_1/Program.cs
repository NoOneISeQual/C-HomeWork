Console.Clear();
Console.WriteLine("Введите трехзначное число ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 100 || n >= 1000)
{
  Console.WriteLine("Вы ввели не трехзначное число");
}
else
  Console.WriteLine(n / 10 % 10);