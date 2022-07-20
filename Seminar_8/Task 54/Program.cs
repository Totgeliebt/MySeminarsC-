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
int[,] SortArray(int[,] newArray1)
{
     int[,] array = new int[newArray1.GetLength(0),newArray1.GetLength(1)];
     for(int i = 0; i < newArray1.GetLength(0); i++)
        for(int j = 0; j< newArray1.GetLength(1); j++) 
            for (int k = 0; k < newArray1.GetLength(1) - 1; k++)
        {
            if (newArray1[i, k] < newArray1[i, k + 1])
            {
                int temp = newArray1[i, k + 1];
                newArray1[i, k + 1] = newArray1[i, k];
                newArray1[i, k] = temp;
            }
            
        } 
        return newArray1;
}
// В задании написано по убыванию, а пример отсортирован по возрастанию. Я сделала, как указано в условиях задачи - по убыанию
int[,] newArray1 = CreateRandom2dArray(4, 4, 1, 11);
Show2dArray(newArray1);
Show2dArray(SortArray(newArray1));
