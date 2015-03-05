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
        public int stepsToReach;

        public GameState(GameState lastState, object moveToGetHere, int stepsToReach)
        {
            reachedGoalHere = false;
            this.lastState = lastState;
            this.moveToGetHere = moveToGetHere;
            this.stepsToReach = stepsToReach;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="moveToGetHere">The move taken to get to the copied state</param>
        /// <returns></returns>
        public abstract GameState Copy(object moveToGetHere);

        public abstract bool Equals(GameState compare);

    }
}
