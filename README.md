# Guess a Number

A simple console-based guessing game written in C#.

The application generates a random number between 1 and 100, and the player tries to guess it.
After each guess, the application indicates whether the correct number is higher or lower.
The game continues until the correct number is guessed.

## Features

- Generates a random number between 1 and 100.
- Provides higher or lower hints after each guess.
- Validates user input and accepts only whole numbers between 1 and 100.
- Stores all valid guesses made during the game.
- Displays the number of attempts and guess history at the end.
- Allows the player to start a new game after guessing correctly.

## Technologies

- C#
- .NET 10
- .NET Console Application

## Getting Started

### Prerequisites

To run the project, you need:

- .NET 10 SDK

Check your installed .NET version:

```bash
dotnet --version
```

### Run the Application

Clone the repository:

```bash
git clone <repository-url>
```

Navigate to the project directory:

```bash
cd guess-a-number
```

Run the application:

```bash
dotnet run
```

## How to Play

1. Start the application.
2. Enter a whole number between 1 and 100.
3. The application will tell you whether the correct number is higher or lower.
4. Continue guessing until you find the correct number.
5. After guessing correctly, the application displays:
    - the correct number
    - the number of attempts
    - all valid guesses made during the game
6. Choose whether you want to play again.

## Project Structure

```text
guess-a-number/
├── Program.cs
├── GuessANumber.csproj
├── README.md
└── .gitignore
```

- `Program.cs` — contains the application logic and entry point.
- `GuessANumber.csproj` — defines the .NET project configuration and target framework.
- `README.md` — provides an overview and instructions for running the project.
- `.gitignore` — specifies files and directories that Git should not track.