int[] CreateSomeArray(int size)

{
    int [] array = new int [size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(0,11);

    return array;
}


void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + ", ");

    Console.WriteLine();
}

int FindSum(int[] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i+=2) 
    {
        sum += array[i];
    }
    return sum;
}

int[] SomeArray = CreateSomeArray(8);
ShowArray(SomeArray);
int result = FindSum(SomeArray);
Console.WriteLine($"The sum of odd index elements is {result}");
