Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int result = Rekurs(n);
Console.WriteLine(result);

int Rekurs(int number)
{
    if(number == 1)
        return 1;
    int temp = Rekurs(number - 1);
    Console.Write(temp + ", ");
    return number;
}