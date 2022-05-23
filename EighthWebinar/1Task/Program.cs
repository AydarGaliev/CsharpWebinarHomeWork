//Задайте двумерный массив. Напишите программу, которая поменяет местами 
//первую и послуднюю строку массива
Console.Write("Введите количество строк m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов n: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[m, n];
double[,] temp = new double[m, n];

FillArray(array);
PrintArray(array);

for(int i = 0; i < m; i++)
{
    for(int j = 0; j < n; j++)
    {
        temp[i, j] = array[i, j];
        temp[0, j] = array[m-1, j];
        temp[m-1, j] = array[0, j];
        Console.Write(temp[i, j] + " ");
    }
    Console.WriteLine();
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
            matrix[rows, columns] = new Random().Next(1, 11);
        }
        Console.WriteLine();
    }
}