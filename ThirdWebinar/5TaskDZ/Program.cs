Console.WriteLine("Проверка числа на палиандром");
Console.Write("Введите пятизначное число N: ");
int a = Convert.ToInt32(Console.ReadLine());
Paliandrom(a);

int Paliandrom(int x)
{
    if((x / 10000 == x % 10) && (((x / 1000) % 10)) == ((x % 100) / 10))
    {
        Console.WriteLine("Число является палиандромом");
        return x;
    }
    else
    {
        Console.WriteLine("Число не является палиандромом");
        return x;
    }
}