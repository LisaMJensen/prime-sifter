using System;
using System.Collections.Generic;

class Number
{
  public static List<int> numbers = new List<int> {};

  public static void PrimeSifter(int inputNumber)
  {
    numbers.Clear();
    // Generates a list of numbers from 2 to the input number
    for (int i = 2; i <= inputNumber; i++)
    {
      numbers.Add(i);
    }

    // Loops through prime numbers starting with 2, which is numbers[0]
    for (int i = 0; i < numbers.Count; i++){
      int prime = numbers[i];
      // Loop through every number in the list to check if divisible by the current prime number
      for (int j = 0; j < numbers.Count; j++)
      {
        if (numbers[j] % prime == 0 && numbers[j] - prime != 0)
        {
          numbers.Remove(numbers[j]);
        }
      }
    }
  }
}
