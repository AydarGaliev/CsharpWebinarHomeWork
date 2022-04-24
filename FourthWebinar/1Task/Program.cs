Console.WriteLine("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for(int i = 1; i <= number; i++)
{
    sum += i;
}
Console.WriteLine("Ответ: " + sum);