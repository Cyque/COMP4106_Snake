using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AI_Snake
{
    public abstract class GameAI
    {
        public int nodesExpanded = 0;

        public List<object> solveGame(GameState firstState, Game game, int player)
        {
            nodesExpanded = 0;
            firstState.reachedGoalHere = false; //reset the goal reach
            firstState.stepsToReach = 0;
            List<object> availableMoves = game.getMoves(firstState);

            List<GameState> evaluated = new List<GameState>();

            reset();
            addState(firstState, player);

            GameState currentState = null;

            bool gameSolved = false;
            while (!gameSolved)
            {
                currentState = pullNextState();
                if (currentState == null)
                    return null; // no solution

                //Console.WriteLine();
                //Console.Write(currentState.ToString());

                nodesExpanded++;
                if (nodesExpanded % 10000 == 0)
                {
                    Console.WriteLine("Nodes Expanded: " + nodesExpanded);
                }


                bool contains = false;
                for (int i = 0; i < evaluated.Count; i++)
                {
                    if (evaluated[i].Equals(currentState)) contains = true;
                }


                //Node must not be already in the evaluated set
                if (!contains)
                {
                    // Console.Write(currentState.moveToGetHere);
                    int gameOverI = game.isGameOver(currentState);
                    if (currentState.reachedGoalHere)
                        gameSolved = true;
                    else if (gameOverI == -1) //game good. expand node
                    {
                        //expand new nodes
                        for (int i = 0; i < availableMoves.Count; i++)
                            addState(game.makeMove(currentState, player, availableMoves[i]), player);
                    }
                    else if (gameOverI == player) { }; //this state is a lost state. do not expand

                    //the node has been evaluated and is added to the evaluated set
                    evaluated.Add(currentState);
                }
            }


            List<object> moves = new List<object>();
            //backtrack moves
            while (currentState != firstState)
            {
                moves.Insert(0, currentState.moveToGetHere);
                currentState = currentState.lastState;
            }

            return moves;
        }


        public abstract void reset();

        public abstract GameState pullNextState();

        public abstract void addState(GameState node, int player);

    }
}


/*

            reset();
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
            }
*/