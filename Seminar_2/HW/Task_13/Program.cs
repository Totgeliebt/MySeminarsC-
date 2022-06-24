
int ThirdDigit(int num) 
{
  string numText = Convert.ToString(num);
    if (numText.Length > 2){
  Console.WriteLine("третья цифра -> " + numText[2]);
  return num;
}
else {
  Console.WriteLine("-> третьей цифры нет");
  return 0;
}
}

Console.WriteLine($"Input the natural number ");
int num = Convert.ToInt32(Console.ReadLine());

int res = ThirdDigit(num);
if(res!= 0) Console.WriteLine($"The third digit is {res}");
