Console.WriteLine("Введите длину массива ");
int Length = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[Length];
double min = numbers[0];
double max = numbers[0];
double dif = 0;
FillArray(numbers);
WriteArray(numbers);

for(int i = 0; i < numbers.Length; i++)
{
    if(numbers[i] > max)
    {
        max = numbers[i];
    }
    if(numbers[i] < min)
    {
         min = numbers[i];
    }
    dif = max - min;
}
Console.WriteLine("Разница между max и min числами массива: " + dif);

void FillArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-99, 99);
    }
}

void WriteArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}