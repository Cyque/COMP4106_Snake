using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace AI_Snake
{
    public class OthelloGame : Game
    {


        /**
         * Loops in a line until a piece is found that would make this line not be
         * able to flip any pieces over.
         * 
         * The lines direction is defined by xInc & yInc
         * 
         * @param xStart
         *            the first x position to start the line from the piece at this
         *            position will not be included in the logic
         * @param yStart
         *            the first x position to start the line from the piece at this
         *            position will not be included in the logic
         * @param xInc
         *            defines the increment of x during the iteration. Ideal values:
         *            -1, 0, or 1
         * @param yInc
         *            defines the increment of y during the iteration. Ideal values:
         *            -1, 0, or 1
         * @param whosTurnPiece
         *            the color of the piece of whos turn it is. Pieces will be
         *            flipped to this value.
         * @param flipPieces
         *            If true the pieces on the board will be flipped.
         * @return whether there
         */
        private bool lineHasFlippable(int[,] gridItems, int xStart, int yStart, int xInc, int yInc, int whosTurnPiece, bool flipPieces)
        {

            int oppPiece = whosTurnPiece == 1 ? 2 : 1;
            bool oppositeFound = false;
            int x = xStart;
            int y = yStart;

            // excludes first piece from logic
            x += xInc;
            y += yInc;

            if (flipPieces)
            {
                // loops through a 'line' in the direction defined by xInc and yInc
                // until a OthelloPiece.NONE or whosTurnPiece is found
                while (x >= 0 && y >= 0 && x < gridItems.GetLength(0)
                        && y < gridItems.GetLength(1))
                {
                    if (gridItems[x, y] == 0)
                    {
                        return false;
                    }
                    else if (gridItems[x, y] == oppPiece)
                    {// OPPOSITE
                        // COLOR
                        oppositeFound = true; // an opposite color piece was found
                    }
                    else if (oppositeFound
                          && gridItems[x, y] == whosTurnPiece)
                    {// PLAYER
                        // COLOR
                        // rollback and flip each piece
                        while (!(x == xStart && y == yStart))
                        {
                            gridItems[x, y] = whosTurnPiece;
                            x -= xInc;
                            y -= yInc;
                        }

                        return true;
                    }
                    else if (gridItems[x, y] == whosTurnPiece)
                    {
                        return false;
                    }
                    x += xInc;
                    y += yInc;

                }
            }
            else
            {
                while (x >= 0 && y >= 0 && x < gridItems.GetLength(0)
                        && y < gridItems.GetLength(1))
                {

                    if (gridItems[x, y] == 0)
                    {
                        return false;
                    }
                    else if (gridItems[x, y] == oppPiece)
                    {// OPPOSITE
                        // COLOR
                        oppositeFound = true; // an opposite color piece was found
                    }
                    else if (oppositeFound
                          && gridItems[x, y] == whosTurnPiece)
                    {// PLAYER
                        // COLOR
                        return true;
                    }
                    else if (gridItems[x, y] == whosTurnPiece)
                    {
                        return false;
                    }
                    x += xInc;
                    y += yInc;
                }
            }

            return false;
        }

        /**
         * Flips all piece a move would have flipped
         * 
         * @param move
         */
        private void flipPieces(int[,] gridItems, Point move, int whosTurn)
        {
            // horizontal right
            lineHasFlippable(gridItems, move.X, move.Y, 1, 0, whosTurn, true);

            // horizontal left
            lineHasFlippable(gridItems, move.X, move.Y, -1, 0, whosTurn, true);

            // vertical down
            lineHasFlippable(gridItems, move.X, move.Y, 0, 1, whosTurn, true);

            // vertical up
            lineHasFlippable(gridItems, move.X, move.Y, 0, -1, whosTurn, true);

            // diagonal down/right
            lineHasFlippable(gridItems, move.X, move.Y, 1, 1, whosTurn, true);

            // diagonal down/left
            lineHasFlippable(gridItems, move.X, move.Y, -1, 1, whosTurn, true);

            // diagonal up/right
            lineHasFlippable(gridItems, move.X, move.Y, 1, -1, whosTurn, true);

            // diagonal up/left
            lineHasFlippable(gridItems, move.X, move.Y, -1, -1, whosTurn, true);

        }


        /**
	     * Determines whether a move will flip pieces
	     * 
	     * @param move
	     * @return
	     */
        private bool moveWillFlipPieces(int[,] gridItems, Point move, int whosTurn)
        {

            // draw rays on horizontal/vertical/diagonal and check if opposing piece
            // lies in between friendly piece


            bool anyTrue = false;
            // horizontal right
            anyTrue = lineHasFlippable(gridItems, move.X, move.Y, 1, 0, whosTurn, false) ? true : anyTrue;

            // horizontal left
            anyTrue = lineHasFlippable(gridItems, move.X, move.Y, -1, 0, whosTurn, false) ? true : anyTrue;

            // vertical down
            anyTrue = lineHasFlippable(gridItems, move.X, move.Y, 0, 1, whosTurn, false) ? true : anyTrue;

            // vertical up
            anyTrue = lineHasFlippable(gridItems, move.X, move.Y, 0, -1, whosTurn, false) ? true : anyTrue;

            // diagonal down/right
            anyTrue = lineHasFlippable(gridItems, move.X, move.Y, 1, 1, whosTurn, false) ? true : anyTrue;

            // diagonal down/left
            anyTrue = lineHasFlippable(gridItems, move.X, move.Y, -1, 1, whosTurn, false) ? true : anyTrue;

            // diagonal up/right
            anyTrue = lineHasFlippable(gridItems, move.X, move.Y, 1, -1, whosTurn, false) ? true : anyTrue;

            // diagonal up/left
            anyTrue = lineHasFlippable(gridItems, move.X, move.Y, -1, -1, whosTurn, false) ? true : anyTrue;

            return anyTrue;
        }


        private bool canPlayerMakeLegalMove(int[,] gridItems, int whosTurn)
        {
            // iterates over every possible move and checks if that move will flip a
            // piece
            for (int x = 0; x < gridItems.GetLength(0); x++)
                for (int y = 0; y < gridItems.GetLength(1); y++)
                {
                    // must be empty space
                    if (gridItems[x, y] == 0)
                    {
                        if (moveWillFlipPieces(gridItems, new Point(x, y), whosTurn))
                            return true;
                    }
                }

            return false;
        }


        private bool isValidMove(int[,] gridItems, Point move, int whosTurn)
        {

            if (
                // check within bounds
                    move.X >= 0
                    && move.X < gridItems.GetLength(0)
                    && move.Y >= 0
                    && move.Y < gridItems.GetLength(1)
                // check empty spot
                    && gridItems[move.X, move.Y] == 0)
            {

                return moveWillFlipPieces(gridItems, move, whosTurn);
            }

            return false;
        }


        protected override GameState makeGameMove(GameState gameState, int player, object move)
        {
            OthelloGameState newS = (OthelloGameState)((OthelloGameState)gameState).Copy(move);

            List<object> mvs = getMoves(newS);

            if (mvs.Count == 0) // no possible moves. switch to other players turn without making move
            {
                newS.WhosTurn = newS.WhosTurn == 1 ? 2 : 1;
                return newS;
            }
            if (move != null)
            {
                Point m = (Point)move;
                bool canMove = false;
                for (int i = 0; i < mvs.Count; i++)
                {
                    if (((Point)mvs[i]).X == ((Point)move).X
                        && ((Point)mvs[i]).Y == ((Point)move).Y)
                    {
                        canMove = true;
                    }
                }
                if (canMove)
                {
                    newS.Items[m.X, m.Y] = newS.WhosTurn;

                    flipPieces(newS.Items, m, newS.WhosTurn);
                    newS.WhosTurn = newS.WhosTurn == 1 ? 2 : 1;
                    return newS;
                }
                else
                    return gameState;
            }
            else
                return gameState;
        }


        public override List<object> getMoves(GameState gameState)
        {
            OthelloGameState gs = (OthelloGameState)gameState;
            List<object> moves = new List<object>();
            for (int x = 0; x < gs.Items.GetLength(0); x++)
                for (int y = 0; y < gs.Items.GetLength(1); y++)
                    if (isValidMove(gs.Items, new Point(x, y), gs.WhosTurn))
                        moves.Add(new Point(x, y));
            return moves;
        }

        //***returns 2 if draw
        protected override int calculateGameOver(GameState gameState)
        {
            OthelloGameState cp = (OthelloGameState)gameState;


            int count1 = 0;
            int count2 = 0;

            for (int x = 0; x < cp.Items.GetLength(0); x++)
                for (int y = 0; y < cp.Items.GetLength(0); y++)
                {
                    if (cp.Items[x, y] == 1)
                        count1++;
                    if (cp.Items[x, y] == 2)
                        count2++;
                }

            if (count1 + count2 == 8 * 8)
            {
                if (count1 > count2)
                    return 0;
                else if (count1 < count2)
                    return 1;
                else
                    return 2;
            }


            //check for no possible moves from both players
            if (getMoves(cp).Count == 0)
            {
                cp.WhosTurn = cp.WhosTurn == 1 ? 2 : 1;
                if (getMoves(cp).Count == 0)
                {
                    cp.WhosTurn = cp.WhosTurn == 1 ? 2 : 1;

                    if (count1 > count2)
                        return 0;
                    else if (count1 < count2)
                        return 1;
                    else
                        return 2;
                }
            }

            



            return -1;
        }

        public OthelloGameState createInitialState()
        {
            int[,] tiles = new int[8, 8];
            for (int x = 0; x < 8; x++)
                for (int y = 0; y < 8; y++)
                    tiles[x, y] = 0;

            tiles[3, 3] = 2;
            tiles[3, 4] = 1;
            tiles[4, 3] = 1;
            tiles[4, 4] = 2;

            return new OthelloGameState(null, null, 0, tiles, 1);
        }
    }
}
