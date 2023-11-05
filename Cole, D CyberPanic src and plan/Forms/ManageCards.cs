using CyberPanicLite.Classes;
using CyberPanicLite.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CyberPanicLite.Classes.Enumerated;

namespace CyberPanicLite.Forms
{
    public partial class ManageCards : Form
    {

        MySQLConnection connection = new MySQLConnection();

        //List of cards within the database for creation/edit
        List<Card> cards = new List<Card>();
        //list of actions within the database for selection
        List<PlayAction> actions;

        //ActionID will be used to determine whether or not to disable Add/Edit
        int cardID = 0;
        //input values for adding to the list
        string inputName;
        string inputDescription;
        int inputCardType;
        PlayAction inputAction1;
        PlayAction inputAction2;
        int inputAction1ID;
        int inputAction2ID;
        string action1Name;
        string action2Name;

        GameMenu menuForm;
        public ManageCards(GameMenu menuForm)
        {
            InitializeComponent();

            //initialize the list
            cards = new List<Card>();
            //update the list
            UpdateList();

            //set the actions in the list
            SetActionLists();

            //disable the edit button until action is selected
            AddCardButton.Enabled = true;
            EditCardButton.Enabled = false;

            // Bind the EffectType enum values to the ComboBox
            CardTypeBox.DataSource = System.Enum.GetValues(typeof(Enumerated.CardType));


            //bind the original menu to reopen when actions are closed
            this.menuForm = menuForm;
            FormClosing += new FormClosingEventHandler(this.ManageCards_FormClosing);
        }
        private void ManageCards_FormClosing(object sender, FormClosingEventArgs e)
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
            //reset actions to a new list
            cards = new List<Card>();
            //clear the list
            CardList.Items.Clear();

            //collect actions from the database
            List<Card> fetchList = connection.FetchCards();

