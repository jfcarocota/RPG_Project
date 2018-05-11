using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GameUtils.GameInputs;


[CreateAssetMenu(fileName = "Conversation", menuName = "Talk/Conversation", order = 0)]
public class TalkSystem : ScriptableObject
{
    [SerializeField]
    Font font;
    [SerializeField]
    List<FrameDialog> dialogues;

    IEnumerator talking;

    public List<FrameDialog> Dialogues
    {
        get
        {
            return dialogues;
        }

        set
        {
            dialogues = value;
        }
    }

    public Font Font
    {
        get
        {
            return font;
        }

        set
        {
            font = value;
        }
    }

    public IEnumerator Talking(float delay)
    {
        GameManager.instance.TextBox.ParentObj.SetActive(true);
        GameManager.instance.TextBox.TextFont = font;
        GameManager.instance.TextBox.Content = dialogues[0].Dialog;
        int i = 0;
        int last = dialogues.Count - 1;
        while (i <= last)
        {
            if (GameInputs.AttackButton)
            {
                i++;
                if (i <= last)
                {
                    GameManager.instance.TextBox.Content = dialogues[i].Dialog;
                }
            }
            yield return new WaitForSeconds(delay);
        }
        GameManager.instance.TextBox.ParentObj.SetActive(false);
    }
}

