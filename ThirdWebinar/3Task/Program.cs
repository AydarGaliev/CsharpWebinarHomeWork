//Строки  2-12 функция ввода.
double x1 = Coordinate("x", "1");
double y1 = Coordinate("y", "1");
double x2 = Coordinate("x", "2");
double y2 = Coordinate("y", "2");


int Coordinate(string coorName, string pointName)
{
    Console.Write($"Введите координату {coorName} точки {pointName}: ");
    return Convert.ToInt32(Console.ReadLine());
}


double x = (x1 - x2)*(x1 - x2);     // Math.Pow - выведение квадрата
double y = (y1 - y2)*(y1 - y2);
double d = x + y;
double distance = Gipotenusa(d);

double Gipotenusa(double sum)
{
    return Math.Sqrt(sum);
}
Console.WriteLine($"Расстояние между точками: {distance}");