using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMove : MonoBehaviour
{
    public BoxSpawn spawnBox;

    public float leftPositionMin = -2f, rightpositionMax = 2f, moveSpeedBox = 2f;
    public int minSpeedDown = 2, maxSpeedDown = 4;
    public bool moveBoxYesOrNot;

    private Rigidbody2D rigidBody2D;

    private void Awake()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
        rigidBody2D.gravityScale = 0f;
        moveBoxYesOrNot = true;
    }
    private void Start()
    {
        if (Random.Range(0, 2) > 0)
        {
            moveSpeedBox *= -1f;
        }
        spawnBox.SpawnBox();
    }
    private void Update()
    {
        MoveBox();
    }
    void MoveBox()
    {
        if (moveBoxYesOrNot)
        {
            Vector2 temp = transform.position;
            temp.x += moveSpeedBox * Time.deltaTime;
            if (temp.x > rightpositionMax)
            {
                moveSpeedBox *= -1f;
            }
            else if (temp.x < leftPositionMin)
            {
                moveSpeedBox *= -1f;
            }
            transform.position = temp;
        }
    }
    public void DropBox()
    {
        moveBoxYesOrNot = false;
        rigidBody2D.gravityScale = Random.Range(minSpeedDown, maxSpeedDown);
    }
}
