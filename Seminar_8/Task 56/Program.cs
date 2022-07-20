
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


int[] SumInRows(int[,] array) 
{ 
    int[] sumArray = new int[array.GetLength(0)]; 
    for (int i = 0; i < array.GetLength(0); i++) 
    { 
        for (int j = 0; j < array.GetLength(1); j++) 
            sumArray[i] += array[i, j]; 
    } 
 
    return sumArray; 
} 

void ShowSumArray(int[] array) 
{ 
    for (int i = 0; i < array.Length; i++) 
        Console.WriteLine($"Сумма {i + 1} строки равна {array[i]} "); 
 
    Console.WriteLine(); 
} 
 

int MinSum(int[] array) 
{ 
    int min = 0; 
    for (int i = 1; i < array.Length; i++) 
        if (array[i] < array[min]) min = i; 
 
    return min + 1; 
}

int[,] newArray1 = CreateRandom2dArray(4, 4, 1, 11);
Show2dArray(newArray1);
int[] sumArray = SumInRows(newArray1);
ShowSumArray(sumArray);
Console.WriteLine($"{MinSum(sumArray)} строка содержит минимальную сумму" );