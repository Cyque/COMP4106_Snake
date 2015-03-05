using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace AI_Snake
{
    public partial class OthelloGameForm : Form
    {
        OthelloGameState gameState;
        OthelloGame game;

        int[,] lastTileData;

        List<Tuple<int, List<object>>> movesTodo = new List<Tuple<int, List<object>>>();

        public OthelloGameForm()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                      ControlStyles.Opaque |
                      ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            movesTodo = new List<Tuple<int, List<object>>>();
            game = new OthelloGame();
            gameState = game.createInitialState();

            lblGameStatus.Text = "GAME STARTED.";
            this.drawGame();
        }

        private void drawGame()
        {
            lastTileData = createTiles();
            pnlGame.Invalidate(); //redraw
        }

        private int[,] createTiles()
        {
            int[,] tiles =  gameState.Items;

            return tiles;
        }

        private void gameOver(int snakeLost)
        {
            lblGameStatus.Text = "GAME OVER. Snake " + snakeLost + " lost.";
        }

        private void nudTimerSpeed_ValueChanged(object sender, EventArgs e)
        {
            tmrGameAI.Interval = (int)nudTimerSpeed.Value;
        }

        private void pnlGame_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);

            if (lastTileData != null)
            {
                int borderWidthPx = 20;
                int widthTotal = pnlGame.Width - borderWidthPx * 2;
                int heightTotal = pnlGame.Height - borderWidthPx * 2;


                int widthBox = widthTotal / lastTileData.GetLength(0);
                int heightBox = heightTotal / lastTileData.GetLength(1);
                int boxSize = Math.Min(widthBox, heightBox);

                for (int y = 0; y < lastTileData.GetLength(0); y++)
                    for (int x = 0; x < lastTileData.GetLength(1); x++)
                    {
                        Brush thisBrush = Brushes.White;
                        switch (lastTileData[x, y])
                        {
                            case 0:
                                thisBrush = Brushes.White; // empty
                                break;
                            case 1:
                                thisBrush = Brushes.Black; // wall
                                break;
                            case 2:
                                thisBrush = Brushes.Green; // head
                                break;
                            case 3:
                                thisBrush = Brushes.Purple; // body
                                break;
                            case 4:
                                thisBrush = Brushes.DarkBlue; // tail
                                break;
                            case 5:
                                thisBrush = Brushes.Red; // food
                                break;
                        }
                        e.Graphics.FillRectangle(thisBrush, new Rectangle(borderWidthPx + boxSize * x, borderWidthPx + boxSize * y, boxSize, boxSize));
                    }
            }
        }



        private void tmrGameAI_Tick(object sender, EventArgs e)
        {

        }

        private void pnlGame_MouseClick(object sender, MouseEventArgs e)
        {
            //reverse mouse position
            int borderWidthPx = 20;
            int widthTotal = pnlGame.Width - borderWidthPx * 2;
            int heightTotal = pnlGame.Height - borderWidthPx * 2;

            int widthBox = widthTotal / lastTileData.GetLength(0);
            int heightBox = heightTotal / lastTileData.GetLength(1);
            int boxSize = Math.Min(widthBox, heightBox);

            Point mouseRelative = new Point(e.X - borderWidthPx, e.Y - borderWidthPx);

            Point actual = new Point((int)Math.Floor((double)mouseRelative.X / (double)boxSize), (int)Math.Floor((double)mouseRelative.Y / (double)boxSize));
            Console.Write(actual.X + " " + actual.Y);


            gameState = (OthelloGameState)game.makeMove(gameState, 1, actual); 
            drawGame();
        }
    }
}
