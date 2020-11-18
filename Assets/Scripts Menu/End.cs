using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class End : MonoBehaviour
{
    public Button newGame, menuButton;
    public TMP_Text endGame, score;

    private void Awake()
    {
        newGame.onClick.AddListener(NewGame);
        menuButton.onClick.AddListener(MenuButton);
    }
    private void NewGame()
    {
        SceneManager.LoadScene("Scenes/Game");
    }
    private void MenuButton()
    {
        SceneManager.LoadScene("Scenes/Menu");
    }

    void Start()
    {
        score.text = "SCORE - x" + GameController.instance.counterPlayerDropBoxUI;
        endGame.text = "END GAME";
    }
}
