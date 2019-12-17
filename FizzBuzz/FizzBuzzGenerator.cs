using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    public class FizzBuzzGenerator
    {        
        public void Start()
        {
            for (int i = 1; i <= 100; i++)
            {
                var output = ModifyOutput(i);
                Console.WriteLine(output);
            }

            Console.ReadLine();
        }

        public string ModifyOutput(int input)
        {
            string stringResult = "";

            if (input % 3 != 0 && input % 5 != 0)
            {                
                return stringResult = input.ToString();
            }

            else
            {                
                if (input % 3 == 0)
                {
                    stringResult = "Fizz";
                }

                if (input % 5 == 0)
                {
                    stringResult += "Buzz";
                }                             
            }

            return stringResult;
        }
    }
}
