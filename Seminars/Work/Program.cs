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

//# Семинар 2

// Найти большее число из рандомных чисел

// Console.Clear();
// int n = new Random().Next(10, 100);
// Console.WriteLine($"Случайное сгенерированное число {n}");
// int n1 = n / 10;
// int n2 = n % 10;
// if (n1 > n2)
//   Console.WriteLine(n1);
// else
//   Console.WriteLine(n2);

// Выводит случайное трехзначное число и удаляет вторую цифру

// Console.Clear();
// int n = new Random().Next(10, 1000);
// Console.WriteLine($"Случайное сгенерированное число {n}");
// int n1 = n / 100;
// int n2 = n % 10;
// int n3 = n1 * 10 + n2;
// // Либо Console.WriteLine(n3 = n1 * 10 + n2);
// Console.WriteLine(n3);

// на входе два числа. выводит кратно ли второе число первому.если нет, то выводит остаток.

// Console.Clear();
// Console.Write("Введите 1-ое число: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.Write("Введите 2-ое число: ");
// int m = int.Parse(Console.ReadLine()!);
// if (n % m == 0)
//   Console.WriteLine ("Кратно");
// else
//   Console.WriteLine ($"не кратно, остаток {n % m}");

// принимает число и проверяет, кратно ли оно одновременно 7 и 23.

// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// if (n % 161 == 0)
//     Console.WriteLine("yes");
// else
//     Console.WriteLine("no");

// // || - или
// // && - и

// принимает на вход два числа и проверяет,  является ли одно число квадратом второго(1 квадрат 2 и наоборот)

// Console.Clear();
// Console.Write("Введите число 1: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число 2: ");
// int m = int.Parse(Console.ReadLine()!);
// if (n * n == m || m * m == n)
//   Console.WriteLine("Да");
// else
//   Console.WriteLine("Нет");

//# Seminar 3

// Console.Clear();
// string s = Console.ReadLine()!;
// char n = '6';
// Console.WriteLine(Convert.ToInt32(s[0].ToString()) * 10);

//Напишите программу, которая будет находить сумму цифр числа
// Console.Clear();
// string s = Console.ReadLine()!;
// int sum = 0;
// for (int i = 0 ; i < s.Length; i++)
//   sum = sum + int.Parse(s[i].ToString());
// Console.WriteLine(sum);

// Console.Clear();
// string s = Console.ReadLine()!;
// int sum = 0;
// // Напишите программу, которая будет находить сумму цифр числа
// for (int i = 0; i < s.Length; i++)
//     sum = sum + int.Parse(s[i].ToString());
// Console.WriteLine(sum);

//  принимает на ввод х;у , не равные 0 и выдает номер четверти в которой находится точка.
// Console.Clear();
// Console.Write("Введите координату X: ");
// double x = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату Y: ");
// double y = Convert.ToDouble(Console.ReadLine());
// while (x == 0)
// {
//     Console.Write("Вы ошиблись!\nВведите координату X: ");
//     x = Convert.ToDouble(Console.ReadLine());
// }
// while (y == 0)
// {
//     Console.Write("Вы ошиблись!\nВведите координату Y: ");
//     y = Convert.ToDouble(Console.ReadLine());
// }
// if (x > 0 && y > 0)
//     Console.WriteLine("I");
// else if (x < 0 && y > 0)
//     Console.WriteLine("II");
// else if (x < 0 && y < 0)
//     Console.WriteLine("III");
// else
//     Console.WriteLine("IV");

// программа, которая по заданному номеру четверти, выдает диапазон возможных координат
// Console.Clear();
// Console.Write("Введите номер четверти: ");
// int n = int.Parse(Console.ReadLine()!);
// while (n < 1 || n > 4)
// {
//     Console.Write("Вы ошиблись!\nВведите номер четверти: ");
//     n = int.Parse(Console.ReadLine()!);
// }
// if (n == 1)
//     Console.WriteLine("x > 0 and y > 0");
// else if (n == 2)
//     Console.WriteLine("x < 0 and y > 0");
// else if (n == 3)
//     Console.WriteLine("x < 0 and y < 0");
// else
//     Console.WriteLine("x > 0 and y < 0");

