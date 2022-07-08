
int[] CreateSomeArray(int size)

{
    int [] array = new int [size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(-1000,1000);

    return array;
}


void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + ", ");

    Console.WriteLine();
}

int HowManyPositive(int M, int[] array)
{
    int count = 0;
    for(int i = 0; i < M; i++)
    { 
        if( array[i] > 0) count++;
    }
    
        return count;
}

Console.WriteLine("Input number: ");
int M = Convert.ToInt32(Console.ReadLine());
int[] SomeArray = CreateSomeArray(M);
ShowArray(SomeArray);
Console.WriteLine(HowManyPositive(M,SomeArray));
