using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBox : MonoBehaviour
{
    Text textScript;

    [SerializeField]
    GameObject parentObj;

    private void Awake()
    {
        textScript = GetComponent<Text>();
    }

    public Font TextFont
    {
        get { return textScript.font; }
        set { textScript.font = value; }
    }

    public string Content
    {
        get { return textScript.text; }
        set { textScript.text = value; }
    }

    public GameObject ParentObj
    {
        get
        {
            return parentObj;
        }
    }
}
