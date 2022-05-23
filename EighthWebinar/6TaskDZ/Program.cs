int m = EnterArraySize("Введите количество строк:");
int n = EnterArraySize("Ведите количество столбцов:");
int[,] array = new int[m, n];
Random rnd = new Random();

for (int i = 0; i < m; i++)
    for (int j = 0; j < n; j++)
    {
        array[i, j] = rnd.Next(-0, 10 + 1);
    }
    for (int i = 0; i < m; i++, Console.WriteLine())
        for (int j = 0; j < n; j++)
        {
            Console.Write(array[i, j] + " ");
        }
int minRowSum = int.MaxValue, indexMinRow = 0;
for (int i = 0; i < m; i++)
{
    int rowSum = 0;
    for (int j = 0; j < n; j++)
        rowSum += array[i, j];
    if (rowSum < minRowSum)
    {
        minRowSum = rowSum;
        indexMinRow = i;
    }
}

Console.WriteLine("Строка с минимальной суммой элементов");
for(int j = 0;j<n;j++)
Console.Write(array[indexMinRow, j] + " ");

int EnterArraySize(string size)
{
    Console.WriteLine(size);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}