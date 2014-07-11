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
            //LCELibrary.LCE.ProcessLCELogic();
            List<int> userInput = new List<int>();
            userInput.AddRange(Enumerable.Range(200, 100));
            LceLibrary.Lce client = new  LceLibrary.Lce();
            client.ProcessLceLogic(userInput);

            // configurable rules
            // key is the divisible by number
            // value is the string that needs to be printed if divisible by that number
            Dictionary<int, string> configRules = new Dictionary<int, string>() { {2, "D2"},  {4, "D4"}, {6, "D6"} };
            client.ProcessLceLogic(configRules, userInput);
        }
    }
}
