using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace GameStats
{
    [Serializable]
    public enum GameClass
    {
        Warrior,
        Assasin,
        Mage,
        Archer,
    }
    public class CharacterClass
    {
        public abstract class Character
        {
            public float Health;
            public float Mana;
            public float Armor;
            public float AttackDamage;
            public float MagicDamage;
            public float AttackSpeed;
            public float MovementSpeed;
        }

        public class Warrior : Character
        {
            public Warrior()
            {
                Health = 150;
                Mana = 20;
                Armor = 30;
                AttackDamage = 25;
                MagicDamage = 0;
                AttackSpeed = 1.2f;
                MovementSpeed = 5.0f;
            }
        }

        public class Assassin : Character
        {
            public Assassin()
            {
                Health = 100;
                Mana = 40;
                Armor = 20;
                AttackDamage = 20;
                MagicDamage = 10;
                AttackSpeed = 1.5f;
                MovementSpeed = 6.5f;
            }
        }

        public class Mage : Character
        {
            public Mage()
            {
                Health = 80;
                Mana = 100;
                Armor = 10;
                AttackDamage = 10;
                MagicDamage = 30;
                AttackSpeed = 1.0f;
                MovementSpeed = 5.5f;
            }
        }

        public class Archer : Character
        {
            public Archer()
            {
                Health = 120;
                Mana = 30;
                Armor = 15;
                AttackDamage = 22;
                MagicDamage = 5;
                AttackSpeed = 1.3f;
                MovementSpeed = 6.0f;
            }
        }
    }
}