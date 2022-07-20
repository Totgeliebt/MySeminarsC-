// void ShowBiggerDigit()
// {
// int rand = new Random().Next(10, 99);
// Console.WriteLine($"The num is {rand}");
// int dec = rand/10;
// int ed = rand%10;
// int max;
// if(dec > ed) max = dec;
// else max = ed;
//     Console.WriteLine($"Bigger digit is {max}");
// }
// ShowBiggerDigit();

// int FindQuart(int x, int y) 
// {
//     if(x>0 && y>0) return 1;
//     if(x<0 && y>0) return 2;
//     if(x<0 && y<0) return 3;
//     if(x<0 && y<0) return 4;
// return -1;
// }
// Console.WriteLine("Input x: ");
// int x0 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input y: ");
// int y0 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Quarter is - "+ FindQuart(x0,y0));

// void findRange(int Quarter) 
// {
//     if(Quarter == 1) Console.WriteLine( $" x - положительный, y - положительный");
//     if(Quarter == 2)  Console.WriteLine( $" x - отрицательный, y - положительный");
//     if(Quarter == 3) Console.WriteLine( $" x - отрицательный, y - отрицательный");
//     if(Quarter == 4)  Console.WriteLine( $" x - положительный, y - отрицательный");
// }

// Console.WriteLine("Input quarter: ");
// int Quarter = Convert.ToInt32(Console.ReadLine());
// findRange(Quarter);

// void ShowSquare(int N) 
// {
//     int Count = 1;
//     while(Count <=N) 
//     {
//         int Squared = Count*Count;
//         Console.WriteLine(Squared);
//         Count++;
//     }
// }
// Console.WriteLine("Input number: ");
// int N = Convert.ToInt32(Console.ReadLine());
// ShowSquare(N); 

// double GetDistance(double x1, double x2, double y1, double y2)
// {
//     double xLine = x2-x1;
//      double yLine = y2-y1;
//      double distQuad = xLine *xLine + yLine*yLine;
//      double result = Math.Sqrt(distQuad);
//      return result;
// }
// getDistance(x1, x2, y1, y2);

// double GetDistance(double x1, double x2, double y1, double y2, double z1, double z2)
// {
//     double xLine = x2-x1;
//      double yLine = y2-y1;
//      double zLine = z2-z1;

//      double distQuad = xLine *xLine + yLine*yLine + zLine*zLine;
//      double result = Math.Sqrt(distQuad);
//      return result;
// }
// Console.WriteLine("Input number: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number: ");
// int z1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number: ");
// int z2 = Convert.ToInt32(Console.ReadLine());

// double result = GetDistance(x1,x2,y1,y2,z1,z2);

// int FindNumberOfDigits(int num)
// {
//     int count = 0; 
//     while (num != 0) 
//     {
//         num = num/10;
//         count++;
//     }
//     return count;
// }

// Console.WriteLine("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("The number of digits is " + FindNumberOfDigits(num));

// int FindFactorial(int num)
// {
//     int factorial = 1; 
//     for (int current =1; current <= num; current++) 
//     {
//         factorial*=current;

//     }
//     return factorial;
// }

// Console.WriteLine("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"The factorial of {num} is " + FindFactorial(num));

// int CustomPow(int a, int b)
// {
//     int result = 1;
//     for (int current =1; current <= b; current++) result*=a;

//     return result;
// }

// Console.WriteLine("Input number: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number: ");
// int b = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"{a} in {b} pow is " + CustomPow(a,b));



// int[] CreateBinaryArray(int size)

// {
//     int [] array = new int [size];
// // int [] array2 = {2, 5, 1, 4};

//     for (int i = 0; i < size; i++)
//         array[i] = new Random().Next(0,2);

//     return array;
// }

// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");

//     // Console.WriteLine();
// }

//  Console.WriteLine("Input number: ");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateBinaryArray(size);
// ShowArray(myArray);

// int Sum(int[] array, bool isPositive)
// {
//     int sumPos = 0;
//     int sumNeg = 0;
//     for(int i = 0; i< array.Length; i++)
//         if(array[i] > 0 && isPositive) sumPos += array[i];
//         else if(array[i] < 0 && !isPositive) sumNeg += array[i];

//     // if(isPositive) return SumPos;
//     // else return sumNeg;

//     return isPositive ? sumPos : sumNeg;

// }

// int [] ChangeElements (int [] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     array[i] *= -1;
// }

