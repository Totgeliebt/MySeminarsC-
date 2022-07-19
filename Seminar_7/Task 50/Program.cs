int[,] CreateRandom2dArray(int m, int n, int minValue, int maxValue)
{
    int[,] newArray = new int[m, n];

    for(int i = 0; i < m; i++)
        for(int j = 0; j< n; j++)
            newArray[i,j] = new Random().Next(minValue, maxValue +1);
    return newArray;
}
void Show2dArray(int[,] array)
{
    for(int i =0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}

int FindElement(int x, int y, int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++) 
            if(x==i && y == j) return array[i,j]; 

    return 0;       
      
}


int[,] array = CreateRandom2dArray(4, 3, 1,9);
Show2dArray(array);
Console.WriteLine("Input x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input y: ");
int y = Convert.ToInt32(Console.ReadLine());

if(FindElement(x,y,array) == 0) Console.WriteLine("No such elem");
else Console.WriteLine(FindElement(x,y,array));