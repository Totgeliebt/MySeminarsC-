// int DeleteDigit() {
//     int rand = new Random().Next(100,1000);
//     Console.WriteLine($"The number is {rand}");
//     int num1 = rand/100;
//     int num2 = rand%10;
//     int result = num1*10 + num2;
//   return result;
// }

// int res = DeleteDigit();
// Console.WriteLine(res);


// int RemainNum (int n1, int n2) 
// {
//     if(n2%n1 == 0) 
//     {
//         Console.WriteLine($"{n2} is divisible by {n1}");
//         return 0;
//     }
//     else 
//     {
//         int remain = n2%n1;
//         return remain;
//     }
// }

// Console.WriteLine($"Input first number ");
// int n1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Input second number ");
// int n2 = Convert.ToInt32(Console.ReadLine());

// int res = RemainNum(n1, n2);
// if(res!= 0) Console.WriteLine($"{n2} and {n1} are not divisible! Remain = {res}");
  




bool DivisisibleBothNum(int n) 
{
    if( n%7 == 0 && n%23 ==0) return true;
    else return false;
}
 
Console.WriteLine($"Input first number ");
int n = Convert.ToInt32(Console.ReadLine());

bool res = DivisisibleBothNum(n);
Console.WriteLine(res);