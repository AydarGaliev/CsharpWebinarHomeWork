double k1 = Input1("k1");
double b1 = Input1("b1");
double k2 = Input2("k2");
double b2 = Input2("b2");
if (k1 == k2)
{
    Console.WriteLine("Прямые параллельны");
}
else
{
     double x = ResultX(b2,b1,k1,k2); 
     double y = ResultY(b2,b1,k1,k2);
     Console.WriteLine($"Координаты пересечения прямых ({x};{y})");
}

double ResultX(double a2,double a1, double b1,double b2)
{
    return (a2-a1)/(b1-b2);
}
double ResultY(double a2,double a1, double b1,double b2)
{
    return b2*((a2-a1)/(b1-b2)) +a2;
}
double Input1(string k1)
{
    Console.Write($"Введите коэффициенты для функции первой прямой {k1} ");
    return Convert.ToDouble(Console.ReadLine()); 
}
double Input2(string k2)
{
    Console.Write($"Введите коэффициенты для функции первой прямой {k2} ");
    return Convert.ToDouble(Console.ReadLine()); 
}