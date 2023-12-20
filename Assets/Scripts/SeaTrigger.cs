using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeaTrigger : MonoBehaviour
{

    public CrabMovement crab;
    public GameObject swimCrab;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject)
        {
            crab.swimming = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (gameObject)
        {
            crab.swimming = false;
        }
    }

}
