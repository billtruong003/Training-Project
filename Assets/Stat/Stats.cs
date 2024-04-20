using System;
using System.Collections;
using System.Collections.Generic;
using AYellowpaper.SerializedCollections;
using NaughtyAttributes;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.TextCore.Text;

namespace GameStats
{
    [CreateAssetMenu(fileName = "Stats", menuName = "Status")]

    public class Stats : ScriptableObject
    {
        public SerializedDictionary<Stat, float> StatsData = new SerializedDictionary<Stat, float>();
        public GameClass createClass;
        [SerializeField]
        [Button]
        private void InitCharacter()
        {
            CharacterClass.Character character = DecideClass();

            StatsData[Stat.Health] = character.Health;
            StatsData[Stat.Mana] = character.Mana;
            StatsData[Stat.Armor] = character.Armor;
            StatsData[Stat.AttackDamage] = character.AttackDamage;
            StatsData[Stat.MagicDamage] = character.MagicDamage;
            StatsData[Stat.AttackSpeed] = character.AttackSpeed;
            StatsData[Stat.MovementSpeed] = character.MovementSpeed;
        }
        private CharacterClass.Character DecideClass()
        {
            if (createClass == GameClass.Warrior)
            {
                CharacterClass.Warrior warrior = new CharacterClass.Warrior();
                return warrior;
            }
            else if (createClass == GameClass.Assasin)
            {
                CharacterClass.Assassin assasin = new CharacterClass.Assassin();
                return assasin;
            }
            else if (createClass == GameClass.Mage)
            {
                CharacterClass.Mage mage = new CharacterClass.Mage();
                return mage;
            }
            else if (createClass == GameClass.Archer)
            {
                CharacterClass.Archer archer = new CharacterClass.Archer();
                return archer;
            }
            else
            {
                return null;
            }
        }
    }
}