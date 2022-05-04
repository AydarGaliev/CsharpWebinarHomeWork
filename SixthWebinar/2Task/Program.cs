int InputNumber(string name)
{
    Console.WriteLine($"Введите число {name} ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int a = InputNumber("A");
int b = InputNumber("B");
int c = InputNumber("C");

if(a < b + c && b < a + c && c < a + b)
{
    Console.WriteLine("Это треуголник");
}
else 
{
    Console.WriteLine("Это не треуголник");
}