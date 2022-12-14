using AdventCode.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventCode.Days
{
    internal class DayThree
    {
        static private TxtReader inputOfTheDays = new("C:\\Users\\Admin Stagiaire\\Desktop\\AdventCode\\AdventCode\\Inputs\\InputDay3.txt");
        public static void ResultOfTheDays()
        {
            DayInitialize.InitializeADay(3);
            List<string> inputs = inputOfTheDays.ReturnInput();
            result(inputs);
        }
        private static void result(List<string> inputs)
        {
            var totalPartOne = 0;
            foreach (var line in inputs)
            {
                bool found = false;
                var first = line.Substring(0, (line.Length / 2));
                var last = line.Substring((line.Length / 2), (line.Length / 2));
                foreach (char charToSearch in first)
                {

                    if (last.Contains(charToSearch) && !found)
                    {
                        var index = (charToSearch < 97 ? (charToSearch - 64) + 26 : charToSearch - 96);
                        totalPartOne += index;
                        found = true;
                    }
                }
            }
            var totalOfGroup = 0;
            for (int i = 1; i < inputs.Count() + 1; i += 3)
            {
                bool foundTwo = false;
                foreach (char charToSearchSecond in inputs[i - 1])
                {
                    if ((inputs[i].Contains(charToSearchSecond) && inputs[i + 1].Contains(charToSearchSecond)) && !foundTwo)
                    {
                        var index = (charToSearchSecond < 97 ? (charToSearchSecond - 64) + 26 : charToSearchSecond - 96);
                        totalOfGroup += index;
                        foundTwo = true;
                    }
                }

            }

            Console.WriteLine("First part of Puzzle : " + totalPartOne);
            Console.WriteLine("Second part of Puzzle : " + totalOfGroup);

        }

    }
}
