int[] CreateSomeArray(int size)

{
    int [] array = new int [size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(100,1000);

    return array;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + ", ");

    Console.WriteLine();
}

int HowManyEvenNumbers(int[] array)
{
    int count = 0;
    for ( int i = 0; i< array.Length; i++ )
    {
        if(array[i]% 2 == 0) count++;
    }
    return count;
}

int[] SomeArray = CreateSomeArray(4);
ShowArray(SomeArray);
int result = HowManyEvenNumbers(SomeArray);
Console.WriteLine($"The amount of even numbers in this array is {result}");