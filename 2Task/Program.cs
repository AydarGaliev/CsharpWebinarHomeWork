﻿Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int square = number1 * number1;
if (square == number2)
{
    Console.WriteLine("Второе число является квадратом первого числа.");
}
else
{
    Console.WriteLine("Второе число не является квадратом первого числа.");
}