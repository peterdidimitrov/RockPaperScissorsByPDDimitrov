using System;

namespace RockPaperScissirs
{
    internal class RockPaperScissors
    {
        static void Main(string[] args)
        {
            const string Rock = "Rock";
            const string Paper = "Paper";
            const string Scissors = "Scissors";

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Please type your name, then press ENTER:");

            string name = Console.ReadLine();

            Console.Write("Choose [r]ock, [p]aper or [s]cissors, then press ENTER: ");

            int playerScore = 0;
            int computerScore = 0;

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                string playerMove = Console.ReadLine();
                Console.ResetColor();

                if (playerMove == "r" || playerMove == "rock")
                {
                    playerMove = Rock;
                }
                else if (playerMove == "p" || playerMove == "paper")
                {
                    playerMove = Paper;
                }
                else if (playerMove == "s" || playerMove == "scissors")
                {
                    playerMove = Scissors;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid Input. Try Again...");
                    Console.ResetColor();
                    continue;
                }

                Random random = new Random();
                int computerRandomNumber = random.Next(1, 4);
                string computerMove = string.Empty;

                switch (computerRandomNumber)
                {
                    case 1:
                        computerMove = Rock;
                        break;
                    case 2:
                        computerMove = Paper;
                        break;
                    case 3:
                        computerMove = Scissors;
                        break;
                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"This computer chose {computerMove}.");
                Console.ResetColor();

                if ((playerMove == Rock && computerMove == Scissors) ||
                    (playerMove == Paper && computerMove == Rock) ||
                    (playerMove == Scissors && computerMove == Paper))
                {
                    playerScore++;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You win.");
                    Console.ResetColor();
                }
                else if ((playerMove == Rock && computerMove == Paper) ||
                    (playerMove == Paper && computerMove == Scissors) ||
                    (playerMove == Scissors && computerMove == Rock))
                {
                    computerScore++;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You lose.");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("This game was a draw.");
                    Console.ResetColor();
                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"{name}: {playerScore} Computer: {computerScore}");

                Console.WriteLine("Type [yes] to Play Again or [no] to quit: ");

                Console.ForegroundColor = ConsoleColor.Yellow;

                string userChoice = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.White;

                if (userChoice == "yes" || userChoice == "Yes" || userChoice == "Y" || userChoice == "y")
                {
                    Console.Write("Choose [r]ock, [p]aper or [s]cissors, then press ENTER: ");
                }
                else
                {
                    Console.WriteLine("Thank you for Playing!");
                    return;
                }
            }
        }
    }
}