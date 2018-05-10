using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameUtils.MenusSystem;
using GameUtils.GameInputs;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MenuSystem
{

    [SerializeField]
    GameObject pausePanel;

    IEnumerator checkPause;

    [SerializeField]
    float pauseDelay;

    new private void Start()
    {
        base.Start();

        checkPause = CheckPause(pauseDelay);
        StartCoroutine(checkPause);
    }

    IEnumerator CheckPause(float delay)
    {
        while (true)
        {
            if (GameInputs.PauseButton)
            {
                pausePanel.SetActive(!pausePanel.activeSelf);
                Time.timeScale = pausePanel.activeSelf ? 0f : 1f;
            }
            yield return new WaitForSecondsRealtime(delay);
        }
    }

    public void GoToTitleScreen()
    {
        SceneManager.LoadScene(0);
    }

}
