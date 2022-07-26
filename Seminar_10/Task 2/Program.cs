
string[] CreateStringArray(int number) 
{
    string[] newArray = new string[number];
    for( int i = 0; i < number; i++ ) {
        Console.WriteLine($"input {i+1} word: ");
        newArray[i] = Console.ReadLine();
    }
    return newArray;
}

string[] CreateDoubleStringArray(string[] array) 
{
    string[] newArray = new string[array.Length/2];
    if(array.Length%2 ==1) {
        return array;
    } 
    else
    {
        for (int i = 0, j = 0; i < array.Length; i += 2, j++)
         {
            newArray[j]=array[i]+array[i+1];
        } 
    return newArray;
    }
}
void ShowStringArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
string[] myArray = CreateStringArray(4);
ShowStringArray(CreateDoubleStringArray(myArray));