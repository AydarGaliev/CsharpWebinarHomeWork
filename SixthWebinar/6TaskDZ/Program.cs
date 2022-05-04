Console.WriteLine("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
double[] array = new double[length];

for (int i = 0; i < length; i++)
{
    Console.WriteLine($"Введите {i + 1} элемент массива");
    array[i] = Convert.ToDouble(Console.ReadLine());
}
int count = 0;
for(int i = 0; i<length;i++)
{
    if(array[i]>0)
    {
        count++; 
    }
    else
    {
        count = count + 0;
    }    
}
Console.WriteLine($"Количество положительных чисел в массиве = {count} ");