// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// int[] CreateArray()
// {
//     Console.WriteLine("Enter the number of array elements: ");
//     int m = Convert.ToInt32(Console.ReadLine());
//     int[] array = new int[m];
//     for (int i = 0; i < m; i++)
//     {
//         Console.WriteLine($"Enter {i + 1} array element: ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     Console.Write("Output an array: ");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }


// int FindAboveZero(int[] array)
// {
//     int sum = 0;

//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0)
//         {
//             sum++;
//         }

//     }
//     return sum;

// }

// Console.Clear();
// int[] myArray = CreateArray();
// PrintArray(myArray);

// if (FindAboveZero(myArray) == 0)
// {
//     Console.WriteLine("There are no numbers greater than zero in this array");
// }

// else
// {
//     Console.WriteLine($"In this array {FindAboveZero(myArray)} greater than zero element(s)");
// }



// ***************************************************************************************************************



// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Console.Clear();

// Console.WriteLine("Две прямые заданы уравнениями y = k1 * x + b1, y = k2 * x + b2");
// Console.WriteLine("Чтобы найти точку их пересечения, введите следующие значения: ");
// Console.WriteLine("b1: ");
// double b1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("k1: ");
// double k1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("b2: ");
// double b2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("k2: ");
// double k2 = Convert.ToInt32(Console.ReadLine());

// if (k1 == k2 && b1 == b2)
// {
//     Console.WriteLine("Прямые совпадают");
// }

// else
// {

//     if (k1 == k2 && b1 != b2)
//     {
//         Console.WriteLine("Прямые параллельны и не имеют пересечений");
//     }

//     else
//     {
//         double x = (b2 - b1) / (k1 - k2);
//         double y = k1 * x + b1;
//         Console.WriteLine($"Координаты точки пересечения двух прямых: ({Math.Round(x, 1)}; {Math.Round(y, 1)})");
//     }

// }



// ***************************************************************************************************************



// Дополнительно (на оценку не влияют):

// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// int GetSize(int number)
// {

//     int size = 1;
//     while (number / 2 >= 1)
//     {
//         number = number / 2;
//         size++;
//     }

//     return size;
// }


// void FillArray(int[] arr)
// {
//     Console.WriteLine("Повторите ввод: ");
//     int number = Convert.ToInt32(Console.ReadLine());
//     int i = 1;
//     arr[0] = number % 2;

//     while (number / 2 >= 1 && i < arr.Length)
//     {
//         arr[i] = number / 2 % 2;
//         number = number / 2;
//         i++;
//     }
// }


// void FlipArray(int[] arr)
// {
//     int i = 0;
//     while (i < arr.Length/2)

//     {
//         int temp = arr[i];
//         arr[i] = arr[arr.Length - i - 1];
//         arr[arr.Length - i - 1] = temp;
//         i++;

//     }
//     Console.WriteLine(string.Join("", arr));
// }


// Console.Clear();
// Console.WriteLine("Введите десятичное число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int[] meArray = new int[GetSize(number)];
// FillArray(meArray);
// Console.Write($"Десятичное число {number} в двоичном фомате: ");
// FlipArray(meArray);



// ***************************************************************************************************************



// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8




// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
