Console.WriteLine("Тут будет массив");
int[] array = new int[8];
void FillArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 20);
    }
    
}
void PrintAray(int[] arrayInternal)
{ 
    int count = arrayInternal.Length;
    Console.Write("{");
    for(int i = 0; i < count - 1; i++)
    {
        Console.Write($"{arrayInternal[i]}, ");
    }
    Console.WriteLine(arrayInternal[count - 1] + "}");
}
FillArray(array);
Console.Write("Исходный массив: ");
PrintAray(array);