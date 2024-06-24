using System;

namespace RPS_Game
{
    public class Player
    {
        private string name;
        private int score = 0;

        public Player(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Score
        {
            get { return score; }
            set { score = value; }
        }

        public string ChooseMove()
        {
            Console.WriteLine($"{name}, please enter your move ('rock', 'paper', or 'scissors'):");
            string move = Console.ReadLine()?.ToLower(); 

            while (move != "rock" && move != "paper" && move != "scissors")
            {
                Console.WriteLine("Invalid move. Please enter 'rock', 'paper', or 'scissors':");
                move = Console.ReadLine()?.ToLower(); 
            }
            return move;
        }
    }
}
