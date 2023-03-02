// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.Write ("Введите трехзначное число");
string answer = Console.ReadLine ();
int number = Convert.ToInt32 (answer);
int resalt = number / 10;
int resalt1 = resalt % 10;
Console.Write (resalt1);