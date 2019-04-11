using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackjackUI
{
    public partial class MainForm : Form
    {
        public Player Player { get; set; }
        public Player Dealer { get; set; }
        private string basePath = @"C:\Users\Jordan\source\repos\JordanGibsonNEA\BlackjackUI\Resources\";
        private int bet { get; set; }

        public MainForm()
        {
            InitializeComponent();

            Player = new Player();
            Dealer = new Player(true);
            lblBet.Text = "Bet: £" + nudBet.Value;
            lblBalance.Text = "Balance: £" + Player.Balance;
            lblDealerTotal.BringToFront();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            pnlTable.Controls.OfType<PictureBox>().ToList().ForEach(x => pnlTable.Controls.Remove(x));
            lblUserTotal.Visible = false;
            lblDealerTotal.Visible = false;
            lblResult.Visible = false;
            Player.NewHand();
            Dealer.NewHand();
            Player.Bet = (int)nudBet.Value;
            Player.Balance -= (int)nudBet.Value;
            DealCard(Player.Hand.Cards[0], new Point(532, 468));
            DealCard(Dealer.Hand.Cards[0], new Point(532, 120));
            DealCard(Player.Hand.Cards[1], new Point(572, 468));
            DealCard(Card.Blank, new Point(572, 120));
            UpdateUI(true);
            EvaluateGameState();
        }

        private void DealCard(Card card, Point point)
        {
            PictureBox pbxCard = new PictureBox();
            pbxCard.Image = GetCardImageByCard(card);
            pbxCard.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxCard.Location = point;
            pbxCard.Size = new Size(75, 108);
            pnlTable.Controls.Add(pbxCard);
            pbxCard.BringToFront();
            pnlTable.Update();
            Thread.Sleep(200);
        }

        private void EvaluateGameState()
        {
            if (Player.Hand.Cards.Count == 2) {
                if (Player.Hand.Cards[0] == Player.Hand.Cards[1]) btnSplit.Enabled = true;
                if (!Player.Hand.ContainsAce) btnDoubleDown.Enabled = true;
            }
            if (Dealer.Hand.Cards.Count == 1 && Dealer.Hand.ContainsAce) btnInsurance.Enabled = true;

            var playerHand = Player.Hand.GetHandTotal();
            var dealerHand = Dealer.Hand.GetHandTotal();
            if (playerHand.Item1 == playerHand.Item2) lblUserTotal.Text = Player.Hand.HighestScore.ToString();
            else if (playerHand.Item2 > 21 && playerHand.Item1 <= 21) lblUserTotal.Text = playerHand.Item1.ToString();
            else lblUserTotal.Text = playerHand.Item1 + "/" + playerHand.Item2;

            if (playerHand.Item1 > 21)
            {
                lblUserTotal.Text = "Bust";
                btnStand_Click(null, null);
            }

            if (dealerHand.Item1 == dealerHand.Item2 || Dealer.Hand.Cards.Count != 1) lblDealerTotal.Text = Dealer.Hand.HighestScore.ToString();
            else if (dealerHand.Item2 > 21 && dealerHand.Item1 <= 21) lblDealerTotal.Text = dealerHand.Item1.ToString();
            else lblDealerTotal.Text = dealerHand.Item1 + "/" + dealerHand.Item2;

            if (dealerHand.Item1 > 21) lblDealerTotal.Text = "Bust";

            lblUserTotal.Visible = true;
            lblDealerTotal.Visible = true;

            lblUserTotal.BringToFront();
            lblDealerTotal.BringToFront();

        }

        private void UpdateUI(bool isDealt)
        {
            btnDraw.Enabled = !isDealt;
            btnHit.Enabled = isDealt;
            btnStand.Enabled = isDealt;
            btnSplit.Enabled = false;
            btnDoubleDown.Enabled = false;
            lblBet.Text = "Bet: £" + nudBet.Value;
            lblBalance.Text = "Balance: £" + Player.Balance;
        }

        private Image GetCardImageByCard(Card card)
        {
            if (card.IsBlank)
                return Image.FromFile(basePath + @"cardBack" + ".png");
            string suit = card.Suit.ToString().ToLower();
            string value = ((int)card.Value).ToString().ToLower();
            value = value.Replace("11", "jack");
            value = value.Replace("12", "queen");
            value = value.Replace("13", "king");
            if(!value.Contains("10")) value = value.Replace("1", "ace");
            return Image.FromFile(basePath + value + "_of_" + suit + ".png");
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            Player.Hit();
            DealCard(Player.Hand.Cards.Last(), new Point(532 + ((Player.Hand.Cards.Count - 1) * 40), 468));
            UpdateUI(true);
            EvaluateGameState();
        }

        private void btnStand_Click(object sender, EventArgs e)
        {
            while (Dealer.Hand.HighestScore < 17)
            {
                Dealer.Hit();
                DealCard(Dealer.Hand.Cards.Last(), new Point(532 + ((Dealer.Hand.Cards.Count - 1) * 40), 120));
                var dealerHand = Dealer.Hand.GetHandTotal();
                if (dealerHand.Item1 == dealerHand.Item2) lblDealerTotal.Text = Dealer.Hand.HighestScore.ToString(); else lblDealerTotal.Text = dealerHand.Item1 + "/" + dealerHand.Item2;
                lblDealerTotal.BringToFront();
                lblDealerTotal.Update();
            }
            var dealerScore = Dealer.Hand.HighestScore;
            var playerScore = Player.Hand.HighestScore;
            lblResult.Visible = true;
            if (playerScore == dealerScore && playerScore <= 21) { lblResult.Text = "Push £" + Player.Bet + "!"; Player.Balance += Player.Bet; }
            else if ((playerScore > dealerScore && playerScore <= 21) || dealerScore > 21 && playerScore <= 21) { lblResult.Text = "You Win £" + Player.Bet * 2 + "!"; Player.Balance += Player.Bet * 2; }
            else if (dealerScore > playerScore && dealerScore <= 21) { lblResult.Text = "You Lose!"; Player.Balance -= Player.Bet; }
            else lblResult.Text = "You Lose!";
            lblDealerTotal.Text = dealerScore > 21 ? "Bust" : dealerScore.ToString();
            lblDealerTotal.BringToFront();
            UpdateUI(false);
            Player.Bet = 0;
        }

        private void nudBet_ValueChanged(object sender, EventArgs e)
        {
            lblBet.Text = "Bet: £" + (int)nudBet.Value;
        }
    }
}
