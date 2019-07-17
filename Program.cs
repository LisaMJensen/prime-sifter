using System;

class Program
{
  static void Main()
  {
    Console.WriteLine("PRIME SIFTER");
    Console.WriteLine("Enter a number, and I will give you all the prime numbers less than that number.");
    Console.WriteLine("Your number:");
    string answer = Console.ReadLine();
    int intAnswer = int.Parse(answer);

    Number.PrimeSifter(intAnswer);

    for (int i = 0; i < Number.numbers.Count; i++)
    {
      Console.WriteLine(Number.numbers[i]);
    }

    Main();
  }
}
