int number = RandomInt(10, 100);
int first = number / 10;
int second = number % 10;
Console.WriteLine(number);

int max = MaxNumber(first, second);
Console.WriteLine(max);

int RandomInt(int inclusiveMin, int exclusiveMax)
{
    return new Random().Next(inclusiveMin, exclusiveMax);
}

int MaxNumber(int number1, int number2)
{
    if(number1 > number2)
        return number1;
    return number2;
}