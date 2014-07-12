using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LceLibrary;

namespace LCE
{
    class Program
    {
        static void Main(string[] args)
        {
            //LCELibrary.LCE.ProcessLceLogic();
            // This is just for testing purposes.
            Console.WriteLine(int.MaxValue);
            // I have seen that the Max. Length of List<int> on my machine is 536870896
            // Anything higher than that would cause an OutOfMemory exception, based on how the CLR is implemented.
            // In order to process 100000000 ints, we will need to use two List<int> variables.
            List<int> userInput1 = new List<int>(536870896);
            userInput1.AddRange(Enumerable.Range(1, 500000000));
            List<int> userInput2 = new List<int>(536870896);
            //Console.WriteLine(userInput1.Last().ToString());
            userInput2.AddRange(Enumerable.Range(500000001, 500000000));
            //Console.WriteLine(userInput2.First().ToString());
            LceLibrary.Lce client = new  LceLibrary.Lce();
            client.ProcessLceLogic(userInput1);
            client.ProcessLceLogic(userInput2); 

            // configurable rules
            // key is the divisible by number
            // value is the string that needs to be printed if divisible by that number
            Dictionary<int, string> configRules = new Dictionary<int, string>() { {2, "D2"},  {4, "D4"}, {6, "D6"} };
            client.ProcessLceLogic(configRules, userInput1);
        }
    }
}
