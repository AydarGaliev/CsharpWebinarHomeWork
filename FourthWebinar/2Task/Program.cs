/* Console.WriteLine("Введите число: ");    // 1 способ
string number = Console.ReadLine();
int quantity = number.Length;
Console.WriteLine(quantity); */


/* Console.WriteLine("Введите число: ");    // 2 способ через цикл
string number = Console.ReadLine();
int result = 0;
for(int i = 0; i < number.Length; i++)
{
    result++;
}
Console.WriteLine(result); */

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int index = 0;
while(number != 0)
{
    number = number / 10;
    index++;
}
Console.WriteLine(index);