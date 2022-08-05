// Дополнительные задания (на оценку не влияют):
// Задача 7: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.Clear();

Console.WriteLine("Введите трёхзназное число: ");
int num = int.Parse(Console.ReadLine());
int lastNumber = num % 10;

if (num / 100 > 0 & num / 100 < 10)
{
    Console.Write("Последняя цифра - ");
    Console.WriteLine(lastNumber);
}

else
    Console.Write("Вы ввели не трёхзначное число");