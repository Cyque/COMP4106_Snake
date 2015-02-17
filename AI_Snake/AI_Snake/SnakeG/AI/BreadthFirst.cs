using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AI_Snake
{
    public class BreadthFirst
    {
        public int nodesExpanded = 0;

        public List<object> solveGame(GameState firstState, Game game, int player)
        {
            nodesExpanded = 0;
            firstState.reachedGoalHere = false; //reset the goal reach
            List<object> availableMoves = game.getMoves();

            HashSet<GameState> evaluated = new HashSet<GameState>();

            List<GameState> evalutationLayer = new List<GameState>();
            evalutationLayer.Add(firstState);

            GameState currentState = null;

            bool gameSolved = false;
            while (!gameSolved)
            {
                if (evalutationLayer.Count == 0)
                    return null; // no solution found
                currentState = evalutationLayer[0];
                evalutationLayer.RemoveAt(0);
                nodesExpanded++;
                                
                //Node must not be already in the evaluated set
                if (!evaluated.Contains(currentState))
                {
                    int gameOverI = game.isGameOver(currentState);
                    if (currentState.reachedGoalHere)
                        gameSolved = true;
                    else if (gameOverI == -1) //game good. expand node
                    {

                        //expand new nodes
                        for (int i = 0; i < availableMoves.Count; i++)
                            evalutationLayer.Add(game.makeMove(currentState, availableMoves[i]));
                    }
                    else if (gameOverI == player) { }; //this state is a lost state. do not expand

                    //the node has been evaluated and is added to the evaluated set
                    evaluated.Add(currentState);
                }
                else
                {

                }

            }


            //todo: backtrack currentState

            List<object> moves = new List<object>();

            while (currentState != firstState)
            {
                moves.Insert(0, currentState.moveToGetHere);
                currentState = currentState.lastState;
            }

            return moves;
        }
    }
}
