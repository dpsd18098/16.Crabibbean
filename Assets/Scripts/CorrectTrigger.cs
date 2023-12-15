using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrectTrigger : MonoBehaviour
{
    Animator animkey;
    //public Rigidbody2D rb;
    //public GameObject trigger;

    // Start is called before the first frame update
    void Start()
    {
        animkey = GetComponent<Animator>();
        //rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animkey.Play("KeyAnimation");
        }
    }
}
