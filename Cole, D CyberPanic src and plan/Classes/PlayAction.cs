using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberPanicLite.Classes
{
    public class PlayAction
    {

        /*** VARIABLES ***/
        public int actionID { get; set; } //Should not be user modified. Auto-incrementing
        public string actionName { get; set; }
        public string actionDescription { get; set; }
        public bool enemyIsTarget;
        public Enumerated.EffectType effectType;
        public int value {  get; set; }
        public int coolDown {  get; set; }
        public int canBePlayedIn {  get; set; }

        public PlayAction()
        {

        }
        public PlayAction(string actionName, bool enemyIsTarget, Enumerated.EffectType effectType, int value, int coolDown)
        {
            this.actionName = actionName;
            this.enemyIsTarget = enemyIsTarget;
            this.effectType = effectType;
            this.value = value;
            this.coolDown = coolDown;
            this.canBePlayedIn = 0;
        }
        public PlayAction(string actionName, string description, bool enemyIsTarget, Enumerated.EffectType effectType, int value, int coolDown)
        {
            this.actionName = actionName;
            this.actionDescription = description;
            this.enemyIsTarget = enemyIsTarget;
            this.effectType = effectType;
            this.value = value;
            this.coolDown = coolDown;
            this.canBePlayedIn = 0;
        }
        public PlayAction(int actionID, string actionName, string description, bool enemyIsTarget, Enumerated.EffectType effectType, int value, int coolDown)
        {
            this.actionID = actionID;
            this.actionName = actionName;
            this.actionDescription = description;
            this.enemyIsTarget = enemyIsTarget;
            this.effectType = effectType;
            this.value = value;
            this.coolDown = coolDown;
            this.canBePlayedIn = 0;
        }

        //copy constructor
        public PlayAction(PlayAction other)
        {
            if(other != null)
            {
                actionID = other.actionID;
                actionName = other.actionName;
                actionDescription = other.actionDescription;
                enemyIsTarget = other.enemyIsTarget;
                effectType = other.effectType;
                value = other.value;
                coolDown = other.coolDown;
                canBePlayedIn = 0;
            }
        }



        /*** FUNCTIONS ***/
        public void setActionName(string actionName)
        {
            this.actionName = actionName;
        }
        public string getActionName()
        {
            return this.actionName;
        }

        public void setEffectType(Enumerated.EffectType effectType)
        {
            this.effectType = effectType;
        }
        public Enumerated.EffectType getEffectType()
        {
            return this.effectType;
        }

        public void setValue(int value)
        {
            this.value = value;
        }
        public int getValue()
        {
            return this.value;
        }
        
        public void targetEnemy()
        {
            enemyIsTarget = true;
        }
        public void targetSelf()
        {
            enemyIsTarget = false;
        }

        //is enemy target returns true of the enemy is a target or false is is self
        public bool isEnemyTarget()
        {
            return enemyIsTarget;
        }

        public void setCoolDown(int coolDown)
        {
            this.coolDown = coolDown;
        }
        public int getCoolDown()
        {
            return coolDown;
        }
        public void activateCoolDown()
        {
            canBePlayedIn = coolDown;
        }
        public void decrementCoolDown()
        {
            canBePlayedIn--;
        }
        public bool playable()
        {
            if(canBePlayedIn >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
