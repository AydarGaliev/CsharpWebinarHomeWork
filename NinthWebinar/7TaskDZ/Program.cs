int mNumber = Input("Введите значение M: ");
int nNumber = Input("Введите значение N: ");

int result = Rekursion(nNumber,mNumber);
Console.WriteLine(result);

int Rekursion(int nNumber, int mNumber)
{
    if (nNumber == 0)
    {
        return mNumber + 1;
    }
    else
    {
        if ((nNumber != 0) && (mNumber == 0))
        {
            return Rekursion(nNumber - 1, 1);
        }
        else
        {
            return Rekursion(nNumber - 1,Rekursion(nNumber, mNumber - 1));
        }
    }
}

int Input(String text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}