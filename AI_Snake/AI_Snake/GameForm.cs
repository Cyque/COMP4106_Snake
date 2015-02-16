using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AI_Snake
{
    public partial class GameForm : Form
    {
        SnakeGame2 game;

        int[,] lastTileData;

        public GameForm()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                      ControlStyles.Opaque |
                      ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            game = new SnakeGame2(new Point((int)nudWidth.Value, (int)nudHeight.Value), (int)nudSnakeLength.Value, (int)nudNumbSnakes.Value);
            game.OnGameChanged += new SnakeGame2.gameChangedHandler(drawGame);
            game.OnGameOver += new SnakeGame2.gameOverHandler(gameOver);
            game.initialize();

            lblGameStatus.Text = "GAME STARTED."; 
        }

        private void drawGame(int [,] tileData)
        {
            lastTileData = tileData;
            pnlGame.Invalidate(); //redraw
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

                for (int y = 0; y < lastTileData.GetLength(1); y++)
                    for (int x = 0; x < lastTileData.GetLength(0); x++)
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
                        }
                        e.Graphics.FillRectangle(thisBrush, new Rectangle(borderWidthPx + boxSize * x, borderWidthPx + boxSize * y, boxSize, boxSize));
                    }
            }
        }

        private void tmrGameAI_Tick(object sender, EventArgs e)
        {
            pnlGame.Invalidate();
        }

        private void GameForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (game != null)
                if (e.KeyChar.Equals('w'))
                {
                    game.makeMove('N');
                }
                else if (e.KeyChar.Equals('s'))
                {
                    game.makeMove('S');
                }
                else if (e.KeyChar.Equals('a'))
                {
                    game.makeMove('W');
                }
                else if (e.KeyChar.Equals('d'))
                {
                    game.makeMove('E');
                }
        }

    }
}
