using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AI_Snake
{
    public class AStar : GameAI
    {
        int heur = 0;
        public AStar(int heur)
        {
            this.heur = heur;
        }

        List<Tuple<GameState, double>> evalutationLayer = new List<Tuple<GameState, double>>();

        public override void reset()
        {
            evalutationLayer = new List<Tuple<GameState, double>>();
        }

        public override void addState(GameState node, int player)
        {
            evalutationLayer.Add(new Tuple<GameState, double>(node, calculateHeuristic(node, player)));
        }

        public override GameState pullNextState()
        {
            if (evalutationLayer.Count == 0)
                return null;
            else
            {
                Tuple<GameState, double> bestHeur = evalutationLayer[0];
                for (int i = 0; i < evalutationLayer.Count; i++)
                {
                    if (evalutationLayer[i].Item2 < bestHeur.Item2)
                        bestHeur = evalutationLayer[i];
                    if (evalutationLayer[i].Item1.reachedGoalHere)
                    {
                        bestHeur = evalutationLayer[i];
                        i = evalutationLayer.Count;
                    }
                }
                evalutationLayer.Remove(bestHeur);

                return bestHeur.Item1;
            }
        }



        private double calculateHeuristic(GameState node, int snakeIndex)
        {
            SnakeGameState sgs = (SnakeGameState)node;


            double xdif = sgs.Food.X - sgs.Snakes[snakeIndex].Head.X;
            double ydif = sgs.Food.Y - sgs.Snakes[snakeIndex].Head.Y;

            double euc =  Math.Sqrt(Math.Pow(xdif, 2) + Math.Pow(ydif, 2));

            double distanceEuc = node.stepsToReach + euc;
            double distanceMan = node.stepsToReach +  Math.Abs(xdif) + Math.Abs(ydif);
            double distanceModifiedEuc = node.stepsToReach * 0.5d + euc;

            if (heur == 0)
                return distanceEuc;
            else if (heur == 1)
                return distanceMan;
            else if (heur == 2)
                return distanceModifiedEuc;
            else if (heur == 3)
                return (distanceEuc + distanceMan) / 2;
            else
                return distanceEuc;

        }
        


    }
}
