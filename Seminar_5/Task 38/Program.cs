double[] CreateSomeArray(int size)

{
    double [] array = new double [size];

    for (int i = 0; i < size; i++)
        array[i] = Math.Round(new Random().Next(0,11)* new Random().NextDouble(),2);

    return array;
}


void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + ", ");

    Console.WriteLine();
}

double FindMax(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
        {
        if (array[i] > max)
            {
             max = array[i];
            }
        }return max;
}

double FindMin(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
        {
        if (array[i] < min)
            {
             min = array[i];
            }
        }return min;
}

double FindDiff(double max, double min)
{
    double diff = max - min;
    return diff;
}

double[] SomeArray = CreateSomeArray(4);
ShowArray(SomeArray);
double resultMax = FindMax(SomeArray);
Console.WriteLine($"The max element is {resultMax}");
double resultMin = FindMin(SomeArray);
Console.WriteLine($"The min element is {resultMin}");
double result = FindDiff(resultMax,resultMin);
Console.WriteLine($"The dif of max and min elements is {result}");
