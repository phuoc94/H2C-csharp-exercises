﻿using System;

namespace exercise_39
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      int sum = 0;
      while(true){
            Console.WriteLine("Give a number:");
            string userInput1 = Console.ReadLine();
            int number = Convert.ToInt32(userInput1);

            if(number == 0){
                break;
                }
            else{
               sum = sum + number;
                }
            }
      Console.WriteLine($"Total sum of numbers: {sum}");
    }
  }
}
