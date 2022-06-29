
double GetDistance(double x1, double y1, double z1, double x2,  double y2,  double z2)
{
    double xLine = x2-x1;
    double yLine = y2-y1;
    double zLine = z2-z1;

    double distQuad = xLine *xLine + yLine*yLine + zLine*zLine;
    double result = Math.Sqrt(distQuad);
    return result;
}

Console.WriteLine("Input number: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number: ");
int z2 = Convert.ToInt32(Console.ReadLine());
double result = GetDistance(x1,y1,z1,x2,y2,z2); 
// double result = GetDistance(3,6,8,2,1,-7); 
