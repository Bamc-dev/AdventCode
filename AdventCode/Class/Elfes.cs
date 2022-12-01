using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventCode
{
    internal class Elfes
    {
        private int _calories = 0;

        public Elfes()
        {

        }

        public void AjouterCalories(int nombreCalories)
        {
            _calories += nombreCalories;
        }

        public int RecupererTotalCalories()
        {
            return _calories;
        }
    }
}
