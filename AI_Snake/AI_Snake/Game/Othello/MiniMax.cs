using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AI_Snake
{
    public class MiniMax
    {
        public static int heur = 0;

        public object miniMax(Game game, GameState node, int depth, bool maximizingPlayer)
        {
            Tuple<float, GameState> result = miniMaxEx(game, node, depth, maximizingPlayer);

            object move = null;

            GameState rollBackState = result.Item2;

            do
            {
                move = rollBackState.moveToGetHere;
                rollBackState = rollBackState.lastState;
            }
            while (!rollBackState.lastState.Equals(node));
            move = rollBackState.moveToGetHere;

            return move;
        }

        private Tuple<float, GameState> miniMaxEx(Game game, GameState node, int depth, bool maximizingPlayer)
        {
            //Console.WriteLine("Step");
            //Console.WriteLine(node);
            if (depth == 0 || game.isGameOver(node) != -1)
                return new Tuple<float, GameState>(heuristic(node), node);

            if (maximizingPlayer)
            {
                Tuple<float, GameState> bestValue = new Tuple<float, GameState>(float.MinValue, null);

                List<object> moves = game.getMoves(node);
                List<GameState> children = new List<GameState>();
                for (int i = 0; i < moves.Count; i++)
                {
                    children.Add(game.makeMove(node, -1, moves[i])); // create child node
                    Tuple<float, GameState> value = miniMaxEx(game, children[i], depth - 1, false);
                    if (value.Item1 > bestValue.Item1)
                        bestValue = value;
                }

                return bestValue;
            }
            else
            {
                Tuple<float, GameState> bestValue = new Tuple<float, GameState>(float.MaxValue, null);

                List<object> moves = game.getMoves(node);
                List<GameState> children = new List<GameState>();
                for (int i = 0; i < moves.Count; i++)
                {
                    children.Add(game.makeMove(node, -1, moves[i])); // create child node
                    Tuple<float, GameState> value = miniMaxEx(game, children[i], depth - 1, true);
                    if (value.Item1 < bestValue.Item1)
                        bestValue = value;
                }

                return bestValue;
            }
        }
        /*
    function minimax(node, depth, maximizingPlayer)
       if depth = 0 or node is a terminal node
           return the heuristic value of node
       if maximizingPlayer
           bestValue := -∞
           for each child of node
               val := minimax(child, depth - 1, FALSE)
               bestValue := max(bestValue, val)
           return bestValue
       else
           bestValue := +∞
           for each child of node
               val := minimax(child, depth - 1, TRUE)
               bestValue := min(bestValue, val)
           return bestValue

   (* Initial call for maximizing player *)
   minimax(origin, depth, TRUE)
    */

        private float heuristic(GameState node)
        {
            if (node is OthelloGameState)
            {
                OthelloGameState ogs = (OthelloGameState)node;

                if (heur == 0) //BW count
                {
                    int[,] items = ogs.Items;

                    int ct = 0;
                    for (int x = 0; x < items.GetLength(0); x++)
                        for (int y = 0; y < items.GetLength(1); y++)
                        {
                            if (items[x, y] == 1)
                                ct += 1;
                            else if (items[x, y] == 2)
                                ct -= 1;
                        }
                    return ct;
                }
                else if (heur == 1)//closest to edge
                {

                }

            }

            return 0;

        }

    }



}
