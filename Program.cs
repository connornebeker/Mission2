// See https://aka.ms/new-console-template for more information
// Connor Nebeker
// IS 413 Section 002
// Program that simulates a dice roll and track the number of rolls for each number

using Mission2;

internal class Program
{
    private static Roll roll = new Roll();

    private static void Main(string[] args)
    {
        //Intro message and input prompt
        Console.WriteLine("Welcome to the dice throwing simulator!" + "\n\n" +
                          "How many dice rolls would you like to simulate?");
        //Input reader, casting the input to an integer
        int rollNum = int.Parse(Console.ReadLine());

        //Calls the Rolltime method, passing it the parameter that the user input
        roll.RollTime(rollNum);
    }

    public void Results(int[] numArray, int rollcnt)
    {
        // intro to the results section
        Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS" + "\n" + 
                          "Each \"*\" represents 1% of the total number of rolls"
                          + "\n" + "Total Number of rolls = " + rollcnt + "\n");

        //for loop that prints the results for each number (2-12)
        for (int i = 0; i < numArray.Length; i++)
        {
            //calculates the percentage
            double percentage = (double)numArray[i] / rollcnt * 100;
            //rounds the percentage to the nearest integer
            int roundedPercentage = (int)Math.Round(percentage);
            //assures that numbers below 1, and above 0, print at least 1 '*'
            int starsToPrint = Math.Max(1, roundedPercentage);

            //if statement insuring that stars don't print for numbers with 0 rolls
            if (roundedPercentage > 0)
            {
                Console.WriteLine($"{i + 2}: {new string('*', starsToPrint)}");
            }
            else
            {
                Console.WriteLine($"{i + 2}:");
            }
        }
            
        //goodbye message!
        Console.WriteLine("\nThank you for using the dice rolling simulator. Goodbye!");
    }
}

    
    