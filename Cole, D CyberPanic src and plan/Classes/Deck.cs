using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberPanicLite.Classes
{
    public class Deck : INotifyPropertyChanged
    {
        /*** VARIABLES ***/
        //database items
        public int deckID { get; set; }
        public string name { get; set; }

        //normal variables
        public int healthMax { get; set; }
        private int _softwareHealth;
        public int softwareHealth{
            get { return _softwareHealth; }
            set {
                if (_softwareHealth != value){
                    _softwareHealth = value;
                    OnPropertyChanged(nameof(softwareHealth));
                }
            }
        }
        //firewall max is 50% of hp
        public int firewallMax { get; set; }
        //firewal should be initialized to 0;
        private int _firewall;
        public int firewall{
            get { return _firewall; }
            set {
                if (_firewall != value){
                    _firewall = value;
                    OnPropertyChanged(nameof(firewall));
                }
            }
        }
        //debuffed will be unused for the sake of testing everything else
        public int debuffed { get; set; }

        //play cards will not be separate items
        public List<Card> hand;

        //play card index will be the int to reference the hand
        public int playCardIndex1 { get; set; }
        public int playCardIndex2 { get; set; }
        public int handCardIndex1 { get; set; }
        public int handCardIndex2 { get; set; }
        public int handCardIndex3 {  get; set; }

        //play cards will reference the cards in the hand
        public Card playCard1;
        public Card playCard2;
        public Card handCard1;
        public Card handCard2;
        public Card handCard3;

        //property handler for win forms
        public event PropertyChangedEventHandler PropertyChanged;
        //informed the UI to make the change
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        /*** CONSTRUCTORS ***/
        //creates basic default deck with no cards
        public Deck()
        {
            //default initialization at 100
            setHPandFirewall(100);

            //set up new hand before adjusting the play cards
            hand = new List<Card>();
            //by defautl the index values will be the first and second card in the hand
            setDefaultCards();
        }
        public Deck(int deckID, string name, int healthMax, Card card1, Card card2, Card card3, Card card4, Card card5) {
            //set the basic info
            this.deckID = deckID;
            this.name = name;
            setHPandFirewall(healthMax);

            //the hand
            hand = new List<Card>
            {
                new Card(card1),
                new Card(card2),
                new Card(card3),
                new Card(card4),
                new Card(card5),
            };
            //set the default card references
            setDefaultCards();
        }

        //copy constructor to be used with the test functions
        public Deck(Deck other)
        {
            deckID = other.deckID;
            name = other.name;
            healthMax = other.healthMax;
            softwareHealth = healthMax;
            firewallMax = other.firewallMax;
            firewall = 0;
            debuffed = other.debuffed;

            //set the hand before adjusting the play cards
            hand = new List<Card>();
            foreach (Card card in other.hand)
            {
                hand.Add(new Card(card));
            }
            setDefaultCards(); 
        }


        /*** FUNCTIONS ***/
        public void setHPandFirewall(int hp)
        {
            healthMax = hp;
            softwareHealth = hp;
            firewallMax = hp / 2;
            firewall = 0;
        }

        public void setDefaultCards()
        {
            //play cards
            playCardIndex1 = 0;
            playCardIndex2 = 1;
            //set playcard 1
            if (hand.Count > 0)
            {
                playCard1 = hand.ElementAt(playCardIndex1);
            }
            else
            {
                playCard1 = null;
            }
            //set playcard 2
            if(hand.Count > 1)
            {
                playCard2 = hand.ElementAt(playCardIndex2);
            }
            else
            {
                playCard2 = null;
            }

            //hand cards
            handCardIndex1 = 2;
            handCardIndex2 = 3;
            handCardIndex3 = 4;
            //set hand card 1
            if (hand.Count > 2)
            {
                handCard1 = hand.ElementAt(handCardIndex1);
            }
            else
            {
                handCard1 = null;
            }
            //set playcard 2
            if (hand.Count > 3)
            {
                handCard2 = hand.ElementAt(handCardIndex2);
            }
            else
            {
                playCard2 = null;
            }
            //set handcard 3
            if (hand.Count > 4)
            {
                handCard3 = hand.ElementAt(handCardIndex3);
            }
            else
            {
                handCard3 = null;
            }
        }

        public void ReduceHP(int value)
        {
            if ((softwareHealth - value) < 0)
            {
                softwareHealth = 0;
            }
            else
            {
                softwareHealth -= value;
            }
        }
        public void HealHP(int value)
        {
            if ((softwareHealth + value) > healthMax)
            {
                softwareHealth = healthMax;
            }
            else
            {
                softwareHealth += value;
            }
        }

    }
}
