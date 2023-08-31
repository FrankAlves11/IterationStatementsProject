using System;
using System.Collections.Generic;
using System.Globalization;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {

            // Create a variable of type int and name it num
            int num = 0;
            var numbers = new List<int>();

            // Create a do-while loop
            do
            {
                num++;
                numbers.Add(num);
            } while (num < 50);

            // Create a while loop
            while (num < 200)
            {
                num++;
                numbers.Add(num);
            }

            Console.WriteLine("Increase:");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("");
            Console.WriteLine("Decrease:");

            // Create a for loop to print the numbers in reverse order - from 200 to 1
            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
              

            
            
               
            

          
        
    
}
