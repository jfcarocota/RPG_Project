using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameUtils.MenusSystem;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleMenu : MenuSystem {

    [SerializeField]
    GameObject warningPanel;
    [SerializeField]
    Button newGameButton;

    [SerializeField]
    Button noOption;

    IEnumerator fadeNload;

    new void Start()
    {
        fadeNload = FadeNload(0);
        base.Start();
    }

    public void NewGame()
    {
        warningPanel.SetActive(true);
        noOption.Select();
    }

    public void CancelNewGame()
    {
        warningPanel.SetActive(false);
        newGameButton.Select();

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
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
