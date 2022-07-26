
string[] CreateStringArray(int number) 
{
    string[] newArray = new string[number];
    for( int i = 0; i < number; i++ ) {
        Console.WriteLine($"input {i+1} word: ");
        newArray[i] = Console.ReadLine();
    }
    return newArray;
}

int CountVowelWords(string[] array)
{       int count = 0;
     for (int i = 0; i < array.Length; i++)
    {
        if( array[i][0] == 'a' || array[i][0] == 'e' || array[i][0] == 'i' || array[i][0] == 'o' || array[i][0] == 'u') count++;
    }
    return count;
}
string[] myArray = CreateStringArray(5);
Console.WriteLine("Word(s) started with vowels - "+CountVowelWords(myArray));