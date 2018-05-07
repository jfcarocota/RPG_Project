using UnityEngine;
using GameUtils.ItemSystem;

public abstract class Potion : Item
{
    [SerializeField]
    protected int effectValue;

    protected abstract void Drink(Hero h);
}
