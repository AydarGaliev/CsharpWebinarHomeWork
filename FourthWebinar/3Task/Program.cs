Console.WriteLine("Введите число: ");
int factorial = Convert.ToInt32(Console.ReadLine());
int a = 1;
for(int i = 1; i <= factorial; i++)
{
    a = a * i;
}
Console.WriteLine(a);