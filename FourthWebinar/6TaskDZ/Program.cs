Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int index = 0;
int sum = 0;
while(number != 0)
{
    sum = sum + (number % 10);
    index++;
    number = number / 10;
}
Console.WriteLine(sum);