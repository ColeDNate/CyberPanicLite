using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberPanicLite.Classes
{
    public class Enumerated
    {
        public enum EffectType
        {
            Attack = 1,
            DelayAttack = 2,
            Debuff = 3,
            DelayDebuff = 4,
            Heal = 5,
            Shield = 6,
            Pierce = 7
        }
        public static Dictionary<string, EffectType> effectMapping = new Dictionary<string, EffectType>
        {
            { "Attack", EffectType.Attack },
            { "Delay Attack", EffectType.DelayAttack },
            { "Debuff", EffectType.Debuff },
            { "Delay Debuff", EffectType.DelayDebuff },
            { "Heal", EffectType.Heal },
            { "Shield", EffectType.Shield },
            { "Pierce", EffectType.Pierce }
        };


        public enum CardType
        {
            Virus = 1,
            Glitch = 2,
            Patch = 3,
            Firewall = 4,
            Worm = 5
        }

        public static Dictionary<string, CardType> cardMapping = new Dictionary<string, CardType>
        {
            { "Virus", CardType.Virus },
            { "Glitch", CardType.Glitch },
            { "Patch", CardType.Patch },
            { "Firewall", CardType.Firewall },
            { "Worm", CardType.Worm },
        };

    }
}
