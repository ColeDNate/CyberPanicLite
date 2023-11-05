/***
 * PreFab Class
 * This class should be used to generate pre-fabricated game objects.
 * The objects will be actions to be used by individual cards
 *      the cards themselves
 *      and a full deck to add the cards to
 * Through pregenerating the objects here, it should serve to maintain organization
 * 
 * */

using CyberPanicLite.Classes;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static CyberPanicLite.Classes.Enumerated;

namespace CyberPanicLite.TestItems
{
    public class PreFab
    {
        /*** ACTIONS ***/
        public PlayAction attack;
        public PlayAction debuff;
        public PlayAction pierce;
        public PlayAction heal;
        public PlayAction shield;

        /* ACTION CREATION */
        public PlayAction newAttack()
        {
            //Not using constructors for the sake of organization
            //attack = new PlayAction();
            attack = new PlayAction("Attack", true, Enumerated.EffectType.Attack, 5, 2);
            //attack.setActionName("Attack");
            //attack.setEffectType(Enumerated.EffectType.Attack);
            //attack.setValue(5);
            //attack.targetEnemy();
            //attack.setCoolDown(2);
            return attack;
        }
        public PlayAction newDebuff()
        {
            //Not using constructors for the sake of organization
            debuff = new PlayAction();
            debuff.setActionName("Debuff");
            debuff.setEffectType(Enumerated.EffectType.Debuff);
            debuff.setValue(5);
            debuff.targetEnemy();
            debuff.setCoolDown(2);
            return debuff;
        }
        public PlayAction newPierce()
        {
            //Not using constructors for the sake of organization
            pierce = new PlayAction();
            pierce.setActionName("Pierce");
            pierce.setEffectType(Enumerated.EffectType.Pierce);
            pierce.setValue(3);
            pierce.targetEnemy();
            pierce.setCoolDown(2);
            return pierce;
        }
        public PlayAction newHeal()
        {
            //Not using constructors for the sake of organization
            heal = new PlayAction();
            heal.setActionName("Heal");
            heal.setEffectType(Enumerated.EffectType.Heal);
            heal.setValue(4);
            heal.targetSelf();
            heal.setCoolDown(2);
            return heal;
        }
        public PlayAction newShield()
        {
            //Not using constructors for the sake of organization
            shield = new PlayAction();
            shield.setActionName("Shield");
            shield.setEffectType(Enumerated.EffectType.Shield);
            shield.setValue(5);
            shield.targetSelf();
            shield.setCoolDown(2);
            return shield;
        }

        /*** CARDS ***/
        public Card Blank; // blank because why not
        public Card Virus;
        public Card Glitch;
        public Card Patch;
        public Card Firewall;
        public Card Worm;

        //NO ACTION CARD
        public Card newBlank()
        {
            Blank = new Card("Blank", "A useless card");
            Virus.cardType = Enumerated.CardType.Glitch;
            return Blank;
        }
        /* SINGLE ACTION CARDS */
        public Card newVirus()
        {
            Virus = new Card("Virus", "Attack card", newAttack());
            Virus.cardType = Enumerated.CardType.Virus;
            return Virus;
        }
        public Card newGlitch()
        {
            Glitch = new Card("Glitch", "Debuff card", newDebuff());

            Virus.cardType = Enumerated.CardType.Glitch;
            return Glitch;
        }
        public Card newPatch()
        {
            Patch = new Card("Patch", "Healing Card", newHeal());
            Virus.cardType = Enumerated.CardType.Patch;
            return Patch;
        }
        public Card newFirewall()
        {
            Firewall = new Card("Firewall", "Shields protect against attacks", newShield());
            Virus.cardType = Enumerated.CardType.Firewall;
            return Firewall;
        }
        public Card newWorm()
        {
            Worm = new Card("Worm", "Piercing attacks get past shields", newPierce());
            Virus.cardType = Enumerated.CardType.Worm;
            return Worm;
        }

        /* DUAL ACTION CARDS */
        // no dual action cards

        /*** DECKS ***/
        public Deck basicDeck;

        /*** DECKS ***/
        //newBasicDeck will return a default deck for testing.
        //this deck should be used in conjunction with a copy constructor
        public Deck newBasicDeck()
        {
            basicDeck = new Deck();

            //debuffed will be left alone until otherwise figured out.

            basicDeck.hand.Add(newVirus());
            basicDeck.hand.Add(newFirewall());
            //using the convenient blank to replace the glitch until it is figured out
            basicDeck.hand.Add(newBlank());
            basicDeck.hand.Add(newPatch());
            basicDeck.hand.Add(newWorm());

            basicDeck.playCard1 = basicDeck.hand.ElementAt(0);
            basicDeck.playCard2 = basicDeck.hand.ElementAt(1);

            return basicDeck;
        }

       
    }
}
