using System;

namespace RPS_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Player playerOne = new Player("Ibrahim");
                Player playerTwo = new Player("AI");

                RPSGame game = new RPSGame(playerOne, playerTwo);
                game.PlayGame();

                if (playerOne.Score > playerTwo.Score)
                {
                    Console.WriteLine($"{playerOne.Name} is the overall winner!");
                }
                else if (playerTwo.Score > playerOne.Score)
                {
                    Console.WriteLine($"{playerTwo.Name} is the overall winner!");
                }
                else
                {
                    Console.WriteLine("The game is a draw!");
                }
            }

            catch (FormatException e)
            {
                Console.WriteLine("Please , Try Again.");
                Console.WriteLine(e.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                Console.WriteLine("The Game Finished.");
            }
        }
    }
}
