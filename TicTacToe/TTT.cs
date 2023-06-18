using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class TTT : Form
    {
        public static readonly Assembly ass = Assembly.GetExecutingAssembly();
        public Point cp;
        public bool hardmode = false;

        //Images Loading

        public readonly Image minBtn = Image.FromStream(ass.GetManifestResourceStream("TicTacToe.img.MinBtn.png"));
        public readonly Image minBtnDwn = Image.FromStream(ass.GetManifestResourceStream("TicTacToe.img.MinBtnDwn.png"));
        public readonly Image exitBtn = Image.FromStream(ass.GetManifestResourceStream("TicTacToe.img.ExitBtn.png"));
        public readonly Image exitBtnDwn = Image.FromStream(ass.GetManifestResourceStream("TicTacToe.img.ExitBtnDwn.png"));
        public static readonly Image nGBtn = Image.FromStream(ass.GetManifestResourceStream("TicTacToe.img.NGBtn.png"));
        public static readonly Image logo = Image.FromStream(ass.GetManifestResourceStream("TicTacToe.img.Logo.png"));
        public readonly Image nGBtnHvr = Image.FromStream(ass.GetManifestResourceStream("TicTacToe.img.NGBtnHvr.png"));
        public readonly Image nGBtnDwn = Image.FromStream(ass.GetManifestResourceStream("TicTacToe.img.NGBtnDwn.png"));
        public static readonly Image diff = Image.FromStream(ass.GetManifestResourceStream("TicTacToe.img.Diff.png"));
        public static readonly Image easy = Image.FromStream(ass.GetManifestResourceStream("TicTacToe.img.Easy.png"));
        public static readonly Image easyHvr = Image.FromStream(ass.GetManifestResourceStream("TicTacToe.img.EasyHvr.png"));
        public static readonly Image easyDwn = Image.FromStream(ass.GetManifestResourceStream("TicTacToe.img.EasyDwn.png"));
        public static readonly Image hard = Image.FromStream(ass.GetManifestResourceStream("TicTacToe.img.Hard.png"));
        public static readonly Image hardHvr = Image.FromStream(ass.GetManifestResourceStream("TicTacToe.img.HardHvr.png"));
        public static readonly Image hardDwn = Image.FromStream(ass.GetManifestResourceStream("TicTacToe.img.HardDwn.png"));
        public static readonly Image border = Image.FromStream(ass.GetManifestResourceStream("TicTacToe.img.Border.png"));
        public static readonly Image field = Image.FromStream(ass.GetManifestResourceStream("TicTacToe.img.Field.png"));
        public static readonly Image fieldHvr = Image.FromStream(ass.GetManifestResourceStream("TicTacToe.img.FieldHvr.png"));
        public static readonly Image winH = Image.FromStream(ass.GetManifestResourceStream("TicTacToe.img.WinH.png"));
        public static readonly Image winV = Image.FromStream(ass.GetManifestResourceStream("TicTacToe.img.WinV.png"));
        public static readonly Image lossH = Image.FromStream(ass.GetManifestResourceStream("TicTacToe.img.LossH.png"));
        public static readonly Image lossV = Image.FromStream(ass.GetManifestResourceStream("TicTacToe.img.LossV.png"));
        public static readonly Image winDL = Image.FromStream(ass.GetManifestResourceStream("TicTacToe.img.WinDL.png"));
        public static readonly Image winDR = Image.FromStream(ass.GetManifestResourceStream("TicTacToe.img.WinDR.png"));
        public static readonly Image lossDR = Image.FromStream(ass.GetManifestResourceStream("TicTacToe.img.LossDR.png"));
        public static readonly Image lossDL = Image.FromStream(ass.GetManifestResourceStream("TicTacToe.img.LossDL.png"));
        public static readonly Image victory = Image.FromStream(ass.GetManifestResourceStream("TicTacToe.img.Victory.png"));
        public static readonly Image defeat = Image.FromStream(ass.GetManifestResourceStream("TicTacToe.img.Defeat.png"));
        public static readonly Image draw = Image.FromStream(ass.GetManifestResourceStream("TicTacToe.img.Draw.png"));
        public static readonly Image endText = Image.FromStream(ass.GetManifestResourceStream("TicTacToe.img.EndText.png"));
        public static readonly Image tac = Image.FromStream(ass.GetManifestResourceStream("TicTacToe.img.Tac.png"));
        public static readonly Image toe = Image.FromStream(ass.GetManifestResourceStream("TicTacToe.img.Toe.png"));
        public static readonly Icon ico = new Icon(ass.GetManifestResourceStream("TicTacToe.Icon.ico"));

        //Game

        public List<int> you  = new List<int>();
        public List<int> bot = new List<int>();
        public int[] fields = new int[9];
        public Random random = new Random();

        //Win Combinations

        public readonly List<int> win1 = new List<int>() { 1, 2, 3 };
        public readonly List<int> win2 = new List<int>() { 4, 5, 6 };
        public readonly List<int> win3 = new List<int>() { 7, 8, 9 };
        public readonly List<int> win4 = new List<int>() { 1, 4, 7 };
        public readonly List<int> win5 = new List<int>() { 2, 5, 8 };
        public readonly List<int> win6 = new List<int>() { 3, 6, 9 };
        public readonly List<int> win7 = new List<int>() { 1, 5, 9 };
        public readonly List<int> win8 = new List<int>() { 3, 5, 7 };


        //Form Initialization

        public TTT()
        {
            InitializeComponent();
        }

        //Game Logic

        private void DiagonalWinL(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(winDL, new Rectangle(30, 269, 420, 420));
        }

        private void DiagonalWinR(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(winDR, new Rectangle(30, 269, 420, 420));
        }

        private void Clear(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(84)))), ((int)(((byte)90)))));
        }

        private void DiagonalLossR(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(lossDR, new Rectangle(30, 269, 420, 420));
        }

        private void DiagonalLossL(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(lossDL, new Rectangle(30, 269, 420, 420));
        }
        private void NewGame()
        {
            you.Clear();
            bot.Clear();
            fields = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            NGBtn.Enabled = false; NGBtn.Visible = false;
            Diff.Enabled = false; Diff.Visible = false;
            DiffSw.Enabled = false; DiffSw.Visible = false;
            B1.Enabled = true; B1.Visible = true; B1.BackgroundImage = field;
            B2.Enabled = true; B2.Visible = true; B2.BackgroundImage = field;
            B3.Enabled = true; B3.Visible = true; B3.BackgroundImage = field;
            B4.Enabled = true; B4.Visible = true; B4.BackgroundImage = field;
            B5.Enabled = true; B5.Visible = true; B5.BackgroundImage = field;
            B6.Enabled = true; B6.Visible = true; B6.BackgroundImage = field;
            B7.Enabled = true; B7.Visible = true; B7.BackgroundImage = field;
            B8.Enabled = true; B8.Visible = true; B8.BackgroundImage = field;
            B9.Enabled = true; B9.Visible = true; B9.BackgroundImage = field;
        }

        private void MakeMove(int m)
        {
            fields[m - 1] = 0;
            if (Check())
            {
                return;
            }

            if (!hardmode)
            {
                int f = random.Next(0, 9);
                while (fields[f] == 0)
                {
                    f = random.Next(0, 9);
                }
                System.Threading.Thread.Sleep(420);
                Toe(f + 1);
            }
            else
            {
                if (B5.Enabled == true)
                {
                    Toe(5);
                }
                else
                {
                    if (bot.Intersect(win1).Count() > 1 && fields[win1.Except(bot).ToArray()[0] - 1] != 0)
                    {
                        Toe(win1.Except(bot).ToArray()[0]);
                        return;
                    }
                    else if (you.Intersect(win1).Count() > 1 && fields[win1.Except(you).ToArray()[0] - 1] != 0)
                    {
                        Toe(win1.Except(you).ToArray()[0]);
                        return;
                    }
                    if (bot.Intersect(win2).Count() > 1 && fields[win2.Except(bot).ToArray()[0] -1] != 0)
                    {
                        Toe(win2.Except(bot).ToArray()[0]);
                        return;
                    }
                    else if (you.Intersect(win2).Count() > 1 && fields[win2.Except(you).ToArray()[0] - 1] != 0)
                    {
                        Toe(win2.Except(you).ToArray()[0]);
                        return;
                    }
                    if (bot.Intersect(win3).Count() > 1 && fields[win3.Except(bot).ToArray()[0] - 1] != 0)
                    {
                        Toe(win3.Except(bot).ToArray()[0]);
                        return;
                    }
                    else if (you.Intersect(win3).Count() > 1 && fields[win3.Except(you).ToArray()[0] - 1] != 0)
                    {
                        Toe(win3.Except(you).ToArray()[0]);
                        return;
                    }
                    if (bot.Intersect(win4).Count() > 1 && fields[win4.Except(bot).ToArray()[0] - 1] != 0)
                    {
                        Toe(win4.Except(bot).ToArray()[0]);
                        return;
                    }
                    else if (you.Intersect(win4).Count() > 1 && fields[win4.Except(you).ToArray()[0] - 1] != 0)
                    {
                        Toe(win4.Except(you).ToArray()[0]);
                        return;
                    }
                    if (bot.Intersect(win5).Count() > 1 && fields[win5.Except(bot).ToArray()[0] - 1] != 0)
                    {
                        Toe(win5.Except(bot).ToArray()[0]);
                        return;
                    }
                    else if (you.Intersect(win5).Count() > 1 && fields[win5.Except(you).ToArray()[0] - 1] != 0)
                    {
                        Toe(win5.Except(you).ToArray()[0]);
                        return;
                    }
                    if (bot.Intersect(win6).Count() > 1 && fields[win6.Except(bot).ToArray()[0] - 1] != 0)
                    {
                        Toe(win6.Except(bot).ToArray()[0]);
                        return;
                    }
                    else if (you.Intersect(win6).Count() > 1 && fields[win6.Except(you).ToArray()[0] - 1] != 0)
                    {
                        Toe(win6.Except(you).ToArray()[0]);
                        return;
                    }
                    if (bot.Intersect(win7).Count() > 1 && fields[win7.Except(bot).ToArray()[0] - 1] != 0)
                    {
                        Toe(win7.Except(bot).ToArray()[0]);
                        return;
                    }
                    else if (you.Intersect(win7).Count() > 1 && fields[win7.Except(you).ToArray()[0] - 1] != 0)
                    {
                        Toe(win7.Except(you).ToArray()[0]);
                        return;
                    }
                    if (bot.Intersect(win8).Count() > 1 && fields[win8.Except(bot).ToArray()[0] - 1] != 0)
                    {
                        Toe(win8.Except(bot).ToArray()[0]);
                        return;
                    }
                    else if (you.Intersect(win8).Count() > 1 && fields[win8.Except(you).ToArray()[0] - 1] != 0)
                    {
                        Toe(win8.Except(you).ToArray()[0]);
                        return;
                    }
                    else
                    {
                        int f = random.Next(0, 9);
                        while (fields[f] == 0)
                        {
                            f = random.Next(0, 9);
                        }
                        fields[f] = 0;
                        System.Threading.Thread.Sleep(420);
                        Toe(f + 1);
                    }
                }
            }
        }

        private void Toe(int f)
        {
            fields[f - 1] = 0;
            switch (f)
            {
                case 1:
                    B1.BackgroundImage = toe;
                    B1.Enabled = false;
                    bot.Add(1);
                    break;

                case 2:
                    B2.BackgroundImage = toe;
                    B2.Enabled = false;
                    bot.Add(2);
                    break;

                case 3:
                    B3.BackgroundImage = toe;
                    B3.Enabled = false;
                    bot.Add(3);
                    break;

                case 4:
                    B4.BackgroundImage = toe;
                    B4.Enabled = false;
                    bot.Add(4);
                    break;

                case 5:
                    B5.BackgroundImage = toe;
                    B5.Enabled = false;
                    bot.Add(5);
                    break;

                case 6:
                    B6.BackgroundImage = toe;
                    B6.Enabled = false;
                    bot.Add(6);
                    break;

                case 7:
                    B7.BackgroundImage = toe;
                    B7.Enabled = false;
                    bot.Add(7);
                    break;

                case 8:
                    B8.BackgroundImage = toe;
                    B8.Enabled = false;
                    bot.Add(8);
                    break;

                case 9:
                    B9.BackgroundImage = toe;
                    B9.Enabled = false;
                    bot.Add(9);
                    break;
            }
            Check();
        }

        private bool Check()
        {
            if (string.Join("", fields) == "000000000")
            {
                Draw();
                return true;
            }
            else if (win1.All(you.Contains))
            {
                Win(1);
                return true;
            }
            else if (win1.All(bot.Contains))
            {
                Lose(1);
                return true;
            }
            if (win2.All(you.Contains))
            {
                Win(2);
                return true;
            }
            else if (win2.All(bot.Contains))
            {
                Lose(2);
                return true;
            }
            if (win3.All(you.Contains))
            {
                Win(3);
                return true;
            }
            else if (win3.All(bot.Contains))
            {
                Lose(3);
                return true;
            }
            if (win4.All(you.Contains))
            {
                Win(4);
                return true;
            }
            else if (win4.All(bot.Contains))
            {
                Lose(4);
                return true;
            }
            if (win5.All(you.Contains))
            {
                Win(5);
                return true;
            }
            else if (win5.All(bot.Contains))
            {
                Lose(5);
                return true;
            }
            if (win6.All(you.Contains))
            {
                Win(6);
                return true;
            }
            else if (win6.All(bot.Contains))
            {
                Lose(6);
                return true;
            }
            if (win7.All(you.Contains))
            {
                Win(7);
                return true;
            }
            else if (win7.All(bot.Contains))
            {
                Lose(7);
                return true;
            }
            if (win8.All(you.Contains))
            {
                Win(8);
                return true;
            }
            else if (win8.All(bot.Contains))
            {
                Lose(8);
                return true;
            }
            return false;
        }

        private void GameOver()
        {
            System.Threading.Thread.Sleep(2000);
            EndText.BackgroundImage = null;
            EndText.Refresh();
            Paint += Clear;
            Diff.Enabled = true; Diff.Visible = true;
            DiffSw.Enabled = true; DiffSw.Visible = true;
            EndGame.Enabled = false; EndGame.Visible = false;
            B1.Enabled = false; B1.Visible = false;
            B2.Enabled = false; B2.Visible = false;
            B3.Enabled = false; B3.Visible = false;
            B4.Enabled = false; B4.Visible = false;
            B5.Enabled = false; B5.Visible = false;
            B6.Enabled = false; B6.Visible = false;
            B7.Enabled = false; B7.Visible = false;
            B8.Enabled = false; B8.Visible = false;
            B9.Enabled = false; B9.Visible = false;
            Refresh();
            NGBtn.Enabled = true; NGBtn.Visible = true;
        }

        private void Win(int w)
        {
            EndText.BackgroundImage = victory;
            EndText.Refresh();
            switch (w)
            {
                case 1:
                    EndGame.Size = new Size(420, 12);
                    EndGame.Image = winH;
                    EndGame.Location = new Point(30, 338);
                    break;

                case 2:
                    EndGame.Size = new Size(420, 12);
                    EndGame.Image = winH;
                    EndGame.Location = new Point(30,473);
                    break;

                case 3:
                    EndGame.Size = new Size(420, 12);
                    EndGame.Image = winH;
                    EndGame.Location = new Point(30, 608);
                    break;

                case 4:
                    EndGame.Size = new Size(12, 420);
                    EndGame.Image = winV;
                    EndGame.Location = new Point(99, 269);
                    break;

                case 5:
                    EndGame.Size = new Size(12, 420);
                    EndGame.Image = winV;
                    EndGame.Location = new Point(234, 269);
                    break;

                case 6:
                    EndGame.Size = new Size(12, 420);
                    EndGame.Image = winV;
                    EndGame.Location = new Point(369, 269);
                    break;

                case 7:
                    Paint += DiagonalWinL;
                    BringToFront();
                    Refresh();
                    GameOver();
                    return;

                case 8:
                    Paint += DiagonalWinR;
                    BringToFront();
                    Refresh();
                    GameOver();
                    return;

            }
            EndGame.BringToFront();
            EndGame.Enabled = true;
            EndGame.Visible = true;
            EndGame.Refresh();
            GameOver();
        }

        private void Lose(int l)
        {
            EndText.BackgroundImage = defeat;
            EndText.Refresh();
            switch (l)
            {
                case 1:
                    EndGame.Size = new Size(420, 12);
                    EndGame.Image = lossH;
                    EndGame.Location = new Point(30, 338);
                    break;

                case 2:
                    EndGame.Size = new Size(420, 12);
                    EndGame.Image = lossH;
                    EndGame.Location = new Point(30, 473);
                    break;

                case 3:
                    EndGame.Size = new Size(420, 12);
                    EndGame.Image = lossH;
                    EndGame.Location = new Point(30, 608);
                    break;

                case 4:
                    EndGame.Size = new Size(12, 420);
                    EndGame.Image = lossV;
                    EndGame.Location = new Point(99, 269);
                    break;

                case 5:
                    EndGame.Size = new Size(12, 420);
                    EndGame.Image = lossV;
                    EndGame.Location = new Point(234, 269);
                    break;

                case 6:
                    EndGame.Size = new Size(12, 420);
                    EndGame.Image = lossV;
                    EndGame.Location = new Point(369, 269);
                    break;

                case 7:
                    Paint += DiagonalLossL;
                    BringToFront();
                    Refresh();
                    GameOver();
                    return;

                case 8:
                    Paint += DiagonalLossR;
                    BringToFront();
                    Refresh();
                    GameOver();
                    return;

            }
            EndGame.BringToFront();
            EndGame.Enabled = true;
            EndGame.Visible = true;
            EndGame.Refresh();
            System.Threading.Thread.Sleep(3000);
            GameOver();
        }

        private void Draw()
        {
            EndText.BackgroundImage = draw;
            EndText.Refresh();
            GameOver();
        }

        //Button Handling

            //Minimize Button
        private void MinBtn_MouseHover(object sender, EventArgs e)
        {
            MinBtn.BackgroundImage = minBtn;
        }

        private void MinBtn_MouseLeave(object sender, EventArgs e)
        {
            MinBtn.BackgroundImage = null;
        }

        private void MinBtn_MouseClick(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void MinBtn_MouseDown(object sender, MouseEventArgs e)
            {
                MinBtn.BackgroundImage = minBtnDwn;
            }

        private void MinBtn_MouseUp(object sender, MouseEventArgs e)
        {
            MinBtn.BackgroundImage = null;
        }
            
            //Exit Button

        private void ExitBtn_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void ExitBtn_MouseHover(object sender, EventArgs e)
        {
            ExitBtn.BackgroundImage = exitBtn;
        }

        private void ExitBtn_MouseLeave(object sender, EventArgs e)
        {
            ExitBtn.BackgroundImage = null;
        }

        private void ExitBtn_MouseDown(object sender, MouseEventArgs e)
        {
            ExitBtn.BackgroundImage = exitBtnDwn;
        }

            //Mover Logic

        private void Mover_MouseDown(object sender, MouseEventArgs e)
        {
            cp = new Point(e.X, e.Y);
        }

        private void Mover_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - cp.X;
                this.Top += e.Y - cp.Y;
            }
        }

            //New Game Button

        private void NGBtn_MouseHover(object sender, EventArgs e)
        {
            NGBtn.BackgroundImage = nGBtnHvr;
        }

        private void NGBtn_MouseLeave(object sender, EventArgs e)
        {
            NGBtn.BackgroundImage = nGBtn;
        }

        private void NGBtn_MouseDown(object sender, MouseEventArgs e)
        {
            NGBtn.BackgroundImage = nGBtnDwn;
        }

        private void NGBtn_MouseUp(object sender, MouseEventArgs e)
        {
            NGBtn.BackgroundImage = nGBtnHvr;
            NewGame();
        }

            //Difficulty Switch

        private void DiffSw_MouseHover(object sender, EventArgs e)
        {
            if (hardmode) 
            {
                DiffSw.BackgroundImage = hardHvr;
            }
            else
            {
                DiffSw.BackgroundImage = easyHvr;
            }
        }

        private void DiffSw_MouseLeave(object sender, EventArgs e)
        {
            if (!hardmode)
            {
                DiffSw.BackgroundImage = easy;
            }
            else
            {
                DiffSw.BackgroundImage = hard; 
            }
        }

        private void DiffSw_MouseDown(object sender, MouseEventArgs e)
        {
            if (hardmode)
            {
                DiffSw.BackgroundImage = hardDwn;
                hardmode = false;
            }
            else
            {
                DiffSw.BackgroundImage = easyDwn;
                hardmode = true;
            }
        }

        private void DiffSw_MouseUp(object sender, MouseEventArgs e)
        {
            if (hardmode)
            {
                DiffSw.BackgroundImage = hardHvr;
            }
            else
            {
                DiffSw.BackgroundImage = easyHvr;
            }
        }

            //Play Buttons

        private void B1_MouseDown(object sender, MouseEventArgs e)
        {
            B1.BackgroundImage = tac;
            B1.Enabled = false;
            you.Add(1);
            MakeMove(1);
        }

        private void B2_MouseDown(object sender, MouseEventArgs e)
        {
            B2.BackgroundImage = tac;
            B2.Enabled = false;
            you.Add(2);
            MakeMove(2);
        }

        private void B3_MouseDown(object sender, MouseEventArgs e)
        {
            B3.BackgroundImage = tac;
            B3.Enabled = false;
            you.Add(3);
            MakeMove(3);
        }

        private void B4_MouseDown(object sender, MouseEventArgs e)
        {
            B4.BackgroundImage = tac;
            B4.Enabled = false;
            you.Add(4);
            MakeMove(4);
        }

        private void B5_MouseDown(object sender, MouseEventArgs e)
        {
            B5.BackgroundImage = tac;
            B5.Enabled = false;
            you.Add(5);
            MakeMove(5);
        }

        private void B6_MouseDown(object sender, MouseEventArgs e)
        {
            B6.BackgroundImage = tac;
            B6.Enabled = false;
            you.Add(6);
            MakeMove(6);
        }

        private void B7_MouseDown(object sender, MouseEventArgs e)
        {
            B7.BackgroundImage = tac;
            B7.Enabled = false;
            you.Add(7);
            MakeMove(7);
        }

        private void B8_MouseDown(object sender, MouseEventArgs e)
        {
            B8.BackgroundImage = tac;
            B8.Enabled = false;
            you.Add(8);
            MakeMove(8);
        }

        private void B9_MouseDown(object sender, MouseEventArgs e)
        {
            B9.BackgroundImage = tac;
            B9.Enabled = false;
            you.Add(9);
            MakeMove(9);
        }

        private void B1_MouseHover(object sender, EventArgs e)
        {
            B1.BackgroundImage = fieldHvr;
        }

        private void B1_MouseLeave(object sender, EventArgs e)
        {
            if (B1.Enabled == true)
            B1.BackgroundImage = field;
        }

        private void B2_MouseHover(object sender, EventArgs e)
        {
            B2.BackgroundImage = fieldHvr;
        }

        private void B2_MouseLeave(object sender, EventArgs e)
        {
            if (B2.Enabled == true)
                B2.BackgroundImage = field;
        }

        private void B3_MouseHover(object sender, EventArgs e)
        {
            B3.BackgroundImage = fieldHvr;
        }

        private void B3_MouseLeave(object sender, EventArgs e)
        {
            if (B3.Enabled == true)
                B3.BackgroundImage = field;
        }

        private void B4_MouseHover(object sender, EventArgs e)
        {
            B4.BackgroundImage = fieldHvr;
        }

        private void B4_MouseLeave(object sender, EventArgs e)
        {
            if (B4.Enabled == true)
                B4.BackgroundImage = field;
        }

        private void B5_MouseHover(object sender, EventArgs e)
        {
            B5.BackgroundImage = fieldHvr;
        }

        private void B5_MouseLeave(object sender, EventArgs e)
        {
            if (B5.Enabled == true)
                B5.BackgroundImage = field;
        }

        private void B6_MouseHover(object sender, EventArgs e)
        {
            B6.BackgroundImage = fieldHvr;
        }

        private void B6_MouseLeave(object sender, EventArgs e)
        {
            if (B6.Enabled == true)
                B6.BackgroundImage = field;
        }

        private void B7_MouseHover(object sender, EventArgs e)
        {
            B7.BackgroundImage = fieldHvr;
        }

        private void B7_MouseLeave(object sender, EventArgs e)
        {
            if (B7.Enabled == true)
                B7.BackgroundImage = field;
        }

        private void B8_MouseHover(object sender, EventArgs e)
        {
            B8.BackgroundImage = fieldHvr;
        }

        private void B8_MouseLeave(object sender, EventArgs e)
        {
            if (B8.Enabled == true)
                B8.BackgroundImage = field;
        }
        private void B9_MouseHover(object sender, EventArgs e)
        {
            B9.BackgroundImage = fieldHvr;
        }

        private void B9_MouseLeave(object sender, EventArgs e)
        {
            if (B9.Enabled == true)
                B9.BackgroundImage = field;
        }
    }
}
