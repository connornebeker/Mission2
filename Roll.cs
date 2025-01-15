namespace Mission2;

public class Roll
{
    public void RollTime(int rollcnt)
        {   //sets up for the random number
            Random random = new Random();
            
            //instantiates an array to store the number of rolls per die
            int[] numArray = new int[11];
            
            //for loop that rolls the dice the amount that the user input
            for (int i = 0; i < rollcnt; i++)
            {
                //generates random numbers for each die
                int randNum1 = random.Next(1, 7);
                int randNum2 = random.Next(1, 7);
                
                //adds the numbers together (for the 2 dice)
                int num = randNum1 + randNum2;
                
                //increments the corresponding roll in the array
                numArray[num - 2]++;

            }
            
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
