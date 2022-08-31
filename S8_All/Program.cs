// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


// int Intro(string message)
// {
//     System.Console.Write(message);
//     int result = Convert.ToInt32(Console.ReadLine());
//     return result;
// }


// int[,] FillMatrix(int lines, int columns, int first, int last)
// {
//     int[,] matrix = new int[lines, columns];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(first, last);
//         }
//     }
//     return matrix;
// }


// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]}\t");
//         }
//         Console.WriteLine();
//     }
// }


// int[,] ToMinimum(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1) - 1; j++)
//         {
//             for (int v = 0; v < matrix.GetLength(1) - 1; v++)
//             {
//                 if (matrix[i, v] < matrix[i, v + 1])
//                 {
//                     int temp = matrix[i, v];
//                     matrix[i, v] = matrix[i, v + 1];
//                     matrix[i, v + 1] = temp;
//                 }
//             }
//         }

//     }

//     return matrix;
// }


// Console.Clear();

// int line = Intro("Enter the number of lines in the array: ");
// int column = Intro("Enter the number of columns in the array: ");
// int begin = Intro("Enter the upper limit of the range: ");
// int end = Intro("Enter the lower limit of the range: ");
// int[,] matr = FillMatrix(line, column, begin, end);
// Console.WriteLine("Output a two-dimensional array: ");
// PrintMatrix(matr);
// Console.WriteLine("Output sorted two-dimensional array: ");
// ToMinimum(matr);
// PrintMatrix(matr);



//******************************************************************************************************************************



// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


// int Intro(string message)
// {
//     System.Console.Write(message);
//     int result = Convert.ToInt32(Console.ReadLine());
//     return result;
// }


// int[,] FillMatrix(int linCol, int first, int last)
// {
//     int[,] matrix = new int[linCol, linCol];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(first, last);
//         }
//     }
//     return matrix;
// }


// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]}\t");
//         }
//         Console.WriteLine();
//     }
// }

// int MaxSumLine(int[,] matrix)
// {
//     int maxSum = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             sum += matrix[i, j];

//         }

//         if (sum > maxSum)
//         {
//             maxSum = sum;

//         }
//     }
//     return maxSum;
// }


// void MinSumLine(int[,] matrix, int minSum)
// {
//     int numLine = 0;
//     Console.Write("Sums of elements by lines: ");
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             sum += matrix[i, j];

//         }
//         Console.Write(sum + " ");
//         if (sum < minSum)
//         {
//             minSum = sum;
//             numLine = i + 1;
//         }
//     }
//     Console.WriteLine();
//     Console.WriteLine($"The number of line with the smallest sum of elements - {numLine}");
// }


// Console.Clear();

// int lc = Intro("Enter the number of lines and columns in the rectangular array: ");
// int begin = Intro("Enter the upper limit of the range: ");
// int end = Intro("Enter the lower limit of the range: ");
// int[,] matr = FillMatrix(lc, begin, end);
// Console.WriteLine("Output a rectangular array: ");
// PrintMatrix(matr);
// MinSumLine(matr, MaxSumLine(matr));



//******************************************************************************************************************************



// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


// int Intro(string message)
// {
//     System.Console.Write(message);
//     int result = Convert.ToInt32(Console.ReadLine());
//     return result;
// }


// int[,] FillMatrix(int lines, int columns, int first, int last)
// {
//     int[,] matrix = new int[lines, columns];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(first, last);
//         }
//     }
//     return matrix;
// }


// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]}\t");
//         }
//         Console.WriteLine();
//     }
// }


// int[,] ProdMatrix(int[,] matrix1, int[,] matrix2)
// {
//     int[,] prodMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
//     for (int i = 0; i < matrix1.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix2.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrix2.GetLength(0); k++)
//             {
//                 prodMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
//             }
//         }
//     }

//     return prodMatrix;
// }


// Console.Clear();

// int line1 = Intro("Enter the number of lines in the first matrix: ");
// int column1 = Intro("Enter the number of columns in the first matrix: ");

// int line2 = Intro("Enter the number of lines in the second matrix: ");
// int column2 = Intro("Enter the number of columns in the second matrix ");

// if (column1 != line2)

// {
//     Console.WriteLine("The product of matrices with such indicators is impossible");
// }

// else

// {

//     int begin = Intro("Enter the upper limit of the range: ");
//     int end = Intro("Enter the lower limit of the range: ");

//     int[,] matr1 = FillMatrix(line1, column1, begin, end);
//     int[,] matr2 = FillMatrix(line2, column2, begin, end);
//     Console.WriteLine();
//     Console.WriteLine("Output first matrix: ");
//     PrintMatrix(matr1);
//     Console.WriteLine();
//     Console.WriteLine("Output second matrix: ");
//     PrintMatrix(matr2);
//     Console.WriteLine();
//     Console.WriteLine($"Product of the introduced matrices: ");
//     PrintMatrix(ProdMatrix(matr1, matr2));

// }



//******************************************************************************************************************************



// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)



// int Intro(string message)
// {
//     System.Console.Write(message);
//     int result = Convert.ToInt32(Console.ReadLine());
//     return result;
// }


// int[,,] FillMatrix(int x, int y, int z)
// {
//     int[,,] matrix = new int[x, y, z];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrix.GetLength(2); k++)
//             {
//                 matrix[i, j, k] = new Random().Next(10, 100);

//             }
//         }

//     }
//     return matrix;
// }

// void PrintMatrix(int[,,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrix.GetLength(2); k++)
//             {
//                 Console.Write($"{matrix[i, j, k]} ({i},{j},{k})\t");
//             }
//             Console.WriteLine();
//         }

//     }
// }


// Console.Clear();

// int x = Intro("Enter the the first dimension of the array: ");
// int y = Intro("Enter the the second dimension of the array: ");
// int z = Intro("Enter the the third dimension of the array: ");

// int[,,] matr = FillMatrix(x, y, x);
// Console.WriteLine("Output a three - dimensional array: ");
// PrintMatrix(matr);



//******************************************************************************************************************************



// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


// int Intro(string message)
// {
//     System.Console.Write(message);
//     int result = Convert.ToInt32(Console.ReadLine());
//     return result;
// }

// int[,] FillMatrix(int size)
// {
//     int[,] matrix = new int[size, size];
//     int num = 1;
//     int i = 0;
//     int j = 0;

//     while (num <= size * size)
//     {
//         matrix[i, j] = num;
//         if (i <= j + 1 && i + j < size - 1)
//             ++j;
//         else if (i < j && i + j >= size - 1)
//             ++i;
//         else if (i >= j && i + j > size - 1)
//             --j;
//         else
//             --i;
//         ++num;
//     }

//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]}\t");
//         }
//         Console.WriteLine();
//     }
// }




// Console.Clear();

// int lc = Intro("Enter the number of lines and columns in the rectangular array: ");
// int[,] matr = FillMatrix(lc);
// Console.WriteLine("Output 4x4 spiral array: ");
// PrintMatrix(matr);





