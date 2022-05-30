int[] data = {0, 1, 1, 1, 1, 0, 0, 0, 1};
int[] info = {2, 3, 3, 1};
int[] output = DecodaAll(data, info);

WriteArray(output);
Console.WriteLine(DecodePosition(data, info, 3));

int[] DecodaAll(int[] data, int[] info)
{
    int[] result = new int[info.Length];
    int k = 0;
    for(int i = 0; i < info.Length; i++)
    {
        for(int j = 0; j < info[i]; j++)
        {
            result[i] = result[i] * 2 + data[k];
            k++;
        }
    }
    return result;
}

int DecodePosition(int[] data, int[] info, int position)
{
    int result = 0;
    int k = 0;
    for(int i = 0; i < position; i++)
    {
        k += info[i];
    }
    for(int i = 0; i < info[position]; i++)
    {
        result = result * 2 + data[k++];
    }
    return result;
}

void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i] + " ");
    }
    Console.WriteLine();
}