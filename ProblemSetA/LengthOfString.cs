using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSetA
{
    class LengthOfString
    {
        public int GetStringLength()
        {
            
            Console.WriteLine("Enter String to count: ");
            string userInput = Console.ReadLine();
            Console.WriteLine("You have " + userInput.Length + " characters in your string");
            return userInput.Length;

        }

    }    
}
