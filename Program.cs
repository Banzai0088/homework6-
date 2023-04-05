// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// int count = 0;
// int max = int.MaxValue;
// int num = 0;
// for (int i = 0; i < max; i++)
// {
//     Console.WriteLine("Введите число, если закончили введите %");
//     string number = Console.ReadLine ();
// if (number=="%")
// {
//     break;
// }
// num=Convert.ToInt32(number);

// if(num>0)
// {
//     count++;
// }
// }
// Console.WriteLine("Пользователь ввел "+count+" шт. чисел больше 0");


// // Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
 
// Console.WriteLine("Введите b1");
// double b1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите k1");
// double k1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите b2");
// double b2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите k2");
// double k2 = Convert.ToInt32(Console.ReadLine());
// double X = (b1 - b2) / (k2 - k1);
// double Y = k2* X+b2;
// Console.WriteLine("координаты точки пересечения: "+" "+"("+X+","+Y+")");