            //    Console.WriteLine("Total number of elements:" +  fetchList.Count);
            //    Console.WriteLine("Test action name" + fetchList[0].actionName);
            foreach (Card card in fetchList)
            {
                if (card != null)
                {
                    //bind the retrieved list to the instantiated list
                    //should be initialized
                    cards.Add(card);

                    //additionally, in the same breath, populate the ListView
                    ListViewItem item = new ListViewItem(card.cardID.ToString());
                    item.SubItems.Add(card.name);
                    item.SubItems.Add(card.description);
                    item.SubItems.Add(card.cardType.ToString());

                    //pull the action names for display
                    if(card.action1 != null)
                    {
                        item.SubItems.Add(card.action1.actionName);
                    }
                    else
                    {
                        item.SubItems.Add("[NO ACTION]");
                    }
                    if (card.action2 != null)
                    {
                        item.SubItems.Add(card.action2.actionName);
                    }
                    else
                    {
                        item.SubItems.Add("[NO ACTION]");
                    }

                    CardList.Items.Add(item);
                }
            }
        }
        //Sets the action list for both of the actions to be chosen for the new card
        private void SetActionLists()
        {
            //empty action
            PlayAction empty = new PlayAction(0, "None", "No Action", false, (EffectType)1, 0, 0);
            //reset actions to a new list
            actions = new List<PlayAction>();
            //clear the list
            ActionList1.Items.Clear();
            ActionList2.Items.Clear();

            //collect actions from the database
            List<PlayAction> fetchList = connection.FetchActions();
            //place the empty action in the list (will not effect the database)
            fetchList.Insert(0, empty);

            //    Console.WriteLine("Total number of elements:" +  fetchList.Count);
            //    Console.WriteLine("Test action name" + fetchList[0].actionName);
            foreach (PlayAction playAction in fetchList)
            {
                if (playAction != null)
                {
                    ListViewItem item1;
                    ListViewItem item2;

                    //bind the retrieved list to the instantiated list
                    //should be initialized
                    actions.Add(playAction);

                    //additionally, in the same breath, populate the ListView
                    item1 = new ListViewItem(playAction.actionName);
                    item2 = new ListViewItem(playAction.actionName);
                    item1.SubItems.Add(playAction.effectType.ToString());
                    item2.SubItems.Add(playAction.effectType.ToString());
                    item1.SubItems.Add(playAction.value.ToString());
                    item2.SubItems.Add(playAction.value.ToString());
                    item1.SubItems.Add(playAction.coolDown.ToString());
                    item2.SubItems.Add(playAction.coolDown.ToString());

                    ActionList1.Items.Add(item1);
                    ActionList2.Items.Add(item2);
                }
            }
        }
        public void AdjustActionInfo(PlayAction action1, PlayAction action2)
        {
            if(action1 != null && action1.actionID != 0)
            {
                Action1NameLabel.Text = action1.actionName;
                Action1DescriptionTextBox.Text = action1.actionDescription;
                Action1EffectLabel.Text = "Effect: " + action1.effectType.ToString();
                Action1TargetLabel.Text = "Target: ";
                if (action1.isEnemyTarget())
                {
                    Action1TargetLabel.Text += "enemy";
                } else {
                    Action1TargetLabel.Text += "self";
                }
                Action1ValueLabel.Text = "Value: " + action1.value;
                Action1CooldownLabel.Text = "Cooldown: " + action1.coolDown;

            }
            else
            {
                SetDefaultAction1Info();
            }
            if (action2 != null && action2.actionID != 0)
            {
                Console.WriteLine("Action ID: " + action2.actionID);
                Action2NameLabel.Text = action2.actionName;
                Action2DescriptionTextBox.Text = action2.actionDescription;
                Action2EffectLabel.Text = "Effect: " + action2.effectType.ToString();
                Action2TargetLabel.Text = "Target: ";
                if (action2.isEnemyTarget())
                {
                    Action2TargetLabel.Text += "enemy";
                }
                else
                {
                    Action2TargetLabel.Text += "self";
                }
                Action2ValueLabel.Text = "Value: " + action2.value;
                Action2CooldownLabel.Text = "Cooldown: " + action2.coolDown;
            }
            else
            {
                SetDefaultAction2Info();
            }
        }

        //set default action info
        public void SetDefaultAction1Info()
        {
            Action1NameLabel.Text = "Action Name";
            Action1DescriptionTextBox.Text = "No Selected Action";
            Action1EffectLabel.Text = "Effect: ";
            Action1TargetLabel.Text = "Target: ";
            Action1ValueLabel.Text = "Value: 0";
            Action1CooldownLabel.Text = "Cooldown: 0";
        }
        public void SetDefaultAction2Info()
        {
            Action2NameLabel.Text = "Action Name";
            Action2DescriptionTextBox.Text = "No Selected Action";
            Action2EffectLabel.Text = "Effect: ";
            Action2TargetLabel.Text = "Target: ";
            Action2ValueLabel.Text = "Value: 0";
            Action2CooldownLabel.Text = "Cooldown: 0";
        }

        //set default inputs
        private void SetDefaultInputs()
        {
            // Fill the data into the forms
            cardID = 0;
            AdjustCardIDLabel();
            CardNameInput.Text = "Card Name";
            CardDescriptionInput.Text = "Card Description";
            CardTypeBox.Text = "Virus";
            SetDefaultAction1Info();
            SetDefaultAction2Info();
            //actions
        }

