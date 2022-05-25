Console.WriteLine("Задайте число N: ");
int number = Convert.ToInt32(Console.ReadLine());
int decreasing = 1;
int result = Rekurs(number, decreasing);
Console.WriteLine(result);

int Rekurs(int number, int decreasing)
{  
    if (decreasing == number) 
    {
    return decreasing;
    }
    Console.Write(Rekurs(number, decreasing + 1) + ", ");
    return decreasing;
}