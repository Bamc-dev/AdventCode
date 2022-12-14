using AdventCode.Class;
using AdventCode.Days;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventCode
{
    internal class DayTwo
    {
        static private TxtReader inputOfTheDays = new("C:\\Users\\Admin Stagiaire\\Desktop\\AdventCode\\AdventCode\\Inputs\\InputDay2.txt");

        public static void ResultOfTheDays()
        {
            DayInitialize.InitializeADay(2);
            List<string> inputs = inputOfTheDays.ReturnInput();
            result(inputs);
        }
        public static void result(List<string> inputs)
        {
            int sumPartOne = 0;
            int sumPartTwo = 0;
            foreach (var line in inputs)
            {
                sumPartOne += ReturnScorePartOne(line);
                sumPartTwo += ReturnScorePartTwo(line);
            }
            Console.WriteLine("First part of puzzle : " + sumPartOne);
            Console.WriteLine("Second part of puzzle : " + sumPartTwo);
        }

        private static int ReturnScorePartOne(string line)
        {
            int score = 0;
            char[] chars = new char[] { line[0], line[2] };
            switch (chars[1])
            {
                case 'X':
                    score += 1;
                    break;
                case 'Y':
                    score += 2;
                    break;
                case 'Z':
                    score += 3;
                    break;
                default:
                    break;
            }
            score += WinOrLooseOrDraw(chars[0], chars[1]);
            return score;
        }

        private static int ReturnScorePartTwo(string line)
        {
            int score = 0;
            char[] chars = new char[] { line[0], line[2] };
            switch (ChooseRightChar(chars[0], chars[1]))
            {
                case 'X':
                    score += 1;
                    break;
                case 'Y':
                    score += 2;
                    break;
                case 'Z':
                    score += 3;
                    break;
                default:
                    break;
            }
            score += WinOrLooseOrDraw(chars[0], ChooseRightChar(chars[0], chars[1]));
            return score;
        }

        private static int WinOrLooseOrDraw(char char1, char char2)
        {
            switch (char1)
            {
                case 'A':
                    switch (char2)
                    {
                        case 'X':
                            return 3;
                        case 'Y':
                            return 6;
                        default:
                            return 0;
                    }
                case 'B':
                    switch (char2)
                    {
                        case 'X':
                            return 0;
                        case 'Y':
                            return 3;
                        default:
                            return 6;
                    }
                default:
                    switch (char2)
                    {
                        case 'X':
                            return 6;
                        case 'Y':
                            return 0;
                        default:
                            return 3;
                    }
            }
        }

        private static char ChooseRightChar(char char1, char char2)
        {
            switch (char1)
            {
                case 'A':
                    switch (char2)
                    {
                        case 'X':
                            return 'Z';
                        case 'Y':
                            return 'X';
                        default:
                            return 'Y';
                    }
                case 'B':
                    switch (char2)
                    {
                        case 'X':
                            return 'X';
                        case 'Y':
                            return 'Y';
                        default:
                            return 'Z';
                    }
                default:
                    switch (char2)
                    {
                        case 'X':
                            return 'Y';
                        case 'Y':
                            return 'Z';
                        default:
                            return 'X';
                    }
            }
        }


    }
}
