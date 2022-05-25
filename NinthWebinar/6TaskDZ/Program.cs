int mNumber = Input("Введите значение M: ");
int nNumber = Input("Введите значение N: ");

int result = RekursSum(nNumber, mNumber);
Console.WriteLine(result + " ");

int RekursSum(int nNumber, int mNumber)
{  
    if (nNumber <= mNumber) 
    {
    return nNumber;
    }
    
    return nNumber + RekursSum(nNumber-1,mNumber);
}

int Input(String text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}