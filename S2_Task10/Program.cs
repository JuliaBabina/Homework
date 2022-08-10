// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();

Console.WriteLine("Enter a three-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (Math.Abs(num) / 100 > 0 && Math.Abs(num) / 100 < 10)
{
    int firstDigit = Math.Abs(num / 10);
    int secondDigit = Math.Abs(firstDigit % 10);

    Console.Write(secondDigit);
}
else
{
    Console.Write("It's not a three-digit number!");
}