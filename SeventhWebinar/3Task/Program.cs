﻿Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];

for(int i = 0; i < m; i++)
{
    for(int j = 0; j < n; j++)
    {
        array[i, j] = i + j;
    }
}

for(int i = 0; i < m; i++)
{
    for(int j = 0; j < n; j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine();

for(int i = 0; i < m; i++)
{
    for(int j = 0; j < n; j++)
    {
        if(i % 2 == 1 && j % 2 == 1 && i!=0 && j!=0)
        {
            array[i, j] = array[i, j] * array[i, j];
        }
        else
        {
            continue;
        }
    }
}

for(int i = 0; i < m; i++)
{
    for(int j = 0; j < n; j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}