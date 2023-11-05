using CyberPanicLite.Classes;
using CyberPanicLite.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CyberPanicLite.Classes.Enumerated;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace CyberPanicLite.Forms
{
    public partial class ManageDecks : Form
    {
        //connection for the database
        MySQLConnection connection = new MySQLConnection();
        //list of decks for pulling, creating, and editing
        List<Deck> decks;

        //list of cards within the database for selection
        List<Card> cards;

        //DeckID will be used to determine whether or not to disable Add/Edit
        int deckID = 0;
        //input values for adding to the list
        string inputName;
        int inputDeckHP;
        Card inputCard1;
        Card inputCard2;
        Card inputCard3;
        Card inputCard4;
        Card inputCard5;
        int inputCardID1;
        int inputCardID2;
        int inputCardID3;
        int inputCardID4;
        int inputCardID5;

        //menu form for closing
        GameMenu menuForm;

        public ManageDecks(GameMenu menuForm)
        {
            InitializeComponent();

            //initialize the list
            decks = new List<Deck>();
            //update the list
            UpdateList();

            //set the actions in the list
            SetCardLists();

            //disable the edit button until action is selected
            AddDeckButton.Enabled = true;
            EditDeckButton.Enabled = false;



            //bind the original menu to reopen when actions are closed
            this.menuForm = menuForm;
            FormClosing += new FormClosingEventHandler(this.ManageDecks_FormClosing);
        }

        private void ManageDecks_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Check if the Menu form reference is available
            if (menuForm != null)
            {
                // Show the existing Menu form when the PlayField form is closed
                menuForm.Show();
            }
        }

        private void UpdateList()
        {
            // Reset cards to a new list
            decks = new List<Deck>();
            // Clear the list
            DeckList.Items.Clear();

            // Collect decks from the database
            List<Deck> fetchList = connection.FetchDecks();

            foreach (Deck deck in fetchList)
            {
                if (deck != null)
                {
                    // Bind the retrieved list to the instantiated list
                    decks.Add(deck);

                    // Additionally, populate the ListView
                    ListViewItem item = new ListViewItem(deck.deckID.ToString());
                    item.SubItems.Add(deck.name);

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
        }
        // Deselects all cards in 5 ListViews (CardList1, CardList2, ..., CardList5)
        private void DeselectCardLists()
        {
            for (int listIndex = 1; listIndex <= 5; listIndex++)
            {
                ListView listView = this.Controls.Find("CardList" + listIndex, true).FirstOrDefault() as ListView;
                if (listView != null)
                {
                    foreach (ListViewItem item in listView.SelectedItems)
                    {
                        item.Selected = false;
                    }
                }
            }
        }
        //single listview approach
        private void DeselectCardList(ListView listView)
        {
            if (listView != null)
            {
                foreach (ListViewItem item in listView.Items)
                {
                    item.BackColor = SystemColors.Window;
                }

                listView.SelectedItems.Clear();
            }
        }




        // Sets the card list for 5 ListViews (CardList1, CardList2, ..., CardList5)
        private void SetCardLists()
        {
            // Create an empty card
            Card empty = new Card(0, "None", "No Card", Enumerated.CardType.Virus, null, null);
            // Reset cards to a new list
            cards = new List<Card>();

            for (int listIndex = 1; listIndex <= 5; listIndex++)
            {
                ListView listView = this.Controls.Find("CardList" + listIndex, true).FirstOrDefault() as ListView;
                if (listView != null)
                {
                    // Clear the list
                    listView.Items.Clear();

                    // Collect cards from the database
                    List<Card> fetchList = connection.FetchCards();
                    // Place the empty card in the list (will not affect the database)
                    fetchList.Insert(0, empty);

                    foreach (Card card in fetchList)
                    {
                        if (card != null)
                        {
                            ListViewItem item = new ListViewItem(card.name);
                            item.SubItems.Add(card.action1 != null ? card.action1.actionName : "No Action");
                            item.SubItems.Add(card.action2 != null ? card.action2.actionName : "No Action");
                            listView.Items.Add(item);

                            // Add the card to the common cards list
                            cards.Add(card);
                        }
                    }
                }
            }
        }


        private Card GetCardFromList(string cardName)
        {
            //check the full list of cards
            foreach (Card card in cards)
            {
                //if card matches the name, pull it
                if (card != null)
                {
                    if (card.name == cardName)
                    {
                        return card;
                    }
                }
            }
            //in the event no card is found, return nothing
            return null;
        }
        private void DeckList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DeckList.SelectedItems.Count > 0)
            {
                // Disable the add button. We are now in edit mode
                EditDeckButton.Enabled = true;
                AddDeckButton.Enabled = false;

                // Change the background color of the selected item
                DeckList.SelectedItems[0].BackColor = Color.LightGray;

                // Remove the background color from other items (optional)
                foreach (ListViewItem item in DeckList.Items)
                {
                    if (item != DeckList.SelectedItems[0])
                    {
                        item.BackColor = SystemColors.Window;
                    }
                }

                // Capture the data from the list
                ListViewItem selectedListItem = DeckList.SelectedItems[0];

                // Deck data captured from the list
                deckID = Int32.Parse(selectedListItem.SubItems[0].Text);
                string deckName = selectedListItem.SubItems[1].Text;
                int maxHP = Int32.Parse(selectedListItem.SubItems[3].Text);

                // Set the deck data in the UI
                DeckIDLabel.Text = deckID.ToString();
                DeckNameTextBox.Text = deckName;
                DeckHPNumeric.Value = maxHP;

                // Handle the first card of the deck 

                // Retrieve the corresponding Deck from your list of decks
                Deck selectedDeck = decks.Find(deck => deck.deckID == deckID);

                // Run the logic to select each of the card lists
                for (int i = 0; i < Math.Min(selectedDeck.hand.Count, 5); i++)
                {
                    Card card = selectedDeck.hand[i];
                    if (card != null)
                    {
                        ListView cardListView = Controls.Find($"CardList{i + 1}", true).FirstOrDefault() as ListView;

                        if (cardListView != null)
                        {
                            // Deselect all items first
                            foreach (ListViewItem item in cardListView.Items)
                            {
                                item.Selected = false;
                            }

                            // Select the desired card
                            foreach (ListViewItem item in cardListView.Items)
                            {
                                if (item.Text == card.name)
                                {
                                    // Select the item
                                    item.Selected = true; 
                                    // Optionally, set the background color for the selected item
                                    item.BackColor = Color.LightGray; 
                                }
                                else
                                {
                                    // Reset the background color for unselected items
                                    item.BackColor = SystemColors.Window; 
                                }
                            }
                        }
                    }
                }

            }
        }

        //to be used with both add and edit
        private bool ValidatedInput()
        {
            //All cases other than success will be red
            ErrorMessageLabel.ForeColor = Color.Red;
            //enable
            ErrorMessageLabel.Visible = true;

            //Check for valid user input
            if (DeckNameTextBox.Text == "Card Name" ||
                DeckNameTextBox.Text == "")
            {
                ErrorMessageLabel.Text = "Invalid Card Name";
                return false;
            }
            else
            {
                if (!NameIsAvailable())
                {
                    return false;
                }
                ErrorMessageLabel.Text = "Success";
                ErrorMessageLabel.ForeColor = Color.Black;
                return true;
            }
        }
        //to be used with add new
        //returns true if 
        private bool NameIsAvailable()
        {
            //check for unique action name.
            //Action name is a unique qualifier in the database
            foreach (Deck deck in decks)
            {
                //check for name similarity
                if (DeckNameTextBox.Text == deck.name)
                {
                    //if adding the value should be 0
                    //if editing the value should be equal to the action
                    //if both conditions fail, this should return false
                    if (deckID != 0 && deckID != deck.deckID)
                    {
                        ErrorMessageLabel.Text = "Card Name already exists. Try again.";
                        ErrorMessageLabel.ForeColor = Color.Red;
                        return false;
                    }
                }
            }
            //if no repitition found, continue
            ErrorMessageLabel.Text = "Success";
            ErrorMessageLabel.ForeColor = Color.Black;
            return true;
        }

        //set default inputs
        private void SetDefaultInputs()
        {
            // Fill the data into the forms
            deckID = 0;
            AdjustDeckIDLabel();
            DeckNameTextBox.Text = "Deck Name";
            DeckHPNumeric.Value = 100;
            DeselectCardList(CardList1);
            DeselectCardList(CardList2);
            DeselectCardList(CardList3);
            DeselectCardList(CardList4);
            DeselectCardList(CardList5);
        }
        //Adjust DeckID Label
        private void AdjustDeckIDLabel()
        {
            if (deckID > 0)
            {
                DeckIDLabel.Text = deckID.ToString();
            }
            else
            {
                DeckIDLabel.Text = "Add New";
            }
        }
        private void SetInputs()
        {
            //simple input values for adding to the list
            inputName = DeckNameTextBox.Text.ToString();
            inputDeckHP = (int)DeckHPNumeric.Value;

            //cards

            string card1Name = "None";
            string card2Name = "None";
            string card3Name = "None";
            string card4Name = "None";
            string card5Name = "None";

            //card 1
            if (CardList1.SelectedItems.Count > 0)
            {
                card1Name = CardList1.SelectedItems[0].SubItems[0].Text;
                inputCard1 = GetCardFromList(card1Name);
                inputCardID1 = inputCard1.cardID;
            }
            else
            {
                inputCard1 = null;
                inputCardID1 = 0;
            }
            //card 2
            if (CardList2.SelectedItems.Count > 0)
            {
                card2Name = CardList2.SelectedItems[0].SubItems[0].Text;
                inputCard2 = GetCardFromList(card2Name);
                inputCardID2 = inputCard2.cardID;
            }
            else
            {
                inputCard2 = null;
                inputCardID2 = 0;
            }
            //card 3
            if (CardList3.SelectedItems.Count > 0)
            {
                card3Name = CardList3.SelectedItems[0].SubItems[0].Text;
                inputCard3 = GetCardFromList(card3Name);
                inputCardID3 = inputCard3.cardID;
            }
            else
            {
                inputCard3 = null;
                inputCardID3 = 0;
            }
            //card 4
            if (CardList4.SelectedItems.Count > 0)
            {
                card4Name = CardList4.SelectedItems[0].SubItems[0].Text;
                inputCard4 = GetCardFromList(card4Name);
                inputCardID4 = inputCard4.cardID;
            }
            else
            {
                inputCard4 = null;
                inputCardID4 = 0;

            }
            //card 5
            if (CardList5.SelectedItems.Count > 0)
            {
                card5Name = CardList5.SelectedItems[0].SubItems[0].Text;
                inputCard5 = GetCardFromList(card5Name);
                inputCardID5 = inputCard5.cardID;
            }
            else
            {
                card5Name = "None";
                inputCard5 = null;
                inputCardID5 = 0;
            }

        }

        //Does not set inputs back to default
        //Used for quick deck copy
        private void ClearIDButton_Click(object sender, EventArgs e)
        {
            //Edits no longer functional.
            AddDeckButton.Enabled = true;
            EditDeckButton.Enabled = false;
            deckID = 0;
            AdjustDeckIDLabel();
        }
        private void ClearAllButton_Click(object sender, EventArgs e)
        {
            //Edits no longer functional
            AddDeckButton.Enabled = true;
            EditDeckButton.Enabled = false;
            deckID = 0;
            SetDefaultInputs();

        }


        //check for valid inputs, and, if validated, inserts into the database
        private void InsertDeck()
        {
            if (ValidatedInput())
            {
                SetInputs();
                connection.InsertDeck(inputName, inputDeckHP, inputCardID1, inputCardID2, inputCardID3, inputCardID4, inputCardID5);
            }

        }

        //checks for valid inputs, and, if validated, edits the element in the database.
        private void EditDeck()
        {
            if (ValidatedInput())
            {
                SetInputs();
                connection.EditDeck(deckID, inputName, inputDeckHP, inputCardID1, inputCardID2, inputCardID3, inputCardID4, inputCardID5);
            }

        }
        //Add does not utilize the actionID
        private void AddDeckButton_Click(object sender, EventArgs e)
        {
            InsertDeck();
            UpdateList();
            SetDefaultInputs();
        }
        private void EditDeckButton_Click(object sender, EventArgs e)
        {
            EditDeck();
            UpdateList();
            SetDefaultInputs();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            connection.DeleteDeck(deckID);
            UpdateList();
            SetDefaultInputs();
        }
    }
}
