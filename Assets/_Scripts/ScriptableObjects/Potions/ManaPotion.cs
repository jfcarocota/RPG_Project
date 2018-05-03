using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameUtils.ItemSystem;

[CreateAssetMenu(fileName = "Mana Potion", menuName = "Potions/ Mana", order = 4)]
public class ManaPotion : Item
{
    [SerializeField]
    int manaRecoverValue;

    public int ManaRecoverValue
    {
        get
        {
            return manaRecoverValue;
        }

        set
        {
            manaRecoverValue = value;
        }
    }
}
