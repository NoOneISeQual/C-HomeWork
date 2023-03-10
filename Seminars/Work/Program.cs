// Ввод чисел

// Console.Clear(); // очистка консоли
// int n = Convert.ToInt32(Console.ReadLine());
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine(n * 3);
// ctrl + / - комментирование и раскомментирование
/*
программный код
Hello, world!
*/

// Необходимо спросить у пользователя 2 числа и узнать, какое из них наибольшее.
// 1 > 2
// 2 > 1
// 1 = 2
// Console.Clear();
// Console.Write("Введите 1-ое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите 2-ое число: ");
// int b = Convert.ToInt32(Console.ReadLine());
// // Интерполяция строк
// // Console.WriteLine($"Результат {a} + {b} = {a + b}");
// // Console.WriteLine("Результат " + a + " + " + b + " = " + (a + b));
// // Console.WriteLine(a > b);
// if (a > b) 
//     Console.WriteLine(a);
// else if (a < b)
//     Console.WriteLine(b);
// else
//     Console.WriteLine("=");

// for (begin; end; step)
// i++ <=> i = i + 1
// for(int i = 1; i <= 10; i++) // 1 2 3 4 5 6 7 8 9 10 
//     Console.Write($"{i} ");
// Console.WriteLine();
// for(int i = 1; i <= 10; i+=2) // 1 3 5 7 9
//     Console.Write($"{i} ");
// Console.WriteLine();
// for(int i = 10; i > 0; i--) // 10 9 8 7 6 5 4 3 2 1
//     Console.Write($"{i} ");

// Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное 
// на само себя).

// Например:
// 4  -> 16 
// -3 -> 9 
// -7 -> 49

// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine(n * n);

// Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет

//моя

// Console.Clear();
// Console.Write("Введите 1-ое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите 2-ое число: ");
// int b = Convert.ToInt32(Console.ReadLine());
//   if (a * a == b)
//       Console.WriteLine("True");
//   else
//       Console.WriteLine("False");

//Учителя

// Console.Clear();
// Console.Write("Введите 1-ое число: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.Write("Введите 2-ое число: ");
// int m = int.Parse(Console.ReadLine()!);
// if (m * m == n)
//     Console.WriteLine("да");
// else
//     Console.WriteLine("нет");


// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница

// Console.Clear();
// Console.Write("Введите день недели(от 1 до 7): ");
// int n = Convert.ToInt32(Console.ReadLine());
// while (n < 1 || n > 7)
// {
//     Console.Write("Вы ошиблись!\nВведите день недели(от 1 до 7): ");
//     n = Convert.ToInt32(Console.ReadLine());
// }
// if (n == 1)
//     Console.WriteLine("Понедельник");
// else if (n == 2)
//     Console.WriteLine("Вторник");
// else if (n == 3)
//     Console.WriteLine("Среда");
// else if (n == 4)
//     Console.WriteLine("Четверг");
// else if (n == 5)
//     Console.WriteLine("Пятница");
// else if (n == 6)
//     Console.WriteLine("Суббота");
// else
//     Console.WriteLine("Воскресенье");

// Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
//  for(int i = -n; i <= n; i++)
//      Console.Write($"{i} ");

//Учитель

// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine()), i = (-1) * n;
// // for (int i = (-1) * n; i <= n; i++)
// //     Console.Write($"{i} ");
// while (i <= n)
// {
//     Console.Write($"{i} ");
//     i++;
// }

// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine()), i = (-1) * n;
// n = Math.Abs(n); // модуль числа
// // for (int i = (-1) * n; i <= n; i++)
// //     Console.Write($"{i} ");
// while (i <= n)
// {
//     Console.Write($"{i} ");
//     i++;
// }

// Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 	456 -> 6
// 	782 -> 2
// 	918 -> 8

// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(n % 10);

Console.Clear();
int n = new Random().Next(10, 100);
Console.WriteLine($"Случайное сгенерированное число {n}");
int n1 = n / 10;
int n2 = n % 10;
if (n1 > n2)
  Console.WriteLine(n1);
else
  Console.WriteLine(n2);