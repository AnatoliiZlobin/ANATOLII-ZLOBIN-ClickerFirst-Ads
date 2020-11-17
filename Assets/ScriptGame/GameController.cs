using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    public GameObject mainCamera;
    public BoxSpawn box_Spawner;
    public controllerCounterUI textCounterUI;
    [HideInInspector]
    public BoxScript currentBox;
    private int moveCount, touch;
    public int counterPlayerDropBoxUI;
    private float cameraCounter = 6f, spawnPositionCounter = 10f;
    private void Awake()
    {
        if (instance == null) instance = this;
    }
    private void Start()
    {
        box_Spawner.SpawnBox();
    }
    void DetectInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            currentBox.DropBox();
            MoveCamera();
            counterPlayerDropBoxUI++;
            textCounterUI.printCounterUI();
        }
    }
    private void Update()
    {
        DetectInput();

    }
    public void MoveCamera()
    {

        if (moveCount == 2)
        {
            moveCount = 0;
            mainCamera.transform.position = new Vector3(0, cameraCounter += 2f, -10);
            mainCamera.SetActive(true);
            box_Spawner.transform.position = new Vector2(0, spawnPositionCounter += 2f);
        }
    }
    public void CounterTouch()
    {
        touch++;
        if (touch == 2)
        {
            touch = 0;
            box_Spawner.SpawnBox();
            moveCount++;
        }
        else if (touch == 1)
        {
        }
        else
        {
            print("End");
        }
    }
}
