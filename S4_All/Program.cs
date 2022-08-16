// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


// Console.Clear();

// Console.WriteLine("Enter a number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter the degree, to which you want to raise the number: ");
// int degree = Convert.ToInt32(Console.ReadLine());

// int res = 1;

// for (int i = 1; i <= degree; i++)
// {
//     res = res * number;
// }

// Console.WriteLine($"{number} in a {degree} degree = {res}");





// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


// int AllNumSum(int number)
// {
//     int sum = 0;
//     while (number > 0)
//     {
//         sum = sum + number % 10;
//         number = number / 10;
//     }

//     return sum;
// }

// Console.Clear();
// Console.Write("Enter a number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"The sum of the digits of the number {num} = {AllNumSum(num)}");





// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// 1 вариант c функциями

// int[] ArrayCreation(int n)
// {
//     int[] someArray = new int[n];

//     for (int i = 0; i < n; i++)
//     {
//         someArray[i] = new Random().Next(-1000, 1001);

//     }
//     return someArray;
// }


// void ArrayPrint(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr[i] + " ");
//     }
// }

// Console.Clear();
// int size = 8;
// Console.Write("Array created: ");

// ArrayPrint(ArrayCreation(size));


// 2 вариант без функций


// Console.Clear();
// int[] array = new int[8];
// Console.Write("Array created: ");

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(-1000, 1000);
//     Console.Write(array[i] + " ");
// }

