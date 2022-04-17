using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BOLayer;
using System.IO;

using System.Diagnostics;

namespace Cards
{
    public partial class Game : Form
    {
        private List<BOLayer.Player> players = new List<BOLayer.Player>();
        private int direction = 1;
        private int currentPlayer = 0;
        private Discard discard = new Discard();

        private void ChangeDirection()
        {
            direction *= -1;
        }

        public Game(int playerCount)
        {
            InitializeComponent();
            for (int i = 0; i < playerCount; i++)
            {
                players.Add(new Player());
            }
            Debug.WriteLine(players.Count);
            Debug.WriteLine(players[0]);
        }

        private void DisplayDiscardPile()
        {
            Panel1.Controls.Clear();
            Card card = discard.Pile.Last();

            PictureBox pictureBox = DisplayCard(card, 75, 0);

            switch (card.Color)
            {
                case BOLayer.Color.Red:
                    btnColor.BackColor = System.Drawing.Color.FromArgb(255, 255, 0, 0);
                    break;
                case BOLayer.Color.Green:
                    btnColor.BackColor = System.Drawing.Color.FromArgb(255, 0, 255, 0);
                    break;
                case BOLayer.Color.Blue:
                    btnColor.BackColor = System.Drawing.Color.FromArgb(255, 0, 0, 255);
                    break;
                case BOLayer.Color.Yellow:
                    btnColor.BackColor = System.Drawing.Color.FromArgb(255, 255, 255, 0);
                    break;
                default:
                    btnColor.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
                    break;
            }

            Panel1.Controls.Add(pictureBox);

        }

        private void DisplayHand(Player player)
        {
            lblCurPlayer.Text = $"Current Player: {currentPlayer + 1}";
            int handCount = player.hand.Count;
            for (int i = handCount - 1; i > 0; i--)
            {
                Card card = players[currentPlayer].hand[i];
                PictureBox pictureBox = DisplayCard(card, (Panel1.Size.Width - 155) / handCount * i, 300);

                Panel1.Controls.Add(pictureBox);
                pictureBox.Name = Panel1.Controls.GetChildIndex(pictureBox).ToString();

                pictureBox.MouseHover += PictureBox_MouseHover;
                pictureBox.MouseLeave += PictureBox_MouseLeave;
                pictureBox.Click += (object sender, EventArgs e) =>
                {
                    try
                    {
                        discard.Play(card, players[currentPlayer]);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (card.isWild())
                    {
                        Form1 chooseColor = new Form1();
                        chooseColor.ShowDialog();

                        card.Color = chooseColor.ChosenColor;
                    }

                    switch (card.FaceValue)
                    {
                        case FaceValue.Reverse:
                            ChangeDirection();
                            break;
                        case FaceValue.Draw:
                            Player p = players[NextPlayer()];
                            // draw cards for next player 4 is wild 2 is other
                            for (int ii = 0; ii < (card.isWild() ? 4 : 2); ii++)
                            {
                                p.Add(new Card());
                            }
                            break;
                        case FaceValue.Skip:
                            currentPlayer = NextPlayer();
                            break;
                    }
                    Debug.WriteLine(currentPlayer);
                    Debug.WriteLine(player.hand.Count);
                    if (player.hand.Count == 1)
                    {
                        Win win = new Win(currentPlayer);
                        this.Hide();
                        win.ShowDialog();
                        this.Close();
                        return;
                    }
                    currentPlayer = NextPlayer();
                    DisplayDiscardPile();
                    DisplayHand(players[currentPlayer]);
                };
            }
        }

        private int NextPlayer()
        {
            int nextPlayer = currentPlayer + direction;
            if (nextPlayer >= players.Count)
            {
                return 0;
            }
            if (nextPlayer < 0)
            {
                return players.Count - 1;
            }
            return nextPlayer;
        }

        private PictureBox DisplayCard(Card card, int x, int y)
        {
            string colorName = card.Color.ToString();
            string faceName = card.FaceValue.ToString();
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            string imgPath = projectDirectory + $@"\Cards\images\cards\{(card.isWild() ? "Wild" : colorName)}_{faceName}.png";

            PictureBox pictureBox = new PictureBox()
            {
                Image = Image.FromFile(imgPath),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Width = 155,
                Height = 224,
                Left = x,
                Top = y
            };
            return pictureBox;
        }

        private void PictureBox_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            Control parent = pictureBox.Parent;

            if (parent == null)
            {
                return;
            }

            parent.Controls.SetChildIndex(pictureBox, Convert.ToInt32(pictureBox.Name));
        }

        private void PictureBox_MouseHover(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            pictureBox.BringToFront();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
        }

        private void Game_Load(object sender, EventArgs e)
        {
            DisplayDiscardPile();
            DisplayHand(players[currentPlayer]);
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            players[currentPlayer].Add(new Card());
            currentPlayer = NextPlayer();
            DisplayDiscardPile();
            DisplayHand(players[currentPlayer]);
        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
