namespace GuessANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
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
                }
                else if (guess < 1 || guess > 100)
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 100.");
                }
                else
                {
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
                        Console.WriteLine("Correct! You guessed the number.");
                        Console.WriteLine($"Your guesses : {string.Join(", ",  guesses)} ");
                        break;
                    }
                }
            }
        }
    }
}