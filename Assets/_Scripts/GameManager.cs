using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameUtils.DataSystem;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField]
    Player player;

    [SerializeField]
    TextBox textBox;

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

    public void SaveGame()
    {
        DataSystem.SaveData(gameData);
    }

    public void LoadGame()
    {
        gameData = DataSystem.LoadGame();
    }

    public bool ExistData
    {
        get { return DataSystem.FileExist; }
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

    public TextBox TextBox
    {
        get
        {
            return textBox;
        }

        set
        {
            textBox = value;
        }
    }

    private void Awake()
    {

        if (!instance)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            instance = this;
            DontDestroyOnLoad(gameObject);
        }else if (instance != this)
        {
            Destroy(gameObject);
        }
    }
}
