void ShowBiggerDigit()
{
int rand = new Random.Next(10, 99);
Console.WriteLine($"The num is {rand}");
int dec = rand/10;
int ed = rand%10;
int max;
if(dec > ed) max = dec;
else max = ed;
    Console.WriteLine($"Bigger digit is {max}");
}
ShowBiggerDigit();