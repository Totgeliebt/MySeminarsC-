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
     Console.WriteLine();
}
int[,] ProductOfArrays(int[,] newArray1, int[,] newArray2)
{
     int[,] array = new int[newArray1.GetLength(0),newArray1.GetLength(1)];
     for(int i = 0; i < newArray1.GetLength(0); i++)
        for(int j = 0; j< newArray1.GetLength(1); j++) 
        {
           array[i,j] = newArray1[i,j] * newArray2[i,j];
        }

    return array;
}

int[,] newArray1 = CreateRandom2dArray(2, 2, 1, 11);
Show2dArray(newArray1);
int[,] newArray2 = CreateRandom2dArray(2, 2, 1, 11);
Show2dArray(newArray2);

Show2dArray(ProductOfArrays(newArray1, newArray2));