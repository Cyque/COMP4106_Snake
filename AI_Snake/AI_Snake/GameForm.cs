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
    public partial class GameForm : Form
    {
        SnakeGameState gameState;
        SnakeGame game;

        int[,] lastTileData;

        List<Tuple<int, List<object>>> movesTodo = new List<Tuple<int, List<object>>>();

        public GameForm()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                      ControlStyles.Opaque |
                      ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            movesTodo = new List<Tuple<int, List<object>>>();
            game = new SnakeGame();
            gameState = game.createInitialState(new Point((int)nudWidth.Value, (int)nudHeight.Value), (int)nudSnakeLength.Value, (int)nudNumbSnakes.Value, (int)nudBlocks.Value);

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
            int[,] tiles = new int[gameState.Size.Y, gameState.Size.X];

            for (int i = 0; i < gameState.Blocks.Count; i++)
                tiles[gameState.Blocks[i].Y, gameState.Blocks[i].X] = 1;

            tiles[gameState.Food.Y, gameState.Food.X] = 5;

            for (int i = 0; i < gameState.Blocks.Count; i++)
                tiles[gameState.Blocks[i].Y, gameState.Blocks[i].X] = 1;


            for (int i = 0; i < gameState.Snakes.Count; i++)
            {
                for (int s = 0; s < gameState.Snakes[i].Body.Count; s++)
                    tiles[gameState.Snakes[i].Body[s].Y, gameState.Snakes[i].Body[s].X] = 3;


                tiles[gameState.Snakes[i].Tail.Y, gameState.Snakes[i].Tail.X] = 4;
                tiles[gameState.Snakes[i].Head.Y, gameState.Snakes[i].Head.X] = 2;
            }


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
                        switch (lastTileData[y, x])
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

        private void GameForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (game != null && movesTodo.Count == 0)
            {
                if (e.KeyChar.Equals('w'))
                {
                    gameState = (SnakeGameState)game.makeMove(gameState, 0, 'N');
                }
                else if (e.KeyChar.Equals('s'))
                {
                    gameState = (SnakeGameState)game.makeMove(gameState, 0, 'S');
                }
                else if (e.KeyChar.Equals('a'))
                {
                    gameState = (SnakeGameState)game.makeMove(gameState, 0, 'W');
                }
                else if (e.KeyChar.Equals('d'))
                {
                    gameState = (SnakeGameState)game.makeMove(gameState, 0, 'E');
                }
                drawGame();
            }
        }

        private void runAI(List<object> moves, int player)
        {
            movesTodo.Add(new Tuple<int, List<object>>(player, moves));
        }

        private void btnAI_Click(object sender, EventArgs e)
        {
            if (!radManual.Checked)
            {

                for (int sn = 0; sn < gameState.Snakes.Count; sn++)
                {
                    GameAI search = null;
                    if (radBreadth.Checked)
                        search = new BreadthFirst();
                    else if (radDepth.Checked)
                        search = new DepthFirst();
                    else if (RadAStar.Checked)
                    {
                        if (radManhattan.Checked)
                            search = new AStar(0);
                        else if (radEuclidean.Checked)
                            search = new AStar(1);
                        else if (radClosestToCenter.Checked)
                            search = new AStar(2);
                        else if (radModMan.Checked)
                            search = new AStar(3);
                        else if (radMixed.Checked)
                            search = new AStar(4);
                    }


                    List<object> result = search.solveGame(gameState, new SnakeGame(), sn);

                    if (result == null)
                        Console.WriteLine("No solution");
                    else
                    {
                        for (int i = 0; i < result.Count; i++)
                            Console.Write(result[i] + ", ");
                        Console.WriteLine();
                        Console.WriteLine(search.nodesExpanded);
                        Console.WriteLine();

                        runAI(result, sn);
                    }
                }
            }
        }

        private void tmrGameAI_Tick(object sender, EventArgs e)
        {
            if (movesTodo.Count > 0)
            {
                for (int i = 0; i < movesTodo.Count; i++)
                {
                    gameState = (SnakeGameState)game.makeMove(gameState, movesTodo[i].Item1, movesTodo[i].Item2[0]);
                    movesTodo[i].Item2.RemoveAt(0);
                    if (movesTodo[i].Item2.Count == 0)
                    {
                        movesTodo.RemoveAt(i);
                        i--;
                    }
                }
                drawGame();
            }
        }

    }
}
