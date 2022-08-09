// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


Console.Clear();

Console.WriteLine("Enter the digital number of the day of the week: ");
int numDay = Convert.ToInt32(Console.ReadLine());

if (numDay > 0 && numDay < 8)
{
    if (numDay == 6 || numDay == 7)
    {
        Console.Write("It's a day off");
    }

    else
    {
        Console.Write("It's a working day");
    }

}

else
{
    Console.Write("This is not the number of the day of the week");
}