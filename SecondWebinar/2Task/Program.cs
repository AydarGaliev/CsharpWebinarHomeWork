int number = new Random().Next(100, 1000);
Console.WriteLine(number);

int  total = Total(number);
Console.WriteLine(total);

int Total(int number)
{
    int first = number / 100;
    int second = number % 10;
    return first * 10 + second;
}

// Вариант через строки

// int number = RandomInt(100, 999);
// int number1 = number / 100;
// int number2 = number % 10;
// Console.WriteLine(number);
// Console.WriteLine(Convert.ToString(number1) + Convert.ToString(number2));
//
// int RandomInt(int min, int max)
// {
//    return new Random().Next(min, max);
// }