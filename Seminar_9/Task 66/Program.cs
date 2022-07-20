int ShowNumbers(int m, int n)
{
    if(n > m) return n+=ShowNumbers(m, n-1);
    else return m;
}
Console.WriteLine(ShowNumbers(1,15));
