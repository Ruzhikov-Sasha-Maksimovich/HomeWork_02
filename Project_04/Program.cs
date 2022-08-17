double DistanceBeTweenCoordinates (double xa, double ya, double za, double xb, double yb,  double zb)
{
    double distanceBeTweenCoordinates = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2));
    return distanceBeTweenCoordinates;
}

System.Console.WriteLine("Введите координаты x по точки a");
double xa = double.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите координаты y по точки a");
double ya = double.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите координаты z по точки a");
double za = double.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите координаты x по точки b");
double xb = double.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите координаты y по точки b");
double yb = double.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите координаты z по точки b");
double zb = double.Parse(Console.ReadLine()!);
double distance = DistanceBeTweenCoordinates(xa, ya, za, xb, yb, zb);
System.Console.WriteLine(distance);