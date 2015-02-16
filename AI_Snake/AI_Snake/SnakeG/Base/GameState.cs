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
        public abstract SnakeGameState Copy();

        public abstract bool Equals(GameState compare);
    }
}
