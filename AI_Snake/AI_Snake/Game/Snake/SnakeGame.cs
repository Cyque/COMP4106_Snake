using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace AI_Snake
{
    public class SnakeGame : Game
    {

        public static Random rndGen = new Random();

        public SnakeGame()
            : base()
        { }


        public override List<Object> getMoves(GameState gameState)
        {
            return new List<object>(new Object[] { 'N', 'E', 'W', 'S' });
        }

        public SnakeGameState createInitialState(Point size, int snakeLength, int numberOfSnakes, int numberOfRandomBlocks)
        {
            List<Point> blocks = new List<Point>();
            List<Snake> snakes = new List<Snake>();
            Point food = new Point(-1, -1);

            for (int i = 0; i < numberOfSnakes; i++)
                snakes.Add(new Snake(snakeLength, randomPoint(size, blocks, snakes, food)));

            for (int y = 0; y < size.Y; y++)
                for (int x = 0; x < size.X; x++)
                    if (x == 0 || x == size.X - 1 || y == 0 || y == size.Y - 1)
                        blocks.Add(new Point(x, y));

            for (int i = 0; i < numberOfRandomBlocks; i++)
                blocks.Add(randomPoint(size, blocks, snakes, food));

            food = randomPoint(size, blocks, snakes, food);

            return new SnakeGameState(null, null, 0, size, snakes, food, blocks);
        }

        private Point randomPoint(Point size, List<Point> blocks, List<Snake> snakes, Point food)
        {
            bool good;
            Point rndPoint;

            do
            {
                good = true;
                rndPoint = new Point(rndGen.Next(1, size.X - 1), rndGen.Next(1, size.Y - 1));

                if (food.Equals(rndPoint))
                    good = false;

                for (int i = 0; i < blocks.Count; i++)
                    if (blocks[i].Equals(rndPoint))
                        good = false;

                for (int i = 0; i < snakes.Count; i++)
                    if (snakes[i].intersects(rndPoint))
                        good = false;

            }
            while (!good);

            //todo: randomize until no collision with other snakes or walls etc
            return rndPoint;
        }


        protected override GameState makeGameMove(GameState gameState, int player, Object move)
        {
            SnakeGameState sgs = (SnakeGameState)gameState.Copy(move);

            sgs.Snakes[player].move((char)move);

            if (sgs.Food.Equals(sgs.Snakes[player].Head))
            {
                sgs.Food = randomPoint(sgs.Size, sgs.Blocks, sgs.Snakes, sgs.Food);
                sgs.Snakes[player].giveFood();
                sgs.reachedGoalHere = true;
            }

            return sgs;
        }

        protected override int calculateGameOver(GameState gameState)
        {
            SnakeGameState sgs = (SnakeGameState)gameState;

            for (int i = 0; i < sgs.Snakes.Count; i++)
            {
                for (int b = 0; b < sgs.Blocks.Count; b++)
                    if (sgs.Snakes[i].intersects(sgs.Blocks[b]))
                        return i;               
                
                for (int j = 0; j < sgs.Snakes.Count; j++)
                    if (sgs.Snakes[j].intersects(sgs.Snakes[i]))
                        return i;
            }

            return -1;
        }
    }
}
