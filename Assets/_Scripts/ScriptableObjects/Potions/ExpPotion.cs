using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameUtils.ItemSystem;

[CreateAssetMenu(fileName = "Exp Potion", menuName = "Potions/ Experience", order = 2)]
public class ExpPotion : Item
{
    [SerializeField]
    int expGainValue;

    public int ExpGainValue
    {
        get
        {
            return expGainValue;
        }

        set
        {
            expGainValue = value;
        }
    }
}
