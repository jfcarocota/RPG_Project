using UnityEngine;
using System;

[Serializable]
public class GameData
{
    [SerializeField]
    int level;
    [SerializeField]
    int magicPower;
    [SerializeField]
    int mana;
    [SerializeField]
    int attackPower;
    [SerializeField]
    int deffense;
    [SerializeField]
    int magicDeffense;
    [SerializeField]
    int health;
    [SerializeField]
    float posX;
    [SerializeField]
    float posY;
    [SerializeField]
    float currentExperience;
    [SerializeField]
    float experienceToNextLevel;
    [SerializeField]
    int maxHealth;
    [SerializeField]
    int maxMana;


    public GameData(int level, int magicPower, int mana, int attackPower, int deffense, 
        int magicDeffense, int health, float posX, float posY, float currentExperience, 
        float experienceToNextLevel, int maxHealth, int maxMana)
    {
        this.level = level;
        this.magicPower = magicPower;
        this.mana = mana;
        this.attackPower = attackPower;
        this.deffense = deffense;
        this.magicPower = magicPower;
        this.health = health;
        this.posX = posX;
        this.posY = posY;
        this.currentExperience = currentExperience;
        this.experienceToNextLevel = experienceToNextLevel;
        this.maxMana = maxMana;
        this.maxHealth = maxHealth;
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

    public int Deffense
    {
        get
        {
            return deffense;
        }

        set
        {
            deffense = value;
        }
    }

    public int MagicDeffense
    {
        get
        {
            return magicDeffense;
        }

        set
        {
            magicDeffense = value;
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

    public float CurrentExperience
    {
        get
        {
            return currentExperience;
        }

        set
        {
            currentExperience = value;
        }
    }

    public float ExperienceToNextLevel
    {
        get
        {
            return experienceToNextLevel;
        }

        set
        {
            experienceToNextLevel = value;
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

    public float PosX
    {
        get
        {
            return posX;
        }

        set
        {
            posX = value;
        }
    }

    public float PosY
    {
        get
        {
            return posY;
        }

        set
        {
            posY = value;
        }
    }
}
