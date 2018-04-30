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


}
