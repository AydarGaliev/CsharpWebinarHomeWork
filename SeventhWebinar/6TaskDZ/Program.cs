Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];

CreateArray(array);
WriteArray(array);

Console.Write("Введите позицию элемента в строке начиная с 0: ");
int positionLine = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию элемента в столбце начиная с 0: ");
int positionColumn = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (positionLine == i && positionColumn == j)
        {
            Console.Write($"Значение искомого элемента равен: {array[positionLine, positionColumn]}");
        }
    }
    if (positionLine >= m || positionColumn >= n)
    {
        Console.Write($"По заданным координатам элемент отсутствует");
        break;
    }
}

Console.WriteLine();

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