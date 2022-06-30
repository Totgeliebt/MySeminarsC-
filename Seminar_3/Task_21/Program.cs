
double GetDistance(double x1, double y1, double z1, double x2,  double y2,  double z2)
{
    double xLine = x2-x1;
    double yLine = y2-y1;
    double zLine = z2-z1;

    double distQuad = xLine *xLine + yLine*yLine + zLine*zLine;
    double result = Math.Round(Math.Sqrt(distQuad), 2);
    Console.WriteLine(result);
    return result;
}

double result = GetDistance(3,6,8,2,1,-7); 
