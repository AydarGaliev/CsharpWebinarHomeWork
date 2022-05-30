Console.WriteLine("Введите буквы: ");
string charWords = Console.ReadLine();

Console.WriteLine("Введите длину слов: ");
int n = int.Parse(Console.ReadLine());
PrintAllWorlds(charWords, n, "");

void PrintAllWorlds(string alphabet, int length, string prefix)
{
    if(length == 0)
        Console.WriteLine(prefix);
    else
    {
        foreach(var c in alphabet)
        {
            PrintAllWorlds(alphabet, length - 1, prefix + c);
        }
    }
}