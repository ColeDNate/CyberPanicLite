/** PlayField Form
 * 
 * the game logic is played here in this file
 * 
 * I realize that there are some functions that seem repetitive
 * After some analysis I determined that it would be better to leave them
 * In the case of the swap functions, it is not a matter of simply swapping cards
 * The swap function directs the reference without having to move all of the card data
 * 
 * 
 * */

using CyberPanicLite.Classes;
using CyberPanicLite.Forms;
using CyberPanicLite.TestItems;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace CyberPanicLite {
    public partial class PlayField : Form
    {
        private const int ACTIONS_PER_TURN = 2;
        //deck initialization
        private Deck playerDeck;
        private Deck opponentDeck;
        //private PreFab generator;

        //turn initialization
        private bool playerTurn;
        private bool opponentTurn;
        private int turnPoints;

        //swap initiated used to disable or enable buttons while active
        private bool handCard1SwapInitiated;
        private bool handCard2SwapInitiated;
        private bool handCard3SwapInitiated;

        //values used for the switching
        private int handIndex;
        private int playIndex;

        //timer for incrementing the computer player's actions
        Timer gameTimer = new Timer();

        GameMenu menuForm;

        public PlayField(GameMenu menuForm, Deck playerDeck, Deck opponentDeck)
        //public PlayField(GameMenu menuForm, Deck playerDeck, Deck opponentDeck)
        {
            InitializeComponent();

            //initializes decks based on the selected decks from the database
            this.playerDeck = new Deck(playerDeck);
            this.opponentDeck = new Deck(opponentDeck);

            //Sets the field
            InitializeField();

            // Set up the timer for the CPU player's actions
            gameTimer.Interval = 1000; // 1000 milliseconds
            gameTimer.Tick += GameTimer_Tick;
            gameTimer.Start();

            //bind the original menu
            this.menuForm = menuForm;

            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PlayField_FormClosing);
        }
        //private async void HandleOpponentTurn()
        //{
        //    if (opponentTurn) // Replace this condition with your actual logic to determine the opponent's turn
        //    {
        //        Console.WriteLine("Async is running");
        //        // Execute the computer player logic asynchronously
        //        //await Task.Run(() => OpponentSequence());

        //        // Set opponentTurn to false when the opponent's turn is over
        //        //opponentTurn = false;
        //    }
        //}

        //GameTimer will be running the consistent checks 
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            // Code to update the game field goes here
            // This method will be called every 100 milliseconds
            if (opponentTurn)
            {
                //Opponents chance to make an action
                OpponentSequence(opponentDeck);
            }
        }

        private void PlayField_Load(object sender, EventArgs e) {

        }

        //Disable player actions is intended for opponent turns
        private void DisablePlayerActions()
        {
            PlayCard1Box.Enabled = false;
            PlayCard2Box.Enabled = false;
            HandCard1Box.Enabled = false;
            HandCard2Box.Enabled = false;
            HandCard3Box.Enabled = false;

        }
        private void EnablePlayerActions() {
            PlayCard1Box.Enabled = true;
            PlayCard2Box.Enabled = true;
            HandCard1Box.Enabled = true;
            HandCard2Box.Enabled = true;
            HandCard3Box.Enabled = true;
        }
        private void ChangePlayCard1Data(Card playCard)
        {
            PlayCard1Box.Text = playCard.name;
            //action 1
            if (playCard.action1 != null && playCard.action1.actionName != null)
            {

                PlayCard1Action1Button.Text = playCard.action1.actionName;
                //account for cooldowns
                if(playCard.action1.canBePlayedIn > 0)
                {
                    PlayCard1Action1Button.Enabled = false;
                }
                
                else
                {
                    PlayCard1Action1Button.Enabled = true;
                }
            }
            //in the event there is no action
            else
            {
                PlayCard1Action1Button.Text = "No Action";
                PlayCard1Action1Button.Enabled = false;
            }
            //action 2
            if (playCard.action2 != null && playCard.action1.actionName != null)
            {
                PlayCard1Action2Button.Text = playCard.action2.actionName;
                //account for cooldowns
                if (playCard.action1.canBePlayedIn > 0)
                {
                    PlayCard1Action2Button.Enabled = false;
                }
                else
                {
                    PlayCard1Action2Button.Enabled = true;
                }
            }
            else
            {
                PlayCard1Action2Button.Text = "No Action";
                PlayCard1Action2Button.Enabled = false;
            }
        }
        private void ChangePlayCard2Data(Card playCard)
        {
            PlayCard2Box.Text = playCard.name;
            //action 1
            if (playCard.action1 != null && playCard.action1.actionName != null)
            {
                PlayCard2Action1Button.Text = playCard.action1.actionName;
                //account for cooldowns
                if (playCard.action1.canBePlayedIn > 0)
                {
                    PlayCard2Action1Button.Enabled = false;
                }
                else
                {
                    PlayCard2Action1Button.Enabled = true;
                }
            }
            else
            {
                PlayCard2Action1Button.Text = "No Action";
                PlayCard2Action1Button.Enabled = false;
            }
            //action 2
            if (playCard.action2 != null && playCard.action2.actionName != null)
            {
                PlayCard2Action2Button.Text = playCard.action2.actionName;
                //account for cooldowns
                if (playCard.action1.canBePlayedIn > 0)
                {
                    PlayCard2Action2Button.Enabled = false;
                }
                else
                {
                    PlayCard2Action2Button.Enabled = true;
                }
            }
            else
            {
                PlayCard2Action2Button.Text = "No Action";
                PlayCard2Action2Button.Enabled = false;
            }
        }
        private void ChangeHandCard1Data(Card handCard)
        {
            HandCard1Box.Text = handCard.name;
            if(handCard.action1.actionName != null)
            {
                Hand1Action1.Text = handCard.action1.actionName;
                Hand1Description1.Text = handCard.action1.actionDescription;
            }
            else
            {
                Hand1Action1.Text = "No Action";
                Hand1Description1.Text = "action does not exist";
            }
            if (handCard.action2.actionName != null)
            {
                Hand1Action2.Text = handCard.action2.actionName;
                Hand1Description2.Text = handCard.action2.actionDescription;
            }
            else
            {
                Hand1Action2.Text = "No Action";
                Hand1Description2.Text = "action does not exist";
            }
        }
        private void ChangeHandCard2Data(Card handCard)
        {
            HandCard2Box.Text = handCard.name;
            if (handCard.action1.actionName != null)
            {
                Hand2Action1.Text = handCard.action1.actionName;
                Hand2Description1.Text = handCard.action1.actionDescription;
            }
            else
            {
                Hand2Action1.Text = "No Action";
                Hand2Description1.Text = "action does not exist";
            }
            if (handCard.action2.actionName != null)
            {
                Hand2Action2.Text = handCard.action2.actionName;
                Hand2Description2.Text = handCard.action2.actionDescription;
            }
            else
            {
                Hand2Action2.Text = "No Action";
                Hand2Description2.Text = "action does not exist";
            }
        }
        private void ChangeHandCard3Data(Card handCard)
        {
            HandCard3Box.Text = handCard.name;
            if (handCard.action1.actionName != null)
            {
                Hand3Action1.Text = handCard.action1.actionName;
                Hand3Description1.Text = handCard.action1.actionDescription;
            }
            else
            {
                Hand3Action1.Text = "No Action";
                Hand3Description1.Text = "action does not exist";
            }
            if (handCard.action2.actionName != null)
            {
                Hand3Action2.Text = handCard.action2.actionName;
                Hand3Description2.Text = handCard.action2.actionDescription;
            }
            else
            {
                Hand3Action2.Text = "No Action";
                Hand3Description2.Text = "action does not exist";
            }
        }

        //change the data for the opponent cards
        private void changeOpponentPlayCard1(Card playCard)
        {
            OpponentPlayCard1.Text = playCard.name;
            if (playCard.action1.actionName != null)
            {
                OpponentCard1Action1.Text = playCard.action1.actionName;
            }
            else
            {
                OpponentCard1Action1.Text = "No Action";
            }
            if (playCard.action2.actionName != null)
            {
                OpponentCard1Action2.Text = playCard.action2.actionName;
            }
            else
            {
                OpponentCard1Action2.Text = "No Action";
            }
        }
        private void changeOpponentPlayCard2(Card playCard)
        {
            OpponentPlayCard2.Text = playCard.name;
            if (playCard.action1.actionName != null)
            {
                OpponentCard2Action1.Text = playCard.action1.actionName;
            }
            else
            {
                OpponentCard2Action1.Text = "No Action";
            }
            if (playCard.action2.actionName != null)
            {
                OpponentCard2Action2.Text = playCard.action2.actionName;
            }
            else
            {
                OpponentCard2Action2.Text = "No Action";
            }
        }
        //set up as a string for potential logging
        private string UseAction(PlayAction playAction)
        {
            //the string to be returned
            string returnString = "";

            //debug line
            Console.WriteLine("Action target: " + playAction.isEnemyTarget());
            //dummy decks for use
            Deck attacker;
            Deck defender;

            // generally attacks will be used by the attacker
            // The second part of the conditions isEnemyTarget
            //      is to reverse the target in case of side effects
            // The idea here is that in future iterations there can be multiple effects
            if ((playerTurn & playAction.isEnemyTarget()) ||
                (opponentTurn & !playAction.isEnemyTarget()))
            {
                attacker = playerDeck;
                defender = opponentDeck;
            }
            else if((opponentTurn & playAction.isEnemyTarget()) ||
                     playerTurn & !playAction.isEnemyTarget())
            {
                attacker = opponentDeck;
                defender = playerDeck;
            }
            else
            {
                Console.WriteLine("Unable to determine attacker and defender.");
                attacker = playerDeck;
                defender = opponentDeck;
            }

            //in the event that the enemy is the target perform the following
            switch (playAction.getEffectType())
            {
                case Enumerated.EffectType.Attack:
                    Console.WriteLine("used attack");
                    if (defender.firewall > playAction.value)
                    {
                        defender.firewall -= playAction.value;
                        Console.WriteLine("Damaged shield");
                    }
                    else{
                        //Adjust health used to not exceed the capacity for the progress bar
                        //since it is damaging, using a negative number
                        defender.ReduceHP(playAction.value - defender.firewall);
                        defender.firewall = 0;
                        Console.WriteLine("Damaged software");
                    }
                    Console.WriteLine("Opponent software at " + defender.softwareHealth + ".");
                    break;
                case Enumerated.EffectType.Debuff:
                    // Handle Debuff effect
                    break;
                case Enumerated.EffectType.Heal:
                    Console.WriteLine("used heal");
                    //healing is simply adding hp so no shield adjustment required
                    defender.HealHP(playAction.value);
                    break;
                case Enumerated.EffectType.Shield:
                    //make sure firewall does not exceed max
                    Console.WriteLine("value is: " + playAction.value);
                    Console.WriteLine("Firewall max is currently " + defender.firewallMax);
                    if ((defender.firewall + playAction.value) > defender.firewallMax)
                    {
                        defender.firewall = defender.firewallMax;
                        Console.WriteLine("Did something to firewall");
                    }
                    else
                    {
                        defender.firewall += playAction.value;
                        Console.WriteLine("Did something to firewall");
                    }

                    Console.WriteLine("player firewall at " + defender.firewall);
                    break;
                case Enumerated.EffectType.Pierce:
                    defender.ReduceHP(playAction.value);
                    break;
                default:
                    // Handle the case where effect is not recognized
                    break;
            }
            return returnString;
        }
        //ai field is a function to determin playability of the field cards
        //essentially checks if a swap is favorable for the AI
        //If all actions are useless forces the swap to be favorable
        private double AIFieldCheck(Deck deck)
        {
            //Hard swap value
            //This value does not equal out to 1 when all actions are diabled
            //When this value is too high the AI tries to swap too frequently
            double HARD_SWAP = 0.1;

            //the ai need to understand when a swap is favorable
            //this value will be a decimal between 0 and 1
            double favorSwap = 0;
            //action to help simplify code
            Card viewCard;

            //check available actions
            viewCard = opponentDeck.playCard1;
            if (viewCard.action1 != null)
            {
                if (viewCard.action1.canBePlayedIn > 0)
                {
                    favorSwap += HARD_SWAP;
                }
            }
            else
            {
                favorSwap += HARD_SWAP;
            }
            if (viewCard.action2 != null)
            {
                if (viewCard.action2.canBePlayedIn > 0)
                {
                    favorSwap += HARD_SWAP;
                }
            }
            else
            {
                favorSwap += HARD_SWAP;
            }
            //check available actions of the second card if not null
            if(deck.playCard2 != null)
            {
                viewCard = opponentDeck.playCard2;
                if (viewCard.action1 != null)
                {
                    if (viewCard.action1.canBePlayedIn > 0)
                    {
                        favorSwap += HARD_SWAP;
                    }
                }
                else
                {
                    favorSwap += HARD_SWAP;
                }
                if (viewCard.action2 != null)
                {
                    if (viewCard.action2.canBePlayedIn > 0)
                    {
                        favorSwap += HARD_SWAP;
                    }
                }
                else
                {
                    favorSwap += HARD_SWAP;
                }
            }
            else
            {
                favorSwap += HARD_SWAP;
            }
            //if the favor swap variable is that of all actions being useless
            //force the favor to 1
            if(favorSwap == (HARD_SWAP * 4))
            {
                favorSwap = 1;
            }
            return favorSwap;
        }
        //This is the function to simplify the code for swaping out cards
        private void AISwapCard(Deck deck, int playIndex, int handIndex)
        {
            if(deck.playCardIndex1 == playIndex)
            {
                if(deck.handCardIndex1 == handIndex)
                {
                    deck.handCard1 = deck.hand.ElementAt(playIndex);
                    deck.playCard1 = deck.hand.ElementAt(handIndex);
                    deck.playCardIndex1 = handIndex;
                    deck.handCardIndex1 = playIndex;
                }
                if (deck.handCardIndex2 == handIndex)
                {
                    deck.handCard2 = deck.hand.ElementAt(playIndex);
                    deck.playCard1 = deck.hand.ElementAt(handIndex);
                    deck.playCardIndex1 = handIndex;
                    deck.handCardIndex2 = playIndex;
                }
                if (deck.handCardIndex3 == handIndex)
                {
                    deck.handCard2 = deck.hand.ElementAt(playIndex);
                    deck.playCard1 = deck.hand.ElementAt(handIndex);
                    deck.playCardIndex1 = handIndex;
                    deck.handCardIndex2 = playIndex;
                }
                changeOpponentPlayCard1(deck.playCard1);
            }
            if (deck.playCardIndex2 == playIndex)
            {
                if (deck.handCardIndex1 == handIndex)
                {
                    deck.handCard1 = deck.hand.ElementAt(playIndex);
                    deck.playCard2 = deck.hand.ElementAt(handIndex);
                    deck.playCardIndex2 = handIndex;
                    deck.handCardIndex1 = playIndex;
                }
                if (deck.handCardIndex2 == handIndex)
                {
                    deck.handCard2 = deck.hand.ElementAt(playIndex);
                    deck.playCard2 = deck.hand.ElementAt(handIndex);
                    deck.playCardIndex2 = handIndex;
                    deck.handCardIndex2 = playIndex;
                }
                if (deck.handCardIndex3 == handIndex)
                {
                    deck.handCard2 = deck.hand.ElementAt(playIndex);
                    deck.playCard2 = deck.hand.ElementAt(handIndex);
                    deck.playCardIndex2 = handIndex;
                    deck.handCardIndex2 = playIndex;
                }
                changeOpponentPlayCard2(deck.playCard2);
            }
        }
        //This function checks a card for available actions
        //generally used when a swap is prompted
        private double AICheckAvailableAction(Card card)
        {
            double availableAction = 0;
            if (card != null)
            {
                if (card.action1 != null)
                {
                    if (card.action1.canBePlayedIn > 0)
                    {
                        availableAction += 0.5;
                    }
                }
                else
                {
                    availableAction += 0.5;
                }
                if (card.action2 != null)
                {
                    if (card.action2.canBePlayedIn > 0)
                    {
                        availableAction += 0.5;
                    }
                }
                else
                {
                    availableAction += 0.5;
                }
            }
            return availableAction;
        }
        //Select card for swap determines a card to switch with given circumstances
        //The purpose here is to look for more defense when HP falls too low
        private int AISelectCardForSwap(Deck deck, bool defenseOverAttack)
        {
            //variable for chosing a card
            //default value at -1 for checking against a selection
            int likelyIndex = -1;
            Random random = new Random();

            //first verify that the card exists then check for defense conditions
            //verify the card has actions available for use
            if (deck.handCard1 != null && (AICheckAvailableAction(deck.handCard1) != 0))
            {
                //if the card is a defense focus and the orientation for ai is defense
                //then select the card
                if ((deck.handCard1.cardType == Enumerated.CardType.Firewall ||
                        deck.handCard1.cardType == Enumerated.CardType.Patch) &&
                        defenseOverAttack)
                {
                    likelyIndex = deck.handCardIndex1;
                }
                else
                {
                    likelyIndex = deck.handCardIndex1;
                }
            }

            //first verify that the card exists then check for defense conditions
            if (deck.handCard2 != null && (AICheckAvailableAction(deck.handCard2) != 0))
            {
                //if the card is a defense focus and the orientation for ai is defense
                //then select the card
                if ((deck.handCard2.cardType == Enumerated.CardType.Firewall ||
                        deck.handCard2.cardType == Enumerated.CardType.Patch) &&
                        defenseOverAttack)
                {
                    //on the assumption that a card has already been selected
                    //Run another random chance for selection 
                    if (likelyIndex != -1)
                    {
                        if (random.NextDouble() > 0.5)
                        {
                            likelyIndex = deck.handCardIndex2;
                        }
                    }
                    else
                    {
                        likelyIndex = deck.handCardIndex2;
                    }
                }
                else
                {
                    if (likelyIndex != -1)
                    {
                        if (random.NextDouble() > 0.5)
                        {
                            likelyIndex = deck.handCardIndex2;
                        }
                    }
                    else
                    {
                        likelyIndex = deck.handCardIndex2;
                    }
                }
            }
            //first verify that the card exists then check for defense conditions
            if (deck.handCard3 != null && (AICheckAvailableAction(deck.handCard3) != 0))
            {
                //if the card is a defense focus and the orientation for ai is defense
                //then select the card
                if ((deck.handCard3.cardType == Enumerated.CardType.Firewall ||
                        deck.handCard3.cardType == Enumerated.CardType.Patch) &&
                        defenseOverAttack)
                {

                    //on the assumption that a card has already been selected
                    //Run another random chance for selection 
                    if (likelyIndex != -1)
                    {
                        if (random.NextDouble() > 0.5)
                        {
                            likelyIndex = deck.handCardIndex3;
                        }
                    }
                    else
                    {
                        likelyIndex = deck.handCardIndex3;
                    }
                }
                else
                {
                    if (likelyIndex != -1)
                    {
                        if (random.NextDouble() > 0.5)
                        {
                            likelyIndex = deck.handCardIndex3;
                        }
                    }
                    else
                    {
                        likelyIndex= deck.handCardIndex3;
                    }
                }
            }
            return likelyIndex;
        }
        //publi void returns an integer representing which action will be taken
        //Card 1 action 1 = 1, action 2 = 2, Card 2 action 1 = 3, action 2 = 4
        //when choosing actions, cooresponding actions have a 2/3 chanse of being played
        public int AIActionSelect(Card playCard1, Card playCard2, bool defenseOverAttack)
        {
            Console.WriteLine("Now in the action selection phase of AI");

            //the variable used to chose an action
            int chosenAction = 0;
            //the list of actions index will represent the actions being selected
            List<int> actions = new List<int>();
            actions.Add(0);
            actions.Add(0);
            actions.Add(0);
            actions.Add(0);

            //random variable
            //randomness will be used to create a likely hood of using the defense oriented attack
            //it will not always choose a defense attack but will be inclined to do so
            Random random = new Random();
            //random mod will increment every time a liklihood increases
            //will be used to select which action to choose
            int randomMod = 0;
            //random selection will be used to make the choice
            int randomSelection;

            //cycle through the four available actions for playability
            //check for defense or attack focus
            //check for null card

            Console.WriteLine("PlayCard1 is " + playCard1.name);
            Console.WriteLine("PlayCard2 is " + playCard2.name);
            if (playCard1 != null)
            {
                //make the AI seem more organic by randomly overriding previously chosen actions
                //if the action has been selected
                //make sure the action exists and is not on cooldown
                if (playCard1.action1 != null && playCard1.action1.canBePlayedIn == 0)
                {
                    Console.WriteLine("Card one is availabe. Action 1 is available.");
                    //if the action is even available, it has a chance of being selected
                    actions[0] += 1;
                    randomMod++;
                    //if the card is a defense oriented card and the AI wants defense
                    //this actions then has a higher chance of being selected
                    if ((playCard1.action1.effectType == Enumerated.EffectType.Heal ||
                        playCard1.action1.effectType == Enumerated.EffectType.Shield) &&
                        defenseOverAttack)
                    {
                        actions[0] += 2;
                        randomMod+=2;
                    }
                    //The card is not defense oriented and the AI wants attack
                    //select this action in that case
                    if (!((playCard1.action1.effectType == Enumerated.EffectType.Heal ||
                        playCard1.action1.effectType == Enumerated.EffectType.Shield) &&
                        !defenseOverAttack))
                    {
                        //there is a 1/2 chance to select an attack ability
                        if (random.NextDouble() > 0.5)
                        {
                            actions[0] += 2;
                            randomMod+=2;
                        }
                    }
                }
                if (playCard1.action2 != null && playCard1.action2.canBePlayedIn == 0)
                {
                    //if the action is even available, it has a chance of being selected
                    actions[1] += 1;
                    randomMod++;
                    //if the card is a defense oriented card and the AI wants defense
                    //this actions then has a higher chance of being selected
                    if ((playCard1.action2.effectType == Enumerated.EffectType.Heal ||
                        playCard1.action2.effectType == Enumerated.EffectType.Shield) &&
                        defenseOverAttack)
                    {
                        actions[1] += 2;
                        randomMod+=2;
                    }
                    //The card is not defense oriented and the AI wants attack
                    //select this action in that case
                    if (!((playCard1.action2.effectType == Enumerated.EffectType.Heal ||
                        playCard1.action2.effectType == Enumerated.EffectType.Shield) &&
                        !defenseOverAttack))
                    {
                        actions[1] += 2;
                        randomMod += 2;
                    }
                }
            }
            if (playCard2 != null)
            {
                //make the AI seem more organic by randomly overriding previously chosen actions
                //if the action has been selected
                //make sure the action exists and is not on cooldown
                if (playCard2.action1 != null && playCard2.action1.canBePlayedIn == 0)
                {
                    //if the action is even available, it has a chance of being selected
                    actions[2] += 1;
                    randomMod++;
                    //if the card is a defense oriented card and the AI wants defense
                    //this actions then has a higher chance of being selected
                    if ((playCard2.action1.effectType == Enumerated.EffectType.Heal ||
                        playCard2.action1.effectType == Enumerated.EffectType.Shield) &&
                        defenseOverAttack)
                    {
                        actions[2] += 2;
                        randomMod+=2;
                    }
                    //The card is not defense oriented and the AI wants attack
                    //select this action in that case
                    if (!((playCard2.action1.effectType == Enumerated.EffectType.Heal ||
                        playCard2.action1.effectType == Enumerated.EffectType.Shield) &&
                        !defenseOverAttack))
                    {
                        actions[2] += 2;
                        randomMod+=2;
                    }
                }
                if (playCard2.action2 != null && playCard2.action2.canBePlayedIn == 0)
                {
                    //if the action is even available, it has a chance of being selected
                    actions[3] += 1;
                    randomMod++;
                    //if the card is a defense oriented card and the AI wants defense
                    //this actions then has a higher chance of being selected
                    if ((playCard2.action2.effectType == Enumerated.EffectType.Heal ||
                        playCard2.action2.effectType == Enumerated.EffectType.Shield) &&
                        defenseOverAttack)
                    {
                        actions[3] += 2;
                        randomMod+=2;
                    }
                    //The card is not defense oriented and the AI wants attack
                    //select this action in that case
                    if (!((playCard2.action2.effectType == Enumerated.EffectType.Heal ||
                        playCard2.action2.effectType == Enumerated.EffectType.Shield) &&
                        !defenseOverAttack))
                    {
                        actions[3] += 2;
                        randomMod+=2;
                    }
                }
            }

            //calculate which card is chosen
            //the random number will be used to select the value from the list
            randomSelection = random.Next(randomMod);

            //the cumulative sum will be used for the hat pull selection used below
            int cumulativeSum = 0;

            // Iterate through the list to find the selected index
            for (int i = 0; i < actions.Count; i++)
            {
                //if the selected random number is < the chance value indicated by the actions index
                //that is the chosen action
                //otherwise, add the next value to the previous to compare against the random
                cumulativeSum += actions[i];
                if (randomSelection < cumulativeSum)
                {
                    Console.WriteLine("Chosen action is " + (i+1));
                    chosenAction = i + 1;
                    break;
                }
            }

            //the chosen action should be a value of 1-4
            return chosenAction;
        }
        /***
         * Opponent Sequence is going to be the computer player of the game
         * for the first iteration this will be a simple AI that
         *      randomly chooses actions based on simple conditions
         *      */
        private void OpponentSequence(Deck deck)
        {
            Console.WriteLine("Computer player attempting to use a turn.");
            Random random = new Random();
            double randomValue;
            bool defenseOverAttack;
            double fieldCard1SwapPropensity;
            double fieldCard2SwapPropensity;
            
            /* INITIALIZE VARIABLES */
            //consider attack favor or defense favor
            if(deck.softwareHealth < (deck.healthMax / 2))
            {
                defenseOverAttack = true;
            }
            else
            {
                defenseOverAttack = false;
            }
            //reset the cards to be checked before swapping
            fieldCard1SwapPropensity = 0;
            fieldCard2SwapPropensity = 0;

            //generate a random value to compare against the propensity to swap
            randomValue = random.NextDouble();
            //swap if the random value is less than the ai swap check
            if (randomValue <= AIFieldCheck(deck))
            {
                Console.WriteLine("Computer player trying to switch");
                //check the status on the playable actions
                //If a swap is being performed, switch with most useless card
                fieldCard1SwapPropensity = AICheckAvailableAction(deck.playCard1);
                fieldCard2SwapPropensity = AICheckAvailableAction(deck.playCard2);

                //logic time
                //first check for the useless cards before considering any other logic.
                if(fieldCard1SwapPropensity == 0)
                {
                    playIndex = deck.playCardIndex1;
                }
                else if(fieldCard2SwapPropensity == 0)
                {
                    playIndex = deck.playCardIndex2;
                }
                else //else runs the logic of choosing for attacks/defense
                {
                    if((deck.playCard1.cardType == Enumerated.CardType.Patch ||
                        deck.playCard1.cardType== Enumerated.CardType.Firewall) &&
                        defenseOverAttack)
                    {
                        playIndex = deck.playCardIndex1;
                    }

                    else if ((deck.playCard2.cardType == Enumerated.CardType.Patch ||
                                deck.playCard2.cardType == Enumerated.CardType.Firewall) &&
                                defenseOverAttack)
                    {
                        playIndex = deck.playCardIndex2;
                    }
                    //randomly select a card to be swapped out
                    else
                    {
                        if (random.NextDouble() > 0.50)
                        {
                            playIndex = deck.playCardIndex1;
                        }
                        else
                        {
                            playIndex = deck.playCardIndex2;
                        }
                    }
                }//the field card now should have been selected


                handIndex = AISelectCardForSwap(deck, defenseOverAttack);
                AISwapCard(deck, playIndex, handIndex);
            }
            //if not swap then we use a play card action
            else
            {
                Console.WriteLine("Computer player trying to use an action");
                switch(AIActionSelect(deck.playCard1, deck.playCard2, defenseOverAttack)){
                    case 1:
                        {
                            Console.WriteLine("Attempting to use Action 1 of card 1");
                            UseAction(deck.playCard1.action1);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Attempting to use Action 2 of card 1");
                            UseAction(deck.playCard1.action2);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Attempting to use Action 1 of card 1");
                            UseAction(deck.playCard2.action1);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Attempting to use Action 2 of card 2");
                            UseAction(deck.playCard2.action2);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("No action available. Failed using action");
                            break;
                        }
                }
            }
            UseTurnPoint();
        }
        //Checks who just played and disables their actions
        private void SwitchTurns()
        {
            Console.WriteLine("Now attempting to change turns");
            //if the players turn was active
            //disable actions since turn is over
            if (playerTurn)
            {
                opponentTurn = true;
                playerTurn = false;
                DisablePlayerActions();
                Console.WriteLine("Now Opponent Turn");
                return;
            }
            //if opponent turn was active
            //reenable actions since turn starts
            if(opponentTurn)
            {
                playerTurn = true;
                opponentTurn = false;
                EnablePlayerActions();
                Console.WriteLine("Now Player turn");
                return;
            }
        }
        private void UseTurnPoint()
        {
            turnPoints--;
            Console.WriteLine("turn points at: " + turnPoints);
            CheckForEnd();
            if(turnPoints == 0)
            {
                SwitchTurns();
                turnPoints = ACTIONS_PER_TURN;
                Console.WriteLine("Turn points now at " + turnPoints);
            }
        }

        private bool CheckForEnd()
        {
            if(playerDeck.softwareHealth <=0 ||
                opponentDeck.softwareHealth <= 0)
            {
                FinishGame();
                return true;
            }
            else
            {
                return false;
            }
        }
        private void FinishGame()
        {
            GameOverBanner.Visible = true;
            GameOverText.Visible = true;
            //game is over, stop the computer player
            gameTimer.Stop();
        }
        private void InitializeField()
        {
            // Instantiate the generator (adjust in prefab class as needed)
           // generator = new PreFab();

            //set swap initiation to false
            handCard1SwapInitiated = false;
            handCard2SwapInitiated = false;
            handCard3SwapInitiated = false;

            // Initialize player and enemy decks (assuming newBasicDeck returns a valid deck)
            //these functions are now disabled with having actual decks
            //playerDeck = new Deck(generator.newBasicDeck());
            //opponentDeck = new Deck(generator.newBasicDeck());

            // Binding combatant stats to respective components
            //PlayerHpBar
            PlayerHpBar.DataBindings.Add("Maximum", playerDeck, "healthMax");
            PlayerHpBar.DataBindings.Add("Value", playerDeck, "softwareHealth");

            //PlayerShield
            PlayerShield.DataBindings.Add("Maximum", playerDeck, "firewallMax");
            PlayerShield.DataBindings.Add("Value", playerDeck, "firewall");

            //OpponentHpBar
            OpponentHpBar.DataBindings.Add("Maximum", opponentDeck, "healthMax");
            OpponentHpBar.DataBindings.Add("Value", opponentDeck, "softwareHealth");

            //OpponentShield
            OpponentShield.DataBindings.Add("Maximum", opponentDeck, "firewallMax");
            OpponentShield.DataBindings.Add("Value", opponentDeck, "firewall");

            //set the name of the opponent and player decks
            OpponentFieldCards.Text = opponentDeck.name + " hand";
            PlayerFieldCards.Text = playerDeck.name + " field";
            PlayerHandCards.Text = playerDeck.name + " hand";

            //game over display
            GameOverBanner.Visible = false;
            GameOverText.Visible = false;

            //Disable the swap buttons for the play cards until activated by the swap buttons
            DisablePlaySwapButtons();

            //set player turn
            playerTurn = true;
            opponentTurn = false;
            turnPoints = ACTIONS_PER_TURN;
            Console.WriteLine("Turn points at: " + turnPoints);

            //Player buttons
            //Play card 1 Actions
            if (playerDeck.playCard1 != null)
            {
                ChangePlayCard1Data(playerDeck.playCard1);
            }
            //play card 2 actions 
            if (playerDeck.playCard2 != null)
            {
                ChangePlayCard2Data(playerDeck.playCard2);
            }
            //change the first hand card
            if(playerDeck.handCard1 != null)
            {
                ChangeHandCard1Data(playerDeck.handCard1);
            }
            //change the second hand card
            if (playerDeck.handCard2 != null)
            {
                ChangeHandCard2Data(playerDeck.handCard2);
            }
            //change the third hand card
            if (playerDeck.handCard3 != null)
            {
                ChangeHandCard3Data(playerDeck.handCard3);
            }
            if(opponentDeck.playCard1 != null) { 
                changeOpponentPlayCard1(opponentDeck.playCard1);
            }
            if (opponentDeck.playCard2 != null)
            {
                changeOpponentPlayCard2(opponentDeck.playCard2);
            }

        }

        //disable swap
        private void DisablePlaySwapButtons()
        {
            PlayCard1SwapButton.Enabled = false;
            PlayCard1SwapButton.Visible = false;
            PlayCard2SwapButton.Enabled = false;
            PlayCard2SwapButton.Visible = false;
        }
        private void EnablePlaySwapButtons()
        {
            PlayCard1SwapButton.Enabled = true;
            PlayCard1SwapButton.Visible = true;
            PlayCard2SwapButton.Enabled = true;
            PlayCard2SwapButton.Visible = true;
        }
        private void DisableHandSwapButtons()
        {
            HandCard1SwapButton.Enabled = false;
            HandCard2SwapButton.Enabled = false;
            HandCard3SwapButton.Enabled = false;
        }
        private void EnableHandSwapButtons()
        {
            HandCard1SwapButton.Enabled = true;
            HandCard2SwapButton.Enabled = true;
            HandCard3SwapButton.Enabled = true;
        }

        private void PlayCard1Action1Button_Click(object sender, EventArgs e)
        {
            UseAction(playerDeck.playCard1.action1);
            DisablePlaySwapButtons();
            UseTurnPoint();
        }

        private void PlayCard1Action2Button_Click(object sender, EventArgs e)
        {
            UseAction(playerDeck.playCard1.action2);
            DisablePlaySwapButtons();
            UseTurnPoint();
        }

        private void PlayCard2Action1Button_Click(object sender, EventArgs e)
        {
            UseAction(playerDeck.playCard2.action1);
            DisablePlaySwapButtons();
            UseTurnPoint();
        }

        private void PlayCard2Action2Button_Click(object sender, EventArgs e)
        {
            UseAction(playerDeck.playCard2.action2);
            DisablePlaySwapButtons();
            UseTurnPoint();
        }

        //The hand card swap buttons do one of two things
        //The first is that they disable other hand buttons and enable the field swap
        //the second is record the index of the card to be swapped.
        private void HandCard1SwapButton_Click(object sender, EventArgs e)
        {
            //assumption that this is the initial click
            if (!handCard1SwapInitiated)
            {
                handCard1SwapInitiated = true;
                //disable other hand swap buttons
                HandCard2SwapButton.Enabled = false;
                HandCard3SwapButton.Enabled = false;
                EnablePlaySwapButtons();
                //values used for the switching
                handIndex = playerDeck.handCardIndex1;

    }
            //the else is essentially changing ones mind
            else
            {
                handCard1SwapInitiated = false;
                //enable other hand swap buttons
                EnableHandSwapButtons();
                DisablePlaySwapButtons();
            }

        }

        private void HandCard2SwapButton_Click(object sender, EventArgs e)
        {
            //assumption that this is the initial click
            if (!handCard2SwapInitiated)
            {
                handCard2SwapInitiated = true;
                //disable other hand swap buttons
                HandCard1SwapButton.Enabled = false;
                HandCard3SwapButton.Enabled = false;
                EnablePlaySwapButtons();
                //values used for the switching
                handIndex = playerDeck.handCardIndex2;

            }
            //the else is essentially changing ones mind
            else
            {
                handCard2SwapInitiated = false;
                //enable other hand swap buttons
                EnableHandSwapButtons();
                DisablePlaySwapButtons();
            }
        }

        private void HandCard3SwapButton_Click(object sender, EventArgs e)
        {
            //assumption that this is the initial click
            if (!handCard3SwapInitiated)
            {
                handCard3SwapInitiated = true;
                //disable other hand swap buttons
                HandCard1SwapButton.Enabled = false;
                HandCard2SwapButton.Enabled = false;
                EnablePlaySwapButtons();
                //values used for the switching
                handIndex = playerDeck.handCardIndex3;

            }
            //the else is essentially changing ones mind
            else
            {
                handCard3SwapInitiated = false;
                //enable other hand swap buttons
                EnableHandSwapButtons();
                DisablePlaySwapButtons();
            }
        }

        //should be impossible to select this button without first initializing a swap.
        private void PlayCard1SwapButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("PlayCard swap 1 clicked");
            //handIndex should have been set with the initial swap click
            playIndex = playerDeck.playCardIndex1;
            //set the playCard to what was in the hand
            playerDeck.playCardIndex1 = handIndex;
            //make the change to the card info
            playerDeck.playCard1 = playerDeck.hand.ElementAt(handIndex);
            ChangePlayCard1Data(playerDeck.playCard1);

            Console.WriteLine("Play card 1 should be " + playerDeck.playCard1.name);

            //set the hand card based on what was initiated
            if (handCard1SwapInitiated)
            {
                playerDeck.handCardIndex1 = playIndex;
                playerDeck.handCard1 = playerDeck.hand.ElementAt(playerDeck.handCardIndex1);
                handCard1SwapInitiated = false;
                ChangeHandCard1Data(playerDeck.handCard1);
            }
            if (handCard2SwapInitiated)
            {
                playerDeck.handCardIndex2 = playIndex;
                playerDeck.handCard2 = playerDeck.hand.ElementAt(playerDeck.handCardIndex2);
                handCard2SwapInitiated = false;
                ChangeHandCard2Data(playerDeck.handCard2);
            }
            if (handCard3SwapInitiated)
            {
                playerDeck.handCardIndex3 = playIndex;
                playerDeck.handCard3 = playerDeck.hand.ElementAt(playerDeck.handCardIndex3);
                handCard3SwapInitiated = false;
                ChangeHandCard3Data(playerDeck.handCard3);
            }
            DisablePlaySwapButtons();
            EnableHandSwapButtons();
            UseTurnPoint();
        }

        private void PlayCard2SwapButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("PlayCard swap 2 clicked");
            //handIndex should have been set with the initial swap click
            playIndex = playerDeck.playCardIndex2;
            //set the playCard to what was in the hand
            playerDeck.playCardIndex2 = handIndex;
            //make the change to the card info
            playerDeck.playCard2 = playerDeck.hand.ElementAt(handIndex);
            ChangePlayCard2Data(playerDeck.playCard2);

            Console.WriteLine("Play card 2 should be " + playerDeck.playCard2.name);

            //set the hand card based on what was initiated
            if (handCard1SwapInitiated)
            {
                playerDeck.handCardIndex1 = playIndex;
                playerDeck.handCard1 = playerDeck.hand.ElementAt(playerDeck.handCardIndex1);
                handCard1SwapInitiated = false;
                ChangeHandCard1Data(playerDeck.handCard1);
            }
            if (handCard2SwapInitiated)
            {
                playerDeck.handCardIndex2 = playIndex;
                playerDeck.handCard2 = playerDeck.hand.ElementAt(playerDeck.handCardIndex2);
                handCard2SwapInitiated = false;
                ChangeHandCard2Data(playerDeck.handCard2);
            }
            if (handCard3SwapInitiated)
            {
                playerDeck.handCardIndex3 = playIndex;
                playerDeck.handCard3 = playerDeck.hand.ElementAt(playerDeck.handCardIndex3);
                handCard3SwapInitiated = false;
                ChangeHandCard3Data(playerDeck.handCard3);
            }
            DisablePlaySwapButtons();
            EnableHandSwapButtons();
            UseTurnPoint();
        }

        private void PlayField_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Check if the Menu form reference is available
            if (menuForm != null)
            {
                // Show the existing Menu form when the PlayField form is closed
                menuForm.Show();
            }
        }

    }


}
