using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AI_Snake
{
    public abstract class Game
    {
        public Game()
        { }

        public GameState makeMove(GameState gameState, int player, Object move)
        {
            if (isGameOver(gameState) != -1)
                return gameState;

            //newS.reachedGoalHere = false;
            GameState newS = makeGameMove(gameState, player, move);
            return newS;
            
        }

        protected abstract GameState makeGameMove(GameState gameState, int player, Object move);

        public abstract List<Object> getMoves();

        /// <summary>
        /// 
        /// </summary>
        /// <returns> -1 = game not over, [0 1 2...] index of winning player</returns>
        public int isGameOver(GameState gameState)
        {
            return calculateGameOver(gameState);
        }

        protected abstract int calculateGameOver(GameState gameState);

    }
}
