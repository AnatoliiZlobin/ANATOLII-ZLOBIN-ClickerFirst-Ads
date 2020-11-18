using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxCollision : MonoBehaviour
{
    public void searchObjectWithTagBox()
    {
        GameObject[] findObject;
        findObject = GameObject.FindGameObjectsWithTag("Box");
        for (int i = 0; i < findObject.Length; i++)
        {
            //if (findObject[i].GetComponent<Rigidbody2D>().gravityScale != 0f)
            //{
                //findObject[i].GetComponent<Rigidbody2D>().isKinematic = false;
                //Destroy(findObject[i].GetComponent<BoxTouch>());
                print(findObject[i]);
            //}
        }
    }
}
