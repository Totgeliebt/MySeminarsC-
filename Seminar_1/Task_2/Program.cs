// task 2
Console.WriteLine($"Input first number ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Input second number ");
int n2 = Convert.ToInt32(Console.ReadLine());

if ( n1 > n2 ) 
{
    Console.WriteLine($"{n1} - is the biggest number, {n2} - is the smallest.");
}
else 
{
    Console.WriteLine($"{n2} - is the biggest number, {n1} - is the smallest.");
}