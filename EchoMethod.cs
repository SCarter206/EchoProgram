using System;
using System.Collections.Generic;
using System.Text;

namespace echo_program
{
    public class Class1
    {
        public string Echo()
        {
            Console.WriteLine("enter text here: ");
            string input = Console.ReadLine();
            Console.WriteLine(input);
            return input;
        }
            
    }
}
