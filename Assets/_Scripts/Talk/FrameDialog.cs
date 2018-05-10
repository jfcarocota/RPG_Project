using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Frame Dialog", menuName = "Talk/Frame Dialog", order = 1)]
public class FrameDialog : ScriptableObject
{
    [SerializeField]
    string displayName;
    [SerializeField]
    Sprite displayImage;
    [SerializeField, TextArea(3, 10)]
    string dialog;

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

    public string Dialog
    {
        get
        {
            return dialog;
        }

        set
        {
            dialog = value;
        }
    }
}
