//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Write("Введите число: ");
string number = Console.ReadLine();

if (number.Length >= 3)
{
    Console.Write("Третья цифра: ");
    Console.WriteLine(ThirdDigit(number));
}
else
{
    Console.WriteLine("В данном числе отсутствует третья цифра.");
}

char ThirdDigit(string number1)
{
    char result = number1[2];
    return result;
}