
Console.WriteLine($"Input first number ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Input second number ");
int n2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Input third number ");
int n3 = Convert.ToInt32(Console.ReadLine());

int max = n1;

if (n2 > n1)  max = n2;
if (n3 > n2)  max = n3;

Console.WriteLine(max);
