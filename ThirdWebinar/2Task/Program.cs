Console.Write("Введите номер плоскости координат: ");
int quarter = Convert.ToInt32(Console.ReadLine());

if(quarter == 0)
{
    Console.WriteLine("Координат в данной плоскости не существует.");
}

if(quarter == 1)
{
    Console.WriteLine($"Диапозон координат в плоскости {quarter} по X от 0 до бесконечности и по Y от 0 до бесконечности");
}
if(quarter == 2)
{
    Console.WriteLine($"Диапозон координат в плоскости {quarter} по X от от - бесконечности до 0 и по Y от 0 до бесконечности");
}
if(quarter == 3)
{
    Console.WriteLine($"Диапозон координат в плоскости {quarter} по X от от - бесконечности до 0 и по Y от - бесконечности до 0");
}
if(quarter == 3)
{
    Console.WriteLine($"Диапозон координат в плоскости {quarter} по X от 0 до бесконечности и по Y от - бесконечности до 0");
}