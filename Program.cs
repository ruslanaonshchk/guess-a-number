namespace GuessANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Guess a Number ===");
            Console.WriteLine();
            Console.WriteLine("I'm thinking of a number between 1 and 100.");
            Console.WriteLine("Try to guess it!");
            Console.WriteLine();

            Random random = new Random();

            bool keepPlaying = true;

            while (keepPlaying)
            {
                int secretNumber = random.Next(1, 101);
                List<int> guesses = new List<int>();

                while (true)
                {
                    Console.Write("Enter your guess (1-100): ");
                    string? input = Console.ReadLine();

                    bool isValidNumber = int.TryParse(input, out int guess);

                    if (!isValidNumber)
                    {
                        Console.WriteLine("Invalid input. Please enter a whole number.");
                        continue;
                    }

                    if (guess < 1 || guess > 100)
                    {
                        Console.WriteLine("Invalid input. Please enter a number between 1 and 100.");
                        continue;
                    }

                    guesses.Add(guess);

                    if (guess < secretNumber)
                    {
                        Console.WriteLine("The correct number is higher.");
                    }
                    else if (guess > secretNumber)
                    {
                        Console.WriteLine("The correct number is lower.");
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Correct! The number was {secretNumber}.");
                        Console.WriteLine($"You guessed it in {guesses.Count} attempts.");
                        Console.WriteLine($"Your guesses: {string.Join(", ", guesses)}");
                        break;
                    }
                }

                Console.WriteLine();

                while (true)
                {
                    Console.Write("Play again? (y/n): ");
                    string? playAgain = Console.ReadLine()?.ToLower();

                    if (playAgain == "y")
                    {
                        Console.WriteLine();
                        break;
                    }

                    if (playAgain == "n")
                    {
                        keepPlaying = false;
                        break;
                    }

                    Console.WriteLine("Invalid input. Please enter 'y' or 'n'.");
                }
            }
        }
    }
}