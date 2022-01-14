using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AI_DACK.libs;
using AI_DACK.Libs;

namespace AI_DACK
{
    public partial class Dashboard : Form
    {
        public static int level = 0; // level = 0 easy
        public static int mode = 0; // mode = 0 PvP
        public static int colAndRow = 0;
        int turnNumber = 0;
        int scoreX = 0;
        int scoreO = 0;
        Board board;
        public Dashboard()
        {
            InitializeComponent();
        }

        private void mainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            notificationTxt.Text = $"XY: {e.Location.X} {e.Location.Y} | Number of Row and Col: {colAndRow} | Level: {level} | Mode: {mode}";
        }

        private void scorePanel_SizeChanged(object sender, EventArgs e)
        {
            int width = scorePanel.Width;
            firstPlayerPanel.Left = width / 2 - firstPlayerPanel.Width - 30;
            secondPlayerPanel.Left = width / 2 + 30;
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {
            if (board != null)
            {
                // Margin of mesh
                int margin = 10;
                Graphics graphics = mainPanel.CreateGraphics();
                Brush blue = new SolidBrush(Color.FromArgb(0, 149, 168));
                Brush dark = new SolidBrush(Color.FromArgb(69, 90, 100));
                Brush wheat = new SolidBrush(Color.Wheat);
                Pen pen = new Pen(blue, 5);
                Pen xPen = new Pen(dark, 5);
                Pen oPen = new Pen(wheat, 5);

                for (int i = 1; i < colAndRow; i++)
                {
                    int x = board.MarginX + board.BarSpace * i;
                    int y = board.MarginY + board.CrossSpace * i;
                    graphics.DrawLine(pen, x, margin + board.MarginY, x, board.Height + board.MarginY - margin);
                    graphics.DrawLine(pen, margin + board.MarginX, y, board.Height + board.MarginX - margin, y);
                }

                for (int i = 0; i < colAndRow; i++)
                {
                    for (int j = 0; j < colAndRow; j++)
                    {
                        if (board.Content[i, j] == 'X')
                        {
                            var xy = board.ConvertPositionIJtoXY(i, j);
                            graphics.DrawLine(
                                xPen,
                                xy.Item1 + (int)(board.BarSpace * 0.2),
                                xy.Item2 + (int)(board.CrossSpace * 0.2),
                                xy.Item1 + board.BarSpace - (int)(board.CrossSpace * 0.2),
                                xy.Item2 + board.CrossSpace - (int)(board.CrossSpace * 0.2)
                            ); // 0.1 is padding of space
                            graphics.DrawLine(
                                xPen,
                                xy.Item1 + (int)(board.BarSpace * 0.2),
                                xy.Item2 + board.CrossSpace - (int)(board.CrossSpace * 0.2),
                                xy.Item1 + board.BarSpace - (int)(board.CrossSpace * 0.2),
                                xy.Item2 + (int)(board.CrossSpace * 0.2)
                            ); // 0.1 is padding of space
                        }
                        if (board.Content[i, j] == 'O')
                        {
                            var xy = board.ConvertPositionIJtoXY(i, j);
                            graphics.DrawEllipse(
                                oPen,
                                xy.Item1 + (int)(board.BarSpace * 0.2),
                                xy.Item2 + (int)(board.CrossSpace * 0.2),
                                board.BarSpace - (int)(board.CrossSpace * 0.4),
                                board.CrossSpace - (int)(board.CrossSpace * 0.4)
                            ); // 0.1 is padding of space
                        }

                    }
                }
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (board != null)
            {
                board.ChangeSize(mainPanel.Width, mainPanel.Height);
                this.Refresh();
            }
        }

        private void mainPanel_MouseClick(object sender, MouseEventArgs e)
        {
            if (board.IsInside(e.Location.X, e.Location.Y))
            {
                Tuple<int, int> pos = board.ConvertPositionXYtoIJ(e.Location.X, e.Location.Y);
                if (board.Content[pos.Item1, pos.Item2] == '-')
                {
                    board.TickAt(pos.Item1, pos.Item2, board.Turn);
                    turnLabel.Text = "Lượt của " + board.Turn;
                    logListBox.Items.Add($"{board.Turn}{++turnNumber} : {pos}");
                    board.ChangeTurn();
                    this.Refresh();
                    if (mode == 1)
                    {
                        if (Check())
                        {
                            if (colAndRow<=3)
                            {
                                MiniMax miniMax = new MiniMax(board.NumOfRow, board.NumOfCol, level);
                                turnLabel.Text = "Lượt của " + board.Turn;
                                Tuple<int, int> r = miniMax.MinimaxDecision(board, board.Turn);
                                board.TickAt(r.Item1, r.Item2, board.Turn);
                                logListBox.Items.Add($"{board.Turn}{++turnNumber} : {r}");
                                board.ChangeTurn();
                                this.Refresh();
                            }    
                            else
                            {
                                AlphaBeta alphaBeta = new AlphaBeta(board.NumOfRow, board.NumOfCol, level);
                                turnLabel.Text = "Lượt của " + board.Turn;
                                Tuple<int, int> r = alphaBeta.AlphaBetaDecision(board, board.Turn);
                                board.TickAt(r.Item1, r.Item2, board.Turn);
                                logListBox.Items.Add($"{board.Turn}{++turnNumber} : {r}");
                                board.ChangeTurn();
                                this.Refresh();
                            }    
                        }
                    }
                    Check();
                }
            }
        }
        private bool Check()
        {
            char result = board.CheckWin();
            switch (result)
            {
                case 't':
                    MessageBox.Show("Hòa!");
                    ResetGame();
                    return false;
                case 'X':
                    MessageBox.Show("X thắng!");
                    scoreX++;
                    scoreXLable.Text = scoreX.ToString();
                    ResetGame();
                    return false;
                case 'O':
                    MessageBox.Show("O thắng!");
                    scoreO++;
                    scoreOLable.Text = scoreO.ToString();
                    ResetGame();
                    return false;
                default:
                    break;
            }
            return true;
        }
        private void ResetGame()
        {
            if (board != null)
            {
                board.ResetContent();
                logListBox.Items.Clear();
                turnNumber = 0;
                turnLabel.Text = "Lượt của " + board.Turn;
                this.Refresh();
            }
        }

        private void tạoVánChơiMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Setting setting = new Setting();
            setting.ShowDialog();
            if (colAndRow != 0)
            {
                board = new Board(mainPanel.Width, mainPanel.Height, colAndRow);
                mainPanel.Enabled = true;
                scoreO = 0;
                scoreX = 0;
                scoreXLable.Text = scoreX.ToString();
                scoreOLable.Text = scoreO.ToString();
                ResetGame();
            }
        }

        private void chơiLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetGame();
        }
    }
}
