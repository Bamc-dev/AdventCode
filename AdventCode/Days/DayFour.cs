using AdventCode.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventCode.Days
{
    internal class DayFour
    {
        static private TxtReader inputOfTheDays = new("C:\\Users\\Admin Stagiaire\\Desktop\\AdventCode\\AdventCode\\Inputs\\InputDay4.txt");

        public static void ResultOfTheDays()
        {
            DayInitialize.InitializeADay(4);
            List<string> inputs = inputOfTheDays.ReturnInput();
            result(inputs);
        }
        private static void result(List<string> inputs)
        {
            int count = 0;
            foreach (var line in inputs)
            {
                var splittedLines = line.Split(',','-');
                
                
                if (int.Parse(splittedLines[1]) - int.Parse(splittedLines[0]) < int.Parse(splittedLines[3]) - int.Parse(splittedLines[2]))
                {

                    IEnumerable<int> range = Enumerable.Range(int.Parse(splittedLines[2]), (int.Parse(splittedLines[3]) - int.Parse(splittedLines[2])) + 1);
                    if (range.Where(x => x == int.Parse(splittedLines[0])).Count() != 0)
                        if (range.Where(y => y == int.Parse(splittedLines[1])).Count() != 0)
                            count++;
                    
                }
                else
                {
                    IEnumerable<int> range = Enumerable.Range(int.Parse(splittedLines[0]), (int.Parse(splittedLines[1]) - int.Parse(splittedLines[0])) + 1);
                    if (range.Where(x => x == int.Parse(splittedLines[2])).Count() != 0)
                        if (range.Where(y => y == int.Parse(splittedLines[3])).Count() != 0)
                            count++;
                }
            }
            Console.WriteLine("First part of Puzzle : "+count);
        }
    }
}
