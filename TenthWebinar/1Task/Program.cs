Console.WriteLine("Введите первое число");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сколько чисел вывести?");
int s = Convert.ToInt32(Console.ReadLine());

FibonacciModified(n, m, s);

void FibonacciModified(int n, int m, int s)
{
    Console.Write(n + " ");
    Console.Write(m + " ");
    int sum = 0;
    for (int i = 2; i < s; i++)
    {
        sum = n + m;
        Console.Write(sum + " ");
        {
            n = m;
            m = sum;
        }
    }
}