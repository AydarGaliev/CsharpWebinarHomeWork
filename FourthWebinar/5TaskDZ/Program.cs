Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
for(int i = 0; i < numberB; i++)
{
    numberA = numberA * numberA;
    i++;
}
Console.WriteLine("Ответ: " + numberA);