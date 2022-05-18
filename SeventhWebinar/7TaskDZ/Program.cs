Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];

CreateArray(array);
WriteArray(array);
Console.Write("Среднее арифметическое столбцов: ");

for (int j = 0; j < n; j++)
{
    double sum = 0;
    double average = 0;
    for (int i = 0; i < m; i++)
    {
        sum += array[i, j];
    }
    average = sum / m;
    Console.Write(Math.Round(average,1) + "; ");
}

void CreateArray(int[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void WriteArray (int[,] array)
{
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}