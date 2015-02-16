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
        private List<Point> food;


        public SnakeGameState(Point size, List<Snake> snakes, List<Point> food)
        {
            this.size = size;
            this.snakes = snakes;
            this.food = food;
        }

        public override bool Equals(GameState c)
        {
            if (!(c is SnakeGameState)) return false;

            SnakeGameState compare = (SnakeGameState)c;

            if (!compare.size.Equals(size)) return false;

            if (compare.snakes.Count != snakes.Count) return false;

            if (compare.food.Count != food.Count) return false;

            for (int i = 0; i < compare.food.Count; i++)
                if (!compare.food[i].Equals(food[i])) return false;

            for (int i = 0; i < compare.snakes.Count; i++)            
                if (!compare.snakes[i].Equals(snakes[i])) return false;
            

            return true;
        }

        public override SnakeGameState Copy()
        {
            Point sizeCopy = new Point(size.X, size.Y);
            List<Snake> snakesCopy = new List<Snake>();
            List<Point> foodCopy = new List<Point>();

            foreach (Snake snake in snakes)
                snakesCopy.Add(snake.Copy());

            foreach (Point foodP in food)
                foodCopy.Add(new Point(foodP.X, foodP.Y));

            return new SnakeGameState(sizeCopy, snakesCopy, foodCopy);
        }

    }
}
