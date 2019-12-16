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
                ModifyOutput(i);                                 
            }

            Console.ReadLine();
        }

        public string ModifyOutput(int input)
        {
            string stringResult = "";

            if (input % 3 != 0 && input % 5 != 0)
            {
                Console.WriteLine(input);
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

                Console.WriteLine(stringResult);                
            }

            return stringResult;
        }
    }
}
