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
        if (transform.position.x > 10.2f)
        {
            Vector3 v = transform.position;
            v.x = 10.2f;
            transform.position = v;
        }
        if (transform.position.x < -10.2f)
        {
            Vector3 v = transform.position;
            v.x = -10.2f;
            transform.position = v;
        }

        if (transform.position.y > 4.5f)
        {
            Vector3 v = transform.position;
            v.y = 4.5f;
            transform.position = v;
        }
        if (transform.position.y < -4.5f)
        {
            Vector3 v = transform.position;
            v.y = -4.5f;
            transform.position = v;
        }

        if (Input.GetButtonDown("Fire1"))
        {
            anim.Play("TurtleAnimation");
        }
        
    }
    
}
