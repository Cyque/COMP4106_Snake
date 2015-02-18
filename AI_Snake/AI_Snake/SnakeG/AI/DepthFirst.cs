using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AI_Snake
{
    public class BreadthFirst : GameAI
    {

        List<GameState> evalutationLayer = new List<GameState>();

        public override void reset()
        {
            evalutationLayer = new List<GameState>();
        }

        public override void addState(GameState node, int player)
        {
            evalutationLayer.Add(node);
        }

        public override GameState pullNextState()
        {
            if (evalutationLayer.Count == 0)
                return null;
            else
            {
                GameState gs = evalutationLayer[0];
                evalutationLayer.RemoveAt(0);
                return gs;
            }
        }
    }
}
