int s = 4;
int [,] spiralArray = new int[s,s];
int temporary = 1;
int i = 0;
int j = 0;
while(temporary<=s*s)
{
    spiralArray[i,j] = temporary;
    temporary ++;
    if (i<=j+1 && i+j<s-1)
    {
        j++;
    }
    else if(i<j && i+j>=s-1)
    {
        i++;
    }
    else if(i>=j && i+j>s-1)
    {
        j--;
    }
    else
    {
        i--;
    }
}
PrintArray(spiralArray);

void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+ " ");
        }
        Console.WriteLine();
    }
}