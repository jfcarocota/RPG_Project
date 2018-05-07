using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Health Potion", menuName = "Potion/Health")]
public class HealthPotion : Potion
{
    protected override void Drink(Hero h)
    {
        h.Health = ((effectValue + h.Health) <= h.MaxHealth) ? effectValue + h.Health : h.MaxHealth;
        Destroy(this);
    }
}
