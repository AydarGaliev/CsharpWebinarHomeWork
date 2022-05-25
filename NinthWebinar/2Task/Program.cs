int numberStart = Input("Введите значение M: ");
int numberEnd = Input("Введите значение N: ");

Console.WriteLine(OutPutFunction(numberStart, numberEnd));

int Input(String text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int OutPutFunction(int numStart, int numEnd)
{
    if(numEnd == numStart)
    {
        return numEnd;
    }
    Console.Write(OutPutFunction(numStart, numEnd - 1) + ", ");
    return numEnd;
}