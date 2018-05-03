using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameUtils.ItemSystem;

[CreateAssetMenu(fileName = "Defense Potion", menuName = "Potions/ Defense", order = 3)]
public class DffensePotion : Item
{
    [SerializeField]
    int defenseGainValue;

    public int DefenseGainValue
    {
        get
        {
            return defenseGainValue;
        }

        set
        {
            defenseGainValue = value;
        }
    }
}
