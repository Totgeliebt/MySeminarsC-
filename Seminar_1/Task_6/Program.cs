Console.WriteLine($"Input a number ");
int n1 = Convert.ToInt32(Console.ReadLine());

if( n1 % 2 == 0) 
{
    Console.WriteLine($"{n1} - even");
}
else
{
    Console.WriteLine($"{n1} - odd");
}