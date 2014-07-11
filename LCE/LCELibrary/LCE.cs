using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LceLibrary
{
    public partial class Lce
    {
        /// <summary>
        /// Processes numbers from 1 to 100
        /// </summary>
        public void ProcessLceLogic()
        {
            List<int> inputList = new List<int>();
            inputList.AddRange(Enumerable.Range(1, 100));

            ProcessLceLogic(inputList);
        }

        /// <summary>
        /// Processes a list of integers specified by the client
        /// </summary>
        /// <param name="userInput"></param>
        public void ProcessLceLogic(List<int> userInput)
        {
            userInput.ForEach(i =>
            {
                ProcessLceForOneInt(i);
            });
        }

        /// <summary>
        /// This is the atomic method. If this is unit-testable, the rest of the methods are automtically testable as well.
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public String ProcessLceForOneInt(int i)
        {
            if ((i % 3 == 0) && (i % 5 == 0))
            {
                Console.WriteLine("fizzbuzz");
                return "fizzbuzz";
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("fizz");
                return "fizz";
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("buzz");
                return "buzz";
            }
            else
            {
                Console.WriteLine(i.ToString());
                return i.ToString();
            }
        }
        /// <summary>
        /// COnfigurable rules
        /// </summary>
        /// <param name="userInput"></param>
        public void ProcessLceLogic(Dictionary<int, String> businessRules, List<int> userInput)
        {
            userInput.ForEach(i =>
            {
                ProcessLceForOneInt(businessRules, i);
            });
        }

        /// <summary>
        /// configurable rules.
        /// </summary>
        /// <param name="businessRules"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        public String ProcessLceForOneInt(Dictionary<int, String> businessRules, int i)
        {
            // The assumption is that the business rules look at divisibility by one number only. (not a combination of numbers)
            // For combinations of numbers, the logic needs to be modified.
            StringBuilder outputVal = new StringBuilder();
            businessRules.ToList().ForEach(kv => {
                if (i % kv.Key == 0)
                {
                    outputVal.Append(kv.Value);
                }
            });

            // If outputVal is empty, none of the criteria is satisfied. Hence print the number itself.
            String returnVal = outputVal.ToString();
            returnVal = String.IsNullOrEmpty(returnVal) ? i.ToString() : returnVal;
            Console.WriteLine(returnVal);
            return returnVal;
        }


    }
}