// int[] ReverseArray(int [] array)
// {
//     for(int i = 0, j = array.Length - 1; i < j; i++, j--)
//     {
//         int temp = array[i];
//         array[i] = array[j];
//         array[j] = temp;
//     }
//     return array;
// }


// string ConvertNumber(int num)
// {
//      string ConNum = string.Empty;
//     while(num > 0)
//     {
//        ConNum =  num%2 + ConNum;
//        num = num/2;
      
//     }
//     return ConNum;
// }

// Console.WriteLine(ConvertNumber(10));




// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + ", ");

//     Console.WriteLine();
// }


// int[] Fibonacci(int N)
// {
//     int[] array = new int[N];
//     array[0] = 0;
//     array[1] = 1;
//     for(int i = 2; i < N; i++)
//     {
//         array[i] = array[i - 1] + array[i - 2];
//     }
//     return array;
// }

// ShowArray(Fibonacci(5));

// bool  IsTriangle(int n1, int n2, int n3)
// {
//     return n1 < n2+n3 && n2< n1 + n3 && n3< n1+ n2;
    
//     // if(n1 < n2+n3 && n2< n1 + n3 && n3< n1+ n2) return true;
//     // else return false;
// }

// Console.WriteLine(IsTriangle(3,4,5));



// Console.WriteLine("Input m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input n: ");
// int n = Convert.ToInt32(Console.ReadLine());


// int[,] indexSumMatrix(int m, int n)
// {
//      int[,] matrix = new int[m, n];

//     for(int i = 0; i < m; i++)
//         for(int j = 0; j < n; j++)
//             matrix[i,j] = i+j;
//     return matrix;
// }

// Console.WriteLine("Input m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = indexSumMatrix(m,n);
// Show2dArray(matrix);

// int[,] QuadArray(int [,] mass)
// {
//     for(int i = 0; i < mass.GetLength(0); i+=2)
//         for(int j = 0; j < mass.GetLength(1); j+=2)
//             mass[i,j] *= mass[i,j];

//     return mass;
// }

// Console.WriteLine("Input m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] mass = CreateRandom2dArray(m, n, 1,9);
// Show2dArray(QuadArray(mass));

// int SumDiagonal(int[,] diag)
// {
//     int sum = 0;
//     for(int i = 0; i < diag.GetLength(0); i++)
//         sum += diag[i,i];

//     return sum;
// }

// Console.WriteLine("Input m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] diag = CreateRandom2dArray(m, n, 1,9);
// Show2dArray(diag);
// int sum = SumDiagonal(diag);
// Console.WriteLine($"The sum is: " + sum);

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

// void ShowShortArray(int [,] array, int rowIgnore, int columnIgnore) 
// {
//      for(int i =0; i < array.GetLength(0); i++)
//     {
//         if(i == rowIgnore) continue;
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             if(j == columnIgnore) continue;
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
// }
// int [,] DelMinStrings(int [,] array) 
// {
//     int minI = 0, minJ = 0;

//     for(int i = 0; i < array.GetLength(0); i++)
//         for(int j = 1; j < array.GetLength(1); j++)
//     {
//         if(array[i, j] < array[minI, minJ])
//         {
//             minI = i;
//             minJ = j;
//         }
//     }
//     for(int j = 0; j < array.GetLength(1); j++) array[minI, j] = 0;
//     for(int i = 0; i < array.GetLength(0); i++) array[i, minJ] = 0; 

//     return array;
// }

// Console.WriteLine("Input m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input min: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max: ");
// int max = Convert.ToInt32(Console.ReadLine());


// int[,] newArray = CreateRandom2dArray(m, n, min, max);
// Show2dArray(newArray);
// ShowShortArray(newArray, 3,4);



// int[,] ChangeRows(int[,] array, int first, int last)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         int temp = array[last, i];
//         array[last, i] = array[first,i];
//         array[first,i]=temp;
//     }
//     return array;
// }
// int[,] newArray = CreateRandom2dArray(5,4,0,9);
// Show2dArray(newArray);
// Show2dArray(ChangeRows(newArray, 2,3));

int[,] TransporateMatrix(int[,] array)
{
    if(array.GetLength(0)!= array.GetLength(1))
    {
        Console.WriteLine("Matrix is not square");
        return array;
    }
    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = i+1; j < array.GetLength(1); j++)
        {
            int temp = array[i,j];
            array[i,j] = array[j,i];
            array[j,i] = temp;
        }
        return array;
}