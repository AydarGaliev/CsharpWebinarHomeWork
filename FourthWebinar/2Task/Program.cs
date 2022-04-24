/* Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int quantity = number.Length;
Console.WriteLine(quantity); */


Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int result = 0;
for(int i = 0; i < number.Length; i++)
{
    result++;
}
Console.WriteLine(result);