// Принимает координаты двух точек и находит расстояние между точками в 2D пространстве
// Console.Clear();
// Console.Write("Введите координату X(1): ");
// double x1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату Y(1): ");
// double y1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату X(2): ");
// double x2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату Y(2): ");
// double y2 = Convert.ToDouble(Console.ReadLine());
// double s = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y2 - y1, 2));
// Console.WriteLine($"Расстояние между двумя точками равно {Math.Round(s, 2)}");

// принимает число (N)  и выдает таблицу квадратов от 1 до N
// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// for (int i = 1; i <= n; i++)
//     Console.WriteLine($"{i} ^ 2 = {i * i}");

//# Семинар 4

// Создание массива

// join -соединить с помощью элементов
// string -строка
// Split - ввод нескольких элементов в одну строку
// array - массив


// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int [] array = new int[n];
// for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(1, 11); // 1-10
// Console.WriteLine($"[{string.Join(", ", array)}]");

//программа, которая принимает на вход число(А) и выдает сумму чисел от 1 до а

// Console.Clear();
// Console.Write("Введите число: ");
// double n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Результат {(1 + n) / 2 * n}");

// программа принимающая число и выдает кол -во цифр в числе
// запрещено использовать .Length

// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine()), count = 0;
// while (n != 0)
// {
//     count++;
//     n = n / 10; // n /= 10
// }
// Console.WriteLine(count);

// второй вариант с кол-вом разрядов

// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine()), count = 1;
// int i = 0;
// while (count <= n)
// {
//     i++;
//     count *= 10;
// }
// Console.WriteLine(i);

// программа с факториалом
// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine()), count = 1;
// for (int i = 2; i <= n; i++)
//     count = count * i;
// Console.WriteLine(count);


// Случайные дробные числа
// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// double[] array = new double[n];
// // ... = new Random.NextDouble() * (end - begin) + begin;
// for (int i = 0; i < array.Length; i++)
//     array[i] = Math.Round(new Random().NextDouble() * (30 - 10) + 10, 2);
// Console.WriteLine($"[{string.Join(", ", array)}]");

// не понял про (30-10)

// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// double[] array = new double[n];
// // ... = new Random.NextDouble() * (end - begin) + begin;
// for (int i = 0; i < array.Length; i++)
//     array[i] = Math.Round(new Random().NextDouble() * 20 + 10, 2);
// Console.WriteLine($"[{string.Join(", ", array)}]");

//#Seminar 5
//домашнее задание 19 задача
// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// while (n < 10000 || n > 99999)
// {
//     Console.Write("Вы ошиблись!\nВведите число: ");
//     n = int.Parse(Console.ReadLine()!);
// }
// int n1 = n / 10000;
// int n2 = (n / 1000) % 10;
// int n4 = (n % 100) / 10;
// int n5 = n % 10;
// if (n1 == n5 && n2 == n4)
//     Console.WriteLine("yes");
// else
//     Console.WriteLine("no");

// или

// Console.Clear();
// Console.Write("Введите число: ");
// string n = Console.ReadLine()!;
// while (n.Length != 5)
// {
//     Console.Write("Вы ошиблись!\nВведите число: ");
//     n = Console.ReadLine()!;
// }
// if (n[0] == n[4] && n[1] == n[3])
//     Console.WriteLine("yes");
// else
//     Console.WriteLine("no");

// задача- сбор черники(доп задание)

// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = int.Parse(Console.ReadLine()!);
// int[] array = new int[n];
// for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(1, 11); // [1, 10]
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// int max = 0;
// for (int i = 1; i < array.Length - 1; i++)
// {
//     if (max < array[i - 1] + array[i] + array[i + 1])
//         max = array[i - 1] + array[i] + array[i + 1];
// }
// if (max < array[array.Length - 1] + array[array.Length - 2] + array[0])
//     max = array[array.Length - 1] + array[array.Length - 2] + array[0];

