using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Play : MonoBehaviour
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
        SceneManager.LoadScene("Scenes/Game");
    }
}

