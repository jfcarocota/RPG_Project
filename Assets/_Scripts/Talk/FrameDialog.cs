using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class FrameDialog 
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
