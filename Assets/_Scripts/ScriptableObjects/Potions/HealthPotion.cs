using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameUtils.ItemSystem;

[CreateAssetMenu(fileName = "Health Potion", menuName = "Potions/ Health", order = 1)]
public class HealthPotion : Item
{
    [SerializeField]
    int recoverValue;

    public int RecoverValue
    {
        get
        {
            return recoverValue;
        }

        set
        {
            recoverValue = value;
        }
    }
}
