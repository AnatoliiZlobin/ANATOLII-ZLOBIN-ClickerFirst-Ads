using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxTouch : MonoBehaviour
{
    public GameController someclass;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("-2");
        if (collision.gameObject.CompareTag("Box"))
        {
            print("-1");
            GameController.instance.CounterTouch();
        }

    }
}
