using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace AI_Snake
{
    public class Snake
    {
        private int[,] tiles; 

        public Snake(Point size)
        {
            tiles = new int[size.X, size.Y];
            createBorder();
        }
        
        private void createBorder()
        {
            for (int y = 0; y < tiles.GetLength(1); y++)
            {
                for (int x = 0; x < tiles.GetLength(0); x++)
                {

                }
            }
        }

    }
}
