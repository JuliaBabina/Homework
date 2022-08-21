// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


// int[] CreateArray(int n)
// {
//     int[] array = new int[n];
//     for (int i = 0; i < n; i++)
//     {
//         array[i] = new Random().Next(100, 1000);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }


// int FindEven(int[] array)
// {
//     int evenSum = 0;

//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0)
//         {
//             evenSum++;
//         }

//     }
//     return evenSum;

// }


// Console.Clear();

// Console.WriteLine("Enter the number of array elements: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int[] myArray = CreateArray(num);
// Console.Write("Output an array: ");
// PrintArray(myArray);
// Console.WriteLine($"In this array {FindEven(myArray)} even elements");



// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


// int[] CreateArrayFL(int n, int first, int last)
// {
//     int[] array = new int[n];
//     for (int i = 0; i < n; i++)
//     {
//         array[i] = new Random().Next(first, last + 1);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int FindOddIndexSum(int[] array)
// {
//     int oddIndexSum = 0;

//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i % 2 != 0)
//         {
//             oddIndexSum += array[i];
//         }

//     }
//     return oddIndexSum;
// }

// Console.Clear();

// Console.WriteLine("Enter the number of array elements: ");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter the first number of the range: ");
// int f = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter the last number of the range: ");
// int l = Convert.ToInt32(Console.ReadLine());

// int[] ArrayArray = CreateArrayFL(num, f, l);
// Console.Write("Output an array: ");
// PrintArray(ArrayArray);
// Console.WriteLine($"The sum of the elements of this array standing in odd positions is equal to {FindOddIndexSum(ArrayArray)}");



// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76
