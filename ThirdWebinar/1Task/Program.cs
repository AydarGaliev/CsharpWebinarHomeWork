﻿Console.Write("X= ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y= ");
int y = Convert.ToInt32(Console.ReadLine());

if(x == 0 || y == 0)
{
    Console.WriteLine("X и Y не могут быть равны 0");
}

int quarterNumber = 1;   //int quarterNumber = 0;
//if(x > 0 && y > 0)
//{
//    quarterNumber = 1;
//}
if (x < 0 && y > 0)
{
    quarterNumber = 2;
}
if (x < 0 && y < 0)
{
    quarterNumber = 3;
}
if (x > 0 && y < 0)
{
    quarterNumber = 4;
}
Console.WriteLine($"Точка находится в четверти номер {quarterNumber}");