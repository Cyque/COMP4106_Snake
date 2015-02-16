using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AI_Snake
{
    public class SnakeGame : Game
    {

        public SnakeGame(SnakeGameState gameState)
            : base(gameState)
        {
        }

        public override GameState makeMove(int player, Object move)
        {
            return null;
        }

        protected override int calculateGameOver()
        {
            //for (int i = 0; i < snakes.Count; i++)
            //{
            //    if (snakes[i].Head.X == 0 || snakes[i].Head.X == tiles.GetLength(0) - 1 || snakes[i].Head.Y == 0 || snakes[i].Head.Y == tiles.GetLength(1) - 1)
            //    {
            //        gameOver = true;
            //        OnGameOver(i);
            //    }

            //    for (int j = 0; j < snakes.Count; j++)
            //        if (snakes[j].intersects(snakes[i]))
            //        {
            //            gameOver = true;
            //            OnGameOver(i);
            //        }
            //}

            return -1;
        }
    }
}
