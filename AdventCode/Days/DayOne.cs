using AdventCode.Class;
using AdventCode.Days;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventCode
{
    internal class DayOne 
    {
        static private TxtReader inputOfTheDays = new("D:\\C#\\AdventCode\\AdventCode\\Inputs\\InputDay1.txt");

        static private List<Elfes> elfes = new List<Elfes>();

        public static void ResultOfTheDays()
        {
            DayInitialize.InitializeADay(1);
            List<string> inputs = inputOfTheDays.ReturnInput();
            result(inputs);
        }
        private static void result(List<string> inputs)
        {
            int nbrElfes = 0;
            for (int i = 0; i < inputs.Count - 1; i++)
            {


                if (i == 0)
                {
                    elfes.Add(new Elfes());
                }
                else
                {
                    if (!(inputs[i].Length == 0))
                    {
                        elfes[nbrElfes].AjouterCalories(Convert.ToInt32(inputs[i]));
                    }
                    else
                    {
                        nbrElfes += 1;
                        elfes.Add(new Elfes());
                    }
                }
            }
            List<Elfes> SortedList = elfes.OrderByDescending(elfe => elfe.RecupererTotalCalories()).ToList();
            Console.WriteLine("First part of Puzzle : " + SortedList[0].RecupererTotalCalories());

            int topThree = 0;


            for (int i = 0; i != 3; i++)
            {
                topThree += SortedList[i].RecupererTotalCalories();
            }
            Console.WriteLine("Second part of Puzzle : " + topThree);
        }


}
}
