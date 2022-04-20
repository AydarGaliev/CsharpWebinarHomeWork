Console.Write("Введите номер четверти плоскостей координат: ");
int quarter = Convert.ToInt32(Console.ReadLine());

if(quarter == 0 || quarter > 4)
{
    Console.WriteLine("Введите корректный номер четверти плоскостей.");
}

if(quarter == 1)
{
    Console.WriteLine($"Диапозон координат в плоскости {quarter} по X от 0 до бесконечности и по Y от 0 до бесконечности");
}
if(quarter == 2)
{
    Console.WriteLine($"Диапозон координат в плоскости {quarter} по X от - бесконечности до 0 и по Y от 0 до бесконечности");
}
if(quarter == 3)
{
    Console.WriteLine($"Диапозон координат в плоскости {quarter} по X от - бесконечности до 0 и по Y от - бесконечности до 0");
}
if(quarter == 4)
{
    Console.WriteLine($"Диапозон координат в плоскости {quarter} по X от 0 до бесконечности и по Y от - бесконечности до 0");
}
