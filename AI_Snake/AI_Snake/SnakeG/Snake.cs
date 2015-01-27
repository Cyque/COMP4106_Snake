using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace AI_Snake
{
    public class Snake
    {
        List<Point> body;
        int maxLength;


        public List<Point> Body { get { return body; } }

        public Point Head { get { return body[0]; } }

        public Snake(int length, Point startPosition)
        {
            body = new List<Point>();
            body.Add(startPosition);
            maxLength = length;
        }

        public bool intersects(Point point)
        {
            for (int i = 0; i < body.Count; i++)
            {
                if (body[i].Equals(point)) return true;
            }
            return false;
        }

        public bool intersects(Snake snake)
        {
            int i = 0;
            if (snake == this)   //dont check head         
                i = 1;

            for (; i < body.Count; i++)
            {
                if (body[i].Equals(snake.Head)) return true;
            }

            return false;
        }


        /// <summary>
        /// Moves the head of the snake in the given direction. 
        /// Moves all tail nodes to follow and adds a new tail 
        /// node if the length of the snake does not match the 
        /// given maxlength
        /// </summary>
        /// <param name="direction"></param>
        public void move(Char direction)
        {
            Point lastPoint = new Point(body[body.Count - 1].X, body[body.Count - 1].Y);
            //move the head and all tail pieces
            for (int i = body.Count - 1; i >= 1; i--)
            {
                body[i] = body[i - 1];
            }

            if (direction == 'N')            
                body[0] = new Point(body[0].X + 0, body[0].Y - 1);
            else if (direction == 'S')
                body[0] = new Point(body[0].X + 0, body[0].Y + 1);
            else if (direction == 'E')
                body[0] = new Point(body[0].X + 1, body[0].Y + 0);
            else if (direction == 'W')
                body[0] = new Point(body[0].X - 1, body[0].Y + 0);


           
            if (body.Count < maxLength)
            {
                body.Add(lastPoint);
            }
        }

        

    }
}
