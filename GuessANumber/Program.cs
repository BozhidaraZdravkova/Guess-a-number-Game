namespace GuessANumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int levelup = 101;
            while (true)
            {
                Random random = new Random();
                int number = random.Next(1, levelup);

                string input = "";
                int guessNumber = 0;

                int tries = 0;
                while (true)
                {
                    if (tries >= 6)
                    {
                        Console.WriteLine("You didn't guess the number. Try again!");
                        break;
                    }
                    guessNumber = 0;
                    Console.WriteLine($"Enter a number in range (1 - {levelup - 1}): ");
                    input = Console.ReadLine();
                    bool isNumber = int.TryParse(input, out guessNumber);
                    if (!isNumber || guessNumber < 1 || guessNumber > (levelup - 1))
                    {
                        Console.WriteLine($"Please enter a valid number in range of 1 - {levelup - 1}");
                        continue;
                    }
                    if (guessNumber > number)
                    {
                        Console.WriteLine("Too high!");
                        tries++;
                    }
                    else if (guessNumber < number)
                    {
                        Console.WriteLine("Too low!");
                        tries++;
                    }
                    else
                    {
                        Console.WriteLine("You guessed the number");
                        levelup += 100;
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
