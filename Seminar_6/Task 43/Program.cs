

double FindX(int b1, int k1, int b2, int k2)
{
    double x;
    return x = Math.Round((double)(b2-b1)/(k1-k2), 1);
}

double FindY(int b1, int k1, double x)
{
    double y;
    return y = Math.Round((double)(k1*x + b1), 1);
}

Console.WriteLine("Input b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());
double x = FindX(b1, k1, b2, k2);
double y = FindY(b1, k1, x);
Console.WriteLine($"Координаты точки пересечения: ({x};{y})");