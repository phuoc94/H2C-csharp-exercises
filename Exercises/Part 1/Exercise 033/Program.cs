﻿using System;

namespace exercise_33
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Give the first string:");
      string userInput1 = Console.ReadLine();

      Console.WriteLine("Give the second string:");
      string userInput2 = Console.ReadLine();


    if(userInput1 == userInput2){
            Console.WriteLine("Echo!");
            }
    else {
            Console.WriteLine("Nope!");
            }
    }
  }
}
