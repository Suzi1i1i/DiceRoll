using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DiceRoll
{
    internal class DiceCalc
    {
        public int[] DiceNumCalc(int n)
        {
            List<int> myList = new List<int>();//Create a list

            Random rand = new Random(); // Create a new Random object
            int[] myArray = new int[11];

            for (int i = 0; i < n; i++)
            {
                int randomNum1 = rand.Next(1, 7); // Generate the first random number between 1 and 6
                int randomNum2 = rand.Next(1, 7); // Generate the second random number between 1 and 6
                int addnum = randomNum1 + randomNum2;
                myArray[addnum - 2] ++;
            }

            return myArray;

        }
    }
}
