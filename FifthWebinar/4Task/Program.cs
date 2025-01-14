﻿//Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
//[5, 18, 123, 6, 2] -> 1
//[1, 2, 3, 6, 2] -> 0
//[10, 11, 12, 13, 14] -> 5

int[] numbers = new int[123];
FillArray(numbers);
WriteArray(numbers);
int count = 0;

for(int i = 0; i < numbers.Length; i++)
{
    if(numbers[i] >= 10 && numbers[i] <= 99)
    {
        count++;
    }
}
Console.Write($"Количество элементов интервале от 10 до 99: {count}");

void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-99, 200);
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