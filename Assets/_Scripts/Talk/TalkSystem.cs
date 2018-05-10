using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[CreateAssetMenu(fileName = "Conversation", menuName = "Talk/Conversation", order = 0)]
public class TalkSystem : ScriptableObject
{
[SerializeField]
string displayName;
[SerializeField]
Sprite displayImage;
[SerializeField]
Font font;
[SerializeField]
List<FrameDialog> dialogues;

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

public string DisplayName
{
    get
    {
        return displayName;
    }

    set
    {
        displayName = value;
    }
}

public Sprite DisplayImage
{
    get
    {
        return displayImage;
    }

    set
    {
        displayImage = value;
    }
}

public void Talk()
{
    GameManager.instance.TextBox.ParentObj.SetActive(true);
    GameManager.instance.TextBox.TextFont = font;
    GameManager.instance.TextBox.Content = dialogues[0].Dialog;
}
}

