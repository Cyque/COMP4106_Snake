using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AI_Snake
{
    public class MiniMax
    {
        public static int heur = 0;

        static int expandedNodes = 0;

        public object miniMax(Game game, GameState node, int depth, bool maximizingPlayer)
        {
            expandedNodes = 0;
            Tuple<float, GameState> result = miniMaxEx(game, node, depth, maximizingPlayer);
            Console.WriteLine("MiniMax. Heur = " + heur + " Nodes: " + expandedNodes);

            object move = null;

            GameState rollBackState = result.Item2;
            move = rollBackState.moveToGetHere;

            while (!rollBackState.Equals(node))
            {
                move = rollBackState.moveToGetHere;
                rollBackState = rollBackState.lastState;
            }

            return move;
        }

        public object miniMaxAlphaBeta(Game game, GameState node, int depth, bool maximizingPlayer)
        {

            expandedNodes = 0;
            Tuple<float, GameState> result = miniMaxAlphaBeta(game, node, depth, maximizingPlayer, double.MinValue, double.MaxValue);
            Console.WriteLine("MiniMax /w Alpha-Beta Pruning. Heur = " + heur + " Nodes: " + expandedNodes);

            if (result == null) return null;

            object move = null;

            GameState rollBackState = result.Item2;
            move = rollBackState.moveToGetHere;

            while (!rollBackState.Equals(node))
            {
                move = rollBackState.moveToGetHere;
                rollBackState = rollBackState.lastState;
            }

            return move;
        }




        private Tuple<float, GameState> miniMaxEx(Game game, GameState node, int depth, bool maximizingPlayer)
        {
            expandedNodes++;
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
                    if (value == null) //special case, the expanded node had no possible moves. I.e, it becomes this players turn again
                    {
                        //now copy the state, checnge player to opposite player and evaluate with !maximizingPlayer again.
                        GameState newG = children[i].Copy(children[i].moveToGetHere);
                        ((OthelloGameState)children[i]).WhosTurn = ((OthelloGameState)children[i]).WhosTurn == 1 ? 2 : 1;
                        value = miniMaxEx(game, newG, depth - 1, true);
                    }
                    if (value.Item1 > bestValue.Item1)
                        bestValue = value;
                }

                if (bestValue.Item1.Equals(float.MinValue))
                    return null;
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
                    if (value == null) //special case, the expanded node had no possible moves. I.e, it becomes this players turn again
                    {
                        //now copy the state, checnge player to opposite player and evaluate with !maximizingPlayer again.
                        GameState newG = children[i].Copy(children[i].moveToGetHere);
                        ((OthelloGameState)children[i]).WhosTurn = ((OthelloGameState)children[i]).WhosTurn == 1 ? 2 : 1;
                        value = miniMaxEx(game, newG, depth - 1, false);
                    }

                    if (value.Item1 < bestValue.Item1)
                        bestValue = value;
                }

                if (bestValue.Item1.Equals(float.MaxValue))
                    return null;
                return bestValue;
            }
        }

        private Tuple<float, GameState> miniMaxAlphaBeta(Game game, GameState node, int depth, bool maximizingPlayer, double alpha, double beta)
        {
            expandedNodes++;
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
                    Tuple<float, GameState> value = miniMaxAlphaBeta(game, children[i], depth - 1, false, alpha, beta);
                    if (value == null) //special case, the expanded node had no possible moves. I.e, it becomes this players turn again
                    {
                        //now copy the state, checnge player to opposite player and evaluate with !maximizingPlayer again.
                        ((OthelloGameState)children[i]).WhosTurn = ((OthelloGameState)children[i]).WhosTurn == 1 ? 2 : 1;
                        value = miniMaxAlphaBeta(game, children[i], depth - 1, true, alpha, beta);
                    }
                    if (value.Item1 > bestValue.Item1)
                        bestValue = value;

                    alpha = (double)Math.Max(alpha, value.Item1);
                    if (beta <= alpha)
                        break;
                }

                if (bestValue.Item1.Equals(float.MinValue))
                    return null;
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
                    Tuple<float, GameState> value = miniMaxAlphaBeta(game, children[i], depth - 1, true, alpha, beta);
                    if (value == null) //special case, the expanded node had no possible moves. I.e, it becomes this players turn again
                    {
                        //now copy the state, checnge player to opposite player and evaluate with !maximizingPlayer again.
                        ((OthelloGameState)children[i]).WhosTurn = ((OthelloGameState)children[i]).WhosTurn == 1 ? 2 : 1;
                        value = miniMaxAlphaBeta(game, children[i], depth - 1, false, alpha, beta);
                    }
                    if (value.Item1 < bestValue.Item1)
                        bestValue = value;

                    beta = (double)Math.Min(beta, value.Item1);
                    if (beta <= alpha)
                        break;
                }

                if (bestValue.Item1.Equals(float.MaxValue))
                    return null;
                return bestValue;
            }
        }


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
                    //this heuristics counts corner pieces as valuable and pieces right beside the corner as not valuable. (combines heur 1)
                    int[,] items = ogs.Items;

                    int ct = 0;

                    //regular black/white counts
                    for (int x = 0; x < items.GetLength(0); x++)
                        for (int y = 0; y < items.GetLength(1); y++)
                        {
                            if (items[x, y] == 1)
                                ct += 1;
                            else if (items[x, y] == 2)
                                ct -= 1;
                        }

                    //corners
                    if (items[0, 0] != 0)
                        ct += items[0, 0] == 1 ? 3 : -3;
                    if (items[0, 7] != 0)
                        ct += items[7, 0] == 1 ? 3 : -3;
                    if (items[7, 0] != 0)
                        ct += items[7, 0] == 1 ? 3 : -3;
                    if (items[7, 7] != 0)
                        ct += items[7, 0] == 1 ? 3 : -3;

                    return ct;
                }

            }

            return 0;

        }

    }



}