        //Adjust CardID Label
        private void AdjustCardIDLabel()
        {
            if (cardID > 0)
            {
                CardIDLabel.Text = cardID.ToString();
            }
            else
            {
                CardIDLabel.Text = "Add New";
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
            if (CardNameInput.Text == "Card Name" ||
                CardNameInput.Text == "")
            {
                ErrorMessageLabel.Text = "Invalid Card Name";
                return false;
            }
            else if (CardDescriptionInput.Text == "Card description")
            {
                ErrorMessageLabel.Text = "Invalid Card Description";
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
            foreach (Card card in cards)
            {
                //check for name similarity
                if (CardNameInput.Text == card.name)
                {
                    //if adding the value should be 0
                    //if editing the value should be equal to the action
                    //if both conditions fail, this should return false
                    if (cardID != 0 && cardID != card.cardID)
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

        private void SetInputs()
        {
            //simple input values for adding to the list
            inputName = CardNameInput.Text;
            inputDescription = CardDescriptionInput.Text;
            
            //input cardType
            //simplify the text from the box
            string selectedText = CardTypeBox.SelectedItem.ToString();
            //use that text in conjunction with a dictionary function within the Enumerated class
            if (Enumerated.cardMapping.TryGetValue(selectedText, out CardType selectedType))
            {
                //now contains the integer value corresponding to the selected type
                inputCardType = (int)selectedType;
            }

            //action names

            ////set the actions based on the name of the selection
            //inputAction1 = GetActionFromList(action1Name);
            //inputAction2 = GetActionFromList(action2Name);

            if (ActionList1.SelectedItems.Count > 0)
            {
                action1Name = ActionList1.SelectedItems[0].SubItems[0].Text;
                inputAction1 = GetActionFromList(action1Name);
                inputAction1ID = inputAction1.actionID;
            }
            else
            {
                action1Name = "None";
                inputAction1 = null;
                inputAction1ID = 0;
            }

            if (ActionList2.SelectedItems.Count > 0)
            {
                action2Name = ActionList2.SelectedItems[0].SubItems[0].Text;
                inputAction2 = GetActionFromList(action2Name);
                inputAction2ID = inputAction2.actionID;
            }
            else
            {
                action2Name = "None";
                inputAction2 = null;
                inputAction2ID = 0;
            }
        }

        private void CardList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CardList.SelectedItems.Count > 0)
            {
                //Disable the add button. We are now in edit mode
                EditCardButton.Enabled = true;
                AddCardButton.Enabled = false;

                // Change the background color of the selected item
                CardList.SelectedItems[0].BackColor = Color.LightGray;

                // Remove the background color from other items (optional)
                foreach (ListViewItem item in CardList.Items)
                {
                    if (item != CardList.SelectedItems[0])
                    {
                        item.BackColor = SystemColors.Window;
                    }
                }

                //capture the data from the list
                ListViewItem selectedListItem = CardList.SelectedItems[0];

                // Action data captured from the list
                cardID = Int32.Parse(selectedListItem.SubItems[0].Text);
                string actionName = selectedListItem.SubItems[1].Text;
                string actionDescription = selectedListItem.SubItems[2].Text;
                string cardType = selectedListItem.SubItems[3].Text;
                string action1 = selectedListItem.SubItems[4].Text;
                string action2 = selectedListItem.SubItems[5].Text;

                // Fill the data into the forms
                CardIDLabel.Text = cardID.ToString();
                CardNameInput.Text = actionName;
                CardDescriptionInput.Text = actionDescription;
                CardTypeBox.Text = cardType;
                //do something with the action list views

                //adjust the selected card's action info
                //find specific action through the database and pull the card data
                PlayAction selectedAction1 = new PlayAction(GetActionFromList(action1, 1));
                PlayAction selectedAction2 = new PlayAction(GetActionFromList(action2, 2));
                AdjustActionInfo(selectedAction1, selectedAction2);

                // First, deselect all items in both ListView controls
                foreach (ListViewItem item in ActionList1.Items)
                {
                    item.Selected = false;
                }

                foreach (ListViewItem item in ActionList2.Items)
                {
                    item.Selected = false;
                }

                // Now, compare and select the desired actions
                foreach (ListViewItem item in ActionList1.Items)
                {
                    // Get the action name from the ListViewItem's Text property
                    string name = item.Text;

                    if (selectedAction1 != null && selectedAction1.actionName == name)
                    {
                        item.Selected = true;
                        break; // No need to continue searching after the action is found
                    }
                }

                foreach (ListViewItem item in ActionList2.Items)
                {
                    // Get the action name from the ListViewItem's Text property
                    string name = item.Text;

                    if (selectedAction2 != null && selectedAction2.actionName == name)
                    {
                        item.Selected = true;
                        break; // No need to continue searching after the action is found
                    }
                }
            }
        }
        //action used here should be 1 or 2 to represent which action is being pulled.
        //not pulled from database. used for quick checking from list
        private PlayAction GetActionFromList(string actionName, int action)
        {
            //check the full list of cards
            foreach(Card card in cards)
            {
                //if card matches the name, pull it
                if(action == 1 && card.action1 != null)
                {
                    if(card.action1.actionName == actionName)
                    {
                        return card.action1;
                    }
                }
                if(action == 2 && card.action2 != null)
                {
                    if(card.action2.actionName == actionName)
                    {
                        return card.action2;
                    }
                }
            }

            return null;
        }
        private PlayAction GetActionFromList(string actionName)
        {
            //check the full list of cards
            foreach (PlayAction action in actions)
            {
                //if card matches the name, pull it
                if (action != null)
                {
                    if (action.actionName == actionName)
                    {
                        return action;
                    }
                }
            }

            return null;
        }

        //Sets inputs back to default values
        private void ClearAllButton_Click(object sender, EventArgs e)
        {
            //Edits no longer functional
            AddCardButton.Enabled = true;
            EditCardButton.Enabled = false;

            cardID = 0;
            AdjustCardIDLabel();

            //remove the selection card from the card listview
            if (CardList.SelectedItems.Count > 0)
            {
                //find the selected item
                ListViewItem selectedListItem = CardList.SelectedItems[0];
                //deselect the item
                selectedListItem.Selected = false;
                //remove highlight
                selectedListItem.BackColor = SystemColors.Window;
            }

            //remove the actions from their respective list views
            if(ActionList1.SelectedItems.Count > 0)
            {
                //find the selected item
                ListViewItem selectedListItem = ActionList1.SelectedItems[0];
                //deselect the item
                selectedListItem.Selected = false;
                //remove highlight
                selectedListItem.BackColor = SystemColors.Window;
            }
            if (ActionList2.SelectedItems.Count > 0)
            {
                //find the selected item
                ListViewItem selectedListItem = ActionList2.SelectedItems[0];
                //deselect the item
                selectedListItem.Selected = false;
                //remove highlight
                selectedListItem.BackColor = SystemColors.Window;
            }

            //reset the inputs to default
            SetDefaultInputs();
        }

        //Does not set inputs back to default
        //Used for quick action copy
        private void ClearIDButton_Click(object sender, EventArgs e)
        {
            //Edits no longer functional.
            AddCardButton.Enabled = true;
            EditCardButton.Enabled = false;
            cardID = 0;
            AdjustCardIDLabel();
        }

        //check for valid inputs, and, if validated, inserts into the database
        private void InsertCard()
        {
            if (ValidatedInput())
            {
                SetInputs();
                connection.InsertCard(inputName, inputDescription, inputCardType, inputAction1ID, inputAction2ID);
            }

        }
        //checks for valid inputs, and, if validated, edits the element in the database.
        private void EditCard()
        {
            if (ValidatedInput())
            {
                SetInputs();
                connection.EditCard(cardID, inputName, inputDescription, inputCardType, inputAction1ID, inputAction2ID);
            }

        }
        //Add does not utilize the actionID
        private void AddCardButton_Click(object sender, EventArgs e)
        {
            InsertCard();
            UpdateList();
            SetDefaultInputs();
        }
        private void EditCardButton_Click(object sender, EventArgs e)
        {
            EditCard();
            UpdateList();
            SetDefaultInputs();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            connection.DeleteCard(cardID);
            UpdateList();
            SetDefaultInputs();
        }

    }
}
