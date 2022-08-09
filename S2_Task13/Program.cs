// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.Clear();

Console.WriteLine("Enter a number: ");
string numSeq = Convert.ToString(Console.ReadLine());
if (numSeq.Length > 2 )
{
    Console.Write("Third digit: " + numSeq[2]);
}

else
{
    Console.Write("This number does not have a third digit");
}


