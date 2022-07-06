




int[] CreateSomeArray(int size)

{
    int [] array = new int [size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(0,1000);

    return array;
}


void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + ", ");

    Console.WriteLine();
}

int[] SomeArray = CreateSomeArray(8);
ShowArray(SomeArray);