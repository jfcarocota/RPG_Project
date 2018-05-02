﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField]
    Player player;

    GameData gameData;

    public Player Player
    {
        get
        {
            return player;
        }

        set
        {
            player = value;
        }
    }

    public GameData GameData
    {
        get
        {
            return gameData;
        }

        set
        {
            gameData = value;
        }
    }

    private void Awake()
    {

        if (!instance)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }else if (instance != this)
        {
            Destroy(gameObject);
        }
    }
}
