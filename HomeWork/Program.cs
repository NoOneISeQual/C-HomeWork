// # Task 1

Console.Clear();
Console.WriteLine("Введите 1 число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число: ");
int m = Convert.ToInt32(Console.ReadLine());
if (n > m)
  Console.WriteLine(n);
else
  Console.WriteLine(m);