using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace AI_Snake
{
    public class SnakeGame
    {
        public static Random rndGen = new Random();

        public delegate void gameChangedHandler(int[,] tileData);

        public event gameChangedHandler OnGameChanged;


        int[,] tiles;
        List<Snake> snakes;

        public SnakeGame(Point size, int snakeLength, int numberOfSnakes)
        {
            tiles = new int[size.X, size.Y];
            createBorder();

            snakes = new List<Snake>();
            for (int i = 0; i < numberOfSnakes; i++)
            {
                snakes.Add(new Snake(snakeLength, randomPoint())); 
            }
        }

        public void initialize()
        {
            OnGameChanged(tiles);
        }

        private Point randomPoint() 
        {
            //todo: randomize until no collision with other snakes or walls etc
            return new Point(rndGen.Next(1, tiles.GetLength(0) - 1), rndGen.Next(1, tiles.GetLength(1) - 1));
        }

        private void createBorder()
        {
            for (int y = 0; y < tiles.GetLength(1); y++)
            {
                for (int x = 0; x < tiles.GetLength(0); x++)
                {
                    if (x == 0 || x == tiles.GetLength(0) - 1 || y == 0 || y == tiles.GetLength(1) - 1)
                    {
                        tiles[x, y] = 1;
                    }
                }
            }
        }

        /// <summary>
        /// Moves = N E S W
        /// </summary>
        /// <param name="move"></param>
        private void makeMove(int snakeIndex, Char move)
        {



        }

        private void makeMove(Char move)
        {
            makeMove(0, move);
        }


    }
}
