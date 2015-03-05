using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace AI_Snake
{
    public class SnakeGame2
    {
        public static Random rndGen = new Random();

        public delegate void gameChangedHandler(int[,] tileData);
        public delegate void gameOverHandler(int snakeCollided);

        public event gameChangedHandler OnGameChanged;
        public event gameOverHandler OnGameOver;

        bool gameOver = false;
        int[,] tiles;
        List<Snake> snakes;

        public SnakeGame2(Point size, int snakeLength, int numberOfSnakes)
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
            updateTiles();
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
        /// updates the tiles with the current snake position
        /// </summary>
        private void updateTiles()
        {
            for (int y = 0; y < tiles.GetLength(1); y++)
            {
                for (int x = 0; x < tiles.GetLength(0); x++)
                {
                    if (tiles[x, y] >= 2)
                    {
                        tiles[x, y] = 0;
                    }
                }
            }

            for (int i = 0; i < snakes.Count; i++)
            {
                for (int s = 1; s < snakes[i].Body.Count - 1; s++)
                {
                    tiles[snakes[i].Body[s].X, snakes[i].Body[s].Y] = 3; // body
                }
                if (snakes[i].Body.Count > 1)
                    tiles[snakes[i].Body[snakes[i].Body.Count - 1].X, snakes[i].Body[snakes[i].Body.Count - 1].Y] = 4; // tail
                      
                tiles[snakes[i].Body[0].X, snakes[i].Body[0].Y] = 2; // head
            }

        }

        /// <summary>
        /// Moves = N E S W
        /// </summary>
        /// <param name="move"></param>
        public void makeMove(int snakeIndex, Char move)
        {
            if (gameOver)
                return;
            snakes[snakeIndex].move(move);
            updateTiles();
            OnGameChanged(tiles);
            checkDead();
        }

        public void makeMove(Char move)
        {
            makeMove(0, move);
        }

        public void checkDead()
        {
            for (int i = 0; i < snakes.Count; i++)
            {
                if (snakes[i].Head.X == 0 || snakes[i].Head.X == tiles.GetLength(0) - 1 || snakes[i].Head.Y == 0 || snakes[i].Head.Y == tiles.GetLength(1) - 1)
                {
                    gameOver = true;
                    OnGameOver(i);
                }

                for (int j = 0; j < snakes.Count; j++)
                    if (snakes[j].intersects(snakes[i]))
                    {
                        gameOver = true;
                        OnGameOver(i);
                    }
                
            }
        }

    }

}
