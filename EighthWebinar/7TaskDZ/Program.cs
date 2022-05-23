int m = EnterArraySize("Введите количество строк первого массива:");
int n = EnterArraySize("Ведите количество столбцов первого массива:");
int k = EnterArraySize("Введите количество строк второго массива:");
int l = EnterArraySize("Ведите количество столбцов второго массива:");
int[,] firstArray = new int[m, n];
int[,] secondArray = new int[k, l];

FillArray(firstArray);
PrintArray(firstArray);
FillArray(secondArray);
PrintArray(secondArray);
Console.WriteLine();
Console.WriteLine("Произведение массивов:");
int[,]result = Composition(firstArray,secondArray);
PrintArray(result);

int EnterArraySize(string size)
{
    Console.WriteLine(size);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void PrintArray(int[,] matr) 
{
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
            Console.Write($" {matr[rows, columns]} ");   
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr) 
{
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
            matr[rows,columns] = new Random().Next(1,11); 
        }
        Console.WriteLine();
    }
}

int[,] Composition(int[,] a, int[,] b)
{
    if (a.GetLength(1) != b.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");
    int[,] result = new int[a.GetLength(0), b.GetLength(1)];
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            for (int k = 0; k < b.GetLength(0); k++)
                {
                    result[i,j] = a[i,j] * b[i,j];
                }
        }
    }
    return result;
}