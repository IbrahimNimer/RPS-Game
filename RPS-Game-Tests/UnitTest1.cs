using RPS_Game;
using Xunit;

namespace RPS_Game_Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("rock", "paper", "AI")]
        [InlineData("scissors", "rock", "AI")]
        [InlineData("paper", "scissors", "AI")]
        public void TestRoundWinner(string player1Move, string player2Move, string expectedWinner)
        {
            // Arrange
            Player playerA = new Player("Ibrahim");
            Player playerB = new Player("AI");
            RPSGame game = new RPSGame(playerA, playerB);

            // Act
            string result = game.CompareMoves(player1Move, player2Move);

            // Assert
            Assert.Contains(expectedWinner, result);
        }

        [Theory]
        [InlineData("rock", "paper", 1)]
        [InlineData("scissors", "rock", 1)]
        [InlineData("paper", "scissors", 1)]
        public void TestRoundScore(string player1Move, string player2Move, int expectedScore)
        {
            // Arrange
            Player playerA = new Player("Ibrahim");
            Player playerB = new Player("AI");
            RPSGame game = new RPSGame(playerA, playerB);

            // Act
            game.CompareMoves(player1Move, player2Move);

            // Assert
            Assert.Equal(expectedScore, playerB.Score);
        }
    }
}
