Console.WriteLine("Введите длинну массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] Fibonacci = new int [length];
Fibonacci[0] = 0;
Fibonacci[1] = 1;
for(int i = 2; i < length; i++)
{
    Fibonacci[i] = Fibonacci[i - 1] + Fibonacci[i - 2];
}
WriteArray(Fibonacci);

void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}