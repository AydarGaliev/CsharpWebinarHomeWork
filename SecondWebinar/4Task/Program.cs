//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

int number = new Random().Next(100, 1000);
Console.WriteLine(number);

int  second = SocondDigit(number);
Console.WriteLine(second);

int SocondDigit(int number)
{
    int first = number / 10;
    int second = first % 10;
    return second;
}