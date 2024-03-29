﻿int[,] CreateArray(int numOfLine, int numOfColumn) 
{ 
    int [,] array = new int[numOfLine,numOfColumn]; 
    Random rand = new Random(); 
     
    for (int i = 0; i<numOfLine; i++) 
    { 
        for(int j = 0; j<numOfColumn; j++) 
        { 
            array[i,j] = rand.Next(0,10); 
        } 
    } 
 
    return array; 
 
} 
 
void ShowTwoArray(int [,] array) 
{ 
    for (int i = 0; i<array.GetLength(0); i++) 
    { 
        for(int j = 0; j<array.GetLength(1); j++) 
        { 
            Console.Write(array[i,j]+"  "); 
        } 
        Console.WriteLine(); 
 
    } 
} 

 
 
double [] FindArithmeticMean(int [,] array) 
{ 
    double[] result = new double[array.GetLength(1)]; 
    for(int j=0; j<array.GetLength(1); j++) 
    { 
        double sum = 0; 
        for (int i = 0; i < array.GetLength(0); i++) 
        { 
            sum += array[i,j]; 
        } 
        double mean = Math.Round((sum/array.GetLength(0)),2); 
        result[j] = mean; 
         
    } 
     
    return result; 
} 

 
void ShowOneArray(double[] array) 
{ 
    for (int i = 0; i<array.Length; i++) 
    { 
        Console.Write($"Arithmetic mean Column # {i} = {array[i]} "); 
        Console.WriteLine(); 
    } 
} 

 
Console.Write("Input number of rows "); 
int numOfLines = Convert.ToInt32(Console.ReadLine()); 
 
Console.Write("Input number of columns "); 
int numOfColumns = Convert.ToInt32(Console.ReadLine()); 
 
 
int [,] myArray = CreateArray(numOfLines,numOfColumns); 
Console.WriteLine("Created array:"); 
ShowTwoArray(myArray); 
 
Console.WriteLine(); 
 
double [] ArrayWithMean = FindArithmeticMean(myArray); 
 
ShowOneArray(ArrayWithMean);