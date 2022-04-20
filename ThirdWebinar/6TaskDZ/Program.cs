double x1 = Coordinate("x", "1");
double y1 = Coordinate("y", "1");
double z1 = Coordinate("z", "1");
double x2 = Coordinate("x", "2");
double y2 = Coordinate("y", "2");
double z2 = Coordinate("z", "2");

int Coordinate(string coorName, string pointName)
{
    Console.Write($"Введите координату {coorName} точки {pointName}: ");
    return Convert.ToInt32(Console.ReadLine());
}

double a = Convert.ToDouble(Math.Pow((x1 - x2), 2));
double b = Convert.ToDouble(Math.Pow((y1 - y2), 2));
double c = Convert.ToDouble(Math.Pow((z1 - z2), 2));
double d = a + b + c;
double distance = Gipotenusa(d);

double Gipotenusa(double sum)
{
    return Math.Sqrt(sum);
}
Console.WriteLine($"Расстояние между точками: {distance}");