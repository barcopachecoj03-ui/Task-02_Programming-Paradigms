using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int playerRoll;
        int computerRoll;

        do
        {
        
            playerRoll = random.Next(1, 7);
            computerRoll = random.Next(1, 7);

            Console.WriteLine($"You rolled: {playerRoll}");
            Console.WriteLine($"Computer rolled: {computerRoll}");

            if (playerRoll > computerRoll)
            {
                Console.WriteLine("Result: You win yay :)");
            }
            else if (computerRoll > playerRoll)
            {
                Console.WriteLine("Result: Computer wins :) ");
            }
            else
            {
                Console.WriteLine("Result: Its a tie lets do it again\n");
            }

        } while (playerRoll == computerRoll);
    }
}