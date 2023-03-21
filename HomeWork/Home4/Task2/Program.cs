Console.Clear();
Console.Write("Введите число: ");
string n = Console.ReadLine()!;
int sum = 0;
for (int i = 0; i < n.Length; i++)
    sum = sum + int.Parse(n[i].ToString());
Console.WriteLine(sum);