using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxTouch : MonoBehaviour
{
    [SerializeField] GameController someclass;
    GameObject box1;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        

        if (collision.gameObject.CompareTag("Box"))
        {
            box1 = gameObject;
            GameController.instance.CounterTouch(box1);
        }
    }
}
