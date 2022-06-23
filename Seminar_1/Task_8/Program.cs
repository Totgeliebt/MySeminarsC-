
Console.WriteLine($"Input a number ");
int N = Convert.ToInt32(Console.ReadLine());

int even = 1;
while (even <= N)
{
    if(even % 2 == 0){
        Console.WriteLine($"{even} ");
    }
    even++;
}