using CyberPanicLite.Classes;
using CyberPanicLite.Data;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CyberPanicLite.Classes.Enumerated;


namespace CyberPanicLite.Forms
{
    public partial class ManageActions : Form
    {
        MySQLConnection connection = new MySQLConnection();

        //list of actions within the database.
        List<PlayAction> actions;

        //ActionID will be used to determine whether or not to disable Add/Edit
        int actionID = 0;
        //input values for adding to the list
        string inputName;
        string inputDescription;
        bool inputTarget;
        int inputEffectType;
        int inputValue;
        int inputCoolDown;

        GameMenu menuForm;

        /*** FUNCTIONSS ***/
        public ManageActions(GameMenu menuForm)
        {
            InitializeComponent();
            SetDefaultInputs();

            //initialize the list
            actions = new List<PlayAction>();
            //update the list
            UpdateList();

            //disable the edit button until action is selected
            EditActionButton.Enabled = false;

            // Bind the EffectType enum values to the ComboBox
            EffectTypeBox.DataSource = System.Enum.GetValues(typeof(Enumerated.EffectType));

            //bind the original menu to reopen when actions are closed
            this.menuForm = menuForm;
            FormClosing += new FormClosingEventHandler(this.ManageActions_FormClosing);
        }

        private void UpdateList()
        {
            //reset actions to a new list
            actions = new List<PlayAction>();
            //clear the list
            ActionList.Items.Clear();

            //collect actions from the database
            List<PlayAction> fetchList = connection.FetchActions();

            //    Console.WriteLine("Total number of elements:" +  fetchList.Count);
            //    Console.WriteLine("Test action name" + fetchList[0].actionName);
            foreach (PlayAction playAction in fetchList)
            {
                if (playAction != null)
                {
                    //bind the retrieved list to the instantiated list
                    //should be initialized
                    actions.Add(playAction);

                    //additionally, in the same breath, populate the ListView
                    ListViewItem item = new ListViewItem(playAction.actionID.ToString());
                    item.SubItems.Add(playAction.actionName);
                    item.SubItems.Add(playAction.actionDescription);
                    //display the target of the action in a more human readible fashion
                    //Also effects logic from the listview selection code
                    if (playAction.enemyIsTarget.ToString() == "True")
                    {
                        item.SubItems.Add("Enemy");
                    }
                    else
                    {
                        item.SubItems.Add("Self");
                    }
                    item.SubItems.Add(playAction.effectType.ToString());
                    item.SubItems.Add(playAction.value.ToString());
                    item.SubItems.Add(playAction.coolDown.ToString());

                    ActionList.Items.Add(item);
                }
            }
        }

        //set default inputs
        private void SetDefaultInputs()
        {
            // Fill the data into the forms
            AdjustActionIDLabel();
            ActionNameInput.Text = "Action Name";
            ActionDescriptionInput.Text = "Action Description";
            EffectTypeBox.Text = "Attack";
            ValueNumeric.Value = 0;
            CooldownNumeric.Value = 0;
            TargetEnemyRadio.Checked = true;
        }
        //Adjust ActionID Label
        private void AdjustActionIDLabel()
        {
            if(actionID > 0)
            {
                ActionIDLabel.Text = actionID.ToString();
            }
            else
            {
                ActionIDLabel.Text = "Add New";
            }
        }


