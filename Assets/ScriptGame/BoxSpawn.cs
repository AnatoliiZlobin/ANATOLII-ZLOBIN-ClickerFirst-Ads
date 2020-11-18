using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSpawn : MonoBehaviour
{
    [SerializeField] GameObject box_Prfab;
    [SerializeField] GameObject box_Obj;

    public void SpawnBox()
    {
        box_Obj = Instantiate(box_Prfab);
        box_Obj.transform.position = transform.position;
    }
}
