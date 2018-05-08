using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    [SerializeField]
    Potion potion;

    public Potion Potion
    {
        get
        {
            return potion;
        }

        set
        {
            potion = value;
        }
    }
}
