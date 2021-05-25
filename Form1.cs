using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch8_Pg382_MoveCardsBetweenDecks
{
    public partial class Form1 : Form
    {
        Deck deck1;
        Deck deck2;

        public Form1()
        {
            InitializeComponent();
            ResetDeck(1);
            RedrawDeck(1);
            ResetDeck(2);
            RedrawDeck(2);
        }

        private void moveToDeck2_Click(object sender, EventArgs e)
        {
            if (deck1ListBox.SelectedItem == null)
            {
                return;
            }
            Card cardToMove = deck1.Deal(deck1ListBox.SelectedIndex);
            deck2.Add(cardToMove);
            RedrawDeck(1);
            RedrawDeck(2);
        }

        private void moveToDeck1_Click(object sender, EventArgs e)
        {
            if (deck2ListBox.SelectedItem == null)
            {
                return;
            }
            Card cardToMove = deck2.Deal(deck2ListBox.SelectedIndex);
            deck1.Add(cardToMove);
            RedrawDeck(1);
            RedrawDeck(2);
        }

        private void reset1_Click(object sender, EventArgs e)
        {
            ResetDeck(1);
            RedrawDeck(1);
        }

        private void reset2_Click(object sender, EventArgs e)
        {
            ResetDeck(2);
            RedrawDeck(2);
        }

        private void shuffle1_Click(object sender, EventArgs e)
        {
            deck1.Shuffle();
            RedrawDeck(1);
        }

        private void shuffle2_Click(object sender, EventArgs e)
        {
            deck2.Shuffle();
            RedrawDeck(2);
        }

        private void ResetDeck(int DeckNumber)
        {
            Random random = new Random();
            List<Card> cardsInDeck = new List<Card>();
            if (DeckNumber == 1)
            {
                for (int i = 0; i < random.Next(1, 11); i++)
                {
                    cardsInDeck.Add(new Card((Suits)random.Next(4), (Values)random.Next(1, 14)));
                    deck1 = new Deck(cardsInDeck);
                }
                deck1.Sort();
            }
            else if (DeckNumber == 2)
            {
                deck2 = new Deck();
            }
        }

        private void RedrawDeck(int DeckNumber)
        {
            if (DeckNumber == 1)
            {
                deck1ListBox.Items.Clear();
                foreach (string cardName in deck1.GetCardNames())
                {
                    deck1ListBox.Items.Add(cardName);
                    deck1Label.Text = "Deck #1 (" + deck1.Count + " cards)";
                }
            }
            else
            {
                deck2ListBox.Items.Clear();
                foreach (string cardName in deck2.GetCardNames())
                {
                    deck2ListBox.Items.Add(cardName);
                    deck2Label.Text = "Deck #1 (" + deck2.Count + " cards)";
                }
            }
        }

    }
}
