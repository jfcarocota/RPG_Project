using UnityEngine;
using GameUtils.ItemSystem;

public abstract class Potion : Item
{
    [SerializeField]
    protected int effectValue;

    public abstract void Drink(Hero h);
}
