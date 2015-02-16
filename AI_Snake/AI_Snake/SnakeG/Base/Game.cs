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

        public abstract GameState makeMove(GameState gameState, int player, Object move);

        /// <summary>
        /// Creates a new gamestate for the game.
        /// </summary>
        /// <param name="move"></param>
        /// <returns>the new gamestate</returns>
        public GameState makeMove(GameState gameState, Object move)
        {
            if(isGameOver(gameState) != -1)
                return gameState;

            GameState newS = makeMove(gameState, 0, move);
            return newS;
        }

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
