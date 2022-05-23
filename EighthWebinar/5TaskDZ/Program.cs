int m = EnterArraySize("Введите количество строк:");
int n = EnterArraySize("Ведите количество столбцов:");
int[,] array = new int[m, n];

FillArray(array);
PrintArray(array);
Console.WriteLine();

for (int i = 0; i < array.GetLength(0); i++)
{
    int[] tempArray = new int[array.GetLength(1)];
    for(int j = 0; j < array.GetLength(1); j++)
    {
        tempArray[j] = array[i, j];
    }
    tempArray = SortArray(tempArray);

    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = tempArray[j];
    }
}
Console.WriteLine("Результат сортировки: ");
PrintArray(array);

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

int[] SortArray(int[] array)
{
	for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length - 1; j++)
        {
            if (array[j] < array[j + 1])
	        {
		        int t = array[j + 1];
		        array[j + 1] = array[j];
		        array[j] = t;
    	    }
        }
    }
	return array;
}