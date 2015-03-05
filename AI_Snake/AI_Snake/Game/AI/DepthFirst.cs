using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AI_Snake
{
    public class DepthFirst : GameAI
    {

        Stack<GameState> evalutationLayer = new Stack<GameState>();

        public override void reset()
        {
            evalutationLayer = new Stack<GameState>();
        }

        public override void addState(GameState node, int player)
        {
            evalutationLayer.Push(node);
        }

        public override GameState pullNextState()
        {
            if (evalutationLayer.Count == 0)
                return null;
            else
            {
                return evalutationLayer.Pop();
            }
        }
    }
}
