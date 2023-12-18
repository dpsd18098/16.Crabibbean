using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeaTrigger : MonoBehaviour
{

    public CrabMovement crab;
    public GameObject swimCrab;
    
     
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject)
        {
            crab.swimming = true;
        }
        else
            crab.swimming = false;
    }

}
