

void IsPalindrome(string number){
  if (number[0]==number[4] || number[1]==number[3]){
    Console.WriteLine($"Ваше число {number} - палиндром.");
  }
  else Console.WriteLine($"Ваше число {number} - НЕ палиндром.");
}

Console.WriteLine("Input number 5-digit number: ");
string Num = Console.ReadLine();
 IsPalindrome(Num);

