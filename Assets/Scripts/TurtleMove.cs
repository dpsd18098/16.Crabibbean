using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtleMove : MonoBehaviour
{
    Animator anim;
   
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            anim.Play("TurtleAnimation");
        }      
    }   
}
