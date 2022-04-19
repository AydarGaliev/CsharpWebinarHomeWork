//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Является ли день выходным?");
Console.WriteLine("Введите число от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());
Days(number);

void Days(int numday)
{
    if(numday > 7)
    {
        Console.WriteLine("В неделе 7 дней");
    }
    else
    {
        if(numday == 6 || numday == 7)
        {
            Console.WriteLine("Да");
        }
        else
        {
            Console.WriteLine("Нет");
        }
    }
}