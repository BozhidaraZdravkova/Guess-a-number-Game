namespace GuessANumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Random random = new Random();
                int number = random.Next(1, 101);

                string input = "";
                int guessNumber = 0;

                while (true)
                {
                    guessNumber = 0;
                    Console.WriteLine("Enter a number to guess: ");
                    input = Console.ReadLine();
                    bool isNumber = int.TryParse(input, out guessNumber);
                    if (!isNumber || guessNumber < 1 || guessNumber > 100)
                    {
                        Console.WriteLine("Please enter a valid number in range of 1 - 100");
                        continue;
                    }
                    if (guessNumber > number)
                    {
                        Console.WriteLine("Too high!");
                    }
                    else if (guessNumber < number)
                    {
                        Console.WriteLine("Too low!");
                    }
                    else
                    {
                        Console.WriteLine("You guessed the number");
                        break;
                    }
                }
                Console.WriteLine("Do you want to play again? y/n:");
                input = Console.ReadLine();
                if (input == "y" || input == "yes")
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
        }
    }
}
