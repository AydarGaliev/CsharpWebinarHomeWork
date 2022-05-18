﻿Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];

for(int i = 0; i < m; i++)
{
    for(int j = 0; j < n; j++)
    {
        array[i, j] = new Random().Next(1, 100);
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

int sum = 0;
for(int i = 0; i < m; i++)
{
    for(int j = 0; j < n; j++)
    {
        if(i == j)
        {
            sum = sum + array[i, j];
        }
    }
}

Console.WriteLine(sum);