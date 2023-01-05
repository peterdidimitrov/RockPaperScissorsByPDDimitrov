using System;

namespace RockPaperScissirs
{
    internal class RockPaperScissors
    {
        static void Main(string[] args)
        {
            //Initialising Rock, Paper and Scissors
            const string Rock = "Rock";
            const string Paper = "Paper";
            const string Scissors = "Scissors";

            //The user can enter a name
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Please type your name, then press ENTER:");

            string userName = Console.ReadLine();

            //the user is choosing between Rock, Paper or Scissors
            Console.Write("Choose [r]ock, [p]aper or [s]cissors, then press ENTER: ");

            //Initialising player's score and computer's score
            int playerScore = 0;
            int computerScore = 0;

            //Initializing counter, which helps for increasing user's chance to win
            int counter = 0;

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
                    //If the user enters invalid move, the program displays special message
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid Input. Try Again...");
                    Console.ResetColor();
                    continue;
                }

                //Increasing counter every time, after user enters correct move
                counter++;

                //Initializing "random" to shuffle computer's choice
                Random random = new Random();
                int computerRandomNumber = random.Next();

                //Increasing user's chance to win by removing the third case: "Scissors", every second round
                if (counter % 2 == 0)
                {
                    computerRandomNumber = random.Next(1, 3);
                }
                else
                {
                    computerRandomNumber = random.Next(1, 4);
                }

                //Initializing computer's move
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

                //Displaying computer's move
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"This computer chose {computerMove}.");
                Console.ResetColor();

                //Defining conditions of win or lose and increasing player's or computer's score, depending of ending of round
                //Displaying message for every possible ending of game with different colour
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

                //Displaying current result
                Console.WriteLine($"{userName}: {playerScore} Computer: {computerScore}");

                //The user has to decide: to play again or to quit the game
                Console.WriteLine("Type [yes] to Play Again or [no] to quit, then press ENTER: ");

                Console.ForegroundColor = ConsoleColor.Yellow;

                string userChoice = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.White;

                //If user choose to continue the game the program restarts and displays a message, else stops and again displays a different message
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
