double[,] CreateRandom2dArray(int m, int n, int minValue, int maxValue)
{
    double[,] newArray = new double[m, n];

    for(int i = 0; i < m; i++)
        for(int j = 0; j< n; j++)
            newArray[i,j] = Math.Round(new Random().Next(minValue, maxValue +1)* new Random().NextDouble(),2);
    return newArray;
}
void Show2dArray(double[,] array)
{
    for(int i =0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}

double[,] array = CreateRandom2dArray(4,3, -10, 10);
Show2dArray(array);