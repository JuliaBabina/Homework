﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.Clear();

Console.WriteLine("Введите первое число: ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите первое число: ");
int numB = Convert.ToInt32(Console.ReadLine());

if (numA > numB)

    Console.Write(numA + " больше " + numB);

else

   if (numA == numB)

    Console.Write("Веденные числа равны");


else
    Console.Write(numA + " меньше " + numB);





