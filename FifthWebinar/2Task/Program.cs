// Задача 1.Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

// 1 Задача

int[] numbers = new int[6];
FillArray(numbers);
WriteArray(numbers);

for(int i = 0; i < numbers.Length; i++)
{
    numbers[i] = -numbers[i];
    Console.Write(numbers[i] + " ");
}

void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write("Введите элемент № " + (i + 1) + ": ");
        array[i] = Convert.ToInt32(Console.ReadLine());
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