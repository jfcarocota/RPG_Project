﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameUtils.MenusSystem;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using GameUtils.AudioController;

public class TitleMenu : MenuSystem {

    [SerializeField]
    GameObject warningPanel;
    [SerializeField]
    Button newGameButton;

    [SerializeField]
    Button noOption;

    [SerializeField]
    GameObject continueButton;

    IEnumerator fadeNload;

    [SerializeField]
    AudioController ac;

    [SerializeField]
    Hero newHero;

    new void Start()
    {
        continueButton.SetActive(GameManager.instance.ExistData);
        fadeNload = FadeNload(0);
        base.Start();
    }

    public void NewGame()
    {
        if (GameManager.instance.ExistData)
        {
            warningPanel.SetActive(true);
            noOption.Select();
        }
        else
        {
            ac.PlayClipOnce(0);
            GameManager.instance.GameData = new GameData(newHero);
            GameManager.instance.SaveGame();
            FadeOut();
            StartCoroutine(fadeNload);
        }
    }

    public void CancelNewGame()
    {
        warningPanel.SetActive(false);
        newGameButton.Select();

    }

    public void AcceptNewGame()
    {
        warningPanel.SetActive(false);
        GameManager.instance.GameData = new GameData(newHero);
        GameManager.instance.SaveGame();
        FadeOut();
        StartCoroutine(fadeNload);
    }

    public void Continue()
    {
        FadeOut();
        StartCoroutine(fadeNload);
    }


    IEnumerator FadeNload(float delay)
    {
        while (MenuEnabled)
        {
            yield return new WaitForSeconds(delay);
        }
        GameManager.instance.LoadGame();
        ResetAlpha();
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