        private void ManageActions_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Check if the Menu form reference is available
            if (menuForm != null)
            {
                // Show the existing Menu form when the PlayField form is closed
                menuForm.Show();
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
            if (ActionNameInput.Text == "Action Name" ||
                ActionNameInput.Text == "")
            {
                ErrorMessageLabel.Text = "Invalid Action Name";
                return false;
            }
            else if (ActionDescriptionInput.Text == "Action description")
            {
                ErrorMessageLabel.Text = "Invalid Action Description";
                return false;
            }
            else if (ValueNumeric.Value == 0)
            {
                //ValueNumeric left at 0 for the sake of intentional design
                ErrorMessageLabel.Text = "Value must be greater than 0";
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
            foreach (PlayAction action in actions)
            {
                //check for name similarity
                if (ActionNameInput.Text == action.actionName)
                {
                    //if adding the value should be 0
                    //if editing the value should be equal to the action
                    //if both conditions fail, this should return false
                    if(actionID != 0 && actionID != action.actionID)
                    {
                        ErrorMessageLabel.Text = "Action Name already exists. Try again.";
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
            inputName = ActionNameInput.Text;
            inputDescription = ActionDescriptionInput.Text;
            inputValue = (int)ValueNumeric.Value;
            inputCoolDown = (int)CooldownNumeric.Value;
            //inputTarget
            if (TargetEnemyRadio.Checked)
            {
                inputTarget = true;
            }
            else
            {
                inputTarget = false;
            }
            //input effectType
            //simplify the text from the box
            string selectedText = EffectTypeBox.SelectedItem.ToString();
            //use that text in conjunction with a dictionary function within the Enumerated class
            if (Enumerated.effectMapping.TryGetValue(selectedText, out EffectType selectedEffect))
            {
                //now contains the integer value corresponding to the selected type
                inputEffectType = (int)selectedEffect;
            }
        }

        private void ActionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ActionList.SelectedItems.Count > 0)
            {
                //Disable the add button. We are now in edit mode
                EditActionButton.Enabled = true;
                AddActionButton.Enabled = false;

                // Change the background color of the selected item
                ActionList.SelectedItems[0].BackColor = Color.LightGray;

                // Remove the background color from other items (optional)
                foreach (ListViewItem item in ActionList.Items)
                {
                    if (item != ActionList.SelectedItems[0])
                    {
                        item.BackColor = SystemColors.Window;
                    }
                }

                //capture the data from the list
                ListViewItem selectedListItem = ActionList.SelectedItems[0];

                // Action data captured from the list
                actionID = Int32.Parse(selectedListItem.SubItems[0].Text);
                string actionName = selectedListItem.SubItems[1].Text;
                string actionDescription = selectedListItem.SubItems[2].Text;
                string enemyIsTarget = selectedListItem.SubItems[3].Text;
                //Console.WriteLine("Selected enemy value is: " + enemyIsTarget);
                string effectType = selectedListItem.SubItems[4].Text;
                string value = selectedListItem.SubItems[5].Text;
                string coolDown = selectedListItem.SubItems[6].Text;

                // Fill the data into the forms
                ActionIDLabel.Text = actionID.ToString();
                ActionNameInput.Text = actionName;
                ActionDescriptionInput.Text = actionDescription;
                EffectTypeBox.Text = effectType;
                ValueNumeric.Value = Int32.Parse(value);
                CooldownNumeric.Value = Int32.Parse(coolDown);
                if(enemyIsTarget == "Enemy")
                {
                    TargetEnemyRadio.Checked = true;
                } else {
                    TargetSelfRadio.Checked = true;
                }
            }
        }
        //Sets inputs back to default values
        private void ClearAll()
        {
            //Edits no longer functional
            AddActionButton.Enabled = true;
            EditActionButton.Enabled = false;

            actionID = 0;
            AdjustActionIDLabel();

            //remove the selection from the list
            if (ActionList.SelectedItems.Count > 0)
            {
                //find the selected item
                ListViewItem selectedListItem = ActionList.SelectedItems[0];
                //deselect the item
                selectedListItem.Selected = false;
                //remove highlight
                selectedListItem.BackColor = SystemColors.Window;
            }

            //reset the inputs to default
            SetDefaultInputs();
        }
        private void ClearAllButton_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        //Does not set inputs back to default
        //Used for quick action copy
        private void ClearIDButton_Click(object sender, EventArgs e)
        {
            //Edits no longer functional.
            AddActionButton.Enabled = true;
            EditActionButton.Enabled = false;
            actionID = 0;
            AdjustActionIDLabel();
        }

        //check for valid inputs, and, if validated, inserts into the database
        private void InsertAction()
        {
            if (ValidatedInput())
            {
                SetInputs();
                connection.InsertAction(inputName, inputDescription, inputTarget, inputEffectType, inputValue, inputCoolDown);
            }

        }
        //checks for valid inputs, and, if validated, edits the element in the database.
        private void EditAction()
        {
            if (ValidatedInput())
            {
                SetInputs();
                connection.EditAction(actionID, inputName, inputDescription, inputTarget, inputEffectType, inputValue, inputCoolDown);
            }

        }
        //Add does not utilize the actionID
        private void AddActionButton_Click(object sender, EventArgs e)
        {
            InsertAction();
            UpdateList();
            ClearAll();
        }
        private void EditActionButton_Click(object sender, EventArgs e)
        {
            EditAction();
            UpdateList();
            ClearAll();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            connection.DeleteAction(actionID);
            UpdateList();
        }
    }
}
