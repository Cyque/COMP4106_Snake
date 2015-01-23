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

        public Snake(int length, Point startPosition)
        {
            body = new List<Point>();
            body.Add(startPosition);
            maxLength = length;
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
            //move the head and all tail pieces
            Point lastPoint = body[body.Count - 1];

            for (int i = body.Count - 1; i >= 1; i--)
            {
                body[i] = body[i - 1];
            }

            if (direction == 'N')
                body[0].Offset(new Point(0, -1));
            else if (direction == 'S')
                body[0].Offset(new Point(0, 1));
            else if (direction == 'E')
                body[0].Offset(new Point(1, 0));
            else if (direction == 'W')
                body[0].Offset(new Point(-1, 0));


            if (body.Count < maxLength)
            {
                body.Add(lastPoint);
            }
        }

        

    }
}
