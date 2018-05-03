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

    public GameData(int level, int magicPower, int mana, int attackPower, int deffense, int magicDeffense)
    {
        this.level = level;
        this.magicPower = magicPower;
        this.mana = mana;
        this.attackPower = attackPower;
        this.deffense = deffense;
        this.magicPower = magicPower;
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
}
