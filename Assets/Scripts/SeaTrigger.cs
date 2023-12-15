using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeaTrigger : MonoBehaviour
{

    public CrabMovement crab;
     
    void OnTriggerEnter2D(Collider2D collision)
    {
        crab.swimming = true; 
    }

}
