using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoll
{
    internal class DiceCalc
    {
        public DiceCalc()
        {
            List<int> myList = new List<int>();//Create a list

            Random rand = new Random(); // Create a new Random object
            int n = Program.input; // Number of times you want to generate random numbers
            int[] myArray = new int[12];

            for (int i = 0; i<n; i++)
            {
                int randomNum1 = rand.Next(1, 7); // Generate the first random number between 1 and 6
                int randomNum2 = rand.Next(1, 7); // Generate the second random number between 1 and 6

                int addnum = randomNum1 + randomNum2;
                myList.Add(addnum); //add all the variables to the list
            }

            for (int i = 1; i <= 12; i++)    //count the numbers of 1s-6s
            {
                int count = 0;
                foreach (int number in myList)
                {
                    if (number == i)
                    {
                        count++;
                        myArray[i - 1] = count;
                    }
                }
            }



        }
}
