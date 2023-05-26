using System;

namespace RPG
{
    public class Stats
    {
        public int Strength, Dexterity, Vitality, Recovery, Endurance, Luck;
        public float dmg
        {
            get
            {
                return Strength;
            }
        }
        public float critMult
        {
            get
            {
                return Strength * 0.25f;
            }
        }
        public float stunChance
        {
            get
            {
                return (Strength * 2 + Dexterity) / 100;
            }
        }
        public float spUse
        {
            get
            {
                return Strength * 3;
            }
        }
        public float critChance
        {
            get
            {
                return (Dexterity * 3 + Strength) / 100;
            }
        }
        public float blockChance
        {
            get
            {
                return (Dexterity * 3 + Endurance) / 100;
            }
        }

        //{ Strength, Dexterity, Vitality, Recovery, Endurance, Luck }

        //{ (dmg, crit mult, stun chance, sp use mult), (crit chance, block chance, parry chance, dodge chance, sp value),
        //(hp regen, hp value, ailment recovery), (sp regen, stun recovery, exauhsted recovery, parry recovery), (max hp, max sp, dmg reduc),
        //(cool stuff)
    }
}
