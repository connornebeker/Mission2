namespace Mission2;

public class Roll
{
    private Program program = new Program();
    public void RollTime(int rollcnt)
    {
        //sets up for the random number
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
        
        program.Results(numArray, rollcnt);
    }
}