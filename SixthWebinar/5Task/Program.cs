Console.WriteLine("Введите длинну массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] Fibonacci = new int [length];

FillArray(Fibonacci);
WriteArray(Fibonacci);

int[] newArray = new int [length];
for(int i = 0; i < newArray.length; i++)
{
    newArray[i] = Fibonacci[i];
}
Console.Write("Копия массива: ");
WriteArray(newArray);

void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
}

void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}