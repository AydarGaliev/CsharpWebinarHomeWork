Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = Summ(number);
Console.WriteLine(result);

int Summ(int number)
{   
    if(number > 0)
    {
        return number%10 + Summ(number/10);
    }
    return 0;
}