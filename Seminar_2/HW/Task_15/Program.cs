
void CheckTheDayOfTheWeek (int DayOfTheWeek) {
  if (DayOfTheWeek == 6 || DayOfTheWeek == 7) {
  Console.WriteLine("Hurray! It's the weekend!");
  }
  else Console.WriteLine("Argh! It's time to work hard!");
}
Console.Write("Input the number of the day of the week from 1 to 7 ");
int DayOfTheWeek = Convert.ToInt32(Console.ReadLine());

CheckTheDayOfTheWeek(DayOfTheWeek);