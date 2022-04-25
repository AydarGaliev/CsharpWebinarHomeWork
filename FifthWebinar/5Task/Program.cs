// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21

Console.WriteLine("Введите длину массива ");
int Length = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[Length];
FillArray(numbers);
WriteArray(numbers);
int Lengthsum;
if(Length % 2 == 0)
{
    Lengthsum = Length / 2;
}
else
{
    Lengthsum = (Length / 2) + 1;
}

int[] sumarr = new int[Lengthsum];

for(int i = 0; i < sumarr.Length; i++)
{
    sumarr[i] = numbers[i] * numbers[numbers.Length-1-i];
}
if(Length % 2 != 0)
{
    sumarr[sumarr.Length-1] = numbers[sumarr.Length-1];
}
WriteArray(sumarr);

void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-20, 20);
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