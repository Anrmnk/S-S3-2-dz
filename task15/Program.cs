// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine ("Введите цифру дня недели" + " ");
int number = Convert.ToInt32(Console.ReadLine());
if ( number <= 7)
if (number == 1 || number == 2 || number == 3 || number == 4 || number == 5)
{
    Console.WriteLine ("Не является выходным");
}
else
{
    Console.WriteLine ("Является выходным");
}
else
{
    Console.WriteLine ("Такого дня недели нет");
}