﻿using System;
using System.Collections.Generic;

namespace exercise_78
{
    class Program
    {
        public static void Main(string[] args)
        {
            // DO NOT CHANGE THE FOLLOWING CODE!
            int[] array = new int[5];
            array[0] = 1;
            array[1] = 3;
            array[2] = 5;
            array[3] = 7;
            array[4] = 9;

            int index = 0;
            while (index < array.Length)
            {
                Console.WriteLine(array[index]);
                index++;
            }
            Console.WriteLine("");

            // Implement here
            // asking for the two indices
            int userinput1 = Convert.ToInt32(Console.ReadLine());
            int userinput2 = Convert.ToInt32(Console.ReadLine());
            int temp = array[userinput1];
            array[userinput1] = array[userinput2];
            array[userinput2] = temp;
            // and then swapping them


            // DO NOT CHANGE THE FOLLOWING CODE!
            Console.WriteLine("");
            index = 0;
            while (index < array.Length)
            {
                Console.WriteLine(array[index]);
                index++;
            }
        }

    }
}


