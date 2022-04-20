Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
int index = 1;

while(index <= N)
{
    Console.Write($"{Math.Pow(index, 3)} ");
    index++;
}