using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class controllerCounterUI : MonoBehaviour
{
    public TMP_Text txt;

    public void printCounterUI()
    {
        txt.text = "x" + GameController.instance.counterPlayerDropBoxUI;
    }
}