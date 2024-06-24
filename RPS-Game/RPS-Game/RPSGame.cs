using System;

namespace RPS_Game
{
    public class RPSGame
    {
        private Player playerOne;
        private Player playerTwo;
        private Random rand;
        private string[] aiMoves;

        public RPSGame(Player playerOne, Player playerTwo)
        {
            this.playerOne = playerOne;
            this.playerTwo = playerTwo;
            this.rand = new Random();
            this.aiMoves = new string[] { "rock", "paper", "scissors" };
        }

        public void PlayGame()
        {
            int round = 1;

            while (playerOne.Score < 3 && playerTwo.Score < 3)
            {
                Console.WriteLine($"Round {round}:");
                string playerOneMove = playerOne.ChooseMove();
                string playerTwoMove = aiMoves[rand.Next(aiMoves.Length)];
                Console.WriteLine($"AI chose: {playerTwoMove}");

                string result = CompareMoves(playerOneMove, playerTwoMove);
                Console.WriteLine(result);
                Console.WriteLine($"{playerOne.Name}'s Score: {playerOne.Score}");
                Console.WriteLine($"{playerTwo.Name}'s Score: {playerTwo.Score}");
                Console.WriteLine();

                round++;
            }
        }

        public string CompareMoves(string playerOneMove, string playerTwoMove) 
        {
            if (playerOneMove == playerTwoMove)
            {
                return "Same Move. Draw!";
            }
            else if ((playerOneMove == "rock" && playerTwoMove == "scissors") ||
                     (playerOneMove == "paper" && playerTwoMove == "rock") ||
                     (playerOneMove == "scissors" && playerTwoMove == "paper"))
            {
                playerOne.Score++;
                return $"{playerOne.Name} wins! {playerOneMove} beats {playerTwoMove}.";
            }
            else
            {
                playerTwo.Score++;
                return $"{playerTwo.Name} wins! {playerTwoMove} beats {playerOneMove}.";
            }
        }
    }
}
