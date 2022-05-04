 int InputNumber(string chislo)
{
    Console.WriteLine($"Введите число {chislo}");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
 int a = InputNumber("А");
 string result = "" + a % 2;

 while(a >= 2)
{
    a = a / 2;
    int c = a % 2;
    result = c + result;
}
Console.Write(result);