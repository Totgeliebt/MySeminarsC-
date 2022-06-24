
int ShowSecondDigit() {
    int rand = new Random().Next(100,1000);
    Console.WriteLine($"The number is {rand}");
    int num = rand%100/10;
  return num;
}

int res = ShowSecondDigit();
Console.WriteLine(res);