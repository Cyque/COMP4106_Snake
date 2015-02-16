using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AI_Snake
{
    public abstract class Game
    {
        protected GameState gameState;

        public delegate void gameChangedHandler(GameState gameState);
        public delegate void gameOverHandler(int player);

        public event gameChangedHandler OnGameChanged;
        public event gameOverHandler OnGameOver;


        public Game(GameState gameState)
        {
            this.gameState = gameState;
        }

        public abstract GameState makeMove(int player, Object move);

        /// <summary>
        /// Creates a new gamestate for the game.
        /// </summary>
        /// <param name="move"></param>
        /// <returns>the new gamestate</returns>
        public GameState makeMove(Object move)
        {
            gameState = makeMove(0, move);
            OnGameChanged(gameState);
            return gameState;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns> -1 = game not over, [0 1 2...] index of winning player</returns>
        public int isGameOver()
        {
            int result = calculateGameOver();
            OnGameOver(result);
            return result;
        }

        protected abstract int calculateGameOver();
    }
}
