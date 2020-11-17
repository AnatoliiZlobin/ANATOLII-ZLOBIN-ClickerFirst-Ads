using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxScript : MonoBehaviour
{
    private float min_X = -2.2f, max_X = 2.2f, move_Speed = 2f;
    private bool canMove, gameOver, ignoreCollision, ignoreTrigger;
    private Rigidbody2D myBody;
    private void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
        myBody.gravityScale = 0f;
    }
    private void Start()
    {
        canMove = true;
        if (Random.Range(0, 2) > 0)
        {
            move_Speed *= -1f;
        }
        GameController.instance.currentBox = this;
    }
    private void Update()
    {
        MoveBox();
    }
    void MoveBox()
    {
        if (canMove)
        {
            Vector2 temp = transform.position;
            temp.x += move_Speed * Time.deltaTime;
            if (temp.x > max_X)
            {
                move_Speed *= -1f;
            }
            else if (temp.x < min_X)
            {
                move_Speed *= -1f;
            }
            transform.position = temp;
        }
    }
    public void DropBox()
    {
        canMove = false;
        myBody.gravityScale = Random.Range(2, 4);
    }
}
