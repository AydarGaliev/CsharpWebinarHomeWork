Console.WriteLine("Введите длину массива ");
int Length = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[Length];
int count = 0;
int sum = 0;
FillArray(numbers);
WriteArray(numbers);

for(int i = 1; i < numbers.Length; i++)
{
    count = numbers[i] + numbers[i + 2];
    i = i + 2;
    sum = count;
}
Console.WriteLine(sum);

void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-99, 99);
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