// if (max < array[array.Length - 1] + array[0] + array[1])
//     max = array[array.Length - 1] + array[0] + array[1];
// Console.WriteLine(max);

// Процедуры

// void f(ref int a)
// {
//     a = a + 10;
// }

// Console.Clear();
// int n = 5;
// f(ref n);
// Console.WriteLine(n);

// void f(int[] a)
// {
//     a[0] += 100;
// }

// Console.Clear();
// int[] array = {1, 2, 3, 4, 5};
// f(array);
// Console.WriteLine(string.Join(" ", array));

//Функции
// Напишите программу, которая принимает 2 числа и возвращает максимальное
// int maxNumbers(int a, int b)
// {
//     if (a > b)
//         return a;
//     return b;
// }

// Console.Clear();
// int n = 10, m = 70;
// int result = maxNumbers(n, m);
// Console.WriteLine(result);

// Создать массив на 12 элементов и вывести сумму положительных и отрицательных чисел

// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-9, 10); // [-9; 9]
// }

// int SumPositiveNumbers(int[] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0)
//             sum += array[i]; // sum = sum + array[i]
//     }
//     return sum;
// }

// int SumNegativeNumbers(int[] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] < 0)
//             sum += array[i]; // sum = sum + array[i]
//     }
//     return sum;
// }


// Console.Clear();
// // Console.Write("Введите кол-во элементов в массиве: ");
// // int n = int.Parse(Console.ReadLine()!);
// int[] array = new int[12];
// InputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// Console.WriteLine($"Сумма положительных элементов равна {SumPositiveNumbers(array)}");
// Console.WriteLine($"Сумма отрицательных элементов равна {SumNegativeNumbers(array)}");

// Замена чисел с положительных на отрицательные

// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-9, 10); // [-9; 9]
// }

// void ChangeArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] *= (-1);
// }

// Console.Clear();
// Console.Write("Введите кол-во элементов в массиве: ");
// int n = int.Parse(Console.ReadLine()!);
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// ChangeArray(array);
// Console.WriteLine($"Конечный массив: [{string.Join(", ", array)}]");


// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-9, 10); // [-9; 9]
// }

// string SearchNumberInArray(int[] array, int number)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == number)
//             return "yes";
//     }
//     return "no";
// }

// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// не работает
// Console.Clear();
// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-100, 100); // [-9; 9]
// }
// int Search(int[] array)

// {
//     int numbers = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] >= 10 && array[i] <= 99)
//         numbers++;
//     }
//     return numbers;
// }

// Console.Clear();
// // Console.Write("Введите кол-во элементов в массиве: ");
// // int n = int.Parse(Console.ReadLine()!);
// int[] array = new int[123];
// InputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// int k = int.Parse(Console.ReadLine()!);
// Console.WriteLine(Search(array));

// вот оно

// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-100, 101); // [-9; 9]
// }


// int Q (int[] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] <= 99 && array[i] >= 10)
//             sum++;
//     }
//     return sum;
// }

// или

// Console.Clear();
// int[] array = new int[123];
// InputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// Console.WriteLine(Q(array));

// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-100, 101); // [-100; 100]
// }

// int CountNumbers(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//        if (array[i] >= 10 && array[i] <= 99)
//             count++;
//     }
//     return count;
// }

// Console.Clear();
// Console.Write("Введите кол-во элементов в массиве: ");
// int[] array = new int[123];
// InputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// Console.WriteLine(CountNumbers(array));

// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(1, 11); // [1, 10]
// }

// void ProizvedenieElements(int[] array)
// {
//     for (int i = 0; i < array.Length / 2 + array.Length % 2; i++)
//         Console.Write($"{array[i] * array[array.Length - 1 - i]} ");
// }

// Console.Clear();
// Console.Write("Введите кол-во элементов в массиве: ");
// int n = int.Parse(Console.ReadLine()!);
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// ProizvedenieElements(array);