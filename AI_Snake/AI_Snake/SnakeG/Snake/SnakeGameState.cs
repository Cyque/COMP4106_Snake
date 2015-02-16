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

        public SnakeGameState(Point size, List<Snake> snakes, Point food, List<Point> blocks)
        {
            this.size = size;
            this.snakes = snakes;
            this.food = food;
            this.blocks = blocks;
        }

        public override bool Equals(GameState c)
        {
            if (!(c is SnakeGameState)) return false;

            SnakeGameState compare = (SnakeGameState)c;

            if (!compare.size.Equals(size)) return false;

            if (compare.snakes.Count != snakes.Count) return false;

            if (!compare.food.Equals(food)) return false;

            for (int i = 0; i < compare.snakes.Count; i++)
                if (!compare.snakes[i].Equals(snakes[i])) return false;

            for (int i = 0; i < compare.blocks.Count; i++)
                if (!compare.blocks[i].Equals(blocks[i])) return false;

            return true;
        }

        public override SnakeGameState Copy()
        {
            Point sizeCopy = new Point(size.X, size.Y);
            List<Snake> snakesCopy = new List<Snake>();
            Point foodCopy = new Point(food.X, food.Y);
            List<Point> blocksCopy = new List<Point>();

            foreach (Snake snake in snakes)
                snakesCopy.Add(snake.Copy());


            foreach (Point block in blocks)
                blocksCopy.Add(new Point(block.X, block.Y));

            return new SnakeGameState(sizeCopy, snakesCopy, foodCopy, blocksCopy);
        }

    }
}
