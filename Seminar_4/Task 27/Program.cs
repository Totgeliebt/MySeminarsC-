int FindSum(int num)
{
    int sum = 0;
    int digit = 1;
    while(digit != 0){
        digit = num %10;
        sum+=digit;
        num = num/10;
    }
    return sum;
}


Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(FindSum(num));