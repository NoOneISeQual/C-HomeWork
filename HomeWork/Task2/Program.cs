Console.Clear();
Console.WriteLine("Введите 1е число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2е число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3е число: ");
int n2 = Convert.ToInt32(Console.ReadLine());
if (n > n1 && n > n2)
  Console.WriteLine(n);
else if (n1 > n && n1 > n2)
  Console.WriteLine(n1);
else if (n2 > n && n2 > n1)
  Console.WriteLine(n2);