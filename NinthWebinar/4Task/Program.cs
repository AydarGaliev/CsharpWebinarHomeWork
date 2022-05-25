int number = Input("Введите число: ");
int stepen = Input("Введите степень: ");

Console.WriteLine(OutPutFunction(number, stepen));

int Input(String text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int OutPutFunction(int numStart, int numEnd)
{
    if(numEnd == 0)
    {
        return 1;
    }
    return numStart * OutPutFunction(numStart, numEnd - 1);
}