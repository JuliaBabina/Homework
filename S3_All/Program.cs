// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.Clear();

// Console.WriteLine("Enter a five-digit number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number / 10000 > 0 && number / 10000 < 10)
// {
//     if (number / 10000 == number % 10 && number / 1000 % 10 == number / 10 % 10)
//     {
//         Console.Write("This is a palindrome");
//     }

//     else
//     {
//         Console.Write("It's not a palindrome");
//     }
// }

// else
// {
//     Console.Write("It's not a five-digit number");
// }


// ********************************************************************************************************


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.Clear();

// Console.Write("Enter x1: ");
// int x1 = int.Parse(Console.ReadLine());

// Console.Write("Enter y1: ");
// int y1 = int.Parse(Console.ReadLine());

// Console.Write("Enter z1: ");
// int z1 = int.Parse(Console.ReadLine());

// Console.Write("Enter x2: ");
// int x2 = int.Parse(Console.ReadLine());

// Console.Write("Enter y2: ");
// int y2 = int.Parse(Console.ReadLine());

// Console.Write("Enter z2: ");
// int z2 = int.Parse(Console.ReadLine());


// double distance = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));

// Console.Write($"The distance between the points is equal to {distance:f2}");


// ********************************************************************************************************


// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.Clear();

// Console.WriteLine("Enter a number: ");
// int n = Convert.ToInt32(Console.ReadLine());
// double cube = 1;
// int number = 1;

// Console.Write($"These are cubes of numbers from 1 to {n}: ");

// while (number <= n)
// {
//     cube = Math.Pow(number, 3);
//     Console.Write(cube + " ");
//     number++;
// }
