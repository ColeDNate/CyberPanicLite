using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberPanicLite.Classes {
    public class Card {
        public int cardID { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public Enumerated.CardType cardType { get; set; }
        public PlayAction action1 { get; set; }
        public PlayAction action2 { get; set; }


        /*** CONSTRUCTORS ***/
        public Card()
        {
            this.name = "Default Card";
            this.description = "A useless card";
            this.action1 = null;
            this.action2 = null;
        }
        //No Action constructor (*a bum card*)
        public Card(string name, string description) {
            this.name = name; 
            this.description = description;
            this.action1 = null;
            this.action2 = null;
        }
        //single action card
        public Card(string name, string description, PlayAction action)
        {
            this.name = name;
            this.description = description;
            this.action1 = action;
            this.action2 = null;
        }
        //double action card
        public Card(string name, string description, PlayAction action1, PlayAction action2)
        {
            this.name = name;
            this.description = description;
            this.action1 = action1;
            this.action2 = action2;
        }

        //double action card with database id
        public Card(int id, string name, string description, Enumerated.CardType cardType, PlayAction action1, PlayAction action2)
        {
            cardID = id;
            this.name = name;
            this.description = description;
            this.cardType = cardType;
            SetAction1(action1);
            SetAction2(action2);
        }
        //copy constructor
        public Card(Card other)
        {
            this.name = other.name;
            this.description = other.description;
            this.cardType = other.cardType;
            SetAction1(other.action1);
            SetAction2(other.action2);
        }


        /*** FUNCTION ***/
        public void SetAction1(PlayAction action) { this.action1 = new PlayAction(action);}
        public void SetAction2(PlayAction action) { this.action2 = new PlayAction(action);}
    }
}
