
// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

// Console.Clear();
// Console.Write("Enter number M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter number N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"All natural numbers from {m} to {n}:");
// Console.WriteLine(PrintNumbers(m, n));

// string PrintNumbers(int start, int end)
// {
//     if (start == end) return start.ToString();
//     return (start + " " + PrintNumbers(start + 1, end));
// }



//**********************************************************************************************************************



// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.Clear();
// Console.Write("Enter number M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter number N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"The sum of natural numbers from {m} to {n} is {SumNumbers(m, n)}");


// int SumNumbers(int start, int end)
// {
//     if (start == end) return start;
//     return (start + SumNumbers(start + 1, end));
// }



//**********************************************************************************************************************



// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


// Console.Clear();
// Console.Write("Enter non-negative number M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter non-negative number N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"A({m},{n}) = {AckFunc(m, n)}");


// int AckFunc(int num1, int num2)
// {
//     if (num1 == 0)
//     {
//         return num2 + 1;
//     }


//     if (num1 > 0 && num2 == 0)
//     {
//         return AckFunc(num1 - 1, 1);
//     }


//     if (num1 > 0 && num2 > 0) ;
//     {
//         return AckFunc(num1 - 1, AckFunc(num1, num2 - 1));
//     }


// }