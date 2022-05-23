//Составить частотный словать элементов двумерного массива. Частотный словать содержит
//информацию о том, сколько раз встречается элемент входных данных
int m = EnterArraySize("Введите количество строк:");
int n = EnterArraySize("Ведите количество столбцов:");
double[,] array = new double[m, n];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int length = 10;

for(int number = 0;number < length; number++)
{
    int count = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
         for(int j = 0; j < array.GetLength(1); j++)
        {   
            if(array[i,j]  == number)
            {
                count++;
            }
        }
    }
    if(count != 0)
    {
        Console.WriteLine($"Цифра {number} встречается {count} раз.");
    }
}

int EnterArraySize(string size)
{
    Console.WriteLine(size);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void PrintArray(double[,] matrix)
{
    for(int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for(int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            Console.Write($" {matrix[rows, columns]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(double[,] matrix)
{
    for(int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for(int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            matrix[rows, columns] = new Random().Next(0, 9);
        }
        Console.WriteLine();
    }
}