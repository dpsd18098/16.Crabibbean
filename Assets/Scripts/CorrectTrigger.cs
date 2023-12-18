using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrectTrigger : MonoBehaviour
{
    Animator animkey;
    public GameObject correctObject;
   
    

    // Start is called before the first frame update
    void Start()
    {
        animkey = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(animkey);
            animkey.Play("KeyAnimation");
        }
    }
}
