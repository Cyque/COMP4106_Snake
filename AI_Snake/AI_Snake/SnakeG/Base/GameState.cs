using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AI_Snake
{
    /// <summary>
    /// contains the game state for a game
    /// </summary>
    public abstract class GameState
    {
        public GameState lastState;

        public object moveToGetHere;
        public bool reachedGoalHere;

        public GameState(GameState lastState, object moveToGetHere)
        {
            reachedGoalHere = false;
            this.lastState = lastState;
            this.moveToGetHere = moveToGetHere;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="moveToGetHere">The move taken to get to the copied state</param>
        /// <returns></returns>
        public abstract SnakeGameState Copy(object moveToGetHere);

        public abstract bool Equals(GameState compare);

        public abstract override int GetHashCode();
    }
}
