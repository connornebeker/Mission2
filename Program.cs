// See https://aka.ms/new-console-template for more information
// Connor Nebeker
// IS 413 Section 002
// Program that simulates a dice roll and track the number of rolls for each number

using System;
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
}
    
    