Console.Write("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = number1 *-1;
while(number2<=number1)
{
    Console.Write(number2 + ", ");
    number2++;
}