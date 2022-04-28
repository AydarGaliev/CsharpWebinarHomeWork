Console.WriteLine("Введите длину массива ");
int Length = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[Length];
int count = 0;
FillArray(numbers);
WriteArray(numbers);

for(int i = 0; i < numbers.Length; i++)
{
    if(numbers[i] % 2 == 0)
    {
        count++;
    }
}
Console.WriteLine("Количество чётных чисел: " + count);

void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 999);
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