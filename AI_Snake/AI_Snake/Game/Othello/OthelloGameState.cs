using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace AI_Snake
{
    public class OthelloGameState : GameState
    {
        private int[,] items;
        private int whosTurn;

        public int[,] Items { get { return items; } }
        public int WhosTurn { get { return whosTurn; } }

        public OthelloGameState(OthelloGameState lastState, object moveToGetHere, int stepsToReach, int[,] items, int whosTurn)
            : base(lastState, moveToGetHere, stepsToReach)
        {
            this.items = items;
            this.whosTurn = whosTurn;
        }

        public override GameState Copy(object moveToGetHere)
        {
            int[,] newItems = new int[8, 8];

            for (int x = 0; x < newItems.GetLength(0); x++)
            {
                for (int y = 0; y < newItems.GetLength(1); y++)
                {
                    newItems[x, y] = items[x, y];
                }
            }

            return new OthelloGameState(this, moveToGetHere, stepsToReach + 1, newItems, whosTurn == 1 ? 2: 1);
        }

        public override bool Equals(GameState compare)
        {
            OthelloGameState cp = (OthelloGameState)compare;

            for (int x = 0; x < items.GetLength(0); x++)
            {
                for (int y = 0; y < items.GetLength(1); y++)
                {
                    if (items[x, y] != cp.items[x, y])
                    {
                        return false;
                    }
                }
            }


            return true;
        }
    }
}
