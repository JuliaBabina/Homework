// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9



// int IntroInt(string message)
// {
//     System.Console.Write(message);
//     int result = Convert.ToInt32(Console.ReadLine());
//     return result;
// }

// double IntroDouble(string message)
// {
//     System.Console.Write(message);
//     double result = Convert.ToDouble(Console.ReadLine());
//     return result;
// }

// double[,] FillMatrix(int lines, int columns, double first, double last)
// {
//     double[,] matrix = new double[lines, columns];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().NextDouble() * (last - first) + first;
//         }
//     }
//     return matrix;
// }


// void PrintMatrix(double[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{Math.Round(matrix[i, j], 1)}\t");
//         }
//         Console.WriteLine();
//     }
// }

// Console.Clear();

// int line = IntroInt("Enter the number of lines in the array: ");
// int column = IntroInt("Enter the number of columns in the array: ");
// double begin = IntroDouble("Enter the upper limit of the range: ");
// double end = IntroDouble("Enter the lower limit of the range: ");
// double[,] matr = FillMatrix(line, column, begin, end);
// Console.WriteLine("Output a two-dimensional array filled with random real numbers: ");
// PrintMatrix(matr);



//*******************************************************************************************************



// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


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


// void FindElement(int[,] matrix, int lin, int col)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (i == lin - 1 && j == col - 1)
//             {
//                 Console.WriteLine($"At the specified position there is a number {matrix[i, j]}");
//                 return;
//             }

//         }

//     }

//     Console.WriteLine($"There are no number at the specified position");
// }

// Console.Clear();

// int line = Intro("Enter the number of lines in the array: ");
// int column = Intro("Enter the number of columns in the array: ");
// int begin = Intro("Enter the upper limit of the range: ");
// int end = Intro("Enter the lower limit of the range: ");
// int[,] matr = FillMatrix(line, column, begin, end);
// Console.WriteLine("Output a two-dimensional array: ");
// PrintMatrix(matr);

// int x = Intro("Enter the line in the array: ");
// int y = Intro("Enter the column in the array: ");
// FindElement(matr, x, y);



//*******************************************************************************************************



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int Intro(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}


int[,] FillMatrix(int lines, int columns, int first, int last)
{
    int[,] matrix = new int[lines, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(first, last);
        }
    }
    return matrix;
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}


double Average(int[,] matrix)
{
    averageSum = 0;
    double [] average  = new int[];
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            averageSum += matrix[i, j];
        }
    }
    return matrix;

}

Console.Clear();

int line = Intro("Enter the number of lines in the array: ");
int column = Intro("Enter the number of columns in the array: ");
int begin = Intro("Enter the upper limit of the range: ");
int end = Intro("Enter the lower limit of the range: ");
int[,] matr = FillMatrix(line, column, begin, end);
Console.WriteLine("Output a two-dimensional array: ");
PrintMatrix(matr);

Console.WriteLine("The arithmetic mean of each column in the array ");
Average(matr);