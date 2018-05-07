using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameUtils
{
    namespace CharacterStatsSystem
    {
        public abstract class CharacterStats : ScriptableObject
        {
            [SerializeField]
            protected string characterName;
            [SerializeField]
            protected int health;
            [SerializeField]
            protected int defense;
            [SerializeField]
            protected int magicDefense;
            [SerializeField]
            protected int magicPower;
            [SerializeField]
            protected int attackPower;
            [SerializeField]
            protected int level;
            [SerializeField]
            protected int maxHealth;
            [SerializeField]
            protected int maxMana;
            [SerializeField]
            protected int mana;


            public string CharacterName
            {
                get
                {
                    return characterName;
                }

                set
                {
                    characterName = value;
                }
            }

            public int Health
            {
                get
                {
                    return health;
                }

                set
                {
                    health = value;
                }
            }

            public int Defense
            {
                get
                {
                    return defense;
                }

                set
                {
                    defense = value;
                }
            }

            public int MagicDefense
            {
                get
                {
                    return magicDefense;
                }

                set
                {
                    magicDefense = value;
                }
            }

            public int MagicPower
            {
                get
                {
                    return magicPower;
                }

                set
                {
                    magicPower = value;
                }
            }

            public int AttackPower
            {
                get
                {
                    return attackPower;
                }

                set
                {
                    attackPower = value;
                }
            }

            public int Level
            {
                get
                {
                    return level;
                }

                set
                {
                    level = value;
                }
            }

            public int MaxHealth
            {
                get
                {
                    return maxHealth;
                }

                set
                {
                    maxHealth = value;
                }
            }

            public int MaxMana
            {
                get
                {
                    return maxMana;
                }

                set
                {
                    maxMana = value;
                }
            }

            public int Mana
            {
                get
                {
                    return mana;
                }

                set
                {
                    mana = value;
                }
            }
        }
    }
}
