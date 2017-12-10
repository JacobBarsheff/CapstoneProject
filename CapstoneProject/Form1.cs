using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapstoneProject;


namespace CapstoneProject
{
    
    public partial class Form1 : Form
    {
        List<Deck> cards = new List<Deck>();
        int playerCardCount;
        int dealerCardCount;
        int deckCount1 = 51;
        int playerbet = 0;
        int hitClickCount = 1;
        int holdClickCount = 1;       
        int playerCardPositonY = 371;
        double playerBalance = 100;

        public Form1()
        {
            InitializeTimer();
            createList(cards);
            InitializeComponent();        
        }
        
        static List<Deck> createList(List<Deck> cards)
        {
            Deck aceClub = new Deck();
            aceClub.Type = "Club";
            aceClub.Number = "ace";
            aceClub.Value = 1;

            Deck twoClub = new Deck();
            twoClub.Type = "Club";
            twoClub.Number = "two";
            twoClub.Value = 2;

            Deck threeClub = new Deck();
            threeClub.Type = "Club";
            threeClub.Number = "three";
            threeClub.Value = 3;

            Deck fourClub = new Deck();
            fourClub.Type = "Club";
            fourClub.Number = "four";
            fourClub.Value = 4;

            Deck fiveClub = new Deck();
            fiveClub.Type = "Club";
            fiveClub.Number = "five";
            fiveClub.Value = 5;

            Deck sixClub = new Deck();
            sixClub.Type = "Club";
            sixClub.Number = "six";
            sixClub.Value = 6;

            Deck sevenClub = new Deck();
            sevenClub.Type = "Club";
            sevenClub.Number = "seven";
            sevenClub.Value = 7;

            Deck eightClub = new Deck();
            eightClub.Type = "Club";
            eightClub.Number = "eight";
            eightClub.Value = 8;

            Deck nineClub = new Deck();
            nineClub.Type = "Club";
            nineClub.Number = "nine";
            nineClub.Value = 9;

            Deck tenClub = new Deck();
            tenClub.Type = "Club";
            tenClub.Number = "ten";
            tenClub.Value = 10;

            Deck JackClub = new Deck();
            JackClub.Type = "Club";
            JackClub.Number = "jack";
            JackClub.Value = 10;

            Deck QueenClub = new Deck();
            QueenClub.Type = "Club";
            QueenClub.Number = "queen";
            QueenClub.Value = 10;

            Deck KingClub = new Deck();
            KingClub.Type = "Club";
            KingClub.Number = "king";
            KingClub.Value = 10;
            //-----------------

            Deck aceHeart = new Deck();
            aceHeart.Type = "Heart";
            aceHeart.Number = "ace";
            aceHeart.Value = 1;

            Deck twoHeart = new Deck();
            twoHeart.Type = "Heart";
            twoHeart.Number = "two";
            twoHeart.Value = 2;

            Deck threeHeart = new Deck();
            threeHeart.Type = "Heart";
            threeHeart.Number = "three";
            threeHeart.Value = 3;

            Deck fourHeart = new Deck();
            fourHeart.Type = "Heart";
            fourHeart.Number = "four";
            fourHeart.Value = 4;

            Deck fiveHeart = new Deck();
            fiveHeart.Type = "Heart";
            fiveHeart.Number = "five";
            fiveHeart.Value = 5;

            Deck sixHeart = new Deck();
            sixHeart.Type = "Heart";
            sixHeart.Number = "six";
            sixHeart.Value = 6;

            Deck sevenHeart = new Deck();
            sevenHeart.Type = "Heart";
            sevenHeart.Number = "seven";
            sevenHeart.Value = 7;

            Deck eightHeart = new Deck();
            eightHeart.Type = "Heart";
            eightHeart.Number = "eight";
            eightHeart.Value = 8;

            Deck nineHeart = new Deck();
            nineHeart.Type = "Heart";
            nineHeart.Number = "nine";
            nineHeart.Value = 9;

            Deck tenHeart = new Deck();
            tenHeart.Type = "Heart";
            tenHeart.Number = "ten";
            tenHeart.Value = 10;

            Deck jackHeart = new Deck();
            jackHeart.Type = "Heart";
            jackHeart.Number = "jack";
            jackHeart.Value = 10;

            Deck queenHeart = new Deck();
            queenHeart.Type = "Heart";
            queenHeart.Number = "queen";
            queenHeart.Value = 10;

            Deck kingHeart = new Deck();
            kingHeart.Type = "Heart";
            kingHeart.Number = "king";
            kingHeart.Value = 10;
            //--------------------

            Deck aceSpade = new Deck();
            aceSpade.Type = "Spade";
            aceSpade.Number = "ace";
            aceSpade.Value = 1;

            Deck twoSpade = new Deck();
            twoSpade.Type = "Spade";
            twoSpade.Number = "two";
            twoSpade.Value = 2;

            Deck threeSpade = new Deck();
            threeSpade.Type = "Spade";
            threeSpade.Number = "three";
            threeSpade.Value = 3;

            Deck fourSpade = new Deck();
            fourSpade.Type = "Spade";
            fourSpade.Number = "four";
            fourSpade.Value = 4;

            Deck fiveSpade = new Deck();
            fiveSpade.Type = "Spade";
            fiveSpade.Number = "five";
            fiveSpade.Value = 5;

            Deck sixSpade = new Deck();
            sixSpade.Type = "Spade";
            sixSpade.Number = "six";
            sixSpade.Value = 6;

            Deck sevenSpade = new Deck();
            sevenSpade.Type = "Spade";
            sevenSpade.Number = "seven";
            sevenSpade.Value = 7;

            Deck eightSpade = new Deck();
            eightSpade.Type = "Spade";
            eightSpade.Number = "eight";
            eightSpade.Value = 8;

            Deck nineSpade = new Deck();
            nineSpade.Type = "Spade";
            nineSpade.Number = "nine";
            nineSpade.Value = 9;

            Deck tenSpade = new Deck();
            tenSpade.Type = "Spade";
            tenSpade.Number = "ten";
            tenSpade.Value = 10;

            Deck jackSpade = new Deck();
            jackSpade.Type = "Spade";
            jackSpade.Number = "jack";
            jackSpade.Value = 10;

            Deck queenSpade = new Deck();
            queenSpade.Type = "Spade";
            queenSpade.Number = "queen";
            queenSpade.Value = 10;

            Deck kingSpade = new Deck();
            kingSpade.Type = "Spade";
            kingSpade.Number = "king";
            kingSpade.Value = 10;

            //-----------------------------------------------------------------

            Deck aceDiamond = new Deck();
            aceDiamond.Type = "Diamond";
            aceDiamond.Number = "ace";
            aceDiamond.Value = 1;

            Deck twoDiamond = new Deck();
            twoDiamond.Type = "Diamond";
            twoDiamond.Number = "two";
            twoDiamond.Value = 2;

            Deck threeDiamond = new Deck();
            threeDiamond.Type = "Diamond";
            threeDiamond.Number = "three";
            threeDiamond.Value = 3;

            Deck fourDiamond = new Deck();
            fourDiamond.Type = "Diamond";
            fourDiamond.Number = "four";
            fourDiamond.Value = 4;

            Deck fiveDiamond = new Deck();
            fiveDiamond.Type = "Diamond";
            fiveDiamond.Number = "five";
            fiveDiamond.Value = 5;

            Deck sixDiamond = new Deck();
            sixDiamond.Type = "Diamond";
            sixDiamond.Number = "six";
            sixDiamond.Value = 6;

            Deck sevenDiamond = new Deck();
            sevenDiamond.Type = "Diamond";
            sevenDiamond.Number = "seven";
            sevenDiamond.Value = 7;

            Deck eightDiamond = new Deck();
            eightDiamond.Type = "Diamond";
            eightDiamond.Number = "eight";
            eightDiamond.Value = 8;

            Deck nineDiamond = new Deck();
            nineDiamond.Type = "Diamond";
            nineDiamond.Number = "nine";
            nineDiamond.Value = 9;

            Deck tenDiamond = new Deck();
            tenDiamond.Type = "Diamond";
            tenDiamond.Number = "ten";
            tenDiamond.Value = 10;

            Deck jackDiamond = new Deck();
            jackDiamond.Type = "Diamond";
            jackDiamond.Number = "jack";
            jackDiamond.Value = 10;

            Deck queenDiamond = new Deck();
            queenDiamond.Type = "Diamond";
            queenDiamond.Number = "queen";
            queenDiamond.Value = 10;

            Deck kingDiamond = new Deck();
            kingDiamond.Type = "Diamond";
            kingDiamond.Number = "king";
            kingDiamond.Value = 10;

            cards.Add(aceClub);
            cards.Add(twoClub);
            cards.Add(threeClub);
            cards.Add(fourClub);
            cards.Add(fiveClub);
            cards.Add(sixClub);
            cards.Add(sevenClub);
            cards.Add(eightClub);
            cards.Add(nineClub);
            cards.Add(tenClub);
            cards.Add(JackClub);
            cards.Add(QueenClub);
            cards.Add(KingClub);

            cards.Add(aceDiamond);
            cards.Add(twoDiamond);
            cards.Add(threeDiamond);
            cards.Add(fourDiamond);
            cards.Add(fiveDiamond);
            cards.Add(sixDiamond);
            cards.Add(sevenDiamond);
            cards.Add(eightDiamond);
            cards.Add(sevenDiamond);
            cards.Add(tenDiamond);
            cards.Add(jackDiamond);
            cards.Add(queenDiamond);
            cards.Add(kingDiamond);

            cards.Add(aceHeart);
            cards.Add(twoHeart);
            cards.Add(threeHeart);
            cards.Add(fourHeart);
            cards.Add(fiveHeart);
            cards.Add(sixHeart);
            cards.Add(sevenHeart);
            cards.Add(eightHeart);
            cards.Add(nineHeart);
            cards.Add(tenHeart);
            cards.Add(jackHeart);
            cards.Add(queenHeart);
            cards.Add(kingHeart);

            cards.Add(aceSpade);
            cards.Add(twoSpade);
            cards.Add(threeSpade);
            cards.Add(fourSpade);
            cards.Add(fiveSpade);
            cards.Add(sixSpade);
            cards.Add(sevenSpade);
            cards.Add(eightSpade);
            cards.Add(nineSpade);
            cards.Add(tenSpade);
            cards.Add(jackSpade);
            cards.Add(queenSpade);
            cards.Add(kingSpade);

            return cards;
        } 


