using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace AI_Snake
{
    public class SnakeGameState : GameState
    {
        private Point size;
        private List<Snake> snakes;
        private Point food;
        private List<Point> blocks;


        public Point Size { get { return size; } }
        public List<Snake> Snakes { get { return snakes; } }
        public Point Food { get { return food; } set { food = value; } }
        public List<Point> Blocks { get { return blocks; } }

        public SnakeGameState(SnakeGameState lastState, object moveToGetHere, int stepsToReach, Point size, List<Snake> snakes, Point food, List<Point> blocks)
            : base(lastState, moveToGetHere, stepsToReach)
        {
            this.size = size;
            this.snakes = snakes;
            this.food = food;
            this.blocks = blocks;
        }

        public override bool Equals(GameState c)
        {

            //return GetHashCode() == c.GetHashCode();

            SnakeGameState compare = (SnakeGameState)c;

            if (compare.size.X != size.X) return false;
            if (compare.size.Y != size.Y) return false;

            if (compare.snakes.Count != snakes.Count) return false;

            if (compare.food.Y != food.Y) return false;

            for (int i = 0; i < compare.snakes.Count; i++)
            {
                if (compare.snakes[i].Body.Count != snakes[i].Body.Count) return false;
                for (int j = 0; j < compare.snakes[i].Body.Count; j++)
                {
                    if (compare.snakes[i].Body[j].X != snakes[i].Body[j].X) return false;
                    if (compare.snakes[i].Body[j].Y != snakes[i].Body[j].Y) return false;
                }
            }

            for (int i = 0; i < compare.blocks.Count; i++)
            {
                if (compare.blocks[i].X != blocks[i].X) return false;
                if (compare.blocks[i].Y != blocks[i].Y) return false;
            }

            return true;
        }

        public override SnakeGameState Copy(object moveToGetHere)
        {
            Point sizeCopy = new Point(size.X, size.Y);
            List<Snake> snakesCopy = new List<Snake>();
            Point foodCopy = new Point(food.X, food.Y);
            List<Point> blocksCopy = new List<Point>();

            foreach (Snake snake in snakes)
                snakesCopy.Add(snake.Copy());


            foreach (Point block in blocks)
                blocksCopy.Add(new Point(block.X, block.Y));

            return new SnakeGameState(this, moveToGetHere, stepsToReach + 1, sizeCopy, snakesCopy, foodCopy, blocksCopy);
        }


        //public override int GetHashCode()
        //{
        //    int hs = 1;
        //    hs *= size.Y;
        //    hs *= size.X;

        //    hs *= food.X;
        //    hs *= food.Y;

        //    for (int i = 0; i < snakes.Count; i++)
        //        for (int j = 0; j < snakes[i].Body.Count; j++)
        //        {
        //            hs *= snakes[i].Body[j].X;
        //            hs *= snakes[i].Body[j].X;
        //        }

        //    for (int i = 0; i < blocks.Count; i++)
        //    {
        //        hs *= blocks[i].X;
        //        hs *= blocks[i].Y;
        //    }

        //    //hs += ((byte) moveToGetHere) * 90000000;
        //    return hs;
        //}


        public override string ToString()
        {
            int[,] tiles = new int[Size.Y, Size.X];

            for (int i = 0; i < Blocks.Count; i++)
                tiles[Blocks[i].Y, Blocks[i].X] = 1;

            tiles[Food.Y, Food.X] = 5;

            for (int i = 0; i < Blocks.Count; i++)
                tiles[Blocks[i].Y, Blocks[i].X] = 1;


            for (int i = 0; i < Snakes.Count; i++)
            {
                for (int s = 0; s < Snakes[i].Body.Count; s++)
                    tiles[Snakes[i].Body[s].Y, Snakes[i].Body[s].X] = 3;


                tiles[Snakes[i].Tail.Y, Snakes[i].Tail.X] = 4;
                tiles[Snakes[i].Head.Y, Snakes[i].Head.X] = 2;
            }

            String ss = "";
            for (int y = 0; y < Size.Y; y++)
            {
                for (int x = 0; x < Size.X; x++)
                {
                    ss += tiles[y, x];
                }
                ss += "\n";
            }

            ss += "Reached Goal Here: " + base.reachedGoalHere + "\n";

            return ss;
        }
    }
}
