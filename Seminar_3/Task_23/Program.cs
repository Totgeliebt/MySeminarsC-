 void ShowCube(int N) 
{
    int Count = 1;
    while(Count <=N) 
    {
        int Cube = Count*Count*Count;
        Console.WriteLine(Cube);
        Count++;
    }
}
Console.WriteLine("Input number: ");
int N = Convert.ToInt32(Console.ReadLine());
ShowCube(N); 
