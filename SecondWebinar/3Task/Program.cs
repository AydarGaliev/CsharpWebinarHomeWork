Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if(number2 % number1 != 0)
{
    Console.Write("Число не кратно остаток: ");
    Console.WriteLine(Division(number2, number1));
}
else
{
    Console.WriteLine("Число кратно");
}


int Division(int number2, int number1)
{
    return number2 % number1;
}