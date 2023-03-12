Console.Clear();
Console.WriteLine("Введите день недели(от 1 до 7): ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 1 || n > 7)
{
  Console.WriteLine("Вы ошиблись! повторите попытку");
}
else if (n == 6 || n == 7)
{
  Console.WriteLine("Выходной");
}
else
  Console.WriteLine("Будний день");