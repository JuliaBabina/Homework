// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


// Option №1 (не работает с отрицательными и с числом с первым нулем)

// Коммент от преподавателя:
// Нет необходимости конвертировать в строку введенную пользователем информацию. Метод ReadLine по умолчанию принимает ввод в качестве строки.
// Вы работаете со строкой. А где гарантия, что пользователь ввёл число? 
// Надо было хотя бы попробовать конвертировать строку в число. 
// Опять же, если пользователь введет число с первым нулём, например, 01234, то при конвертации мы получим 1234. 
// Но Ваша программа этого не учтет и покажет вторую цифру 1.

// Console.Clear();

// Console.WriteLine("Enter a number: ");
// string numSeq = Console.ReadLine();
// if (numSeq.Length > 2 )
// {
//     Console.Write("Third digit: " + numSeq[2]);
// }

// else
// {
//     Console.Write("This number does not have a third digit");
// }

// Option №2

Console.Clear();

Console.WriteLine("Enter a number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (Math.Abs(num) / 100 > 0)
{
    if (Math.Abs(num) / 100 < 10) Console.Write("Third digit: " + Math.Abs(num) % 10);
    if (Math.Abs(num) / 100 > 10 && Math.Abs(num) / 100 < 100) Console.Write("Third digit: " + Math.Abs(num) / 10 % 10);
    if (Math.Abs(num) / 100 > 100 && Math.Abs(num) / 100 < 1000) Console.Write("Third digit: " + Math.Abs(num) / 100 % 10);
    if (Math.Abs(num) / 100 > 1000 && Math.Abs(num) / 100 < 10000) Console.Write("Third digit: " + Math.Abs(num) / 1000 % 10);
    if (Math.Abs(num) / 100 > 10000 && Math.Abs(num) / 100 < 100000) Console.Write("Third digit: " + Math.Abs(num) / 10000 % 10);
    if (Math.Abs(num) / 100 > 100000 && Math.Abs(num) / 100 < 1000000) Console.Write("Third digit: " + Math.Abs(num) / 100000 % 10);
    if (Math.Abs(num) / 100 > 1000000 && Math.Abs(num) / 100 < 10000000) Console.Write("Third digit: " + Math.Abs(num) / 1000000 % 10);
    if (Math.Abs(num) / 100 > 10000000 && Math.Abs(num) / 100 < 100000000) Console.Write("Third digit: " + Math.Abs(num) / 10000000 % 10);
}

else
{
    Console.Write("This number does not have a third digit");
}