/*
 * Rock Paper Scissors Game
 * 
 * This program is a simple implementation of the Rock Paper Scissors game in C#.
 * It allows the player to play against the computer and keeps track of the scores.
 * The game continues until one of the players reaches a score of 3.
 * 
 * Author: Soroush Abdoli
 * GitHub: https://github.com/soroushabd */

/**************************************************************
 * Requirements:
 * - .NET Core SDK 7.0
 * - C# compatible development environment (e.g., Visual Studio,
 *   Visual Studio Code, JetBrains Rider)
 **************************************************************/

/**************************************************************
 * Installation:
 * 1. Clone the repository or download the source code files.
 * 2. Open the project in your preferred C# development
 *    environment.
 * 3. Build the project to restore the dependencies and compile
 *    the executable.
 **************************************************************/

/**************************************************************
 * Usage:
 * 1. Open the command-line interface or the built-in terminal
 *    in your development environment.
 * 2. Navigate to the project directory.
 * 3. Execute the compiled executable file.
 * 4. Follow the on-screen instructions to play the game.
 * 5. When prompted, choose between ROCK, PAPER, or SCISSORS
 *    by entering the corresponding option.
 * 6. The computer will generate its choice randomly.
 * 7. After each round, the game will display the result and
 *    update the scores.
 * 8. The game continues until one player reaches a score of 3.
 * 9. The final winner is declared, and the option to play
 *    again is presented.
 **************************************************************/


namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputCPU;
            int randomInt;
            int scorePlayer = 0;
            int scoreCPU = 0;
            bool playAgain = true;

            // Main Game loop
            while (playAgain)
            {
                // Reset scores for a new game
                scorePlayer = 0;
                scoreCPU = 0;

                // Game Round Loop
                while (scorePlayer < 3 && scoreCPU < 3)
                {
                    Console.WriteLine($"\n\t\t scorePlayer: {scorePlayer} \t\t scoreCPU: {scoreCPU}\n\n");
                    Console.Write("Choose between ROCK, PAPER, SCISSORS:    ");
                    inputPlayer = Console.ReadLine();
                    inputPlayer = inputPlayer.ToUpper();

                    // Generate random choice for the computer
                    Random rnd = new Random();
                    randomInt = rnd.Next(1, 4);

                    // Determine the winner of the round
                    switch (randomInt)
                    {
                        case 1:
                            inputCPU = "ROCK";
                            Console.WriteLine("Computer chose ROCK");
                            if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("PLAYER WINS!!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("CPU WINS!!\n\n");
                                scoreCPU++;
                            }
                            break;
                        case 2:
                            inputCPU = "PAPER";
                            Console.WriteLine("Computer chose PAPER");
                            if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("CPU WINS!!\n\n");
                                scoreCPU++;

                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("DRAW!!\n\n");

                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("PLAYER WINS!!\n\n");
                                scorePlayer++;
                            }
                            break;
                        case 3:
                            inputCPU = "SCISSORS";
                            Console.WriteLine("Computer chose SCISSORS");
                            if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("PLAYER WINS!!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("CPU WINS!!\n\n");
                                scoreCPU++;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid entry!");
                            break;
                    }
                }

                // Determine the winner of the game
                if (scorePlayer == 3)
                {
                    Console.WriteLine($"\n\t\t scorePlayer: {scorePlayer} \t\t scoreCPU: {scoreCPU}\n\n");

                    Console.WriteLine("Player WON!!\n\n");
                }
                else if (scoreCPU == 3)
                {
                    Console.WriteLine($"\n\t\t scorePlayer: {scorePlayer} \t\t scoreCPU: {scoreCPU}\n\n");

                    Console.WriteLine("Computer WON!!\n\n");
                }
                else
                {

                }

                // Ask the user if they want to play again
                Console.WriteLine("Do you want to play again?(y/n)");
                string loop = Console.ReadLine();
                if (loop == "y")
                {
                    playAgain = true;
                    Console.Clear();
                }
                else if (loop == "n")
                {
                    playAgain = false;
                }
                else
                {
                    Console.WriteLine("Invalid entry!");
                }
            }
        }
    }
}