        public void btnHit_Click(object sender, EventArgs e)
        {
            btnBet5.Visible = false;
            btnBet10.Visible = false;
            btnBet20.Visible = false;
            btnBet50.Visible = false;
            newShoe.Visible = false;
            Random rnd = new Random();
            int randomCard = rnd.Next(0, deckCount1);
           
                switch (hitClickCount)
                {
                    case 1:
                        string filePath3 = Path.Combine(System.IO.Path.GetFullPath(@"..\..\"), $"Resources\\{cards[randomCard].Number}{cards[randomCard].Type}.PNG");
                        playerCard3.BackgroundImage = Image.FromFile(filePath3);
                        playerCard1.Location = new System.Drawing.Point(306, playerCardPositonY);
                        playerCard2.Location = new System.Drawing.Point(361, playerCardPositonY);
                        playerCard3.Location = new System.Drawing.Point(421, playerCardPositonY);
                        playerCard3.Visible = true;
                        hitClickCount = hitClickCount + 1;
                        playerCardCount = playerCardCount + cards[randomCard].Value;
                        cards.Remove(cards[randomCard]);
                        deckCount1 = deckCount1 - 1;
                    break;

                    case 2:
                        string filePath4 = Path.Combine(System.IO.Path.GetFullPath(@"..\..\"), $"Resources\\{cards[randomCard].Number}{cards[randomCard].Type}.PNG");
                        playerCard4.BackgroundImage = Image.FromFile(filePath4);
                        playerCard1.Location = new System.Drawing.Point(280, playerCardPositonY);
                        playerCard2.Location = new System.Drawing.Point(335, playerCardPositonY);
                        playerCard3.Location = new System.Drawing.Point(392, playerCardPositonY);
                        playerCard4.Location = new System.Drawing.Point(450, playerCardPositonY);
                        playerCard4.Visible = true;
                        playerCardCount = playerCardCount + cards[randomCard].Value;
                        cards.Remove(cards[randomCard]);
                        hitClickCount = hitClickCount + 1;
                        deckCount1 = deckCount1 - 1;
                    break;

                    case 3:
                        string filePath5 = Path.Combine(System.IO.Path.GetFullPath(@"..\..\"), $"Resources\\{cards[randomCard].Number}{cards[randomCard].Type}.PNG");
                        playerCard5.BackgroundImage = Image.FromFile(filePath5);
                        playerCard1.Location = new System.Drawing.Point(258, playerCardPositonY);
                        playerCard2.Location = new System.Drawing.Point(313, playerCardPositonY);
                        playerCard3.Location = new System.Drawing.Point(370, playerCardPositonY);
                        playerCard4.Location = new System.Drawing.Point(428, playerCardPositonY);
                        playerCard5.Location = new System.Drawing.Point(486, playerCardPositonY);
                        playerCard5.Visible = true;
                        playerCardCount = playerCardCount + cards[randomCard].Value;
                        cards.Remove(cards[randomCard]);
                        hitClickCount = hitClickCount + 1;
                        deckCount1 = deckCount1 - 1;
                        break;

                    case 4:
                        string filePath6 = Path.Combine(System.IO.Path.GetFullPath(@"..\..\"), $"Resources\\{cards[randomCard].Number}{cards[randomCard].Type}.PNG");
                        playerCard6.BackgroundImage = Image.FromFile(filePath6);
                        playerCard1.Location = new System.Drawing.Point(234, playerCardPositonY);
                        playerCard2.Location = new System.Drawing.Point(289, playerCardPositonY);
                        playerCard3.Location = new System.Drawing.Point(346, playerCardPositonY);
                        playerCard4.Location = new System.Drawing.Point(404, playerCardPositonY);
                        playerCard5.Location = new System.Drawing.Point(462, playerCardPositonY);
                        playerCard6.Location = new System.Drawing.Point(521, playerCardPositonY);
                        playerCard6.Visible = true;
                        playerCardCount = playerCardCount + cards[randomCard].Value;
                        cards.Remove(cards[randomCard]);
                        hitClickCount = hitClickCount + 1;
                        deckCount1 = deckCount1 - 1;
                        break;
                case 5:
                    string filePath7 = Path.Combine(System.IO.Path.GetFullPath(@"..\..\"), $"Resources\\{cards[randomCard].Number}{cards[randomCard].Type}.PNG");
                    playerCard7.BackgroundImage = Image.FromFile(filePath7);
                    playerCard1.Location = new System.Drawing.Point(265, playerCardPositonY);
                    playerCard2.Location = new System.Drawing.Point(339, playerCardPositonY);
                    playerCard3.Location = new System.Drawing.Point(419, playerCardPositonY);
                    playerCard4.Location = new System.Drawing.Point(496, playerCardPositonY);
                    playerCard5.Location = new System.Drawing.Point(573, playerCardPositonY);
                    playerCard6.Location = new System.Drawing.Point(652, playerCardPositonY);
                    playerCard7.Location = new System.Drawing.Point(728, playerCardPositonY);
                    playerCard7.Visible = true;
                    playerCardCount = playerCardCount + cards[randomCard].Value;
                    cards.Remove(cards[randomCard]);
                    hitClickCount = hitClickCount + 1;
                    deckCount1 = deckCount1 - 1;
                    break;
            }
            if (playerCardCount > 21)
            {
                playerBalance = playerBalance - playerbet;
                result.Text = "You lose!";

                btnNextGame.Visible = true;
                btnHold.Visible = false;
                btnHit.Visible = false;

                btnBet5.Visible = true;
                btnBet10.Visible = true;
                btnBet20.Visible = true;
                btnBet50.Visible = true;
                btnClearBet.Visible = true;

            }
            else if (playerCardCount < 21)
            {
                result.Text = "Hold or Hit?";
            }
            else if (playerCardCount == 21)
            {
                result.Text = "BlackJack!!!";
                btnHit.Visible = false;
            }
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnClearBet.Visible = false;
            btnBet5.Visible = false;
            btnBet10.Visible = false;
            btnBet20.Visible = false;
            btnBet50.Visible = false;         
            Random rnd = new Random();

            int randomCardDealer = rnd.Next(0, deckCount1);
            string filePath = Path.Combine(System.IO.Path.GetFullPath(@"..\..\"), $"Resources\\{cards[randomCardDealer].Number}{cards[randomCardDealer].Type}.PNG");
            dealerCard1.BackgroundImage = Image.FromFile(filePath);            
            dealerCardCount = dealerCardCount + cards[randomCardDealer].Value;
            cards.Remove(cards[randomCardDealer]);
            deckCount1 = deckCount1 - 1;
            
            dealerCard1.Visible = true;

            int randomCardDealer2 = rnd.Next(0, deckCount1);
            string filePath2 = Path.Combine(System.IO.Path.GetFullPath(@"..\..\"), $"Resources\\{cards[randomCardDealer2].Number}{cards[randomCardDealer2].Type}.PNG");
            dealerCard2.BackgroundImage = Image.FromFile(filePath2);
            dealerCardCount = dealerCardCount + cards[randomCardDealer2].Value;
            cards.Remove(cards[randomCardDealer2]);
            deckCount1 = deckCount1 - 1;
            dealerCard2.Visible = true;

            int randomCardPlayer1 = rnd.Next(0, deckCount1);
            string filePath3 = Path.Combine(System.IO.Path.GetFullPath(@"..\..\"), $"Resources\\{cards[randomCardPlayer1].Number}{cards[randomCardPlayer1].Type}.PNG");
            playerCard1.BackgroundImage = Image.FromFile(filePath3);
            playerCardCount = playerCardCount + cards[randomCardPlayer1].Value;
            cards.Remove(cards[randomCardPlayer1]);
            deckCount1 = deckCount1 - 1;

            playerCard1.Visible = true;
            
            int randomCardPlayer2 = rnd.Next(0, deckCount1);
            string filePath4 = Path.Combine(System.IO.Path.GetFullPath(@"..\..\"), $"Resources\\{cards[randomCardPlayer2].Number}{cards[randomCardPlayer2].Type}.PNG");
            playerCardCount = playerCardCount + cards[randomCardPlayer2].Value;
            playerCard2.BackgroundImage = Image.FromFile(filePath4);
            cards.Remove(cards[randomCardPlayer2]);
            deckCount1 = deckCount1 - 1;

            playerCard2.Visible = true;
            btnStart.Visible = false;
            btnHit.Visible = true;
            btnHold.Visible = true;

            result.Text = "Hold or Hit?";

        }

        private void btnHold_Click(object sender, EventArgs e)
        {
            btnBet5.Visible = false;
            btnBet10.Visible = false;
            btnBet20.Visible = false;
            btnBet50.Visible = false;
            btnClearBet.Visible = false;
            newShoe.Visible = false;
            btnHit.Visible = false;
            
            if (dealerCardCount <= 16)
            {   Random rnd = new Random();
                switch (holdClickCount)
                {
                    case 1:            
                        int randomCardDealer = rnd.Next(0, deckCount1);
                        string filePath = Path.Combine(System.IO.Path.GetFullPath(@"..\..\"), $"Resources\\{cards[randomCardDealer].Number}{cards[randomCardDealer].Type}.PNG");
                        dealerCard3.BackgroundImage = Image.FromFile(filePath);
                        dealerCardCount = dealerCardCount + cards[randomCardDealer].Value;
                        cards.Remove(cards[randomCardDealer]);
                        deckCount1 = deckCount1 - 1;
                        holdClickCount = holdClickCount + 1;
                        dealerCard3.Visible = true;
                    break;

                    case 2:
                        int randomCardDealer2 = rnd.Next(0, deckCount1);
                        string filePath2 = Path.Combine(System.IO.Path.GetFullPath(@"..\..\"), $"Resources\\{cards[randomCardDealer2].Number}{cards[randomCardDealer2].Type}.PNG");
                        dealerCard4.BackgroundImage = Image.FromFile(filePath2);
                        dealerCardCount = dealerCardCount + cards[randomCardDealer2].Value;
                        cards.Remove(cards[randomCardDealer2]);
                        deckCount1 = deckCount1 - 1;
                        holdClickCount = holdClickCount + 1;
                        dealerCard4.Visible = true;
                    break;

                    case 3:
                        int randomCardDealer3 = rnd.Next(0, deckCount1);
                        string filePath3 = Path.Combine(System.IO.Path.GetFullPath(@"..\..\"), $"Resources\\{cards[randomCardDealer3].Number}{cards[randomCardDealer3].Type}.PNG");
                        dealerCard5.BackgroundImage = Image.FromFile(filePath3);
                        dealerCardCount = dealerCardCount + cards[randomCardDealer3].Value;
                        cards.Remove(cards[randomCardDealer3]);
                        deckCount1 = deckCount1 - 1;
                        holdClickCount = holdClickCount + 1;
                        dealerCard5.Visible = true;
                        break;

                    case 5:
                        int randomCardDealer4 = rnd.Next(0, deckCount1);
                        string filePath4 = Path.Combine(System.IO.Path.GetFullPath(@"..\..\"), $"Resources\\{cards[randomCardDealer4].Number}{cards[randomCardDealer4].Type}.PNG");
                        dealerCard6.BackgroundImage = Image.FromFile(filePath4);
                        dealerCardCount = dealerCardCount + cards[randomCardDealer4].Value;
                        cards.Remove(cards[randomCardDealer4]);
                        deckCount1 = deckCount1 - 1;
                        holdClickCount = holdClickCount + 1;
                        dealerCard6.Visible = true;
                        break;
                    case 6:
                        int randomCardDealer5 = rnd.Next(0, deckCount1);
                        string filePath5 = Path.Combine(System.IO.Path.GetFullPath(@"..\..\"), $"Resources\\{cards[randomCardDealer5].Number}{cards[randomCardDealer5].Type}.PNG");
                        dealerCard7.BackgroundImage = Image.FromFile(filePath5);
                        dealerCardCount = dealerCardCount + cards[randomCardDealer5].Value;
                        cards.Remove(cards[randomCardDealer5]);
                        deckCount1 = deckCount1 - 1;
                        holdClickCount = holdClickCount + 1;
                        dealerCard7.Visible = true;
                        break;

                }
            }
            else if (dealerCardCount < 21 && dealerCardCount > playerCardCount)
            {
                result.Text = "Dealer Wins";
                btnNextGame.Visible = true;
                btnHold.Visible = false;
                btnHit.Visible = false;
                playerBalance = playerBalance - playerbet;
                btnBet5.Visible = true;
                btnBet10.Visible = true;
                btnBet20.Visible = true;
                btnBet50.Visible = true;
                btnClearBet.Visible = true;

            }
            else if (dealerCardCount == 21)
            {
                if (dealerCardCount == playerCardCount)
                {
                    result.Text = "Dealer Pushes";
                }
                else
                {
                    result.Text = "Dealer hits Black Jack";
                }
                
                btnNextGame.Visible = true;
                btnHold.Visible = false;
                btnHit.Visible = false;
                btnBet5.Visible = true;
                btnBet10.Visible = true;
                btnBet20.Visible = true;
                btnBet50.Visible = true;
                btnClearBet.Visible = true;
            }
            else if (dealerCardCount > 21)
            {
                result.Text = "Dealer Busts";
                btnNextGame.Visible = true;
                btnHold.Visible = false;
                btnHit.Visible = false;
                playerBalance = playerBalance + (1.5*playerbet);
                btnBet5.Visible = true;
                btnBet10.Visible = true;
                btnBet20.Visible = true;
                btnBet50.Visible = true;
                btnClearBet.Visible = true;
            }
            else if(dealerCardCount == playerCardCount)
            {
                result.Text = "Push";
                btnNextGame.Visible = true;
                btnHold.Visible = false;
                btnHit.Visible = false;
                btnBet5.Visible = true;
                btnBet10.Visible = true;
                btnBet20.Visible = true;
                btnBet50.Visible = true;
                btnClearBet.Visible = true;
            }
            else
            {
                result.Text = "You win!!";
                btnNextGame.Visible = true;
                btnHold.Visible = false;
                btnHit.Visible = false;
                playerBalance = playerBalance + (1.5 * playerbet);
                btnBet5.Visible = true;
                btnBet10.Visible = true;
                btnBet20.Visible = true;
                btnBet50.Visible = true;
                btnClearBet.Visible = true;
            }
            
        }

        private void btnNextGame_Click(object sender, EventArgs e)
        {
            errorBet.Visible = false;
            result.Text = "";
            btnHold.Visible = true;
            btnHit.Visible = true;
            btnNextGame.Visible = false;
            playerCardCount = 0;
            dealerCardCount = 0;
            Random rnd2 = new Random();

            int randomCardDealer = rnd2.Next(0, deckCount1);
            string filePath = Path.Combine(System.IO.Path.GetFullPath(@"..\..\"), $"Resources\\{cards[randomCardDealer].Number}{cards[randomCardDealer].Type}.PNG");
            dealerCard1.BackgroundImage = Image.FromFile(filePath);
            dealerCardCount = dealerCardCount + cards[randomCardDealer].Value;
            cards.Remove(cards[randomCardDealer]);
            deckCount1 = deckCount1 - 1;

            dealerCard1.Visible = true;

            int randomCardDealer2 = rnd2.Next(0, deckCount1);
            string filePath2 = Path.Combine(System.IO.Path.GetFullPath(@"..\..\"), $"Resources\\{cards[randomCardDealer2].Number}{cards[randomCardDealer2].Type}.PNG");
            dealerCard2.BackgroundImage = Image.FromFile(filePath2);
            dealerCardCount = dealerCardCount + cards[randomCardDealer2].Value;
            cards.Remove(cards[randomCardDealer2]);
            deckCount1 = deckCount1 - 1;

            dealerCard2.Visible = true;

            int randomCardPlayer1 = rnd2.Next(0, deckCount1);
            string filePath3 = Path.Combine(System.IO.Path.GetFullPath(@"..\..\"), $"Resources\\{cards[randomCardPlayer1].Number}{cards[randomCardPlayer1].Type}.PNG");
            playerCard1.BackgroundImage = Image.FromFile(filePath3);
            playerCard1.Location = new System.Drawing.Point(334, playerCardPositonY);

            playerCardCount = playerCardCount + cards[randomCardPlayer1].Value;
            cards.Remove(cards[randomCardPlayer1]);
            deckCount1 = deckCount1 - 1;

            playerCard1.Visible = true;

            int randomCardPlayer2 = rnd2.Next(0, deckCount1);
            string filePath4 = Path.Combine(System.IO.Path.GetFullPath(@"..\..\"), $"Resources\\{cards[randomCardPlayer2].Number}{cards[randomCardPlayer2].Type}.PNG");
            playerCardCount = playerCardCount + cards[randomCardPlayer2].Value;
            playerCard2.BackgroundImage = Image.FromFile(filePath4);
            playerCard2.Location = new System.Drawing.Point(389, playerCardPositonY);
            cards.Remove(cards[randomCardPlayer2]);
            deckCount1 = deckCount1 - 1;

            playerCard3.Visible = false;
            playerCard4.Visible = false;
            playerCard5.Visible = false;
            playerCard6.Visible = false;
            playerCard7.Visible = false;

            dealerCard3.Visible = false;
            dealerCard4.Visible = false;
            dealerCard5.Visible = false;
            dealerCard6.Visible = false;
            dealerCard7.Visible = false;

            btnBet5.Visible = false;
            btnBet10.Visible = false;
            btnBet20.Visible = false;
            btnBet50.Visible = false;
            btnClearBet.Visible = false;

            hitClickCount = 1;
            holdClickCount = 1;

            if (deckCount1 < 10)
            {
                deckCount1 = deckCount1 + 52;
                newShoe.Visible = true;
                createList(cards);
            }
        }

        private void InitializeTimer()
        {
            Timer timer = new Timer
            {
                Interval = (200)
            };
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();
        }

        private void Timer_Tick(object o, EventArgs e)
        {
            deckCount.Text = cards.Count.ToString() + " Cards Left";
            dealerCardCtn.Text = dealerCardCount.ToString();
            playerCardctn.Text = playerCardCount.ToString();
            currentBet.Text = ("Current Bet: $" + (playerbet.ToString()));
            plyBalance.Text = ("Balance: $" + (playerBalance.ToString()));
            
            
        }

        private void btnBet5_Click(object sender, EventArgs e)
        {
            if (playerbet < playerBalance)
            {
                playerbet = playerbet + 5;
            }
            else
            {
                errorBet.Visible = true;
            }
        }

        private void btnBet10_Click(object sender, EventArgs e)
        {
            if (playerbet < playerBalance)
            {
                playerbet = playerbet + 10;
            }
            else
            {
                errorBet.Visible = true;
            }

        }

        private void btnBet20_Click(object sender, EventArgs e)
        {
            if (playerbet < playerBalance)
            {
                playerbet = playerbet + 20;
            }
            else
            {
                errorBet.Visible = true;
            }
        }

        private void btnBet50_Click(object sender, EventArgs e)
        {
            if (playerbet < playerBalance)
            {
                playerbet = playerbet + 50;
            }
            else
            {
                errorBet.Visible = true;
            }
        }

        private void btnClearBet_Click(object sender, EventArgs e)
        {
            playerbet = 0;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void dealerCardCtn_Click(object sender, EventArgs e)
        {

        }

        private void playerCardctn_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void result_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void newShoe_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dealerCard5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void dealerCard1_Click(object sender, EventArgs e)
        {

        }

        private void btnSplit_Click(object sender, EventArgs e)
        {

        }
    }
}
