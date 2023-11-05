using CyberPanicLite.Classes;
using CyberPanicLite.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyberPanicLite.Forms
{
    public partial class GameMenu : Form
    {
        List<Deck> decks;

        Deck selectedDeck;
        Deck opponentDeck;

        MySQLConnection connection = new MySQLConnection();
        public GameMenu()
        {

            InitializeComponent();
            //initialize the list
            decks = new List<Deck>();
            FillDeckList();
        }

        private void FillDeckList()
        {
            // Collect decks from the database
            List<Deck> fetchList = connection.FetchDecks();

            //for each of the cards display the information in the list
            // info: Name of Deck, Name of First Card, HP of deck

            foreach (Deck deck in fetchList)
            {
                if (deck != null)
                {
                    // Bind the retrieved list to the instantiated list
                    decks.Add(deck);

                    // Additionally, populate the ListView
                    ListViewItem item = new ListViewItem(deck.name);

                    // Check if there is at least one card in the hand
                    if (deck.hand.Count > 0)
                    {
                        Card firstCard = deck.hand[0];
                        if (firstCard != null)
                        {
                            // Display the name of the first card in the hand
                            item.SubItems.Add(firstCard.name);
                        }
                        else
                        {
                            // No card found in the first slot of the hand
                            item.SubItems.Add("[NO CARD]");
                        }
                    }
                    else
                    {
                        // No cards in the hand
                        item.SubItems.Add("[NO CARD]");
                    }

                    //add hp value
                    item.SubItems.Add(deck.healthMax.ToString());

                    DeckList.Items.Add(item);
                }
            }
            // Select the first item in the DeckList ListView
            if (DeckList.Items.Count > 0)
            {
                DeckList.Items[0].Selected = true;
            }
        }

        private Deck SelectDeck()
        {
            // Deck set to null if no deck is found
            Deck selectedDeck = null;

            if (DeckList.SelectedItems.Count > 0)
            {
                // Get the selected item
                ListViewItem selectedItem = DeckList.SelectedItems[0];

                // Retrieve the name from the first subitem (index 0)
                string deckName = selectedItem.SubItems[0].Text;

                // Find the corresponding Deck object in your list of decks
                selectedDeck = decks.Find(deck => deck.name == deckName);
            }

            return selectedDeck;
        }


        private Deck RandomDeck()
        {
            // Check if there are decks in the list
            if (decks.Count == 0)
            {
                // Return null or handle the case where there are no decks
                return null;
            }

            // Initialize a random number generator
            Random random = new Random();

            // Generate a random index within the range of the list of decks
            int randomIndex = random.Next(0, decks.Count);

            // Retrieve and return the random deck
            Deck randomDeck = decks[randomIndex];

            return randomDeck;
        }



        private void PlayButton_Click(object sender, EventArgs e)
        {
            // Create an instance of the PlayField form
            // brings in a selected deck from the menu and a random deck as the opponent.
            //PlayField playFieldForm = new PlayField(this, SelectDeck(), RandomDeck());
            PlayField playFieldForm = new PlayField(this, SelectDeck(), RandomDeck());

            this.Hide();

            // Show the PlayField form
            playFieldForm.Show();
        }

        private void ActionButton_Click(object sender, EventArgs e)
        {
            // Create an instance of the PlayField form
            ManageActions actionForm = new ManageActions(this);

            this.Hide();

            // Show the PlayField form
            actionForm.Show();
        }

        private void manageCardsButton_Click(object sender, EventArgs e)
        {
            // Create an instance of the PlayField form
            ManageCards cardForm = new ManageCards(this);

            this.Hide();

            // Show the PlayField form
            cardForm.Show();
        }

        private void manageDecksButton_Click(object sender, EventArgs e)
        {
            // Create an instance of the PlayField form
            ManageDecks cardForm = new ManageDecks(this);

            this.Hide();

            // Show the PlayField form
            cardForm.Show();
        }
    }
}
