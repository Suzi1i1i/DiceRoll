using DiceRoll;
using System.Reflection;
using System.Runtime.CompilerServices;
static void DiceRoll()
{
    DiceCalc dc = new DiceCalc();
    int input = 0;

    System.Console.WriteLine("Welcome to the dice throwing simulator!");
    System.Console.WriteLine("How many dice rolls would you like to simulate?");
    input = Convert.ToInt32(Console.ReadLine());

    int[] Results = dc.DiceNumCalc(input);

    Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
    Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
    Console.WriteLine("Total number of rolls =" + input + "\n");
    for (int i = 0; i < 11; i++)
    {
        Console.Write((i + 2) + ": ");
        int percentage = (int)((Results[i] / (double)input) * 100);

        for (int j = 0; j < percentage; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }


    Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
}

