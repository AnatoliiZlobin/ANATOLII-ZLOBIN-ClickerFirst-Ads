using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.UI;

public class Ads : MonoBehaviour
{
    public Button adsButton;
    [System.Obsolete]
    void Start()
    {
        if (Advertisement.isSupported) Advertisement.Initialize("3902765", false);
    }
    void Awake()
    {
        adsButton.onClick.AddListener(adsButton_onClick);
    }

    [System.Obsolete]
    void adsButton_onClick()
    {
        if (Advertisement.IsReady())
        {
            Advertisement.Show("video");
        }
    }
}
