﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Mana Potion", menuName = "Potion/Mana")]
public class ManaPotion : Potion
{
    public override void Drink(Hero h)
    {
        h.Mana = ((effectValue + h.Mana) <= h.MaxMana) ? effectValue + h.Mana : h.MaxMana;
    }
}
