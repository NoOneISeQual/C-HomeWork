// Console.Clear();
// int N = new Random().Next(1,100);


Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
for(int i = 2; i<= n; i = i + 2)
  Console.WriteLine(i);