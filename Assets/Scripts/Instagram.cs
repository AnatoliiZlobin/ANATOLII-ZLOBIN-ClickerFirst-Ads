using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Instagram : MonoBehaviour
{
    public Button adsButton;
    [System.Obsolete]
    void Awake()
    {
        adsButton.onClick.AddListener(adsButton_onClick);
    }

    [System.Obsolete]
    void adsButton_onClick()
    {
        Application.OpenURL("https://www.instagram.com/dj_kasperr/");
    }
}
